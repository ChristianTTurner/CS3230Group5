using CS3230_Group5.DAL;
using CS3230_Group5.Model;
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

            profileLabel.Text = SignedInUser.FirstName + " " + SignedInUser.LastName;
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
        }



        private void logOutButton_Click(object sender, EventArgs e)
        {
            // Log out: return to the login page
            var login = new LogInPage();
            login.Show();
            this.Hide();

            SignedInUser.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var form2 = new homePageButton();
            form2.Show();
            this.Hide();
        }

        private void editPatientProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            // Edit profile not implemented yet - placeholder behavior
            MessageBox.Show("Edit profile is not implemented yet.", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
