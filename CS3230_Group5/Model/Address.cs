namespace CS3230_Group5.Model
{
    /// <summary>
    /// Represents a mailing address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets the database identifier. Null for a new address.
        /// </summary>
        public int? AddressId { get; }

        /// <summary>
        /// Gets the first address line.
        /// </summary>
        public string Address1 { get; }

        /// <summary>
        /// Gets the optional second address line.
        /// </summary>
        public string? Address2 { get; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        public string City { get; }

        /// <summary>
        /// Gets the two-letter state abbreviation.
        /// </summary>
        public string State { get; }

        /// <summary>
        /// Gets the five-digit ZIP code.
        /// </summary>
        public string Zip { get; }

        /// <summary>
        /// Initializes an address and validates its information.
        /// </summary>
        public Address(int? addressId, string address1, string? address2, string city, string state, string zip)
        {
            if (addressId.HasValue && addressId.Value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(addressId),
                    "Address ID must be positive when provided.");
            }

            this.AddressId = addressId;
            this.Address1 = validateRequired(address1, nameof(address1));
            this.Address2 = validateOptional(address2);
            this.City = validateRequired(city, nameof(city));
            this.State = validateState(state);
            this.Zip = validateZip(zip);
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

        private static string? validateOptional(string? value)
        {
            return string.IsNullOrWhiteSpace(value)
                ? null
                : value.Trim();
        }

        private static string validateState(string state)
        {
            state = validateRequired(state, nameof(state));

            if (state.Length != 2 ||
                state[0] < 'A' || state[0] > 'Z' ||
                state[1] < 'A' || state[1] > 'Z')
            {
                throw new ArgumentException(
                    "State must be a two-letter uppercase abbreviation.",
                    nameof(state));
            }

            return state;
        }

        private static string validateZip(string zip)
        {
            zip = validateRequired(zip, nameof(zip));

            if (zip.Length != 5)
            {
                throw new ArgumentException(
                    "ZIP code must contain exactly five digits.",
                    nameof(zip));
            }

            foreach (char character in zip)
            {
                if (character < '0' || character > '9')
                {
                    throw new ArgumentException(
                        "ZIP code must contain only digits.",
                        nameof(zip));
                }
            }

            return zip;
        }

    }
}
