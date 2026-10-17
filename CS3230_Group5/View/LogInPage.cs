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

        private void logInButton_Click(object sender, EventArgs e)
        {
            logInErrorLabel.Visible = false;

            if (signInNurse()) return;
            if (signInAdmin()) return;

            logInErrorLabel.Visible = true;
        }

        private bool signInNurse()
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

            if (reader.Read())
            {
                var home = new CS3230_Group5.homePageButton();
                home.Show();
                this.Hide();
                return true;
            }

            return false;
        }

        private bool signInAdmin()
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

            if (reader.Read())
            {
                var home = new CS3230_Group5.homePageButton();
                home.Show();
                this.Hide();
                return true;
            }

            return false;
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

        private void logInPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }
    }
}
