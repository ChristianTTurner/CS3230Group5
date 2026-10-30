using System;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Nurse_View
{
    /// <summary>
    /// Displays and searches patient records. Database work is delegated to PatientDal.
    /// </summary>
    public partial class SearchPatientPage : Form
    {
        private readonly PatientDal _patientDal = new PatientDal();

        public SearchPatientPage()
        {
            InitializeComponent();
            ConfigurePatientList();
            PopulatePatientList();

            homeButton.Click += (s, e) => NavigateTo(new homePageButton());
            nurseButton.Click += (s, e) => NavigateTo(new ViewNursesPage());
            patientsButton.Click += (s, e) => PopulatePatientList();
            appointmentButton.Click += (s, e) => NavigateTo(new CreateAppointmentPage());
            logoutButton.Click += (s, e) => NavigateTo(new LogInPage());
            searchButton.Click += (s, e) => SearchPatients();
            editPatientButton.Click += (s, e) => EditSelectedPatient();
        }

        private void ConfigurePatientList()
        {
            patientList.View = System.Windows.Forms.View.Details;
            patientList.FullRowSelect = true;
            patientList.MultiSelect = false;
            patientList.Columns.Clear();
            patientList.Columns.Add("ID", 60, HorizontalAlignment.Left);
            patientList.Columns.Add("First Name", 120, HorizontalAlignment.Left);
            patientList.Columns.Add("Last Name", 120, HorizontalAlignment.Left);
            patientList.Columns.Add("DOB", 100, HorizontalAlignment.Left);
            patientList.Columns.Add("Phone", 120, HorizontalAlignment.Left);
            patientList.Columns.Add("Gender", 80, HorizontalAlignment.Left);
            patientList.Columns.Add("Active", 60, HorizontalAlignment.Left);
        }
        private void AutoResizePatientColumns()
        {
            foreach (ColumnHeader column in patientList.Columns)
            {
                column.Width = -2;
            }
        }

        private void PopulatePatientList(string? filter = null)
        {
            try
            {
                patientList.Items.Clear();

                foreach (Patient patient in _patientDal.GetPatients(filter))
                {
                    var item = new ListViewItem(patient.PatientId.ToString());
                    item.SubItems.Add(patient.FirstName);
                    item.SubItems.Add(patient.LastName);
                    item.SubItems.Add(patient.DateOfBirth?.ToString("yyyy-MM-dd") ?? string.Empty);
                    item.SubItems.Add(patient.Phone);
                    item.SubItems.Add(patient.Gender);
                    item.SubItems.Add(patient.Active.ToString());
                    patientList.Items.Add(item);
                }

                AutoResizePatientColumns();

                deletePatientButton.Enabled = patientList.SelectedItems.Count > 0;
            }
            catch (Exception ex)
            {
                ShowError("Error loading patients", ex);
            }
        }

        private void SearchPatients()
        {
            PopulatePatientList(searchPatientTextBox.Text.Trim());
        }

        private void searchPatientTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchPatients();
        }

        private void EditSelectedPatient()
        {
            if (!TryGetSelectedPatientId(out int patientId))
                return;

            var editForm = new CreatePatientPage();
            editForm.LoadForEdit(patientId);
            NavigateTo(editForm);
        }

        private bool TryGetSelectedPatientId(out int patientId)
        {
            patientId = 0;

            if (patientList.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a patient first.",
                    "No Patient Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (int.TryParse(patientList.SelectedItems[0].SubItems[0].Text,
                    out patientId) && patientId > 0)
            {
                return true;
            }

            MessageBox.Show(
                "The selected patient ID is invalid.",
                "Invalid Patient",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        private void patientList_ItemSelectionChanged(
            object sender, ListViewItemSelectionChangedEventArgs e)
        {
            deletePatientButton.Enabled = patientList.SelectedItems.Count > 0;
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedPatientId(out int patientId))
                return;

            DialogResult confirmation = MessageBox.Show(
                $"Delete patient #{patientId}? This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes)
                return;

            try
            {
                _patientDal.DeletePatient(patientId);
                PopulatePatientList(searchPatientTextBox.Text.Trim());
                MessageBox.Show(
                    "Patient deleted.",
                    "Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Error deleting patient", ex);
            }
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            NavigateTo(new CreatePatientPage());
        }

        private void SearchPatientPage_Load(object sender, EventArgs e)
        {
           
        }

        private void NavigateTo(Form nextForm)
        {
            nextForm.Show();
            Hide();
        }

        private static void ShowError(string title, Exception exception)
        {
            MessageBox.Show(
                $"{title}: {exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
