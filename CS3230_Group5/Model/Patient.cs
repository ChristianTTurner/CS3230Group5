using System;

namespace CS3230_Group5.Model
{
    /// <summary>
    /// Represents a patient record displayed and managed by the application.
    /// </summary>
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public bool Active { get; set; }
        public int? AddressId { get; set; }
    }
}