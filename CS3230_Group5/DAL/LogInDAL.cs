using CS3230_Group5.Model;
using MySqlConnector;
using System;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Provides database access for signing administrators and nurses in.
    /// </summary>
    public class LogInDAL
    {
        /// <summary>
        /// Signs in an administrator if the username and password match an existing account.
        /// Stores the administrator's details in <see cref="SignedInUser"/> for use across forms.
        /// </summary>
        /// <param name="username">The entered username.</param>
        /// <param name="password">The entered password.</param>
        /// <returns>
        /// <see langword="true"/> when the credentials match and the user has been signed in;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public bool SignInAdmin(string username, string password)
        {
            const string query =
                "select * from administrator where username = @username and password = @password";

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var cmd = CreateCredentialsCommand(connection, query, username, password);
            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return false;

            StoreAdmin(reader);

            return true;
        }

        /// <summary>
        /// Signs in a nurse if the username and password match an existing account.
        /// Stores the nurse's details in <see cref="SignedInUser"/> for use across forms.
        /// </summary>
        /// <param name="username">The entered username.</param>
        /// <param name="password">The entered password.</param>
        /// <returns>
        /// <see langword="true"/> when the credentials match and the user has been signed in;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public bool SignInNurse(string username, string password)
        {
            const string query = @"SELECT n.nurse_id, n.username, n.password, n.first_name, n.last_name,
        n.date_of_birth, n.address_id AS nurse_address_id, n.phone, a.address1, a.address2, a.city
        FROM nurse n JOIN address a ON n.address_id = a.address_id
        WHERE n.username = @username AND n.password = @password";

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var cmd = CreateCredentialsCommand(connection, query, username, password);
            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return false;

            StoreNurse(reader);

            return true;
        }

        /// <summary>
        /// Creates a command that takes the username and password parameters.
        /// </summary>
        /// <param name="connection">The connection the command will run on.</param>
        /// <param name="query">The SQL query using @username and @password.</param>
        /// <param name="username">The entered username.</param>
        /// <param name="password">The entered password.</param>
        /// <returns>The command with both parameters set.</returns>
        private static MySqlCommand CreateCredentialsCommand(
            MySqlConnection connection, string query, string username, string password)
        {
            var cmd = new MySqlCommand(query, connection);

            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            return cmd;
        }

        /// <summary>
        /// Stores the administrator in the current row as the signed-in user.
        /// </summary>
        /// <param name="reader">The reader positioned on an administrator row.</param>
        private static void StoreAdmin(MySqlDataReader reader)
        {
            SignedInUser.UserID = reader.GetInt32("admin_id");
            SignedInUser.Username = reader.GetString("username");
            SignedInUser.Password = reader.GetString("password");
            SignedInUser.FirstName = reader.GetString("first_name");
            SignedInUser.LastName = reader.GetString("last_name");
            SignedInUser.DateOfBirth = reader.GetDateOnly("date_of_birth");
            SignedInUser.Phone = reader.GetString("phone");
            SignedInUser.AddressId = reader.GetInt32("address_id");
            SignedInUser.IsAdmin = true;
        }

        /// <summary>
        /// Stores the nurse in the current row as the signed-in user.
        /// </summary>
        /// <param name="reader">The reader positioned on a nurse row.</param>
        private static void StoreNurse(MySqlDataReader reader)
        {
            SignedInUser.UserID = reader.GetInt32("nurse_id");
            SignedInUser.Username = reader.GetString("username");
            SignedInUser.Password = reader.GetString("password");
            SignedInUser.FirstName = reader.GetString("first_name");
            SignedInUser.LastName = reader.GetString("last_name");
            SignedInUser.DateOfBirth = reader.GetDateOnly("date_of_birth");
            SignedInUser.AddressId = reader.GetInt32("nurse_address_id");
            SignedInUser.Phone = reader.GetString("phone");
            SignedInUser.IsAdmin = false;
            SignedInUser.Address1 = reader.GetString("address1");
            SignedInUser.Address2 = reader.IsDBNull(reader.GetOrdinal("address2"))
                ? null
                : reader.GetString("address2");
            SignedInUser.City = reader.GetString("city");
        }
    }
}