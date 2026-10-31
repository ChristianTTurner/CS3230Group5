
using System;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using CS3230_Group5.View.Appointments_View;
using CS3230_Group5.View.Patient_View;
using CS3230_Group5.View.Nurse_View;

namespace CS3230_Group5.View.Patient_View
{
    /// <summary>
    /// Displays and searches patient records.
    /// Allows users to add, edit, delete, and view patient visits.
    /// Database operations are delegated to PatientDal.
    /// </summary>
    public partial class SearchPatientPage : Form
    {
        private readonly PatientDal _patientDal = new PatientDal();

        public SearchPatientPage()
        {
            InitializeComponent();

            ConfigurePatientGrid();
            PopulatePatientList();

            homeButton.Click += (s, e) =>
                NavigateTo(new homePageButton());

            nurseButton.Click += (s, e) =>
                NavigateTo(new ViewNursesPage());

            patientsButton.Click += (s, e) =>
                PopulatePatientList();

            appointmentButton.Click += (s, e) =>
                NavigateTo(new ViewAppointmentsPage());

            logoutButton.Click += (s, e) =>
                NavigateTo(new LogInPage());

            searchButton.Click += (s, e) =>
                SearchPatients();

            editPatientButton.Click += (s, e) =>
                EditSelectedPatient();

            dataGridView1.SelectionChanged +=
                dataGridView1_SelectionChanged;

            dataGridView1.CellContentClick +=
                dataGridView1_CellContentClick;
        }

        private void ConfigurePatientGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            btnView.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;

            btnView.Width = 110;

            btnView.Text = "Visits";
            btnView.UseColumnTextForButtonValue = true;

            deletePatientButton.Enabled = false;
        }

        private void PopulatePatientList(string? filter = null)
        {
            try
            {
                dataGridView1.Rows.Clear();

                foreach (Patient patient in _patientDal.GetPatients(filter))
                {
                    dataGridView1.Rows.Add(
                        patient.PatientId,
                        patient.FirstName,
                        patient.LastName,
                        patient.DateOfBirth?.ToString("yyyy-MM-dd")
                        ?? string.Empty,
                        patient.Phone,
                        patient.Gender,
                        patient.Active.ToString(),
                        "View Visits"
                    );
                }

                dataGridView1.ClearSelection();
                deletePatientButton.Enabled = false;
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

        private void searchPatientTextBox_TextChanged(
            object sender, EventArgs e)
        {
            SearchPatients();
        }

        private void dataGridView1_SelectionChanged(
            object sender, EventArgs e)
        {
            deletePatientButton.Enabled =
                dataGridView1.SelectedRows.Count > 0;
        }
        private bool TryGetSelectedPatientId(out int patientId)
        {
            patientId = 0;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a patient first.",
                    "No Patient Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            object? value = dataGridView1.SelectedRows[0]
                .Cells["patient_id"].Value;

            if (value != null &&
                int.TryParse(value.ToString(), out patientId) &&
                patientId > 0)
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

        private void EditSelectedPatient()
        {
            if (!TryGetSelectedPatientId(out int patientId))
                return;

            var editForm = new CreatePatientPage();
            editForm.LoadForEdit(patientId);

            NavigateTo(editForm);
        }

        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name != "btnView")
                return;

            object? value = dataGridView1.Rows[e.RowIndex]
                .Cells["patient_id"].Value;

            if (value == null ||
                !int.TryParse(value.ToString(), out int patientId) ||
                patientId <= 0)
            {
                MessageBox.Show(
                    "The selected patient ID is invalid.",
                    "Invalid Patient",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var historyPage = new PatientViewHistoryPage(patientId, this);
            NavigateTo(historyPage);
        }
        private void deletePatientButton_Click(
            object sender, EventArgs e)
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

        private void addPatientButton_Click(
            object sender, EventArgs e)
        {
            NavigateTo(new CreatePatientPage());
        }

        private void SearchPatientPage_Load(
            object sender, EventArgs e)
        {
        }
        private void NavigateTo(Form nextForm)
        {
            nextForm.Show();
            Hide();
        }

        private static void ShowError(
            string title, Exception exception)
        {
            MessageBox.Show(
                $"{title}: {exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}