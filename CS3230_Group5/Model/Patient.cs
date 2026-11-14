using System;

namespace CS3230_Group5.Model
{
    /// <summary>
    /// Represents a patient record displayed and managed by the application.
    /// Stores the patient's personal information, contact details, and account status.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Gets or sets the unique identifier of the patient.
        /// </summary>
        public int PatientId { get; set; }

        /// <summary>
        /// Gets or sets the patient's first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the patient's last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the patient's date of birth.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the patient's phone number.
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the patient's gender.
        /// </summary>
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the patient's record is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the address associated with the patient.
        /// </summary>
        public int? AddressId { get; set; }
    }
}