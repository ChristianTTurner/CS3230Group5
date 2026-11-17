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

            if (!reader.Read())
            {
                throw new InvalidOperationException(
                    "Unable to retrieve administrator statistics.");
            }

            var adminStats = new AdminStatistics();
            adminStats.TotalTestsPerformed = Convert.ToInt32(reader["performed_all_tests_n_times"]);
            adminStats.NumAbnormalResults = Convert.ToInt32(reader["num_abnormal_results"]);
            adminStats.NumNormalResults = Convert.ToInt32(reader["num_normal_results"]);

            while (reader.Read())
            {
                var testCode = Convert.ToString(reader["test_code"]);

                if (testCode == null)
                {
                    continue;
                }

                getTestStatistics(reader, adminStats, testCode);
            }

            return adminStats;
        }

        private static void getTestStatistics(MySqlDataReader reader, AdminStatistics adminStats, string testCode)
        {
            if (testCode.Equals("HEPA"))
            {
                adminStats.TotalHEPATestsPerformed = Convert.ToInt32(reader["performed_num_times"]);
                adminStats.HEPATestPercentage = Convert.ToDouble(reader["percentage"]);
            }
            if (testCode.Equals("HEPB"))
            {
                adminStats.TotalHEPBTestsPerformed = Convert.ToInt32(reader["performed_num_times"]);
                adminStats.HEPBTestPercentage = Convert.ToDouble(reader["percentage"]);
            }
            if (testCode.Equals("LDL"))
            {
                adminStats.TotalLDLTestsPerformed = Convert.ToInt32(reader["performed_num_times"]);
                adminStats.LDLTestPercentage = Convert.ToDouble(reader["percentage"]);
            }
            if (testCode.Equals("WBC"))
            {
                adminStats.TotalWBCTestsPerformed = Convert.ToInt32(reader["performed_num_times"]);
                adminStats.WBCTestPercentage = Convert.ToDouble(reader["percentage"]);
            }
        }
    }
}

