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
        /// </summary>
        /// <param name="nurse">The nurse to add.</param>
        /// <param name="address">The nurse's address.</param>
        /// <param name="password">The nurse's password.</param>
        /// <returns>The generated nurse ID.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the nurse or address is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the password is blank.</exception>
        public int AddNurse(Nurse nurse, Address address, string password)
        {
            validateNewNurse(nurse, address, password);

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                int addressId = insertAddress(connection, transaction, address);
                int nurseId = insertNurse(connection, transaction, nurse, addressId, password);

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
        /// <param name="nurseId">The nurse ID to look up.</param>
        /// <returns>The nurse and address, or <see langword="null"/> when no nurse matches.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the nurse ID is not positive.</exception>
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
        /// Gets the nurse's password by their ID.
        /// </summary>
        /// <param name="nurseId">The nurse ID to look up.</param>
        /// <returns>The stored password, or <see langword="null"/> when no nurse matches.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the nurse ID is not positive.</exception>
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
        /// <param name="nurse">The nurse with the updated values.</param>
        /// <param name="address">The address with the updated values.</param>
        /// <param name="password">The nurse's password.</param>
        /// <returns><see langword="true"/> when the update completes.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the nurse or address is null.</exception>
        /// <exception cref="ArgumentException">
        /// Thrown when an ID is missing, the nurse and address IDs do not match, or the password is blank.
        /// </exception>
        public bool UpdateNurse(Nurse nurse, Address address, string password)
        {
            validateNurseUpdate(nurse, address, password);

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                updateAddress(connection, transaction, address);
                updateNurse(connection, transaction, nurse, password);

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
        /// <returns>A list of nurses with their addresses, ordered by last name then first name.</returns>
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

        /// <summary>
        /// Validates the values required to add a nurse.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when the nurse or address is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the password is blank.</exception>
        private static void validateNewNurse(Nurse nurse, Address address, string password)
        {
            if (nurse == null) throw new ArgumentNullException(nameof(nurse));
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password is required.", nameof(password));
        }

        /// <summary>
        /// Validates the values required to update a nurse.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when the nurse or address is null.</exception>
        /// <exception cref="ArgumentException">
        /// Thrown when an ID is missing, the nurse and address IDs do not match, or the password is blank.
        /// </exception>
        private static void validateNurseUpdate(Nurse nurse, Address address, string password)
        {
            if (nurse == null) throw new ArgumentNullException(nameof(nurse));
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (!nurse.NurseId.HasValue) throw new ArgumentException("Nurse ID is required to update a nurse.", nameof(nurse));
            if (!nurse.AddressId.HasValue) throw new ArgumentException("Address ID is required to update a nurse.", nameof(nurse));
            if (!address.AddressId.HasValue) throw new ArgumentException("Address ID is required to update an address.", nameof(address));
            if (nurse.AddressId.Value != address.AddressId.Value) throw new ArgumentException("The nurse and address IDs must match.");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password is required.", nameof(password));
        }

        /// <summary>
        /// Inserts an address row inside a transaction.
        /// </summary>
        /// <returns>The generated address ID.</returns>
        private static int insertAddress(MySqlConnection connection, MySqlTransaction transaction, Address address)
        {
            using var command = new MySqlCommand(
                @"INSERT INTO address (address1, address2, city, state, zip)
                      VALUES (@address1, @address2, @city, @state, @zip);",
                connection, transaction);

            addAddressParameters(command, address);
            command.ExecuteNonQuery();

            return checked((int)command.LastInsertedId);
        }

        /// <summary>
        /// Updates an existing address row inside a transaction.
        /// </summary>
        private static void updateAddress(MySqlConnection connection, MySqlTransaction transaction, Address address)
        {
            using var command = new MySqlCommand(
                @"UPDATE address
                      SET address1 = @address1,
                          address2 = @address2,
                          city = @city,
                          state = @state,
                          zip = @zip
                     WHERE address_id = @addressId;",
                connection, transaction);

            addAddressParameters(command, address);
            command.Parameters.Add("@addressId", MySqlDbType.Int32).Value = address.AddressId!.Value;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Inserts a nurse row inside a transaction.
        /// </summary>
        /// <returns>The generated nurse ID.</returns>
        private static int insertNurse(MySqlConnection connection, MySqlTransaction transaction, Nurse nurse, int addressId, string password)
        {
            using var command = new MySqlCommand(
                @"INSERT INTO nurse
                      (first_name, last_name, date_of_birth, address_id, phone, username, password)
                      VALUES (@firstName, @lastName, @dateOfBirth, @addressId, @phone, @username, @password);",
                connection, transaction);

            addNurseParameters(command, nurse, password);
            command.Parameters.Add("@addressId", MySqlDbType.Int32).Value = addressId;

            command.ExecuteNonQuery();

            return checked((int)command.LastInsertedId);
        }

        /// <summary>
        /// Updates an existing nurse row inside a transaction.
        /// </summary>
        private static void updateNurse(MySqlConnection connection, MySqlTransaction transaction, Nurse nurse, string password)
        {
            using var command = new MySqlCommand(
                @"UPDATE nurse
                      SET first_name = @firstName,
                          last_name = @lastName,
                          date_of_birth = @dateOfBirth,
                          phone = @phone,
                          username = @username,
                          password = @password
                      WHERE nurse_id = @nurseId AND address_id = @addressId;",
                connection, transaction);

            addNurseParameters(command, nurse, password);
            command.Parameters.Add("@nurseId", MySqlDbType.Int32).Value = nurse.NurseId!.Value;
            command.Parameters.Add("@addressId", MySqlDbType.Int32).Value = nurse.AddressId!.Value;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds the address parameters shared by the insert and update commands.
        /// </summary>
        private static void addAddressParameters(MySqlCommand command, Address address)
        {
            command.Parameters.Add("@address1", MySqlDbType.VarChar, 100).Value = address.Address1;
            command.Parameters.Add("@address2", MySqlDbType.VarChar, 100).Value =
                (object?)address.Address2 ?? DBNull.Value;
            command.Parameters.Add("@city", MySqlDbType.VarChar, 50).Value = address.City;
            command.Parameters.Add("@state", MySqlDbType.String, 2).Value = address.State;
            command.Parameters.Add("@zip", MySqlDbType.String, 5).Value = address.Zip;
        }

        /// <summary>
        /// Adds the nurse parameters shared by the insert and update commands.
        /// </summary>
        private static void addNurseParameters(MySqlCommand command, Nurse nurse, string password)
        {
            command.Parameters.Add("@firstName", MySqlDbType.VarChar, 50).Value = nurse.FirstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar, 50).Value = nurse.LastName;
            command.Parameters.Add("@dateOfBirth", MySqlDbType.Date).Value = nurse.DateOfBirth;
            command.Parameters.Add("@phone", MySqlDbType.String, 10).Value = nurse.Phone;
            command.Parameters.Add("@username", MySqlDbType.VarChar, 30).Value = nurse.Username;
            command.Parameters.Add("@password", MySqlDbType.VarChar, 100).Value = password;
        }

        /// <summary>
        /// Converts the current database row to a nurse and their address.
        /// </summary>
        /// <param name="reader">The reader positioned on a nurse and address row.</param>
        /// <returns>The mapped nurse and address.</returns>
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