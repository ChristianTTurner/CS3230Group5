using CS3230_Group5.DAL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS3230_Group5.View
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
            logInButton.Enabled = false;
            logInErrorLabel.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            this.signInNurse();
            this.signInAdmin();
        }

        private void signInNurse()
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            var selectQuery = "select nurse_id from nurse where username = @username and password = @password";

            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@username", MySqlDbType.VarChar);
            cmd.Parameters["@username"].Value = usernameInput.Text;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            cmd.Parameters["@password"].Value = passwordInput.Text;

            using var reader = cmd.ExecuteReader();
            var nurseIdOrdinal = reader.GetOrdinal("nurse_id");

            if (reader.Read())
            {
                if (reader.GetInt16(nurseIdOrdinal) != 0)
                {
                    var form2 = new View.NurseHomePage();
                    form2.IsAdmin = false;
                    form2.SignedInID = reader.GetInt16(nurseIdOrdinal);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
            }
            else
            {
                logInErrorLabel.Visible = true;
            }
        }

        private void signInAdmin()
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            var selectQuery = "select admin_id from administrator where username = @username and password = @password";

            using var cmd = new MySqlCommand(selectQuery, connection);

            cmd.Parameters.Add("@username", MySqlDbType.VarChar);
            cmd.Parameters["@username"].Value = usernameInput.Text;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            cmd.Parameters["@password"].Value = passwordInput.Text;

            using var reader = cmd.ExecuteReader();
            var adminIdOrdinal = reader.GetOrdinal("admin_id");

            if (reader.Read())
            {
                if (reader.GetInt16(adminIdOrdinal) != 0)
                {
                    var form2 = new View.NurseHomePage();
                    form2.IsAdmin = true;
                    form2.SignedInID = reader.GetInt16(adminIdOrdinal);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
            }
            else
            {
                logInErrorLabel.Visible = true;
            }
        }

        private void usernameInput_Leave(object sender, EventArgs e)
        {
            logInButton.Enabled = this.validLogInInput();
        }

        private void passwordInput_Leave(object sender, EventArgs e)
        {
            logInButton.Enabled = this.validLogInInput();
        }

        private bool validLogInInput()
        {
            return !usernameInput.Text.IsWhiteSpace() && !passwordInput.Text.IsWhiteSpace();
        }
    }
}
