using System;
using System.Collections.Generic;
using System.Text;
using CS3230_Group5.Model;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    public class AdminStatisticsDal
    {
        public AdminStatistics GetStatistics(DateTime startDate, DateTime endDate)
        {
            if (startDate.Date > endDate.Date)
            {
                throw new ArgumentException(
                    "Start date cannot be after the end date.");
            }

            var storedProcedure = @"call get_most_performed_tests_duringdates(@startDate, @endDate)";

            using var connection =
                new MySqlConnection(Connection.ConnectionString());
            using var command =
                new MySqlCommand(storedProcedure, connection);

            command.Parameters.Add(
                    "@startDate", MySqlDbType.DateTime).Value = startDate.Date;
            command.Parameters.Add(
                    "@endDate", MySqlDbType.DateTime).Value = endDate.Date.AddDays(1);

            connection.Open();
            using var reader = command.ExecuteReader();



            var adminStats = new AdminStatistics();

            while (reader.Read())
            {
                var testInfo = new TestInfo();

                testInfo.Code = Convert.ToString(reader["test_code"]);
                testInfo.Name = Convert.ToString(reader["test_name"]);
                testInfo.NumPerformed = Convert.ToInt32(reader["performed_num_times"]);
                testInfo.Percentage = Convert.ToInt32(reader["percentage"]);

                adminStats.TotalTestsPerformed = Convert.ToInt32(reader["performed_all_tests_n_times"]);
                adminStats.NumAbnormalResults = Convert.ToInt32(reader["num_abnormal_results"]);
                adminStats.NumNormalResults = Convert.ToInt32(reader["num_normal_results"]);

                adminStats.TestStatistics.Add(testInfo);
            }

            return adminStats;
        }

        
    }
}

