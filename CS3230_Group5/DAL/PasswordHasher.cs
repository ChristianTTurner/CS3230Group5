using System;
using BCrypt.Net;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Hashes and verifies user passwords so plaintext passwords are never stored in the database.
    /// </summary>
    /// <remarks>
    /// Uses the BCrypt algorithm through the BCrypt.Net-Next library. BCrypt generates a random
    /// salt for every hash and stores the salt and cost inside the resulting 60-character string,
    /// so no separate salt column is needed.
    /// Sources:
    /// - BCrypt.Net-Next library: https://github.com/BcryptNet/bcrypt.net
    /// - Provos, N. and Mazieres, D. (1999). "A Future-Adaptable Password Scheme". USENIX Annual Technical Conference.
    /// - OWASP Password Storage Cheat Sheet: https://cheatsheetseries.owasp.org/cheatsheets/Password_Storage_Cheat_Sheet.html
    /// </remarks>
    public static class PasswordHasher
    {
        private const int WorkFactor = 11;

        /// <summary>
        /// Creates a salted BCrypt hash of a password.
        /// </summary>
        /// <param name="password">The plaintext password.</param>
        /// <returns>The hash to store in the database.</returns>
        /// <exception cref="ArgumentException">Thrown when the password is blank.</exception>
        public static string Hash(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password is required.", nameof(password));

            return BCrypt.Net.BCrypt.HashPassword(password, WorkFactor);
        }

        /// <summary>
        /// Checks an entered password against a stored hash.
        /// </summary>
        /// <param name="password">The plaintext password the user entered.</param>
        /// <param name="storedHash">The hash stored in the database.</param>
        /// <returns>
        /// <see langword="true"/> when the password matches; otherwise, <see langword="false"/>.
        /// A stored value that is not a valid BCrypt hash never matches.
        /// </returns>
        public static bool Verify(string password, string? storedHash)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(storedHash))
                return false;

            try
            {
                return BCrypt.Net.BCrypt.Verify(password, storedHash);
            }
            catch (SaltParseException)
            {
                return false;
            }
        }
    }
}