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
                string? finalDiagnosis;

                const string lockQuery = @"
                    SELECT final_diagnosis
                    FROM appointment_summary
                    WHERE appointment_id = @appointmentId
                    FOR UPDATE;";

                using (var lockCommand = new MySqlCommand(lockQuery, connection, transaction))
                {
                    lockCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

                    using var reader = lockCommand.ExecuteReader();

                    if (!reader.Read())
                        throw new InvalidOperationException(
                            "Save the routine check-up before ordering tests.");

                    finalDiagnosis = reader.IsDBNull(0) ? null : reader.GetString(0);
                }

                if (!string.IsNullOrWhiteSpace(finalDiagnosis))
                    throw new InvalidOperationException(
                        "A final diagnosis has been entered, so this visit is read-only.");

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
    }
}
