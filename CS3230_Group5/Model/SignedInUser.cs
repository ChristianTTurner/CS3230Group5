
namespace CS3230_Group5.Model
{
    /// <summary>
    /// Stores the information of the currently signed-in user.
    /// Provides access to the user's account details, personal information,
    /// address information, and administrative privileges.
    /// </summary>
    public class SignedInUser
    {
        /// <summary>
        /// Gets or sets the username of the currently signed-in user.
        /// </summary>
        public static string? Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the currently signed-in user.
        /// </summary>
        public static string? Password { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the currently signed-in user.
        /// </summary>
        public static int? UserID { get; set; }

        /// <summary>
        /// Gets or sets the first name of the currently signed-in user.
        /// </summary>
        public static string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the currently signed-in user.
        /// </summary>
        public static string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the currently signed-in user.
        /// </summary>
        public static DateOnly? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the currently signed-in user.
        /// </summary>
        public static string? Phone { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the address associated with the user.
        /// </summary>
        public static int? AddressId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the currently signed-in user
        /// has administrative privileges.
        /// </summary>
        public static bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets the first line of the user's address.
        /// </summary>
        public static string? Address1 { get; set; }

        /// <summary>
        /// Gets or sets the second line of the user's address.
        /// </summary>
        public static string? Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city associated with the user's address.
        /// </summary>
        public static string? City { get; set; }

        /// <summary>
        /// Gets or sets the state associated with the user's address.
        /// </summary>
        public static string? State { get; set; }

        /// <summary>
        /// Gets or sets the ZIP code associated with the user's address.
        /// </summary>
        public static string? Zip { get; set; }

        /// <summary>
        /// Clears the currently signed-in user's stored information
        /// and resets the administrative status.
        /// </summary>
        public static void Clear()
        {
            Username = null;
            Password = null;
            UserID = null;
            FirstName = null;
            LastName = null;
            DateOfBirth = null;
            Phone = null;
            AddressId = null;
            IsAdmin = false;
            Address1 = null;
            Address2 = null;
            City = null;
            State = null;
            Zip = null;
        }
    }
}