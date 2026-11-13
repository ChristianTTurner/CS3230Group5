
using CS3230_Group5.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CS3230_Group5.View
{
    /// <summary>
    /// Displays the profile information of the currently signed-in user.
    /// Provides navigation back to the home page and the option to log out.
    /// </summary>
    public partial class ProfilePage : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProfileID { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Initializes the profile page and displays the signed-in user's
        /// personal, account, and address information.
        /// </summary>
        public ProfilePage()
        {
            InitializeComponent();

            LoadProfileInformation();
        }

        private void LoadProfileInformation()
        {
            profileLabel.Text =
                SignedInUser.FirstName + " " + SignedInUser.LastName;

            fnameLabel.Text = "First Name: " + SignedInUser.FirstName;
            lnameLabel.Text = "Last Name: " + SignedInUser.LastName;
            dobLabel.Text = "Date of Birth: " + SignedInUser.DateOfBirth;
            phoneLabel.Text = "Phone #: " + SignedInUser.Phone;

            if (IsAdmin)
            {
                userIdLabel.Text = "Admin ID: " + SignedInUser.UserID;
            }
            else
            {
                userIdLabel.Text = "Nurse ID: " + SignedInUser.UserID;
            }

            usernameLabel.Text = "Username: " + SignedInUser.Username;
            label1.Text = "Password: " + SignedInUser.Password;

            add1Label.Text = "Address 1: " + SignedInUser.Address1;
            add2Label.Text = "Address 2: " + SignedInUser.Address2;
            cityLabel.Text = "City: " + SignedInUser.City;
            stateLabel.Text = "State: " + SignedInUser.State;
            zipLabel.Text = "ZIP Code: " + SignedInUser.Zip;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            SignedInUser.Clear();

            NavigateTo(new LogInPage());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            NavigateTo(new homePageButton());
        }

        private void NavigateTo(Form nextForm)
        {
            nextForm.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
        }
    }
}