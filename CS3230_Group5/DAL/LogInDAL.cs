using CS3230_Group5.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS3230_Group5.DAL
{
    public class LogInDAL
    {
        /** Signs in an Admin if username and password match an existing Admin account
         *  Stores the Admins ID under SignedInUser.UserID for persistence across Forms
         * 
         *  @param username the inputted username
         *  @param password the inputted password
         *  
         *  @returns true if the credential are correct and the user has been signed in
         *           false if the credentials don't find a match and the user hasn't been signed in
         */
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

            if (reader.Read())
            {
                var idOrdinal = reader.GetOrdinal("admin_id");
                SignedInUser.UserID = reader.GetInt32(idOrdinal).ToString();
                return true;
            }

            return false;
        }

        /** Signs in an Nurse if username and password match an existing Nurse account
        *  Stores the Nurse ID under SignedInUser.UserID for persistence across Forms
        * 
        *  @param username the inputted username
        *  @param password the inputted password
        *  
        *  @returns true if the credential are correct and the user has been signed in
        *           false if the credentials don't find a match and the user hasn't been signed in
        */
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
            
            if (reader.Read())
            {
                var idOrdinal = reader.GetOrdinal("nurse_id");
                SignedInUser.UserID = reader.GetInt32(idOrdinal).ToString();
                return true;
            }

            return false;
        }
    }
}
