
using CS3230_Group5.DAL;
using CS3230_Group5.View.Nurse_View;
using System;
using System.Data;
using System.Windows.Forms;

namespace CS3230_Group5.View.Patient_View
{
    /// <summary>
    /// Provides the form for displaying a patient's personal information and appointment visit history.
    /// </summary>
    public partial class PatientViewHistoryPage : Form
    {
        private readonly int _patientId;
        private readonly PatientDal _patientDal = new PatientDal();
        private readonly AppointmentSummaryDal _appointmentDal =
            new AppointmentSummaryDal();

        private readonly Form _previousPage;

        /// <summary>
        /// Initializes the patient visit history page.
        /// </summary>
        /// <param name="patientId">The ID of the patient whose history will be displayed.</param>
        /// <param name="previousPage">The form to return to when the user navigates back.</param>
        public PatientViewHistoryPage(int patientId, Form previousPage)
        {
            InitializeComponent();

            _patientId = patientId;
            _previousPage = previousPage;

            ConfigureVisitHistoryGrid();

            backButton.Click += backButton_Click;
            newAppointmentButton.Click += newAppointmentButton_Click;
            visitHistoryDataGridView.CellContentClick +=
                visitHistoryDataGridView_CellContentClick;
        }

        /// <summary>
        /// Configures the visit history grid.
        /// </summary>
        private void ConfigureVisitHistoryGrid()
        {
            visitHistoryDataGridView.AutoGenerateColumns = false;
            visitHistoryDataGridView.AllowUserToAddRows = false;
            visitHistoryDataGridView.AllowUserToDeleteRows = false;
            visitHistoryDataGridView.ReadOnly = true;
            visitHistoryDataGridView.MultiSelect = false;

            visitHistoryDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            visitHistoryDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            visitHistoryDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            visitHistoryDataGridView.RowHeadersVisible = false;

            btnView.Text = "Details";
            btnView.UseColumnTextForButtonValue = true;
            btnView.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;
            btnView.Width = 100;
        }

        /// <summary>
        /// Loads the selected patient's information and visit history.
        /// </summary>
        private void PatientViewHistoryPage_Load(
            object sender, EventArgs e)
        {
            LoadPatientInformation();
            LoadPatientVisitHistory();
        }

        /// <summary>
        /// Displays the selected patient's personal information.
        /// </summary>
        private void LoadPatientInformation()
        {
            try
            {
                DataTable patientTable =
                    _patientDal.GetPatientDetails(_patientId);

                if (patientTable.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Patient information could not be found.",
                        "Patient Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DataRow patient = patientTable.Rows[0];

                displayPatientBasicInformation(patient);
                displayPatientAddress(patient);
                displayPatientActiveStatus(patient);
            }
            catch (Exception ex)
            {
                ShowError("Error loading patient information", ex);
            }
        }

        private void displayPatientBasicInformation(DataRow patient)
        {
            string firstName = patient["first_name"]?.ToString() ?? "";
            string lastName = patient["last_name"]?.ToString() ?? "";

            patientIdLabel.Text =
                $"Patient ID: {patient["patient_id"]}";

            patientNameLabel.Text =
                $"Name: {firstName} {lastName}";

            dobLabel.Text =
                patient["date_of_birth"] == DBNull.Value
                    ? "Date of Birth: Not provided"
                    : $"Date of Birth: {Convert.ToDateTime(patient["date_of_birth"]):MM/dd/yyyy}";

            phoneLabel.Text =
                $"Phone #: {patient["phone"]}";

            genderLabel.Text =
                $"Gender: {patient["gender"]}";
        }

        private void displayPatientAddress(DataRow patient)
        {
            string street = patient["street_address"]?.ToString() ?? "";
            string cityStateZip = patient["city_state_zip"]?.ToString() ?? "";

            addressLabel.Text =
                string.IsNullOrWhiteSpace(street) &&
                string.IsNullOrWhiteSpace(cityStateZip)
                    ? "Address: Not provided"
                    : $"Address: {street}\n{cityStateZip}";
        }

        private void displayPatientActiveStatus(DataRow patient)
        {
            activeLabel.Text =
                $"Active: {(Convert.ToBoolean(patient["active"]) ? "Yes" : "No")}";
        }

        /// <summary>
        /// Loads all appointments belonging to the selected patient.
        /// </summary>
        private void LoadPatientVisitHistory()
        {
            try
            {
                visitHistoryDataGridView.Rows.Clear();

                DataTable visits =
                    _appointmentDal.GetPatientVisitHistory(_patientId);

                foreach (DataRow visit in visits.Rows)
                {
                    addVisitHistoryRow(visit);
                }

                updateVisitsLabel(visits.Rows.Count);
            }
            catch (Exception ex)
            {
                ShowError("Error loading patient visit history", ex);
            }
        }

        private void addVisitHistoryRow(DataRow visit)
        {
            string initialDiagnosis =
                visit["initial_diagnosis"] == DBNull.Value
                    ? "Not recorded"
                    : visit["initial_diagnosis"].ToString() ?? "";

            string finalDiagnosis =
                visit["final_diagnosis"] == DBNull.Value
                    ? "Not recorded"
                    : visit["final_diagnosis"].ToString() ?? "";

            visitHistoryDataGridView.Rows.Add(
                visit["appointment_id"],
                Convert.ToDateTime(visit["visit_datetime"]),
                visit["doctor_name"]?.ToString() ?? "",
                visit["visit_reason"]?.ToString() ?? "",
                initialDiagnosis,
                finalDiagnosis,
                "Details"
            );
        }

        private void updateVisitsLabel(int visitCount)
        {
            if (visitCount == 0)
            {
                visitsLabel.Text =
                    "Visits — No appointments found for this patient.";
            }
            else
            {
                visitsLabel.Text =
                    $"Visits — {visitCount} appointment(s) found";
            }
        }

        /// <summary>
        /// Opens the details page for the selected appointment.
        /// </summary>
        private void visitHistoryDataGridView_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (visitHistoryDataGridView.Columns[e.ColumnIndex].Name
                != "btnView")
                return;

            if (!tryGetSelectedAppointmentId(e.RowIndex, out int appointmentId))
            {
                MessageBox.Show(
                    "The selected appointment ID is invalid.",
                    "Invalid Appointment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            openAppointmentDetails(appointmentId);
        }

        private bool tryGetSelectedAppointmentId(
            int rowIndex, out int appointmentId)
        {
            appointmentId = 0;

            object? value =
                visitHistoryDataGridView.Rows[rowIndex]
                    .Cells["appointment_id"].Value;

            return value != null &&
                   int.TryParse(value.ToString(), out appointmentId) &&
                   appointmentId > 0;
        }

        private void openAppointmentDetails(int appointmentId)
        {
            var detailsPage =
                new PatientVisitDetailsPage(appointmentId, this);

            Hide();
            detailsPage.Show();
        }

        /// <summary>
        /// Returns to the previous page.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            _previousPage.Show();
            Close();
        }

        private void newAppointmentButton_Click(
            object sender, EventArgs e)
        {
            var appointmentPage =
                new CreateAppointmentPage(_patientId, this);

            Hide();
            appointmentPage.Show();
        }

        /// <summary>
        /// Refreshes the appointment visit history displayed in the grid.
        /// </summary>
        public void RefreshVisitHistory()
        {
            LoadPatientVisitHistory();
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