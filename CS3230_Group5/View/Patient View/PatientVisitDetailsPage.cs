
using System;
using System.Data;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Patient_View
{
    public partial class PatientVisitDetailsPage : Form
    {
        private readonly int _appointmentId;
        private readonly Form? _previousPage;

        private readonly AppointmentSummaryDal _appointmentDal =
            new AppointmentSummaryDal();

        public PatientVisitDetailsPage(int appointmentId)
            : this(appointmentId, null)
        {
        }

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

                doctorIdTextBox.Text =
                    GetValue(appointment, "doctor_id");

                doctorNameTextBox.Text =
                    GetValue(appointment, "doctor_name");
            }
            catch (Exception ex)
            {
                ShowError("Error loading appointment information", ex);
            }
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

                symptomsTextBox.Text =
                    DisplayOrDefault(summary.Symptoms);

                initialTextBox.Text =
                    DisplayOrDefault(summary.InitialDiagnosis);

                finalTextBox.Text =
                    DisplayOrDefault(summary.FinalDiagnosis);
            }
            catch (Exception ex)
            {
                ShowError("Error loading checkup information", ex);
            }
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
                    string performedDate =
                        FormatDateTime(test, "performed_datetime");

                    string result =
                        DisplayOrDefault(GetValue(test, "result"),
                            "Pending");

                    string abnormal = "Pending";

                    if (test["abnormal"] != DBNull.Value)
                    {
                        abnormal =
                            Convert.ToBoolean(test["abnormal"])
                                ? "Yes"
                                : "No";
                    }

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

                if (tests.Rows.Count == 0)
                {
                    label4.Text =
                        "Tests Ordered and Performed — No tests ordered for this visit.";
                }
                else
                {
                    label4.Text =
                        $"Tests Ordered and Performed — {tests.Rows.Count} test(s)";
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading ordered tests", ex);
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
        /// Returns to the visit history page.
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