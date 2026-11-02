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
