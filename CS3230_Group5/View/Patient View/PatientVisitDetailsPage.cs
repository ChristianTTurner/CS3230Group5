
using System;
using System.Data;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Patient_View
{
    /// <summary>
    /// Provides a read-only view of a patient's appointment details,
    /// checkup information, diagnoses, and ordered test results.
    /// </summary>
    public partial class PatientVisitDetailsPage : Form
    {
        private readonly int _appointmentId;
        private readonly Form? _previousPage;

        private readonly AppointmentSummaryDal _appointmentDal =
            new AppointmentSummaryDal();

        /// <summary>
        /// Initializes the appointment details page without a previous page reference.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment to display.</param>
        public PatientVisitDetailsPage(int appointmentId)
            : this(appointmentId, null)
        {
        }

        /// <summary>
        /// Initializes the appointment details page with an optional previous page.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment to display.</param>
        /// <param name="previousPage">The form to return to when the user navigates back.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the appointment ID is less than or equal to zero.
        /// </exception>
        public PatientVisitDetailsPage(
            int appointmentId, Form? previousPage)
        {
            InitializeComponent();

            if (appointmentId <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(appointmentId),
                    "Appointment ID must be positive.");
            }

            _appointmentId = appointmentId;
            _previousPage = previousPage;

            ConfigureReadOnlyControls();

            backButton.Click += backButton_Click;
        }

        /// <summary>
        /// Configures the details page as read-only.
        /// </summary>
        private void ConfigureReadOnlyControls()
        {
            patientIdTextBox.ReadOnly = true;
            patientNameTextBox.ReadOnly = true;
            patientDobTextBox.ReadOnly = true;
            patientPhoneTextBox.ReadOnly = true;

            appointmentIdTextBox.ReadOnly = true;
            dateTimeTextBox.ReadOnly = true;
            textBox1.ReadOnly = true;
            doctorIdTextBox.ReadOnly = true;
            doctorNameTextBox.ReadOnly = true;

            systolicTextBox.ReadOnly = true;
            diastolicTextBox.ReadOnly = true;
            tempTextBox.ReadOnly = true;
            pulseTextBox.ReadOnly = true;
            heightTextBox.ReadOnly = true;
            weightTextBox.ReadOnly = true;

            symptomsTextBox.ReadOnly = true;
            initialTextBox.ReadOnly = true;
            finalTextBox.ReadOnly = true;

            symptomsTextBox.Multiline = true;
            initialTextBox.Multiline = true;
            finalTextBox.Multiline = true;

            configureTestsGrid();
        }

        private void configureTestsGrid()
        {
            testsDataGridView.AutoGenerateColumns = false;
            testsDataGridView.AllowUserToAddRows = false;
            testsDataGridView.AllowUserToDeleteRows = false;
            testsDataGridView.ReadOnly = true;
            testsDataGridView.MultiSelect = false;
            testsDataGridView.RowHeadersVisible = false;

            testsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            testsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            testsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
        }

        /// <summary>
        /// Loads appointment information when the page opens.
        /// </summary>
        private void PatientVisitDetailsPage_Load(
            object sender, EventArgs e)
        {
            LoadAppointmentInformation();
            LoadCheckupInformation();
            LoadOrderedTests();
        }

        /// <summary>
        /// Loads patient, appointment, and doctor information.
        /// </summary>
        private void LoadAppointmentInformation()
        {
            try
            {
                DataTable appointmentTable =
                    _appointmentDal.GetAppointmentDetails(_appointmentId);

                if (appointmentTable.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "The selected appointment could not be found.",
                        "Appointment Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    Close();
                    return;
                }

                DataRow appointment = appointmentTable.Rows[0];

                populatePatientAppointmentFields(appointment);
                populateDoctorFields(appointment);
            }
            catch (Exception ex)
            {
                ShowError("Error loading appointment information", ex);
            }
        }

        private void populatePatientAppointmentFields(DataRow appointment)
        {
            patientIdTextBox.Text =
                GetValue(appointment, "patient_id");

            patientNameTextBox.Text =
                $"{GetValue(appointment, "first_name")} " +
                $"{GetValue(appointment, "last_name")}";

            patientDobTextBox.Text =
                FormatDate(appointment, "date_of_birth");

            patientPhoneTextBox.Text =
                GetValue(appointment, "phone");

            appointmentIdTextBox.Text =
                GetValue(appointment, "appointment_id");

            dateTimeTextBox.Text =
                FormatDateTime(appointment, "appointment_datetime");

            textBox1.Text =
                GetValue(appointment, "reason");
        }

        private void populateDoctorFields(DataRow appointment)
        {
            doctorIdTextBox.Text =
                GetValue(appointment, "doctor_id");

            doctorNameTextBox.Text =
                GetValue(appointment, "doctor_name");
        }

        /// <summary>
        /// Loads checkup measurements, symptoms, and diagnoses.
        /// </summary>
        private void LoadCheckupInformation()
        {
            try
            {
                AppointmentSummary? summary =
                    _appointmentDal.GetSummary(_appointmentId);

                if (summary == null)
                {
                    SetCheckupNotRecorded();
                    return;
                }

                populateCheckupMeasurements(summary);
                populateCheckupNotes(summary);
            }
            catch (Exception ex)
            {
                ShowError("Error loading checkup information", ex);
            }
        }

        private void populateCheckupMeasurements(AppointmentSummary summary)
        {
            systolicTextBox.Text =
                FormatValue(summary.SystolicReading);

            diastolicTextBox.Text =
                FormatValue(summary.DiastolicReading);

            tempTextBox.Text =
                FormatValue(summary.BodyTemperature);

            pulseTextBox.Text =
                FormatValue(summary.Pulse);

            heightTextBox.Text =
                FormatValue(summary.Height);

            weightTextBox.Text =
                FormatValue(summary.Weight);
        }

        private void populateCheckupNotes(AppointmentSummary summary)
        {
            symptomsTextBox.Text =
                DisplayOrDefault(summary.Symptoms);

            initialTextBox.Text =
                DisplayOrDefault(summary.InitialDiagnosis);

            finalTextBox.Text =
                DisplayOrDefault(summary.FinalDiagnosis);
        }

        /// <summary>
        /// Displays a message when no checkup has been recorded.
        /// </summary>
        private void SetCheckupNotRecorded()
        {
            systolicTextBox.Text = "Not recorded";
            diastolicTextBox.Text = "Not recorded";
            tempTextBox.Text = "Not recorded";
            pulseTextBox.Text = "Not recorded";
            heightTextBox.Text = "Not recorded";
            weightTextBox.Text = "Not recorded";

            symptomsTextBox.Text = "Not recorded";
            initialTextBox.Text = "Not recorded";
            finalTextBox.Text = "Not recorded";
        }

        /// <summary>
        /// Loads all tests belonging to this appointment.
        /// </summary>
        private void LoadOrderedTests()
        {
            try
            {
                testsDataGridView.Rows.Clear();

                DataTable tests =
                    _appointmentDal.GetOrderedTests(_appointmentId);

                foreach (DataRow test in tests.Rows)
                {
                    addOrderedTestRow(test);
                }

                updateTestHeader(tests.Rows.Count);
            }
            catch (Exception ex)
            {
                ShowError("Error loading ordered tests", ex);
            }
        }

        private void addOrderedTestRow(DataRow test)
        {
            string performedDate =
                FormatDateTime(test, "performed_datetime");

            string result =
                DisplayOrDefault(GetValue(test, "result"), "Pending");

            string abnormal = getAbnormalStatus(test);

            if (test["performed_datetime"] == DBNull.Value)
            {
                performedDate = "Not performed yet";
            }

            testsDataGridView.Rows.Add(
                GetValue(test, "test_code"),
                performedDate,
                result,
                abnormal
            );
        }

        private string getAbnormalStatus(DataRow test)
        {
            if (test["abnormal"] == DBNull.Value)
            {
                return "Pending";
            }

            return Convert.ToBoolean(test["abnormal"])
                ? "Yes"
                : "No";
        }

        private void updateTestHeader(int testCount)
        {
            if (testCount == 0)
            {
                testHeaderLabel.Text =
                    "Tests Ordered and Performed — No tests ordered for this visit.";
            }
            else
            {
                testHeaderLabel.Text =
                    $"Tests Ordered and Performed — {testCount} test(s)";
            }
        }

        /// <summary>
        /// Returns a database value as text.
        /// </summary>
        private static string GetValue(DataRow row, string column)
        {
            return row[column] == DBNull.Value
                ? string.Empty
                : row[column].ToString() ?? string.Empty;
        }

        /// <summary>
        /// Formats a nullable date.
        /// </summary>
        private static string FormatDate(DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
                return "Not provided";

            return Convert.ToDateTime(row[column])
                .ToString("MM/dd/yyyy");
        }

        /// <summary>
        /// Formats a nullable date and time.
        /// </summary>
        private static string FormatDateTime(
            DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
                return "Not available";

            return Convert.ToDateTime(row[column])
                .ToString("MM/dd/yyyy hh:mm tt");
        }

        /// <summary>
        /// Formats nullable numeric values.
        /// </summary>
        private static string FormatValue<T>(T? value)
            where T : struct
        {
            return value.HasValue
                ? value.Value.ToString() ?? string.Empty
                : "Not recorded";
        }

        /// <summary>
        /// Returns a default message for missing text.
        /// </summary>
        private static string DisplayOrDefault(
            string? value, string defaultText = "Not recorded")
        {
            return string.IsNullOrWhiteSpace(value)
                ? defaultText
                : value;
        }

        /// <summary>
        /// Returns to the previous page when one is available.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            if (_previousPage != null && !_previousPage.IsDisposed)
            {
                _previousPage.Show();
                _previousPage.BringToFront();
            }

            Close();
        }

        private static void ShowError(string title, Exception exception)
        {
            MessageBox.Show(
                $"{title}: {exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}