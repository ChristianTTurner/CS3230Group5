using CS3230_Group5.DAL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View
{
    public partial class ProfilePage : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProfileID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAdmin { get; set; }

        public ProfilePage()
        {
            InitializeComponent();

            if (IsAdmin)
            {
                this.populatePerAdmin();
            }
            else
            {
                this.populatePerNurse();
            }
        }

        private void populatePerAdmin()
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            var selectQuery = "select admin_id, first_name, last_name, date_of_birth, address_id, phone from administrator where admin_id = @adminID";
            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@adminID", MySqlDbType.Int16);
            cmd.Parameters["@adminID"].Value = ProfileID;

            using var reader = cmd.ExecuteReader();
            var adminIdOrdinal = reader.GetOrdinal("admin_id");
            var fNameOrdinal = reader.GetOrdinal("first_name");
            var lNameOrdinal = reader.GetOrdinal("last_name");
            var dobOrdinal = reader.GetOrdinal("date_of_birth");
            var phoneOrdinal = reader.GetOrdinal("phone");

            if (reader.Read())
            {
                if (reader.GetInt16(adminIdOrdinal) != 0)
                {
                    accountNameLabel.Text = reader.GetString(fNameOrdinal) + reader.GetString(lNameOrdinal);
                    accountInfo.Text = "Admin ID: " + reader.GetInt16(adminIdOrdinal) +
                        "\n DOB: " + reader.GetDateOnly(dobOrdinal) +
                        "\n Phone Number: " + reader.GetChar(phoneOrdinal);
                }
            }
            connection.Close();
        }

        private void populatePerNurse()
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            var selectQuery = "select nurse_id, first_name, last_name, date_of_birth, address_id, phone from nurse where nurse_id = @nurseID";
            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@nurseID", MySqlDbType.Int16);
            cmd.Parameters["@nurseID"].Value = ProfileID;

            using var reader = cmd.ExecuteReader();
            var adminIdOrdinal = reader.GetOrdinal("nurse_id");
            var fNameOrdinal = reader.GetOrdinal("first_name");
            var lNameOrdinal = reader.GetOrdinal("last_name");
            var dobOrdinal = reader.GetOrdinal("date_of_birth");
            var phoneOrdinal = reader.GetOrdinal("phone");

            if (reader.Read())
            {
                if (reader.GetInt16(adminIdOrdinal) != 0)
                {
                    accountNameLabel.Text = reader.GetString(fNameOrdinal) + reader.GetString(lNameOrdinal);
                    accountInfo.Text = "Nurse ID: " + reader.GetInt16(adminIdOrdinal) +
                        "\n DOB: " + reader.GetDateOnly(dobOrdinal) +
                        "\n Phone Number: " + reader.GetChar(phoneOrdinal);
                }
            }
            connection.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var form2 = new HomePage();
            form2.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var form2 = new NurseHomePage();
            form2.SignedInID = ProfileID;
            form2.IsAdmin = IsAdmin;
            form2.Show();
            this.Hide();
        }
    }
}
