namespace CS3230_Group5.Model
{
    /// <summary>
    /// Represents a nurse with identity and contact information.
    /// </summary>
    public class Nurse
    {
        /// <summary>
        /// Gets the database identifier. Null for a new nurse.
        /// </summary>
        public int? NurseId { get; }

        /// <summary>
        /// Gets the nurse's first name.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Gets the nurse's last name.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Gets the nurse's date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; }

        /// <summary>
        /// Gets the identifier of the nurse's address.
        /// </summary>
        public int AddressId { get; }

        /// <summary>
        /// Gets the nurse's 10-digit phone number.
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// Gets the nurse's login username.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Initializes a nurse and validates the supplied information.
        /// </summary>
        public Nurse(int? nurseId, string firstName, string lastName, DateTime? dateOfBirth, int? addressId, string phone, string username)
        {
            if (nurseId.HasValue && nurseId.Value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(nurseId),
                    "Nurse ID must be positive when provided.");
            }

            if (!addressId.HasValue || addressId.Value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(addressId),
                    "Address ID must be positive.");
            }

            if (!dateOfBirth.HasValue)
            {
                throw new ArgumentNullException(nameof(dateOfBirth));
            }

            if (dateOfBirth.Value.Date > DateTime.Today)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(dateOfBirth),
                    "Date of birth cannot be in the future.");
            }

            NurseId = nurseId;
            FirstName = validateRequired(firstName, nameof(firstName));
            LastName = validateRequired(lastName, nameof(lastName));
            DateOfBirth = dateOfBirth.Value.Date;
            AddressId = addressId.Value;
            Phone = validatePhone(phone);
            Username = validateRequired(username, nameof(username));
        }

        private static string validateRequired(string value, string name)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    $"{name} cannot be empty.", name);
            }

            return value.Trim();
        }

        private static string validatePhone(string phone)
        {
            phone = validateRequired(phone, nameof(phone));

            if (phone.Length != 10)
            {
                throw new ArgumentException(
                    "Phone number must contain exactly 10 digits.",
                    nameof(phone));
            }

            foreach (char character in phone)
            {
                if (character < '0' || character > '9')
                {
                    throw new ArgumentException(
                        "Phone number must contain only digits.",
                        nameof(phone));
                }
            }

            return phone;
        }
    }
}
