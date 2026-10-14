using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS3230_Group5.DAL
{
    public static class Connection
    {
        public static string ConnectionString()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3307,
                Database = "cs3230f26_g5",
                UserID = Environment.GetEnvironmentVariable("CS3230_DB_USER"),
                Password = Environment.GetEnvironmentVariable("CS3230_DB_PASSWORD")
            };

            if (string.IsNullOrWhiteSpace(builder.UserID) ||
                string.IsNullOrWhiteSpace(builder.Password))
            {
                throw new InvalidOperationException(
                    "Database credentials are not configured.");
            }

            return builder.ToString();
        }
    }
}
