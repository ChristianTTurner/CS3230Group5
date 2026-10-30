using System;
using System.Collections.Generic;
using CS3230_Group5.Model;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    public class AppointmentDal
    {
        public Dictionary<int, string> GetPatients()
        {
            var patients = new Dictionary<int, string>();
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(
                @"SELECT patient_id, first_name, last_name
                  FROM patient
                  WHERE active = TRUE
                  ORDER BY last_name, first_name;", connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
                patients.Add(reader.GetInt32("patient_id"), $"{reader.GetString("first_name")} {reader.GetString("last_name")}");

            return patients;
        }

        public Dictionary<int, string> GetDoctors()
        {
            var doctors = new Dictionary<int, string>();
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(
                @"SELECT doctor_id, first_name, last_name
                  FROM doctor
                  ORDER BY last_name, first_name;", connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
                doctors.Add(reader.GetInt32("doctor_id"), $"{reader.GetString("first_name")} {reader.GetString("last_name")}");

            return doctors;
        }

        public int AddAppointment(int patientId, int doctorId, DateTime appointmentDateTime, string reason)
        {
            if (patientId <= 0) throw new ArgumentOutOfRangeException(nameof(patientId));
            if (doctorId <= 0) throw new ArgumentOutOfRangeException(nameof(doctorId));
            if (appointmentDateTime < DateTime.Now) throw new ArgumentException("Appointment date and time cannot be in the past.");
            if (appointmentDateTime.TimeOfDay < TimeSpan.FromHours(8) || appointmentDateTime.TimeOfDay > TimeSpan.FromHours(17))
                throw new ArgumentException("Appointments must be scheduled between 8:00 AM and 5:00 PM.");
            if (appointmentDateTime.Minute % 15 != 0 || appointmentDateTime.Second != 0 || appointmentDateTime.Millisecond != 0)
                throw new ArgumentException("Appointments must start on a 15-minute interval.");
            if (string.IsNullOrWhiteSpace(reason)) throw new ArgumentException("Reason is required.");

            DateTime slotStart = new DateTime(appointmentDateTime.Year, appointmentDateTime.Month, appointmentDateTime.Day, appointmentDateTime.Hour, appointmentDateTime.Minute, 0);
            DateTime slotEnd = slotStart.AddMinutes(15);

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

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

        public List<Appointment> GetAppointments()
        {
            var appointments = new List<Appointment>();
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(
                @"SELECT appointment_id, p.first_name, p.last_name, d.first_name, d.last_name, datetime
                    FROM appointment as a INNER JOIN patient as p ON a.patient_id = p.patient_id
                    INNER JOIN doctor as d ON a.doctor_id = d.doctor_id
                    ORDER BY appointment_id;", connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
                appointments.Add(new Appointment(reader.GetInt32("appointment_id"), 
                    $"{reader.GetString("patient.first_name")} {reader.GetString("patient.last_name")}",
                    $"{reader.GetString("doctor.first_name")} {reader.GetString("doctor.last_name")}",
                    reader.GetDateTime("datetime"), reader.GetString("reason")));

            return appointments;
        }
    }
}