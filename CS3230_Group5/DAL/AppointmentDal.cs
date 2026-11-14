using CS3230_Group5.Model;
using MySqlConnector;
using System;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Provides database access operations for appointments, patients, and doctors.
    /// </summary>
    public class AppointmentDal
    {
        /// <summary>
        /// Retrieves active patients ordered by last name and first name.
        /// </summary>
        /// <returns>A dictionary containing patient IDs and display names.</returns>
        public Dictionary<int, string> GetPatients()
        {
            const string query = @"SELECT patient_id, first_name, last_name
                  FROM patient
                  WHERE active = TRUE
                  ORDER BY last_name, first_name;";

            return readNameMap(query, "patient_id");
        }

        /// <summary>
        /// Retrieves doctors ordered by last name and first name.
        /// </summary>
        /// <returns>A dictionary containing doctor IDs and display names.</returns>
        public Dictionary<int, string> GetDoctors()
        {
            const string query = @"SELECT doctor_id, first_name, last_name
                  FROM doctor
                  ORDER BY last_name, first_name;";

            return readNameMap(query, "doctor_id");
        }

        /// <summary>
        /// Deletes an appointment, its related summary record, and ordered tests.
        /// </summary>
        /// <param name="id">The appointment ID to delete.</param>
        /// <returns><see langword="1"/> when one or more records are deleted; otherwise, <see langword="0"/>.</returns>
        public bool DeleteAppointment(int id)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var callDelete = @"call DeleteAppointment(@id);";
            var command = new MySqlCommand(callDelete, connection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            using var reader = command.ExecuteReader();
            reader.Read();
            var result = reader.GetInt16("result");
            reader.Close();

            return result > 0;
        }

        /// <summary>
        /// Adds an appointment after validating the requested time slot and reason.
        /// </summary>
        /// <param name="patientId">The patient ID for the appointment.</param>
        /// <param name="doctorId">The doctor ID for the appointment.</param>
        /// <param name="appointmentDateTime">The requested appointment date and time.</param>
        /// <param name="reason">The reason for the appointment.</param>
        /// <returns>The ID of the newly created appointment.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when a patient or doctor ID is not positive.</exception>
        /// <exception cref="ArgumentException">Thrown when the appointment time or reason is invalid.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the doctor already has an appointment in the requested time slot.</exception>
        public int AddAppointment(int patientId, int doctorId, DateTime appointmentDateTime, string reason)
        {
            validateNewAppointment(patientId, doctorId, appointmentDateTime, reason);

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            ensureSlotIsAvailable(connection, doctorId, appointmentDateTime);

            return insertAppointment(connection, patientId, doctorId, appointmentDateTime, reason);
        }

        /// <summary>
        /// Updates an existing appointment in the database.
        /// </summary>
        /// <param name="appointment">The appointment containing the updated values.</param>
        /// <param name="message">The result message from the database operation.</param>
        /// <returns><see langword="true"/> when the appointment is updated; otherwise, <see langword="false"/>.</returns>
        public bool UpdateAppointment(Appointment appointment, out string message)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = this.createUpdateAppointmentCommand(connection, appointment);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    message = "Edits saved successfully";
                    return true;
                }

                message = "Error saving edits to database";
                return false;
            }
            catch (Exception ex)
            {
                message = "Error saving edits to database: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Retrieves appointments, optionally filtered by appointment, patient, doctor, or date information.
        /// </summary>
        /// <param name="filter">An optional search value used to filter the results.</param>
        /// <returns>A list of matching appointments.</returns>
        public List<Appointment> GetAppointments(string? filter = null)
        {
            var appointments = new List<Appointment>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = this.createSearchAppointmentsCommand(connection, filter);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                appointments.Add(mapAppointment(reader));
            }

            return appointments;
        }

        /// <summary>
        /// Runs a query that returns an ID column plus first and last names
        /// and builds a dictionary of IDs to display names.
        /// </summary>
        /// <param name="query">The SQL query to run.</param>
        /// <param name="idColumn">The name of the ID column in the result.</param>
        /// <returns>A dictionary containing IDs and "first last" display names.</returns>
        private static Dictionary<int, string> readNameMap(string query, string idColumn)
        {
            var names = new Dictionary<int, string>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                names.Add(
                    reader.GetInt32(idColumn),
                    $"{reader.GetString("first_name")} {reader.GetString("last_name")}");
            }

            return names;
        }

        /// <summary>
        /// Validates the values for a new appointment.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when a patient or doctor ID is not positive.</exception>
        /// <exception cref="ArgumentException">Thrown when the time or reason is invalid.</exception>
        private static void validateNewAppointment(int patientId, int doctorId, DateTime appointmentDateTime, string reason)
        {
            if (patientId <= 0) throw new ArgumentOutOfRangeException(nameof(patientId));
            if (doctorId <= 0) throw new ArgumentOutOfRangeException(nameof(doctorId));
            if (appointmentDateTime < DateTime.Now) throw new ArgumentException("Appointment date and time cannot be in the past.");
            if (appointmentDateTime.TimeOfDay < TimeSpan.FromHours(8) || appointmentDateTime.TimeOfDay > TimeSpan.FromHours(17))
                throw new ArgumentException("Appointments must be scheduled between 8:00 AM and 5:00 PM.");
            if (appointmentDateTime.Minute % 15 != 0 || appointmentDateTime.Second != 0 || appointmentDateTime.Millisecond != 0)
                throw new ArgumentException("Appointments must start on a 15-minute interval.");
            if (string.IsNullOrWhiteSpace(reason)) throw new ArgumentException("Reason is required.");
        }

        /// <summary>
        /// Confirms the doctor has no appointment in the requested 15-minute slot.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the slot is already booked.</exception>
        private static void ensureSlotIsAvailable(MySqlConnection connection, int doctorId, DateTime appointmentDateTime)
        {
            DateTime slotStart = new DateTime(appointmentDateTime.Year, appointmentDateTime.Month, appointmentDateTime.Day, appointmentDateTime.Hour, appointmentDateTime.Minute, 0);
            DateTime slotEnd = slotStart.AddMinutes(15);

            using var checkCommand = new MySqlCommand(
                @"SELECT COUNT(*) FROM appointment
                  WHERE doctor_id = @doctorId
                  AND datetime >= @slotStart
                  AND datetime < @slotEnd;", connection);

            checkCommand.Parameters.Add("@doctorId", MySqlDbType.Int32).Value = doctorId;
            checkCommand.Parameters.Add("@slotStart", MySqlDbType.DateTime).Value = slotStart;
            checkCommand.Parameters.Add("@slotEnd", MySqlDbType.DateTime).Value = slotEnd;

            if (Convert.ToInt32(checkCommand.ExecuteScalar()) > 0)
                throw new InvalidOperationException("This doctor already has an appointment during that 15-minute time slot.");
        }

        /// <summary>
        /// Inserts a new appointment row.
        /// </summary>
        /// <returns>The ID of the newly created appointment.</returns>
        private static int insertAppointment(MySqlConnection connection, int patientId, int doctorId, DateTime appointmentDateTime, string reason)
        {
            using var command = new MySqlCommand(
                @"INSERT INTO appointment (patient_id, doctor_id, datetime, reason)
                  VALUES (@patientId, @doctorId, @appointmentDateTime, @reason);", connection);

            command.Parameters.Add("@patientId", MySqlDbType.Int32).Value = patientId;
            command.Parameters.Add("@doctorId", MySqlDbType.Int32).Value = doctorId;
            command.Parameters.Add("@appointmentDateTime", MySqlDbType.DateTime).Value = appointmentDateTime;
            command.Parameters.Add("@reason", MySqlDbType.VarChar, 255).Value = reason.Trim();
            command.ExecuteNonQuery();

            return checked((int)command.LastInsertedId);
        }

        /** Update appointment information in the Database
         * 
         *  @param appointment the appointment to be updated
         *  @param message resulting information based on the updates success
         *  
         *  @returns true if the edits were saved successfully
         *          false if the edits weren't saved successfully
         */
        public bool UpdateAppointment(Appointment appointment, out string message)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var command = createUpdateAppointmentCommand(connection, appointment);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    message = "Edits saved successfully";
                    return true;
                }

                message = "Error saving edits to database";
                return false;
            }
            catch (Exception ex) {
                message = "Error saving edits to database: " + ex.Message;
                return false;
            }
        }

        private MySqlCommand createUpdateAppointmentCommand(MySqlConnection connection, Appointment appointment)
        {
            var query = this.buildUpdateAppointmentQuery(appointment);
            var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                        "@appointmentId", MySqlDbType.Int64)
                    .Value = $"{appointment.AppointmentId}";
            command.Parameters.Add(
                        "@patientId", MySqlDbType.Int64)
                    .Value = $"{appointment.PatientId}";
            command.Parameters.Add(
                        "@doctorId", MySqlDbType.Int64)
                    .Value = $"{appointment.DoctorId}";
            command.Parameters.Add(
                        "@datetime", MySqlDbType.DateTime)
                    .Value = $"{appointment.DateTime.ToString("yyyy-MM-dd HH:mm:ss")}";
            command.Parameters.Add(
                        "@reason", MySqlDbType.Int64)
                    .Value = $"{appointment.Reason}";

            return command;
        }

        /// <summary>
        /// Builds the SQL used to update an appointment.
        /// </summary>
        private string buildUpdateAppointmentQuery(Appointment appointment)
        {
            return @"UPDATE appointment
                   SET patient_id = @patientId, doctor_id = @doctorId, datetime = @datetime, reason = @reason
                   WHERE appointment_id = @appointmentId;";
        }

        /** Get the appointments stored in the Database
         * 
         *  @param filter the filter based on the search input
         *  
         *  @returns a list of appointments
         */
        public List<Appointment> GetAppointments(string? filter = null)
        {
            var appointments = new List<Appointment>();
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = createSearchAppointmentsCommand(connection, filter);

            using var reader = command.ExecuteReader();
            Appointment newAppt;
            while (reader.Read())
            {
                newAppt = new Appointment(reader.GetInt32("appointment_id"),
                    reader.GetInt32("patient_id"), reader.GetInt32("doctor_id"),
                    reader.GetDateTime("datetime"), reader.GetString("reason"));
                newAppt.PatientName = $"{reader.GetString("pfname")} {reader.GetString("plname")}";
                newAppt.DoctorName = $"{reader.GetString("dfname")} {reader.GetString("dlname")}";
                
                appointments.Add(newAppt);
            }

            appointment.PatientName = $"{reader.GetString("pfname")} {reader.GetString("plname")}";
            appointment.DoctorName = $"{reader.GetString("dfname")} {reader.GetString("dlname")}";

            return appointment;
        }

        /// <summary>
        /// Creates the command that retrieves appointments, adding the filter parameter when one is given.
        /// </summary>
        private MySqlCommand createSearchAppointmentsCommand(MySqlConnection connection, string? filter = null)
        {
            bool hasFilter = !string.IsNullOrWhiteSpace(filter);

            string query = this.buildAppointmentSearchQuery(hasFilter);

            var command = new MySqlCommand(query, connection);

            if (hasFilter)
            {
                command.Parameters.Add(
                            "@filter", MySqlDbType.VarChar, 200)
                        .Value = $"%{filter!.Trim()}%";
            }

            return command;
        }

        /// <summary>
        /// Builds the appointment query with or without search criteria.
        /// </summary>
        private string buildAppointmentSearchQuery(bool hasFilter)
        {
            const string selectQuery = @"SELECT appointment_id, p.first_name as pfname,
                    p.last_name as plname, p.patient_id, d.first_name as dfname, d.last_name as dlname, d.doctor_id, datetime, reason
                    FROM appointment a INNER JOIN patient p ON a.patient_id = p.patient_id
                    INNER JOIN doctor d ON a.doctor_id = d.doctor_id";
            const string filterQuery = @"WHERE appointment_id LIKE @filter OR p.first_name LIKE @filter
                    OR p.last_name LIKE @filter OR CONCAT(p.first_name, ' ', p.last_name) LIKE @filter
                    OR d.first_name LIKE @filter OR d.last_name LIKE @filter
                    OR CONCAT(d.first_name, ' ', d.last_name) LIKE @filter
                    OR datetime LIKE @filter";
            const string orderByQuery = @"ORDER BY appointment_id;";

            if (!hasFilter)
            {
                return $"{selectQuery} {orderByQuery}";
            }

            return $"{selectQuery} {filterQuery} {orderByQuery}";
        }
    }
}