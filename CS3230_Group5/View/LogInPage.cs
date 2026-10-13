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
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            var selectQuery = "select id from nurse where ";

            using var command = new MySqlCommand(selectQuery, connection);
            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("id");
            if (reader[idOrdinal] != null) 
            {
                //TODO Sign in
                var form2 = new View.NurseHomePage();
                form2.Show();
                this.Hide();
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
