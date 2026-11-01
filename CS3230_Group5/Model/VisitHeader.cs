using System;

namespace CS3230_Group5.Model
{
    /// <summary>
    /// Names and dates shown at the top of visit screens, so the user never
    /// sees bare ids.
    /// </summary>
    public class VisitHeader
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDateTime { get; set; }

        public string PatientName { get; set; } = string.Empty;
        public DateTime PatientDateOfBirth { get; set; }

        public string DoctorName { get; set; } = string.Empty;

        /// <summary>Null until a routine check-up has been saved.</summary>
        public string? NurseName { get; set; }

        /// <summary>True once a final diagnosis has been entered (visit is read-only).</summary>
        public bool IsFinalized { get; set; }
    }
}
