
using System;
using System.Windows.Forms;
using CS3230_Group5.Model;
using CS3230_Group5.View;
using CS3230_Group5.View.Admin_View;
using CS3230_Group5.View.Appointments_View;
using CS3230_Group5.View.Nurse_View;
using SearchPatientPage = CS3230_Group5.View.Patient_View.SearchPatientPage;

namespace CS3230_Group5
{
    /// <summary>
    /// Displays the application's home page and provides navigation
    /// to patient, appointment, nurse, profile, and administrator pages.
    /// Displays the signed-in user's information and restricts
    /// administrator features to authorized users.
    /// </summary>
    public partial class homePageButton : Form
    {
        /// <summary>
        /// Initializes the home page, displays the signed-in user's
        /// information, configures administrator-only controls,
        /// and connects navigation event handlers.
        /// </summary>
        public homePageButton()
        {
            InitializeComponent();

            nurseButton.Visible = SignedInUser.IsAdmin;

            homeButton.Click += HomeButton_Click;
            nurseButton.Click += NurseButton_Click;
            patientsButton.Click += PatientsButton_Click;
            appointmentButton.Click += AppointmentButton_Click;
            logoutButton.Click += LogoutButton_Click;

            managePatients.Click += ManagePatients_Click;
            manageAppointments.Click += ManageAppointments_Click;
            manageNurse.Click += ManageNurse_Click;
            manageProfile.Click += ManageProfile_Click;
            adminStats.Click += AdminStatistics_Click;

            userNameLabel.Text = "Username: " + SignedInUser.Username;
            idLabel.Text = "User ID: " + SignedInUser.UserID;

            manageNurse.Visible = SignedInUser.IsAdmin;
            manageNurseLabel.Visible = SignedInUser.IsAdmin;

            adminStats.Visible = SignedInUser.IsAdmin;
            adminStatsLabel.Visible = SignedInUser.IsAdmin;

            adminStatsLabel.BringToFront();
        }

        private void HomeButton_Click(object? sender, EventArgs e)
        {
        }

        private void NurseButton_Click(object? sender, EventArgs e)
        {
            NavigateTo(new ViewNursesPage());
        }

        private void AdminStatistics_Click(object? sender, EventArgs e)
        {
            if (!SignedInUser.IsAdmin)
            {
                MessageBox.Show("Access denied.");
                return;
            }

            NavigateTo(new AdminStatisticsPage(this));
        }

        private void PatientsButton_Click(object? sender, EventArgs e)
        {
            NavigateTo(new SearchPatientPage());
        }

        private void AppointmentButton_Click(object? sender, EventArgs e)
        {
            NavigateTo(new ViewAppointmentsPage());
        }

        private void ManagePatients_Click(object? sender, EventArgs e)
        {
            NavigateTo(new SearchPatientPage());
        }

        private void ManageAppointments_Click(object? sender, EventArgs e)
        {
            NavigateTo(new ViewAppointmentsPage());
        }

        private void ManageNurse_Click(object? sender, EventArgs e)
        {
            NavigateTo(new ViewNursesPage());
        }

        private void ManageProfile_Click(object? sender, EventArgs e)
        {
            NavigateTo(new ProfilePage());
        }

        private void LogoutButton_Click(object? sender, EventArgs e)
        {
            NavigateTo(new LogInPage());
        }

        private void NavigateTo(Form nextForm)
        {
            nextForm.Show();
            Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void idLabel_Click(object sender, EventArgs e)
        {
        }
    }
}