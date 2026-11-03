using System;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Saves the final diagnosis, which locks the visit (check-up, tests,
    /// results and diagnoses become read-only).
    /// </summary>
    public class FinalDiagnosisDal
    {
        /// <summary>
        /// Saves the final diagnosis in one transaction. The visit row is locked
        /// first, so two people cannot finalize the same visit.
        /// </summary>
        /// <exception cref="ArgumentException">The diagnosis is missing or too long.</exception>
        /// <exception cref="InvalidOperationException">
        /// There is no check-up yet, the visit is already finalized, or an
        /// ordered test still has no result.
        /// </exception>
        public void SaveFinalDiagnosis(int appointmentId, string diagnosis)
        {
            if (appointmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            if (string.IsNullOrWhiteSpace(diagnosis))
                throw new ArgumentException("A final diagnosis is required.", nameof(diagnosis));
            if (diagnosis.Trim().Length > 500)
                throw new ArgumentException("The final diagnosis cannot exceed 500 characters.", nameof(diagnosis));

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                string? existingFinalDiagnosis;

                const string lockQuery = @"
                    SELECT final_diagnosis
                    FROM appointment_summary
                    WHERE appointment_id = @appointmentId
                    FOR UPDATE;";

                using (var lockCommand = new MySqlCommand(lockQuery, connection, transaction))
                {
                    lockCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

                    using var reader = lockCommand.ExecuteReader();

                    if (!reader.Read())
                        throw new InvalidOperationException(
                            "Save the routine check-up before entering a final diagnosis.");

                    existingFinalDiagnosis = reader.IsDBNull(0) ? null : reader.GetString(0);
                }

                if (!string.IsNullOrWhiteSpace(existingFinalDiagnosis))
                    throw new InvalidOperationException(
                        "A final diagnosis has already been entered for this visit.");

                const string pendingQuery = @"
                    SELECT COUNT(*)
                    FROM ordered_test
                    WHERE appointment_id = @appointmentId
                      AND (result IS NULL OR TRIM(result) = '');";

                int pendingTests;

                using (var pendingCommand = new MySqlCommand(pendingQuery, connection, transaction))
                {
                    pendingCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    pendingTests = Convert.ToInt32(pendingCommand.ExecuteScalar());
                }

                if (pendingTests > 0)
                    throw new InvalidOperationException(
                        $"{pendingTests} ordered test(s) still need results. " +
                        "Enter every result before the final diagnosis.");

                const string updateQuery = @"
                    UPDATE appointment_summary
                    SET final_diagnosis = @diagnosis
                    WHERE appointment_id = @appointmentId
                      AND final_diagnosis IS NULL;";

                int rowsAffected;

                using (var updateCommand = new MySqlCommand(updateQuery, connection, transaction))
                {
                    updateCommand.Parameters.Add("@diagnosis", MySqlDbType.VarChar, 500).Value = diagnosis.Trim();
                    updateCommand.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    rowsAffected = updateCommand.ExecuteNonQuery();
                }

                if (rowsAffected != 1)
                    throw new InvalidOperationException("The final diagnosis could not be saved.");

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
