
using CS3230_Group5.Model;
using MySqlConnector;
using System;
using System.Data;

namespace CS3230_Group5.DAL
{
    public class AppointmentSummaryDal
    {
        /// <summary>
        /// Gets appointment, patient, and doctor information.
        /// </summary>
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

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                "@appointmentId", MySqlDbType.Int32
            ).Value = appointmentId;

            connection.Open();

            using var reader = command.ExecuteReader();

            var table = new DataTable();
            table.Load(reader);

            return table;
        }

        /// <summary>
        /// Gets an existing summary, or null if one has not been created.
        /// </summary>
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

            if (!reader.Read())
                return null;

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
        /// Retrieves all appointments and diagnosis information for one patient.
        /// </summary>
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

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                "@patientId", MySqlDbType.Int32).Value = patientId;

            connection.Open();

            using var reader = command.ExecuteReader();

            var table = new DataTable();
            table.Load(reader);

            return table;
        }

        /// <summary>
        /// Saves a routine checkup using the SaveRoutineCheckup stored procedure.
        /// </summary>
        public void SaveCheckup(AppointmentSummary summary)
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

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = new MySqlCommand(
                "SaveRoutineCheckup", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(
                "@p_appointment_id", MySqlDbType.Int32
            ).Value = summary.AppointmentId;

            command.Parameters.Add(
                "@p_nurse_id", MySqlDbType.Int32
            ).Value = summary.NurseId.Value;

            command.Parameters.Add(
                "@p_systolic", MySqlDbType.Int32
            ).Value = summary.SystolicReading.Value;

            command.Parameters.Add(
                "@p_diastolic", MySqlDbType.Int32
            ).Value = summary.DiastolicReading.Value;

            command.Parameters.Add(
                "@p_temperature", MySqlDbType.Decimal
            ).Value = summary.BodyTemperature.Value;

            command.Parameters.Add(
                "@p_pulse", MySqlDbType.Int32
            ).Value = summary.Pulse.Value;

            command.Parameters.Add(
                "@p_height", MySqlDbType.Decimal
            ).Value = summary.Height.Value;

            command.Parameters.Add(
                "@p_weight", MySqlDbType.Decimal
            ).Value = summary.Weight.Value;

            command.Parameters.Add(
                "@p_symptoms", MySqlDbType.VarChar, 500
            ).Value = summary.Symptoms.Trim();

            connection.Open();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates initial diagnosis on an existing summary.
        /// A checkup must exist first because the other required summary
        /// columns do not allow NULL.
        /// </summary>
        public void SaveInitialDiagnosis(
            int appointmentId, string diagnosis)
        {
            const string query = @"
                UPDATE appointment_summary
                SET initial_diagnosis = @diagnosis
                WHERE appointment_id = @appointmentId;";

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

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0 && !SummaryExists(connection, appointmentId))
            {
                throw new InvalidOperationException(
                    "Save the routine checkup before entering the initial diagnosis.");
            }
        }

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
