using System;
using System.Collections.Generic;
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
        /// Retrieves patients, optionally filtering by a patient's name.
        /// </summary>
        public List<Patient> GetPatients(string? filter = null)
        {
            const string baseQuery = @"
                SELECT patient_id, first_name, last_name, date_of_birth,
                       phone, gender, active, address_id
                FROM patient";

            bool hasFilter = !string.IsNullOrWhiteSpace(filter);
            string query = hasFilter
                ? baseQuery + @"
                WHERE CONCAT(first_name, ' ', last_name) LIKE @filter
                   OR first_name LIKE @filter
                   OR last_name LIKE @filter
                ORDER BY last_name, first_name;"
                : baseQuery + " ORDER BY last_name, first_name;";

            var patients = new List<Patient>();

            using var connection =
                new MySqlConnection(Connection.ConnectionString());
            using var command = new MySqlCommand(query, connection);

            if (hasFilter)
            {
                command.Parameters.Add("@filter", MySqlDbType.VarChar, 200)
                        .Value = $"%{filter!.Trim()}%";
            }

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                patients.Add(new Patient
                {
                    PatientId = reader.GetInt32("patient_id"),
                    FirstName = ReadString(reader, "first_name"),
                    LastName = ReadString(reader, "last_name"),
                    DateOfBirth = reader.IsDBNull(reader.GetOrdinal("date_of_birth"))
                        ? null
                        : reader.GetDateTime("date_of_birth"),
                    Phone = ReadString(reader, "phone"),
                    Gender = ReadString(reader, "gender"),
                    Active = !reader.IsDBNull(reader.GetOrdinal("active")) &&
                             Convert.ToBoolean(reader["active"]),
                    AddressId = reader.IsDBNull(reader.GetOrdinal("address_id"))
                        ? null
                        : reader.GetInt32("address_id")
                });
            }

            return patients;
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

        private static string ReadString(MySqlDataReader reader, string column)
        {
            int ordinal = reader.GetOrdinal(column);
            return reader.IsDBNull(ordinal) ? string.Empty : reader.GetString(ordinal);
        }
    }
}
