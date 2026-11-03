using System;
using System.Collections.Generic;
using System.Text;
using CS3230_Group5.Model;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    public class AdminStatisticsDal
    {
        public AdminStatistics GetStatistics(
            DateTime startDate,
            DateTime endDate)
        {
            if (startDate.Date > endDate.Date)
            {
                throw new ArgumentException(
                    "Start date cannot be after the end date.");
            }

            const string query = @"
                SELECT

                    -- Total appointments
                    (
                        SELECT COUNT(*)
                        FROM appointment
                        WHERE datetime >= @startDate
                          AND datetime < @endDate
                    ) AS total_appointments,

                    -- Unique patients
                    (
                        SELECT COUNT(DISTINCT patient_id)
                        FROM appointment
                        WHERE datetime >= @startDate
                          AND datetime < @endDate
                    ) AS unique_patients,

                    -- Completed checkups
                    (
                        SELECT COUNT(*)
                        FROM appointment_summary s
                        INNER JOIN appointment a
                            ON s.appointment_id = a.appointment_id
                        WHERE a.datetime >= @startDate
                          AND a.datetime < @endDate
                    ) AS completed_checkups,

                    -- Tests ordered for appointments in the date range
                    (
                        SELECT COUNT(*)
                        FROM ordered_test ot
                        INNER JOIN appointment a
                            ON ot.appointment_id = a.appointment_id
                        WHERE a.datetime >= @startDate
                          AND a.datetime < @endDate
                    ) AS tests_ordered,

                    -- Tests performed during the date range
                    (
                        SELECT COUNT(*)
                        FROM ordered_test
                        WHERE performed_datetime >= @startDate
                          AND performed_datetime < @endDate
                    ) AS tests_performed,

                    -- Abnormal results recorded during the date range
                    (
                        SELECT COUNT(*)
                        FROM ordered_test
                        WHERE performed_datetime >= @startDate
                          AND performed_datetime < @endDate
                          AND abnormal = TRUE
                    ) AS abnormal_results;
            ";

            using var connection =
                new MySqlConnection(Connection.ConnectionString());

            using var command =
                new MySqlCommand(query, connection);

            command.Parameters.Add(
                    "@startDate", MySqlDbType.DateTime).Value =
                startDate.Date;

            command.Parameters.Add(
                    "@endDate", MySqlDbType.DateTime).Value =
                endDate.Date.AddDays(1);

            connection.Open();

            using var reader = command.ExecuteReader();

            if (!reader.Read())
            {
                throw new InvalidOperationException(
                    "Unable to retrieve administrator statistics.");
            }

            return new AdminStatistics
            {
                TotalAppointments =
                    Convert.ToInt32(reader["total_appointments"]),

                UniquePatients =
                    Convert.ToInt32(reader["unique_patients"]),

                CompletedCheckups =
                    Convert.ToInt32(reader["completed_checkups"]),

                TestsOrdered =
                    Convert.ToInt32(reader["tests_ordered"]),

                TestsPerformed =
                    Convert.ToInt32(reader["tests_performed"]),

                AbnormalResults =
                    Convert.ToInt32(reader["abnormal_results"])
            };
        }
    }
}

