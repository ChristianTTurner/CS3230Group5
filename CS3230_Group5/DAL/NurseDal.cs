
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


        /// <summary>
        /// Retrieves a nurse and their address by nurse ID.
        /// </summary>
        /// <param name="nurseId">The ID of the nurse to retrieve.</param>
        /// <returns>The nurse and address, or null if the nurse is not found.</returns>
        public (Nurse Nurse, Address Address)? GetNurseById(int nurseId)
        {
            if (nurseId <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(nurseId), "Nurse ID must be positive.");

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            using var command = new MySqlCommand(
                @"SELECT
              n.nurse_id,
              n.first_name,
              n.last_name,
              n.date_of_birth,
              n.address_id AS nurse_address_id,
              n.phone,
              n.username,
              a.address_id AS address_id,
              a.address1,
              a.address2,
              a.city,
              a.state,
              a.zip
          FROM nurse n
          JOIN address a ON n.address_id = a.address_id
          WHERE n.nurse_id = @nurseId;",
                connection);

            command.Parameters.AddWithValue("@nurseId", nurseId);

            using var reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            var nurse = new Nurse(
                reader.GetInt32("nurse_id"),
                reader.GetString("first_name"),
                reader.GetString("last_name"),
                reader.GetDateTime("date_of_birth"),
                reader.GetInt32("nurse_address_id"),
                reader.GetString("phone"),
                reader.GetString("username"));

            var address = new Address(
                reader.GetInt32("address_id"),
                reader.GetString("address1"),
                reader.IsDBNull(reader.GetOrdinal("address2"))
                    ? null
                    : reader.GetString("address2"),
                reader.GetString("city"),
                reader.GetString("state"),
                reader.GetString("zip"));

            return (nurse, address);
        }

    }
}
