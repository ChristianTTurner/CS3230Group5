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
            var selectQuery = "select * from administrator where username = @username and password = @password";

            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@username", MySqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                SignedInUser.UserID = reader.GetInt32("admin_id");
                SignedInUser.Username = reader.GetString("username");
                SignedInUser.Password = reader.GetString("password");
                SignedInUser.FirstName = reader.GetString("first_name");
                SignedInUser.LastName = reader.GetString("last_name");
                SignedInUser.DateOfBirth = reader.GetDateOnly("date_of_birth");
                SignedInUser.Phone = reader.GetString("phone");
                SignedInUser.AddressId = reader.GetInt32("address_id");
                SignedInUser.IsAdmin = true;

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
            var selectQuery = "select * from nurse as n join address as a on n.address_id = a.address_id where username = @username and password = @password";

            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@username", MySqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;

            using var reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {   
                SignedInUser.UserID = reader.GetInt32("nurse_id");
                SignedInUser.Username = reader.GetString("username");
                SignedInUser.Password = reader.GetString("password");
                SignedInUser.FirstName = reader.GetString("first_name");
                SignedInUser.LastName = reader.GetString("last_name");
                SignedInUser.DateOfBirth = reader.GetDateOnly("date_of_birth");
                SignedInUser.AddressId = reader.GetInt32("address_id");
                SignedInUser.Phone = reader.GetString("phone");
                SignedInUser.IsAdmin = false;
                SignedInUser.Address1 = reader.GetString("address1");
                SignedInUser.Address2 = reader.GetString("address2");
                SignedInUser.City = reader.GetString("city");

                return true;
            }

            return false;
        }
    }
}
