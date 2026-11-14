
using CS3230_Group5.DAL;
using System;
using System.Windows.Forms;

namespace CS3230_Group5.View
{
    /// <summary>
    /// Handles user authentication for nurses and administrators.
    /// Validates login input and navigates authorized users to the home page.
    /// </summary>
    public partial class LogInPage : Form
    {
        private readonly LogInDAL DAL = new LogInDAL();

        /// <summary>
        /// Initializes the login page, disables the login button until
        /// valid input is provided, and configures the Enter key to submit
        /// the login form.
        /// </summary>
        public LogInPage()
        {
            InitializeComponent();

            logInButton.Enabled = false;
            logInErrorLabel.Visible = false;

            AcceptButton = logInButton;

            usernameInput.TextChanged += LoginInput_TextChanged;
            passwordInput.TextChanged += LoginInput_TextChanged;
        }

        private void LoginInput_TextChanged(object sender, EventArgs e)
        {
            logInErrorLabel.Visible = false;
            logInButton.Enabled = ValidLoginInput();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            logInErrorLabel.Visible = false;

            if (signInNurse())
                return;

            if (signInAdmin())
                return;

            DisplayLoginError();
        }

        private bool signInNurse()
        {
            if (!DAL.SignInNurse(usernameInput.Text, passwordInput.Text))
                return false;

            OpenHomePage();
            return true;
        }

        private bool signInAdmin()
        {
            if (!DAL.SignInAdmin(usernameInput.Text, passwordInput.Text))
                return false;

            OpenHomePage();
            return true;
        }

        private void OpenHomePage()
        {
            var home = new CS3230_Group5.homePageButton();
            home.Show();
            Hide();
        }

        private void DisplayLoginError()
        {
            logInErrorLabel.Text = "Invalid username or password.";
            logInErrorLabel.Visible = true;
        }

        private bool ValidLoginInput()
        {
            return !string.IsNullOrWhiteSpace(usernameInput.Text) &&
                   !string.IsNullOrWhiteSpace(passwordInput.Text);
        }

        private void usernameInput_Leave(object sender, EventArgs e)
        {
            logInButton.Enabled = ValidLoginInput();
        }

        private void passwordInput_Leave(object sender, EventArgs e)
        {
            logInButton.Enabled = ValidLoginInput();
        }

        private void logInPageTitle_Click(object sender, EventArgs e)
        {
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
        }
    }
}