using System;
using System.Windows.Forms;
using CS3230_Group5.Model;
using CS3230_Group5.View;
using CS3230_Group5.View.Appointments_View;
using CS3230_Group5.View.Nurse_View;
using SearchPatientPage = CS3230_Group5.View.Patient_View.SearchPatientPage;

namespace CS3230_Group5
{
    public partial class homePageButton : Form
    {
        public homePageButton()
        {
            InitializeComponent();

            homeButton.Click += HomeButton_Click;
            nurseButton.Click += NurseButton_Click;
            patientsButton.Click += PatientsButton_Click;
            appointmentButton.Click += AppointmentButton_Click;
            logoutButton.Click += LogoutButton_Click;


            managePatients.Click += ManagePatients_Click;
            manageAppointments.Click += ManageAppointments_Click;
            manageNurse.Click += ManageNurse_Click;
            manageProfile.Click += ManageProfile_Click;

            userNameLabel.Text = "Username: " + SignedInUser.Username;
            idLabel.Text = "User ID: " + SignedInUser.UserID;
            manageNurse.Visible = SignedInUser.IsAdmin;
            manageNurseLabel.Visible = manageNurse.Visible;
        }

        private void HomeButton_Click(object? sender, EventArgs e)
        {
            
        }

        private void NurseButton_Click(object? sender, EventArgs e)
        {
            var viewNurse = new ViewNursesPage();
            viewNurse.Show();
            this.Hide();
        }

        private void PatientsButton_Click(object? sender, EventArgs e)
        {
            var viewPatient = new SearchPatientPage();
            viewPatient.Show();
            this.Hide();
        }

        private void AppointmentButton_Click(object? sender, EventArgs e)
        {
            var viewAppointment = new ViewAppointmentsPage();
            viewAppointment.Show();
            this.Hide();
        }

        private void ManagePatients_Click(object? sender, EventArgs e)
        {
            var searchPatients = new SearchPatientPage();
            searchPatients.Show();
            this.Hide();
        }

        private void ManageAppointments_Click(object? sender, EventArgs e)
        {
            var viewAppointment = new ViewAppointmentsPage();
            viewAppointment.Show();
            this.Hide();
        }

        private void ManageNurse_Click(object? sender, EventArgs e)
        {
            var nursePage = new ViewNursesPage();
            nursePage.Show();
            this.Hide();
        }

        private void ManageProfile_Click(object? sender, EventArgs e)
        {
            var profile = new ProfilePage();
            profile.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object? sender, EventArgs e)
        {
            var login = new LogInPage();
            login.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
