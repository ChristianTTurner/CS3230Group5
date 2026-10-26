
using System;
using System.Collections.Generic;
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
        public int AddNurse(Nurse nurse, Address address, string password)
        {
            if (nurse == null) throw new ArgumentNullException(nameof(nurse));
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password is required.", nameof(password));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                using var addressCommand = new MySqlCommand(
                    @"INSERT INTO address (address1, address2, city, state, zip)
                      VALUES (@address1, @address2, @city, @state, @zip);",
                    connection, transaction);
                addressCommand.Parameters.Add("@address1", MySqlDbType.VarChar, 100).Value = address.Address1;
                addressCommand.Parameters.Add("@address2", MySqlDbType.VarChar, 100).Value = (object?)address.Address2 ?? DBNull.Value;
                addressCommand.Parameters.Add("@city", MySqlDbType.VarChar, 50).Value = address.City;
                addressCommand.Parameters.Add("@state", MySqlDbType.String, 2).Value = address.State;
                addressCommand.Parameters.Add("@zip", MySqlDbType.String, 5).Value = address.Zip;
                addressCommand.ExecuteNonQuery();

                int addressId = checked((int)addressCommand.LastInsertedId);

                using var nurseCommand = new MySqlCommand(
                    @"INSERT INTO nurse
                      (first_name, last_name, date_of_birth, address_id, phone, username, password)
                      VALUES (@firstName, @lastName, @dateOfBirth, @addressId, @phone, @username, @password);",
                    connection, transaction);

                nurseCommand.Parameters.Add("@firstName", MySqlDbType.VarChar, 50).Value = nurse.FirstName;
                nurseCommand.Parameters.Add("@lastName", MySqlDbType.VarChar, 50).Value = nurse.LastName;
                nurseCommand.Parameters.Add("@dateOfBirth", MySqlDbType.Date).Value = nurse.DateOfBirth;
                nurseCommand.Parameters.Add("@addressId", MySqlDbType.Int32).Value = addressId;
                nurseCommand.Parameters.Add("@phone", MySqlDbType.String, 10).Value = nurse.Phone;
                nurseCommand.Parameters.Add("@username", MySqlDbType.VarChar, 30).Value = nurse.Username;
                nurseCommand.Parameters.Add("@password", MySqlDbType.VarChar, 100).Value = password;
                nurseCommand.ExecuteNonQuery();

                int nurseId = checked((int)nurseCommand.LastInsertedId);
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
        public (Nurse Nurse, Address Address)? GetNurseById(int nurseId)
        {
            if (nurseId <= 0) throw new ArgumentOutOfRangeException(nameof(nurseId), "Nurse ID must be positive.");

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(
                @"SELECT n.nurse_id, n.first_name, n.last_name, n.date_of_birth,
                     n.address_id AS nurse_address_id, n.phone, n.username, n.password,
                     a.address_id, a.address1, a.address2, a.city, a.state, a.zip
              FROM nurse n
              JOIN address a ON n.address_id = a.address_id
              WHERE n.nurse_id = @nurseId;",
                connection);

            command.Parameters.Add("@nurseId", MySqlDbType.Int32).Value = nurseId;

            using var reader = command.ExecuteReader();
            return reader.Read() ? readNurseAndAddress(reader) : null;
        }

        /// <summary>
        /// Gets the nurse's password by thier id
        /// </summary>
        /// <param name="nurseId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string? GetNursePasswordById(int nurseId)
        {
            if (nurseId <= 0)
                throw new ArgumentOutOfRangeException(nameof(nurseId));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(
                @"SELECT password
          FROM nurse
          WHERE nurse_id = @nurseId;",
                connection);

            command.Parameters.Add("@nurseId", MySqlDbType.Int32).Value = nurseId;

            var result = command.ExecuteScalar();

            return result == null || result == DBNull.Value
                ? null
                : Convert.ToString(result);
        }

        /// <summary>
        /// Updates a nurse and their associated address in one transaction.
        /// </summary>
        public bool UpdateNurse(Nurse nurse, Address address, string password)
        {
            if (nurse == null) throw new ArgumentNullException(nameof(nurse));
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (!nurse.NurseId.HasValue) throw new ArgumentException("Nurse ID is required to update a nurse.", nameof(nurse));
            if (!nurse.AddressId.HasValue) throw new ArgumentException("Address ID is required to update a nurse.", nameof(nurse));
            if (!address.AddressId.HasValue) throw new ArgumentException("Address ID is required to update an address.", nameof(address));
            if (nurse.AddressId.Value != address.AddressId.Value) throw new ArgumentException("The nurse and address IDs must match.");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password is required.", nameof(password));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {

                using var addressCommand = new MySqlCommand(
                    @"UPDATE address
                      SET address1 = @address1,
                          address2 = @address2,
                          city = @city,
                          state = @state,
                          zip = @zip
                     WHERE address_id = @addressId;",
                    connection, transaction);

                addressCommand.Parameters.Add("@address1", MySqlDbType.VarChar, 100).Value = address.Address1;
                addressCommand.Parameters.Add("@address2", MySqlDbType.VarChar, 100).Value =
                    (object?)address.Address2 ?? DBNull.Value;
                addressCommand.Parameters.Add("@city", MySqlDbType.VarChar, 50).Value = address.City;
                addressCommand.Parameters.Add("@state", MySqlDbType.String, 2).Value = address.State;
                addressCommand.Parameters.Add("@zip", MySqlDbType.String, 5).Value = address.Zip;
                addressCommand.Parameters.Add("@addressId", MySqlDbType.Int32).Value = address.AddressId.Value;

                addressCommand.ExecuteNonQuery();


                using var nurseCommand = new MySqlCommand(
                    @"UPDATE nurse
                      SET first_name = @firstName,
                          last_name = @lastName,
                          date_of_birth = @dateOfBirth,
                          phone = @phone,
                          username = @username,
                          password = @password
                      WHERE nurse_id = @nurseId AND address_id = @addressId;",
                    connection, transaction);

                nurseCommand.Parameters.Add("@firstName", MySqlDbType.VarChar, 50).Value = nurse.FirstName;
                nurseCommand.Parameters.Add("@lastName", MySqlDbType.VarChar, 50).Value = nurse.LastName;
                nurseCommand.Parameters.Add("@dateOfBirth", MySqlDbType.Date).Value = nurse.DateOfBirth;
                nurseCommand.Parameters.Add("@phone", MySqlDbType.String, 10).Value = nurse.Phone;
                nurseCommand.Parameters.Add("@username", MySqlDbType.VarChar, 30).Value = nurse.Username;
                nurseCommand.Parameters.Add("@password", MySqlDbType.VarChar, 100).Value = password;
                nurseCommand.Parameters.Add("@nurseId", MySqlDbType.Int32).Value = nurse.NurseId.Value;
                nurseCommand.Parameters.Add("@addressId", MySqlDbType.Int32).Value = nurse.AddressId.Value;

                nurseCommand.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Retrieves all nurses and their associated addresses.
        /// </summary>
        public List<(Nurse Nurse, Address Address)> GetAllNurses()
        {
            var nurses = new List<(Nurse Nurse, Address Address)>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(
                @"SELECT n.nurse_id, n.first_name, n.last_name, n.date_of_birth,
                         n.address_id AS nurse_address_id, n.phone, n.username,
                         a.address_id, a.address1, a.address2, a.city, a.state, a.zip
                  FROM nurse n
                  JOIN address a ON n.address_id = a.address_id
                  ORDER BY n.last_name, n.first_name;",
                connection);

            using var reader = command.ExecuteReader();

            while (reader.Read()) nurses.Add(readNurseAndAddress(reader));

            return nurses;
        }

        private static (Nurse Nurse, Address Address) readNurseAndAddress(MySqlDataReader reader)
        {
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
                reader.IsDBNull(reader.GetOrdinal("address2")) ? null : reader.GetString("address2"),
                reader.GetString("city"),
                reader.GetString("state"),
                reader.GetString("zip"));

            return (nurse, address);
        }
    }
}
