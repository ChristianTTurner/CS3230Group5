
using System;
using MySqlConnector;
using CS3230_Group5.Model;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Handles database operations for nurses.
    /// </summary>
    public class NurseDal
    {
        /// <summary>
        /// Adds a nurse and their address in one transaction.
        /// Returns the generated nurse ID.
        /// </summary>
        /// <param name="nurse">Nurse information.</param>
        /// <param name="address">Address information.</param>
        /// <param name="passwordHash">Securely generated password hash.</param>
        /// <returns>The generated nurse ID.</returns>
        public int AddNurse(Nurse nurse, Address address, string passwordHash)
        {
            if (nurse == null) throw new ArgumentNullException(nameof(nurse));
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (string.IsNullOrWhiteSpace(passwordHash)) throw new ArgumentException("Password hash is required.", nameof(passwordHash));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                int addressId;

                using (var addressCommand = new MySqlCommand(
                    @"INSERT INTO address
                      (address1, address2, city, state, zip)
                      VALUES
                      (@address1, @address2, @city, @state, @zip);",
                    connection, transaction))
                {
                    addressCommand.Parameters.AddWithValue("@address1", address.Address1);
                    addressCommand.Parameters.AddWithValue("@address2", (object?)address.Address2 ?? DBNull.Value);
                    addressCommand.Parameters.AddWithValue("@city", address.City);
                    addressCommand.Parameters.AddWithValue("@state", address.State);
                    addressCommand.Parameters.AddWithValue("@zip", address.Zip);

                    addressCommand.ExecuteNonQuery();
                    addressId = checked((int)addressCommand.LastInsertedId);
                }

                int nurseId;

                using (var nurseCommand = new MySqlCommand(
                    @"INSERT INTO nurse
                      (first_name, last_name, date_of_birth, address_id, phone, username, password)
                      VALUES
                      (@firstName, @lastName, @dateOfBirth, @addressId, @phone, @username, @password);",
                    connection, transaction))
                {
                    nurseCommand.Parameters.AddWithValue("@firstName", nurse.FirstName);
                    nurseCommand.Parameters.AddWithValue("@lastName", nurse.LastName);
                    nurseCommand.Parameters.AddWithValue("@dateOfBirth", nurse.DateOfBirth);
                    nurseCommand.Parameters.AddWithValue("@addressId", addressId);
                    nurseCommand.Parameters.AddWithValue("@phone", nurse.Phone);
                    nurseCommand.Parameters.AddWithValue("@username", nurse.Username);
                    nurseCommand.Parameters.AddWithValue("@password", passwordHash);

                    nurseCommand.ExecuteNonQuery();
                    nurseId = checked((int)nurseCommand.LastInsertedId);
                }

                transaction.Commit();
                return nurseId;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
