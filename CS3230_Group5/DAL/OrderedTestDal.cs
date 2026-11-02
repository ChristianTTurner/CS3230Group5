using System;
using System.Collections.Generic;
using CS3230_Group5.Model;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Database operations for the tests ordered during a visit and their results.
    /// </summary>
    public class OrderedTestDal
    {
        /// <summary>
        /// Gets the patient, doctor, nurse and lock status for a visit,
        /// or null if the appointment does not exist.
        /// </summary>
        public VisitHeader? GetVisitHeader(int appointmentId)
        {
            const string query = @"
                SELECT
                    a.appointment_id,
                    a.datetime,
                    CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                    p.date_of_birth,
                    CONCAT(d.first_name, ' ', d.last_name) AS doctor_name,
                    CONCAT(n.first_name, ' ', n.last_name) AS nurse_name,
                    s.final_diagnosis
                FROM appointment a
                INNER JOIN patient p ON p.patient_id = a.patient_id
                INNER JOIN doctor d ON d.doctor_id = a.doctor_id
                LEFT JOIN appointment_summary s ON s.appointment_id = a.appointment_id
                LEFT JOIN nurse n ON n.nurse_id = s.nurse_id
                WHERE a.appointment_id = @appointmentId;";

            using var connection = new MySqlConnection(Connection.ConnectionString());
            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

            connection.Open();
            using var reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            int nurseOrdinal = reader.GetOrdinal("nurse_name");
            int finalOrdinal = reader.GetOrdinal("final_diagnosis");

            return new VisitHeader
            {
                AppointmentId = reader.GetInt32("appointment_id"),
                AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("datetime")),
                PatientName = reader.GetString("patient_name"),
                PatientDateOfBirth = reader.GetDateTime(reader.GetOrdinal("date_of_birth")),
                DoctorName = reader.GetString("doctor_name"),
                NurseName = reader.IsDBNull(nurseOrdinal) ? null : reader.GetString(nurseOrdinal),
                IsFinalized = !reader.IsDBNull(finalOrdinal)
                              && !string.IsNullOrWhiteSpace(reader.GetString(finalOrdinal))
            };
        }

        /// <summary>
        /// Gets every test ordered for a visit with its test details and result.
        /// </summary>
        public List<OrderedTest> GetOrderedTests(int appointmentId)
        {
            const string query = @"
                SELECT
                    ot.appointment_id,
                    ot.test_code,
                    t.test_name,
                    t.low_value,
                    t.high_value,
                    t.unit_measurement,
                    ot.performed_datetime,
                    ot.result,
                    ot.abnormal
                FROM ordered_test ot
                INNER JOIN test t ON t.test_code = ot.test_code
                WHERE ot.appointment_id = @appointmentId
                ORDER BY t.test_name;";

            var tests = new List<OrderedTest>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

            connection.Open();
            using var reader = command.ExecuteReader();

            int lowOrdinal = reader.GetOrdinal("low_value");
            int highOrdinal = reader.GetOrdinal("high_value");
            int unitOrdinal = reader.GetOrdinal("unit_measurement");
            int performedOrdinal = reader.GetOrdinal("performed_datetime");
            int resultOrdinal = reader.GetOrdinal("result");
            int abnormalOrdinal = reader.GetOrdinal("abnormal");

            while (reader.Read())
            {
                tests.Add(new OrderedTest
                {
                    AppointmentId = reader.GetInt32("appointment_id"),
                    TestCode = reader.GetString("test_code"),
                    TestName = reader.GetString("test_name"),
                    LowValue = reader.IsDBNull(lowOrdinal) ? null : reader.GetDecimal(lowOrdinal),
                    HighValue = reader.IsDBNull(highOrdinal) ? null : reader.GetDecimal(highOrdinal),
                    UnitMeasurement = reader.IsDBNull(unitOrdinal) ? null : reader.GetString(unitOrdinal),
                    PerformedDateTime = reader.IsDBNull(performedOrdinal) ? null : reader.GetDateTime(performedOrdinal),
                    Result = reader.IsDBNull(resultOrdinal) ? null : reader.GetString(resultOrdinal),
                    Abnormal = reader.IsDBNull(abnormalOrdinal) ? null : Convert.ToBoolean(reader.GetValue(abnormalOrdinal))
                });
            }

            return tests;
        }

        /// <summary>
        /// Saves a test result in one transaction. The visit row is locked while
        /// checking that no final diagnosis exists, so a finalized visit can never
        /// be changed. If the test has a low and/or high value, normality is
        /// calculated here; otherwise <paramref name="manualAbnormal"/> is used.
        /// </summary>
        /// <exception cref="ArgumentException">The inputs are invalid.</exception>
        /// <exception cref="InvalidOperationException">
        /// The test was not ordered, or the visit is already finalized.
        /// </exception>
        public void SaveResult(
            int appointmentId,
            string testCode,
            DateTime performedDateTime,
            string result,
            bool? manualAbnormal)
        {
            if (appointmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            if (string.IsNullOrWhiteSpace(testCode))
                throw new ArgumentException("A test is required.", nameof(testCode));
            if (string.IsNullOrWhiteSpace(result))
                throw new ArgumentException("A result is required.", nameof(result));
            if (result.Trim().Length > 255)
                throw new ArgumentException("The result cannot exceed 255 characters.", nameof(result));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                decimal? low;
                decimal? high;
                string? finalDiagnosis;

                const string lockQuery = @"
                    SELECT t.low_value, t.high_value, s.final_diagnosis
                    FROM ordered_test ot
                    INNER JOIN appointment_summary s ON s.appointment_id = ot.appointment_id
                    INNER JOIN test t ON t.test_code = ot.test_code
                    WHERE ot.appointment_id = @appointmentId
                      AND ot.test_code = @testCode
                    FOR UPDATE;";

                using (var lockCommand = new MySqlCommand(lockQuery, connection, transaction))
                {
                    lockCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    lockCommand.Parameters.Add("@testCode", MySqlDbType.VarChar, 10).Value = testCode;

                    using var reader = lockCommand.ExecuteReader();

                    if (!reader.Read())
                        throw new InvalidOperationException("That test was not ordered for this visit.");

                    low = reader.IsDBNull(0) ? null : reader.GetDecimal(0);
                    high = reader.IsDBNull(1) ? null : reader.GetDecimal(1);
                    finalDiagnosis = reader.IsDBNull(2) ? null : reader.GetString(2);
                }

                if (!string.IsNullOrWhiteSpace(finalDiagnosis))
                    throw new InvalidOperationException(
                        "A final diagnosis has been entered, so this visit is read-only.");

                bool abnormal;

                if (low.HasValue || high.HasValue)
                {
                    if (!OrderedTest.TryParseNumericResult(result, out decimal value))
                        throw new ArgumentException("This test requires a numeric result.", nameof(result));

                    abnormal = OrderedTest.IsAbnormal(value, low, high);
                }
                else
                {
                    if (!manualAbnormal.HasValue)
                        throw new ArgumentException("Select normal or abnormal for this test.", nameof(manualAbnormal));

                    abnormal = manualAbnormal.Value;
                }

                const string updateQuery = @"
                    UPDATE ordered_test
                    SET performed_datetime = @performed,
                        result = @result,
                        abnormal = @abnormal
                    WHERE appointment_id = @appointmentId
                      AND test_code = @testCode;";

                using (var updateCommand = new MySqlCommand(updateQuery, connection, transaction))
                {
                    updateCommand.Parameters.Add("@performed", MySqlDbType.DateTime).Value = performedDateTime;
                    updateCommand.Parameters.Add("@result", MySqlDbType.VarChar, 255).Value = result.Trim();
                    updateCommand.Parameters.Add("@abnormal", MySqlDbType.Bool).Value = abnormal;
                    updateCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    updateCommand.Parameters.Add("@testCode", MySqlDbType.VarChar, 10).Value = testCode;
                    updateCommand.ExecuteNonQuery();
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
