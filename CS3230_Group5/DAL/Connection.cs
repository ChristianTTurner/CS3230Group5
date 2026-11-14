using System;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace CS3230_Group5.DAL
{
    /// <summary>
    /// Builds the database connection string from configuration files, so the
    /// server details and credentials are not hardcoded in the source code.
    /// </summary>
    /// <remarks>
    /// Settings are read from appsettings.json (committed to Git, no credentials),
    /// then from appsettings.local.json (NOT committed, holds the user and password).
    /// If the connection string still has no user or password, the CS3230_DB_USER
    /// and CS3230_DB_PASSWORD environment variables are used instead.
    /// </remarks>
    public static class Connection
    {
        private const string ConnectionName = "CS3230Database";

        private static readonly Lazy<IConfigurationRoot> Configuration =
            new Lazy<IConfigurationRoot>(BuildConfiguration);

        /// <summary>
        /// Gets the connection string for the project database.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The connection string or the credentials are not configured.
        /// </exception>
        public static string ConnectionString()
        {
            string? configured = Configuration.Value.GetConnectionString(ConnectionName);

            if (string.IsNullOrWhiteSpace(configured))
            {
                throw new InvalidOperationException(
                    $"The connection string '{ConnectionName}' was not found in appsettings.json.");
            }

            var builder = new MySqlConnectionStringBuilder(configured);

            if (string.IsNullOrWhiteSpace(builder.UserID))
            {
                builder.UserID = Environment.GetEnvironmentVariable("CS3230_DB_USER") ?? string.Empty;
            }

            if (string.IsNullOrWhiteSpace(builder.Password))
            {
                builder.Password = Environment.GetEnvironmentVariable("CS3230_DB_PASSWORD") ?? string.Empty;
            }

            if (string.IsNullOrWhiteSpace(builder.UserID) ||
                string.IsNullOrWhiteSpace(builder.Password))
            {
                throw new InvalidOperationException(
                    "Database credentials are not configured. Add them to appsettings.local.json " +
                    "(see appsettings.local.example.json) or set the CS3230_DB_USER and " +
                    "CS3230_DB_PASSWORD environment variables.");
            }

            return builder.ToString();
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.local.json", optional: true)
                .Build();
        }
    }
}
