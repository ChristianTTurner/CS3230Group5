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
        LogInDAL DAL = new LogInDAL();

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
            if (DAL.SignInNurse(usernameInput.Text, passwordInput.Text))
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
            if (DAL.SignInAdmin(usernameInput.Text, passwordInput.Text))
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
