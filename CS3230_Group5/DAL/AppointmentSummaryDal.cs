using CS3230_Group5.Model;
using MySqlConnector;
using System;
using System.Data;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Provides database access operations for appointment summaries,
    /// including routine checkups, diagnoses, visit history, and ordered tests.
    /// </summary>
    public class AppointmentSummaryDal
    {
        /// <summary>
        /// The message shown when a visit can no longer be changed because a final diagnosis exists.
        /// </summary>
        private const string FinalizedMessage =
            "A final diagnosis has been entered, so this visit is read-only.";

        /// <summary>
        /// Gets appointment, patient, and doctor information.
        /// </summary>
        /// <param name="appointmentId">The appointment ID to look up.</param>
        /// <returns>A table containing the matching appointment, patient, and doctor details.</returns>
        public DataTable GetAppointmentDetails(int appointmentId)
        {
            const string query = @"
                SELECT
                    a.appointment_id,
                    a.patient_id,
                    p.first_name,
                    p.last_name,
                    p.date_of_birth,
                    p.phone,
                    p.gender,
                    a.datetime AS appointment_datetime,
                    a.reason,
                    a.doctor_id,
                    CONCAT(d.first_name, ' ', d.last_name) AS doctor_name
                FROM appointment a
                INNER JOIN patient p
                    ON a.patient_id = p.patient_id
                INNER JOIN doctor d
                    ON a.doctor_id = d.doctor_id
                WHERE a.appointment_id = @appointmentId;";

            return LoadTable(query, "@appointmentId", appointmentId);
        }

        /// <summary>
        /// Gets an existing summary, or null if one has not been created.
        /// </summary>
        /// <param name="appointmentId">The appointment ID to look up.</param>
        /// <returns>The appointment summary, or <see langword="null"/> when none exists.</returns>
        public AppointmentSummary? GetSummary(int appointmentId)
        {
            const string query = @"
                SELECT
                    appointment_id,
                    nurse_id,
                    systolic_reading,
                    diastolic_reading,
                    body_temperature,
                    pulse,
                    height,
                    weight,
                    symptoms,
                    initial_diagnosis,
                    final_diagnosis
                FROM appointment_summary
                WHERE appointment_id = @appointmentId;";

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                "@appointmentId", MySqlDbType.Int32
            ).Value = appointmentId;

            connection.Open();

            using var reader = command.ExecuteReader();

            return reader.Read() ? MapSummary(reader) : null;
        }

        /// <summary>
        /// Retrieves all appointments and diagnosis information for one patient.
        /// </summary>
        /// <param name="patientId">The patient ID to look up.</param>
        /// <returns>A table of the patient's visits, newest first.</returns>
        public DataTable GetPatientVisitHistory(int patientId)
        {
            const string query = @"
        SELECT
            a.appointment_id,
            a.patient_id,
            a.datetime AS visit_datetime,
            CONCAT(d.first_name, ' ', d.last_name) AS doctor_name,
            a.reason AS visit_reason,
            s.initial_diagnosis,
            s.final_diagnosis
        FROM appointment a
        INNER JOIN doctor d
            ON a.doctor_id = d.doctor_id
        LEFT JOIN appointment_summary s
            ON a.appointment_id = s.appointment_id
        WHERE a.patient_id = @patientId
        ORDER BY a.datetime DESC;";

            return LoadTable(query, "@patientId", patientId);
        }

        /// <summary>
        /// Retrieves all tests ordered for one appointment.
        /// </summary>
        /// <param name="appointmentId">The appointment ID to look up.</param>
        /// <returns>A table of the ordered tests, sorted by test code.</returns>
        public DataTable GetOrderedTests(int appointmentId)
        {
            const string query = @"
        SELECT
            test_code,
            performed_datetime,
            result,
            abnormal
        FROM ordered_test
        WHERE appointment_id = @appointmentId
        ORDER BY test_code;";

            return LoadTable(query, "@appointmentId", appointmentId);
        }

        /// <summary>
        /// Saves a routine checkup using the SaveRoutineCheckup stored procedure.
        /// </summary>
        /// <param name="summary">The checkup values to save.</param>
        /// <exception cref="ArgumentNullException">Thrown when the summary is null.</exception>
        /// <exception cref="ArgumentException">Thrown when a required value is missing or invalid.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the visit already has a final diagnosis.</exception>
        public void SaveCheckup(AppointmentSummary summary)
        {
            ValidateCheckup(summary);

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = CreateSaveCheckupCommand(connection, summary);

            connection.Open();

            EnsureNotFinalized(connection, summary.AppointmentId);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates initial diagnosis on an existing summary.
        /// A checkup must exist first because the other required summary
        /// columns do not allow NULL.
        /// </summary>
        /// <param name="appointmentId">The appointment ID to update.</param>
        /// <param name="diagnosis">The initial diagnosis, or blank to clear it.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown when no checkup exists yet or the visit already has a final diagnosis.
        /// </exception>
        public void SaveInitialDiagnosis(
            int appointmentId, string diagnosis)
        {
            const string query = @"
                UPDATE appointment_summary
                SET initial_diagnosis = @diagnosis
                WHERE appointment_id = @appointmentId
                  AND final_diagnosis IS NULL;";

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                "@appointmentId", MySqlDbType.Int32
            ).Value = appointmentId;

            command.Parameters.Add(
                "@diagnosis", MySqlDbType.VarChar, 500
            ).Value = string.IsNullOrWhiteSpace(diagnosis)
                ? DBNull.Value
                : diagnosis.Trim();

            connection.Open();

            if (command.ExecuteNonQuery() > 0)
                return;

            ThrowWhyDiagnosisWasNotSaved(connection, appointmentId);
        }

        /// <summary>
        /// Runs a query that takes one integer parameter and loads the result into a table.
        /// </summary>
        /// <param name="query">The SQL query to run.</param>
        /// <param name="parameterName">The name of the integer parameter, including the @ sign.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>A table containing the query results.</returns>
        private static DataTable LoadTable(
            string query, string parameterName, int value)
        {
            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                parameterName, MySqlDbType.Int32).Value = value;

            connection.Open();

            using var reader = command.ExecuteReader();

            var table = new DataTable();
            table.Load(reader);

            return table;
        }

        /// <summary>
        /// Converts the current database row to an <see cref="AppointmentSummary"/>.
        /// </summary>
        /// <param name="reader">The reader positioned on a summary row.</param>
        /// <returns>The mapped summary.</returns>
        private static AppointmentSummary MapSummary(MySqlDataReader reader)
        {
            return new AppointmentSummary
            {
                AppointmentId = reader.GetInt32("appointment_id"),
                NurseId = reader.GetInt32("nurse_id"),

                SystolicReading = reader.GetInt32("systolic_reading"),
                DiastolicReading = reader.GetInt32("diastolic_reading"),
                BodyTemperature = reader.GetDecimal("body_temperature"),
                Pulse = reader.GetInt32("pulse"),
                Height = reader.GetDecimal("height"),
                Weight = reader.GetDecimal("weight"),

                Symptoms = reader.GetString("symptoms"),
                InitialDiagnosis = ReadNullableString(
                    reader, "initial_diagnosis"),
                FinalDiagnosis = ReadNullableString(
                    reader, "final_diagnosis")
            };
        }

        /// <summary>
        /// Validates the values of a routine checkup before saving.
        /// </summary>
        /// <param name="summary">The checkup to validate.</param>
        /// <exception cref="ArgumentNullException">Thrown when the summary is null.</exception>
        /// <exception cref="ArgumentException">Thrown when a required value is missing or invalid.</exception>
        private static void ValidateCheckup(AppointmentSummary summary)
        {
            if (summary == null)
                throw new ArgumentNullException(nameof(summary));

            if (summary.AppointmentId <= 0)
                throw new ArgumentException(
                    "A valid appointment is required.");

            if (!summary.NurseId.HasValue || summary.NurseId.Value <= 0)
                throw new ArgumentException(
                    "A valid nurse ID is required.");

            if (!summary.SystolicReading.HasValue ||
                !summary.DiastolicReading.HasValue ||
                !summary.BodyTemperature.HasValue ||
                !summary.Pulse.HasValue ||
                !summary.Height.HasValue ||
                !summary.Weight.HasValue)
            {
                throw new ArgumentException(
                    "All six measurements are required.");
            }

            if (string.IsNullOrWhiteSpace(summary.Symptoms))
                throw new ArgumentException(
                    "Symptoms are required. Enter 'None reported' if applicable.");

            if (summary.Symptoms.Trim().Length > 500)
                throw new ArgumentException(
                    "Symptoms cannot exceed 500 characters.");
        }

        /// <summary>
        /// Creates the command that calls the SaveRoutineCheckup stored procedure.
        /// </summary>
        /// <param name="connection">The connection the command will run on.</param>
        /// <param name="summary">The validated checkup values.</param>
        /// <returns>The stored procedure command with all parameters set.</returns>
        private static MySqlCommand CreateSaveCheckupCommand(
            MySqlConnection connection, AppointmentSummary summary)
        {
            var command = new MySqlCommand("SaveRoutineCheckup", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add(
                "@p_appointment_id", MySqlDbType.Int32
            ).Value = summary.AppointmentId;

            command.Parameters.Add(
                "@p_nurse_id", MySqlDbType.Int32
            ).Value = summary.NurseId!.Value;

            command.Parameters.Add(
                "@p_systolic", MySqlDbType.Int32
            ).Value = summary.SystolicReading!.Value;

            command.Parameters.Add(
                "@p_diastolic", MySqlDbType.Int32
            ).Value = summary.DiastolicReading!.Value;

            command.Parameters.Add(
                "@p_temperature", MySqlDbType.Decimal
            ).Value = summary.BodyTemperature!.Value;

            command.Parameters.Add(
                "@p_pulse", MySqlDbType.Int32
            ).Value = summary.Pulse!.Value;

            command.Parameters.Add(
                "@p_height", MySqlDbType.Decimal
            ).Value = summary.Height!.Value;

            command.Parameters.Add(
                "@p_weight", MySqlDbType.Decimal
            ).Value = summary.Weight!.Value;

            command.Parameters.Add(
                "@p_symptoms", MySqlDbType.VarChar, 500
            ).Value = summary.Symptoms!.Trim();

            return command;
        }

        /// <summary>
        /// Throws the exception that explains why an initial diagnosis update changed no rows.
        /// </summary>
        /// <param name="connection">An open connection.</param>
        /// <param name="appointmentId">The appointment ID that was being updated.</param>
        /// <exception cref="InvalidOperationException">
        /// Always thrown: no checkup exists yet, or the visit is finalized.
        /// </exception>
        private static void ThrowWhyDiagnosisWasNotSaved(
            MySqlConnection connection, int appointmentId)
        {
            if (!SummaryExists(connection, appointmentId))
            {
                throw new InvalidOperationException(
                    "Save the routine checkup before entering the initial diagnosis.");
            }

            throw new InvalidOperationException(FinalizedMessage);
        }

        /// <summary>
        /// Throws if the visit already has a final diagnosis.
        /// </summary>
        /// <param name="connection">An open connection.</param>
        /// <param name="appointmentId">The appointment ID to check.</param>
        /// <exception cref="InvalidOperationException">Thrown when a final diagnosis exists.</exception>
        private static void EnsureNotFinalized(
            MySqlConnection connection, int appointmentId)
        {
            const string query = @"
                SELECT final_diagnosis
                FROM appointment_summary
                WHERE appointment_id = @appointmentId;";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                "@appointmentId", MySqlDbType.Int32
            ).Value = appointmentId;

            object? value = command.ExecuteScalar();

            if (value != null && value != DBNull.Value &&
                !string.IsNullOrWhiteSpace(Convert.ToString(value)))
            {
                throw new InvalidOperationException(FinalizedMessage);
            }
        }

        /// <summary>
        /// Checks whether a summary row exists for the appointment.
        /// </summary>
        /// <param name="connection">An open connection.</param>
        /// <param name="appointmentId">The appointment ID to check.</param>
        /// <returns><see langword="true"/> when a summary exists; otherwise, <see langword="false"/>.</returns>
        private static bool SummaryExists(
            MySqlConnection connection, int appointmentId)
        {
            const string query = @"
                SELECT COUNT(*)
                FROM appointment_summary
                WHERE appointment_id = @appointmentId;";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                "@appointmentId", MySqlDbType.Int32
            ).Value = appointmentId;

            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }

        /// <summary>
        /// Reads a string column, returning null for database NULL.
        /// </summary>
        /// <param name="reader">The reader positioned on a row.</param>
        /// <param name="column">The column name.</param>
        /// <returns>The string value, or <see langword="null"/>.</returns>
        private static string? ReadNullableString(
            MySqlDataReader reader, string column)
        {
            int ordinal = reader.GetOrdinal(column);

            return reader.IsDBNull(ordinal)
                ? null
                : reader.GetString(ordinal);
        }
    }
}