using System;
using System.Collections.Generic;
using System.Linq;
using CS3230_Group5.Model;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Database operations for ordering tests during a visit.
    /// </summary>
    public class TestOrderDal
    {
        /// <summary>
        /// Gets the list of standard tests a visit can order.
        /// </summary>
        public List<OrderedTest> GetStandardTests()
        {
            const string query = @"
                SELECT test_code, test_name, low_value, high_value, unit_measurement
                FROM test
                ORDER BY test_name;";

            var tests = new List<OrderedTest>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            using var command = new MySqlCommand(query, connection);

            connection.Open();
            using var reader = command.ExecuteReader();

            int lowOrdinal = reader.GetOrdinal("low_value");
            int highOrdinal = reader.GetOrdinal("high_value");
            int unitOrdinal = reader.GetOrdinal("unit_measurement");

            while (reader.Read())
            {
                tests.Add(new OrderedTest
                {
                    TestCode = reader.GetString("test_code"),
                    TestName = reader.GetString("test_name"),
                    LowValue = reader.IsDBNull(lowOrdinal) ? null : reader.GetDecimal(lowOrdinal),
                    HighValue = reader.IsDBNull(highOrdinal) ? null : reader.GetDecimal(highOrdinal),
                    UnitMeasurement = reader.IsDBNull(unitOrdinal) ? null : reader.GetString(unitOrdinal)
                });
            }

            return tests;
        }

        /// <summary>
        /// Orders every test in <paramref name="testCodes"/> for the visit in one
        /// transaction, so the whole order is saved or none of it is.
        /// </summary>
        /// <exception cref="ArgumentException">No tests were given.</exception>
        /// <exception cref="InvalidOperationException">
        /// There is no check-up yet, the visit is finalized, or a test was already ordered.
        /// </exception>
        public void OrderTests(int appointmentId, IEnumerable<string> testCodes)
        {
            if (appointmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(appointmentId));

            List<string> codes = (testCodes ?? Enumerable.Empty<string>())
                .Where(code => !string.IsNullOrWhiteSpace(code))
                .Select(code => code.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (codes.Count == 0)
                throw new ArgumentException("Select at least one test to order.", nameof(testCodes));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                EnsureVisitIsOpen(
                    connection,
                    transaction,
                    appointmentId,
                    "Save the routine check-up before ordering tests.");

                var alreadyOrdered = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                const string existingQuery = @"
                    SELECT test_code
                    FROM ordered_test
                    WHERE appointment_id = @appointmentId;";

                using (var existingCommand = new MySqlCommand(existingQuery, connection, transaction))
                {
                    existingCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

                    using var reader = existingCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        alreadyOrdered.Add(reader.GetString(0));
                    }
                }

                string? duplicate = codes.FirstOrDefault(code => alreadyOrdered.Contains(code));

                if (duplicate != null)
                    throw new InvalidOperationException(
                        $"{duplicate} has already been ordered for this visit.");

                const string insertQuery = @"
                    INSERT INTO ordered_test (appointment_id, test_code)
                    VALUES (@appointmentId, @testCode);";

                using (var insertCommand = new MySqlCommand(insertQuery, connection, transaction))
                {
                    insertCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    MySqlParameter codeParameter =
                        insertCommand.Parameters.Add("@testCode", MySqlDbType.VarChar, 10);

                    foreach (string code in codes)
                    {
                        codeParameter.Value = code;
                        insertCommand.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Removes a test that was ordered but has no result yet, in one transaction.
        /// A test that already has a result, or a visit with a final diagnosis,
        /// can never be changed.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The visit is finalized, the test is not ordered, or it already has a result.
        /// </exception>
        public void RemoveOrderedTest(int appointmentId, string testCode)
        {
            if (appointmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            if (string.IsNullOrWhiteSpace(testCode))
                throw new ArgumentException("A test is required.", nameof(testCode));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                EnsureVisitIsOpen(
                    connection,
                    transaction,
                    appointmentId,
                    "There is no check-up for this visit.");

                string? result;

                const string testQuery = @"
                    SELECT result
                    FROM ordered_test
                    WHERE appointment_id = @appointmentId
                      AND test_code = @testCode
                    FOR UPDATE;";

                using (var testCommand = new MySqlCommand(testQuery, connection, transaction))
                {
                    testCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    testCommand.Parameters.Add("@testCode", MySqlDbType.VarChar, 10).Value = testCode;

                    using var reader = testCommand.ExecuteReader();

                    if (!reader.Read())
                        throw new InvalidOperationException(
                            "That test is not part of this visit's order.");

                    result = reader.IsDBNull(0) ? null : reader.GetString(0);
                }

                if (!string.IsNullOrWhiteSpace(result))
                    throw new InvalidOperationException(
                        "This test already has a result, so it cannot be removed.");

                const string deleteQuery = @"
                    DELETE FROM ordered_test
                    WHERE appointment_id = @appointmentId
                      AND test_code = @testCode
                      AND (result IS NULL OR TRIM(result) = '');";

                int rowsDeleted;

                using (var deleteCommand = new MySqlCommand(deleteQuery, connection, transaction))
                {
                    deleteCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    deleteCommand.Parameters.Add("@testCode", MySqlDbType.VarChar, 10).Value = testCode;
                    rowsDeleted = deleteCommand.ExecuteNonQuery();
                }

                if (rowsDeleted != 1)
                    throw new InvalidOperationException("The test could not be removed.");

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Locks the visit row and throws if there is no check-up or a final
        /// diagnosis already exists.
        /// </summary>
        private static void EnsureVisitIsOpen(
            MySqlConnection connection,
            MySqlTransaction transaction,
            int appointmentId,
            string noCheckupMessage)
        {
            const string lockQuery = @"
                SELECT final_diagnosis
                FROM appointment_summary
                WHERE appointment_id = @appointmentId
                FOR UPDATE;";

            using var command = new MySqlCommand(lockQuery, connection, transaction);
            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

            using var reader = command.ExecuteReader();

            if (!reader.Read())
                throw new InvalidOperationException(noCheckupMessage);

            string? finalDiagnosis = reader.IsDBNull(0) ? null : reader.GetString(0);

            if (!string.IsNullOrWhiteSpace(finalDiagnosis))
                throw new InvalidOperationException(
                    "A final diagnosis has been entered, so this visit is read-only.");
        }
    }
}
