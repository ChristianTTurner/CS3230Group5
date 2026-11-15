using System;
using System.Collections.Generic;
using System.Data;
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
        /// Saves a test result by calling the save_test_result stored procedure
        /// (see sp.sql). In one transaction the procedure locks the visit, refuses
        /// a finalized visit or a test that was not ordered, decides whether the
        /// result is abnormal from the test's low and high values (or uses
        /// <paramref name="manualAbnormal"/> when the test has no range), and saves it.
        /// </summary>
        /// <param name="appointmentId">The visit the test was ordered for.</param>
        /// <param name="testCode">The ordered test, for example WBC.</param>
        /// <param name="performedDateTime">When the test was performed.</param>
        /// <param name="result">The result text or number.</param>
        /// <param name="manualAbnormal">
        /// Normal (false) or abnormal (true), used only for tests with no range.
        /// </param>
        /// <exception cref="ArgumentException">The inputs are invalid.</exception>
        /// <exception cref="InvalidOperationException">
        /// The stored procedure rejected the call, for example because the visit
        /// is finalized or the test was not ordered.
        /// </exception>
        public void SaveResult(
            int appointmentId,
            string testCode,
            DateTime performedDateTime,
            string result,
            bool? manualAbnormal)
        {
            // MySQL error raised by SIGNAL in the stored procedure.
            const int signalledError = 1644;

            if (appointmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            if (string.IsNullOrWhiteSpace(testCode))
                throw new ArgumentException("A test is required.", nameof(testCode));
            if (string.IsNullOrWhiteSpace(result))
                throw new ArgumentException("A result is required.", nameof(result));
            if (result.Trim().Length > 255)
                throw new ArgumentException("The result cannot exceed 255 characters.", nameof(result));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            using var command = new MySqlCommand("save_test_result", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@p_appointment_id", MySqlDbType.Int32).Value = appointmentId;
            command.Parameters.Add("@p_test_code", MySqlDbType.VarChar, 10).Value = testCode.Trim();
            command.Parameters.Add("@p_performed_datetime", MySqlDbType.DateTime).Value = performedDateTime;
            command.Parameters.Add("@p_result", MySqlDbType.VarChar, 255).Value = result.Trim();
            command.Parameters.Add("@p_manual_abnormal", MySqlDbType.Bool).Value =
                (object?)manualAbnormal ?? DBNull.Value;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) when (ex.Number == signalledError)
            {
                // The procedure rejected the call and already rolled back.
                throw new InvalidOperationException(ex.Message, ex);
            }
        }
    }
}
