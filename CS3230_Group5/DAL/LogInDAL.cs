using CS3230_Group5.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS3230_Group5.DAL
{
    public class LogInDAL
    {
        public bool SignInAdmin(string username, string password)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            var selectQuery = "select admin_id from administrator where username = @username and password = @password";

            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@username", MySqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;

            using var reader = cmd.ExecuteReader();

            return reader.Read();
        }

        public bool SignInNurse(string username, string password) 
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            var selectQuery = "select nurse_id from nurse where username = @username and password = @password";

            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@username", MySqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;

            using var reader = cmd.ExecuteReader();
            
            return reader.Read();
        }
    }
}
