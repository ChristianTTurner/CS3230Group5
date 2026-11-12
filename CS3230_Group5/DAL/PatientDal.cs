using System;
using System.Collections.Generic;
using System.Data;
using CS3230_Group5.Model;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Performs database operations for patient records.
    /// Keeps SQL and data-access logic out of the Windows Forms views.
    /// </summary>
    public class PatientDal
    {
        /// <summary>
        /// Retrieves patients, optionally searching by name, phone, or date of birth.
        /// </summary>
        public List<Patient> GetPatients(string? filter = null)
        {
            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = CreatePatientSearchCommand(
                connection, filter);

            connection.Open();

            using var reader = command.ExecuteReader();

            return ReadPatients(reader);
        }

        /// <summary>
        /// Retrieves one patient's information, including their address.
        /// </summary>
        public DataTable GetPatientDetails(int patientId)
        {
            const string query = @"
        SELECT
            p.patient_id,
            p.first_name,
            p.last_name,
            p.date_of_birth,
            p.phone,
            p.gender,
            p.active,
        CONCAT_WS(', ',
            NULLIF(a.address1, ''),
            NULLIF(a.address2, '')
        ) AS street_address,

        CONCAT_WS(', ',
            NULLIF(a.city, ''),
            NULLIF(a.state, ''),
            NULLIF(a.zip, '')
        ) AS city_state_zip
        FROM patient p
        LEFT JOIN address a
            ON p.address_id = a.address_id
        WHERE p.patient_id = @patientId;";

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add(
                "@patientId", MySqlDbType.Int32).Value = patientId;

            connection.Open();

            using var reader = command.ExecuteReader();

            var table = new DataTable();
            table.Load(reader);

            return table;
        }

        /// <summary>
        /// Creates the SQL command for retrieving and filtering patients.
        /// </summary>
        private static MySqlCommand CreatePatientSearchCommand(
            MySqlConnection connection, string? filter)
        {
            bool hasFilter = !string.IsNullOrWhiteSpace(filter);

            string query = BuildPatientSearchQuery(hasFilter);

            var command = new MySqlCommand(query, connection);

            if (hasFilter)
            {
                command.Parameters.Add(
                            "@filter", MySqlDbType.VarChar, 200)
                        .Value = $"%{filter!.Trim()}%";
            }

            return command;
        }

        /// <summary>
        /// Builds the patient query with or without search criteria.
        /// </summary>
        private static string BuildPatientSearchQuery(bool hasFilter)
        {
            const string selectQuery = @"
        SELECT patient_id, first_name, last_name, date_of_birth,
               phone, gender, active, address_id
        FROM patient";

            if (!hasFilter)
            {
                return selectQuery + " ORDER BY last_name, first_name;";
            }

            return selectQuery + @"
        WHERE first_name LIKE @filter
           OR last_name LIKE @filter
           OR CONCAT(first_name, ' ', last_name) LIKE @filter
           OR phone LIKE @filter
           OR DATE_FORMAT(date_of_birth, '%Y-%m-%d') LIKE @filter
           OR DATE_FORMAT(date_of_birth, '%m/%d/%Y') LIKE @filter
        ORDER BY last_name, first_name;";
        }

        /// <summary>
        /// Converts the database results into a list of Patient models.
        /// </summary>
        private static List<Patient> ReadPatients(MySqlDataReader reader)
        {
            var patients = new List<Patient>();

            while (reader.Read())
            {
                patients.Add(MapPatient(reader));
            }

            return patients;
        }

        /// <summary>
        /// Maps the current database row to a Patient model.
        /// </summary>
        private static Patient MapPatient(MySqlDataReader reader)
        {
            return new Patient
            {
                PatientId = reader.GetInt32("patient_id"),
                FirstName = ReadString(reader, "first_name"),
                LastName = ReadString(reader, "last_name"),
                DateOfBirth = ReadNullableDate(reader, "date_of_birth"),
                Phone = ReadString(reader, "phone"),
                Gender = ReadString(reader, "gender"),
                Active = ReadActiveStatus(reader),
                AddressId = ReadNullableInt(reader, "address_id")
            };
        }

        /// <summary>
        /// Reads a string value, returning an empty string for database NULL.
        /// </summary>
        private static string ReadString(
            MySqlDataReader reader, string column)
        {
            return reader.IsDBNull(reader.GetOrdinal(column))
                ? string.Empty
                : reader.GetString(column);
        }

        /// <summary>
        /// Reads a nullable date from the current database row.
        /// </summary>
        private static DateTime? ReadNullableDate(
            MySqlDataReader reader, string column)
        {
            int ordinal = reader.GetOrdinal(column);

            return reader.IsDBNull(ordinal)
                ? null
                : reader.GetDateTime(ordinal);
        }

        /// <summary>
        /// Reads a nullable integer from the current database row.
        /// </summary>
        private static int? ReadNullableInt(
            MySqlDataReader reader, string column)
        {
            int ordinal = reader.GetOrdinal(column);

            return reader.IsDBNull(ordinal)
                ? null
                : reader.GetInt32(ordinal);
        }

        /// <summary>
        /// Reads the patient's active status.
        /// </summary>
        private static bool ReadActiveStatus(MySqlDataReader reader)
        {
            int ordinal = reader.GetOrdinal("active");

            return !reader.IsDBNull(ordinal)
                   && Convert.ToBoolean(reader.GetValue(ordinal));
        }

        /// <summary>
        /// Loads a patient and their address (if any) for editing.
        /// Returns null when the patient does not exist.
        /// </summary>
        public (Patient Patient, Address? Address)? GetPatientForEdit(int patientId)
        {
            if (patientId <= 0)
                throw new ArgumentOutOfRangeException(nameof(patientId));

            const string query = @"
                SELECT p.patient_id, p.first_name, p.last_name, p.date_of_birth,
                       p.phone, p.gender, p.active, p.address_id,
                       a.address1, a.address2, a.city, a.state, a.zip
                FROM patient p
                LEFT JOIN address a ON p.address_id = a.address_id
                WHERE p.patient_id = @patientId;";

            using var connection =
                new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@patientId", MySqlDbType.Int32).Value = patientId;

            using var reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            Patient patient = MapPatient(reader);

            Address? address = patient.AddressId.HasValue
                ? new Address(
                    patient.AddressId,
                    ReadString(reader, "address1"),
                    ReadString(reader, "address2"),
                    ReadString(reader, "city"),
                    ReadString(reader, "state"),
                    ReadString(reader, "zip"))
                : null;

            return (patient, address);
        }

        /// <summary>
        /// Adds a patient and their address in one transaction.
        /// Returns the new patient's ID.
        /// </summary>
        public int AddPatient(Patient patient, Address address)
        {
            ArgumentNullException.ThrowIfNull(patient);
            ArgumentNullException.ThrowIfNull(address);

            using var connection =
                new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                int addressId = InsertAddress(connection, transaction, address);

                const string insertPatient = @"
                    INSERT INTO patient
                        (first_name, last_name, date_of_birth, phone,
                         address_id, gender, active)
                    VALUES
                        (@firstName, @lastName, @dateOfBirth, @phone,
                         @addressId, @gender, @active);";

                using var command = new MySqlCommand(
                    insertPatient, connection, transaction);
                AddPatientParameters(command, patient, addressId);
                command.ExecuteNonQuery();

                int patientId = checked((int)command.LastInsertedId);

                transaction.Commit();
                return patientId;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Updates a patient and their address in one transaction.
        /// If the patient has no address yet, one is created.
        /// Returns true when the patient row was found.
        /// </summary>
        public bool UpdatePatient(Patient patient, Address address)
        {
            ArgumentNullException.ThrowIfNull(patient);
            ArgumentNullException.ThrowIfNull(address);

            if (patient.PatientId <= 0)
                throw new ArgumentException(
                    "Patient ID is required to update a patient.", nameof(patient));

            using var connection =
                new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                int addressId = address.AddressId.HasValue
                    ? UpdateAddress(connection, transaction, address)
                    : InsertAddress(connection, transaction, address);

                const string updatePatient = @"
                    UPDATE patient
                    SET first_name = @firstName,
                        last_name = @lastName,
                        date_of_birth = @dateOfBirth,
                        phone = @phone,
                        address_id = @addressId,
                        gender = @gender,
                        active = @active
                    WHERE patient_id = @patientId;";

                using var command = new MySqlCommand(
                    updatePatient, connection, transaction);
                AddPatientParameters(command, patient, addressId);
                command.Parameters.Add("@patientId", MySqlDbType.Int32).Value =
                    patient.PatientId;

                bool found = command.ExecuteNonQuery() > 0;

                transaction.Commit();
                return found;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private static void AddPatientParameters(
            MySqlCommand command, Patient patient, int addressId)
        {
            command.Parameters.Add("@firstName", MySqlDbType.VarChar, 50).Value =
                patient.FirstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar, 50).Value =
                patient.LastName;
            command.Parameters.Add("@dateOfBirth", MySqlDbType.Date).Value =
                (object?)patient.DateOfBirth ?? DBNull.Value;
            command.Parameters.Add("@phone", MySqlDbType.VarChar, 10).Value =
                patient.Phone;
            command.Parameters.Add("@addressId", MySqlDbType.Int32).Value =
                addressId;
            command.Parameters.Add("@gender", MySqlDbType.VarChar, 20).Value =
                patient.Gender;
            command.Parameters.Add("@active", MySqlDbType.Bool).Value =
                patient.Active;
        }

        private static int InsertAddress(
            MySqlConnection connection,
            MySqlTransaction transaction,
            Address address)
        {
            const string query = @"
                INSERT INTO address (address1, address2, city, state, zip)
                VALUES (@address1, @address2, @city, @state, @zip);";

            using var command = new MySqlCommand(query, connection, transaction);
            AddAddressParameters(command, address);
            command.ExecuteNonQuery();

            return checked((int)command.LastInsertedId);
        }

        private static int UpdateAddress(
            MySqlConnection connection,
            MySqlTransaction transaction,
            Address address)
        {
            const string query = @"
                UPDATE address
                SET address1 = @address1,
                    address2 = @address2,
                    city = @city,
                    state = @state,
                    zip = @zip
                WHERE address_id = @addressId;";

            using var command = new MySqlCommand(query, connection, transaction);
            AddAddressParameters(command, address);
            command.Parameters.Add("@addressId", MySqlDbType.Int32).Value =
                address.AddressId!.Value;
            command.ExecuteNonQuery();

            return address.AddressId.Value;
        }

        private static void AddAddressParameters(
            MySqlCommand command, Address address)
        {
            command.Parameters.Add("@address1", MySqlDbType.VarChar, 100).Value =
                address.Address1;
            command.Parameters.Add("@address2", MySqlDbType.VarChar, 100).Value =
                (object?)address.Address2 ?? DBNull.Value;
            command.Parameters.Add("@city", MySqlDbType.VarChar, 50).Value =
                address.City;
            command.Parameters.Add("@state", MySqlDbType.String, 2).Value =
                address.State;
            command.Parameters.Add("@zip", MySqlDbType.String, 5).Value =
                address.Zip;
        }

        /// <summary>
        /// Deletes a patient in a transaction. The associated address is deleted
        /// only when no patient or nurse still references it.
        /// </summary>
        public void DeletePatient(int patientId)
        {
            if (patientId <= 0)
                throw new ArgumentOutOfRangeException(nameof(patientId));

            using var connection =
                new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                int? addressId = GetPatientAddressId(
                    connection, transaction, patientId);

                using (var deletePatient = new MySqlCommand(
                           "DELETE FROM patient WHERE patient_id = @patientId",
                           connection, transaction))
                {
                    deletePatient.Parameters.Add(
                        "@patientId", MySqlDbType.Int32).Value = patientId;

                    int rowsAffected = deletePatient.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException(
                            "The selected patient no longer exists.");
                }

                if (addressId.HasValue && !IsAddressInUse(
                        connection, transaction, addressId.Value))
                {
                    using var deleteAddress = new MySqlCommand(
                        "DELETE FROM address WHERE address_id = @addressId",
                        connection, transaction);
                    deleteAddress.Parameters.Add(
                        "@addressId", MySqlDbType.Int32).Value = addressId.Value;
                    deleteAddress.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private static int? GetPatientAddressId(
            MySqlConnection connection,
            MySqlTransaction transaction,
            int patientId)
        {
            const string query = @"
                SELECT address_id
                FROM patient
                WHERE patient_id = @patientId;";

            using var command = new MySqlCommand(query, connection, transaction);
            command.Parameters.Add("@patientId", MySqlDbType.Int32).Value = patientId;
            object? result = command.ExecuteScalar();

            return result == null || result == DBNull.Value
                ? null
                : Convert.ToInt32(result);
        }

        private static bool IsAddressInUse(
            MySqlConnection connection,
            MySqlTransaction transaction,
            int addressId)
        {
            const string query = @"
                SELECT
                    (SELECT COUNT(*) FROM patient WHERE address_id = @addressId)
                    +
                    (SELECT COUNT(*) FROM nurse WHERE address_id = @addressId);";

            using var command = new MySqlCommand(query, connection, transaction);
            command.Parameters.Add("@addressId", MySqlDbType.Int32).Value = addressId;
            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }
    }
}