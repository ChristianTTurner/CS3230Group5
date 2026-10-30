
using System;

namespace CS3230_Group5.Model
{
    /// <summary>
    /// Represents a scheduled patient appointment.
    /// </summary>
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public DateTime DateTime { get; set; }

        public string Reason { get; set; }

        /// <summary>
        /// Initializes an appointment.
        /// </summary>
        public Appointment(
            int appointmentId,
            int patientId,
            int doctorId,
            DateTime dateTime,
            string reason)
        {
            if (appointmentId <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(appointmentId),
                    "Appointment ID must be positive.");

            if (patientId <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(patientId),
                    "Patient ID must be positive.");

            if (doctorId <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(doctorId),
                    "Doctor ID must be positive.");

            if (string.IsNullOrWhiteSpace(reason))
                throw new ArgumentException(
                    "Appointment reason cannot be empty.",
                    nameof(reason));

            AppointmentId = appointmentId;
            PatientId = patientId;
            DoctorId = doctorId;
            DateTime = dateTime;
            Reason = reason.Trim();
        }
    }
}
