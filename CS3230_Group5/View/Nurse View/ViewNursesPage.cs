
using System;
using System.Windows.Forms;
using CS3230_Group5.DAL;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class ViewNursesPage : Form
    {
        private readonly NurseDal nurseDal = new NurseDal();

        public ViewNursesPage()
        {
            InitializeComponent();
            setUpNursesList();
            loadNurses();
           
            homeButton.Click += (s, e) =>
            {
                var home = new homePageButton();
                home.Show();
                this.Hide();
            };
            nurseButton.Click += (s, e) => { };
            patientsButton.Click += (s, e) =>
            {
                var viewPatient = new SearchPatientPage();
                viewPatient.Show();
                this.Hide();
            };
            appointmentButton.Click += (s, e) =>
            {
                var createAppointment = new CreateAppointmentPage();
                createAppointment.Show();
                this.Hide();
            };
            logoutButton.Click += (s, e) =>
            {
                var login = new View.LogInPage();
                login.Show();
                this.Hide();
            };

            viewNurseButton.Click += viewNurseButton_Click;
        }

        private void setUpNursesList()
        {
            nursesList.View = System.Windows.Forms.View.Details;
            nursesList.FullRowSelect = true;
            nursesList.GridLines = true;
            nursesList.Columns.Add("ID", 45);
            nursesList.Columns.Add("Name", 150);
            nursesList.Columns.Add("Phone", 100);
            nursesList.Columns.Add("Username", 120);
            nursesList.Columns.Add("Address", 300);
        }

        private void loadNurses()
        {
            try
            {
                nursesList.Items.Clear();

                foreach (var item in nurseDal.GetAllNurses())
                {
                    var nurse = item.Nurse;
                    var address = item.Address;

                    var row = new ListViewItem(nurse.NurseId?.ToString() ?? "");
                    row.SubItems.Add($"{nurse.FirstName} {nurse.LastName}");
                    row.SubItems.Add(nurse.Phone);
                    row.SubItems.Add(nurse.Username);
                    row.SubItems.Add($"{address.Address1}, {address.City}, {address.State} {address.Zip}");

                    nursesList.Items.Add(row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Unable to load nurses. Please check the database connection and try again.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var home = new CS3230_Group5.homePageButton();
            home.Show();
            Hide();
        }

        private void addNurseButton_Click(object sender, EventArgs e)
        {
            var addNursePage = new AddNursePage();
            addNursePage.Show();
            Hide();
        }

        private void profileLink_LinkClicked(
            object? sender,
            LinkLabelLinkClickedEventArgs e)
        {
            openSelectedNurseForEditing();
        }

        private void viewNurseButton_Click(object? sender, EventArgs e)
        {
            openSelectedNurseForEditing();
        }

        private void openSelectedNurseForEditing()
        {
            if (nursesList.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a nurse first.",
                    "No Nurse Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(nursesList.SelectedItems[0].Text, out int nurseId))
            {
                MessageBox.Show(
                    "Invalid nurse ID.",
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var editNursePage = new AddNursePage(nurseId);
            editNursePage.Show();
            Hide();
        }

        private void ViewNursesPage_Load(object sender, EventArgs e)
        {

        }

        private void viewNursesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}