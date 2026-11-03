using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using CS3230_Group5.View.Nurse_View;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CS3230_Group5.View.Appointments_View
{
    public partial class AppointmentDetailsPage : Form
    {
        private readonly AppointmentSummaryDal _summaryDal =
            new AppointmentSummaryDal();

        private int _appointmentId;

        private Label patientIdValue = null!;
        private Label firstNameValue = null!;
        private Label lastNameValue = null!;
        private Label dobValue = null!;
        private Label phoneValue = null!;

        private Label appointmentIdValue = null!;
        private Label dateTimeValue = null!;
        private Label doctorValue = null!;
        private Label reasonValue = null!;

        private Label systolicValue = null!;
        private Label diastolicValue = null!;
        private Label pulseValue = null!;
        private Label temperatureValue = null!;
        private Label heightValue = null!;
        private Label weightValue = null!;

        private readonly OrderedTestDal _testDal = new OrderedTestDal();

        public AppointmentDetailsPage() : this(0)
        {
        }

        public AppointmentDetailsPage(int appointmentId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;

            CreateValueLabels();
            ConfigureReadOnlyFields();
            ConfigureTestsGrid();
            AttachEventHandlers();
        }

        private void ConfigureReadOnlyFields()
        {
            symptomsTextBox.ReadOnly = true;
            initialDiagnosisTextBox.ReadOnly = true;
            finalDiagnosisTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Lets the tests grid fill its width and wrap long text instead of cutting it off.
        /// </summary>
        private void ConfigureTestsGrid()
        {
            orderedTestDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderedTestDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            orderedTestDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            testCodeColumn.FillWeight = 60;
            testNameColumn.FillWeight = 120;
            performedDateTimeColumn.FillWeight = 110;
            resultColumn.FillWeight = 110;
            statusColumn.FillWeight = 80;
        }

        private void AttachEventHandlers()
        {
            checkUpButton.Click += checkUpButton_Click;
            initialDiagnosisButton.Click += initialDiagnosisButton_Click;
            backButton.Click += backButton_Click;

            // TODO (Task B): Connect Edit Appointment.
            editAppointmentButton.Click += (s, e) =>
            {
                // Open the partner's Edit Appointment form.
            };

            orderTestButton.Click += orderTestButton_Click;

            viewTestButton.Click += viewTestButton_Click;

            finalDiagnosisButton.Click += finalDiagnosisButton_Click;
        }

        private void AppointmentDetailsPage_Load(object? sender, EventArgs e)
        {
            if (_appointmentId > 0)
            {
                LoadPageData();
            }
        }

        public void LoadAppointment(int appointmentId)
        {
            if (appointmentId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            }

            _appointmentId = appointmentId;
            LoadPageData();
        }

        private void CreateValueLabels()
        {
            CreatePatientValueLabels();
            CreateAppointmentValueLabels();
            CreateCheckupValueLabels();
        }

        private void CreatePatientValueLabels()
        {
            patientIdValue = AddValueLabel(patientInfoPanel, 160, 49, 400);
            firstNameValue = AddValueLabel(patientInfoPanel, 160, 82, 400);
            lastNameValue = AddValueLabel(patientInfoPanel, 160, 121, 400);
            dobValue = AddValueLabel(patientInfoPanel, 160, 160, 400);
            phoneValue = AddValueLabel(patientInfoPanel, 160, 197, 400);
        }

        private void CreateAppointmentValueLabels()
        {
            appointmentIdValue = AddValueLabel(appointmentPanel, 175, 49, 210);
            dateTimeValue = AddValueLabel(appointmentPanel, 175, 91, 390);
            doctorValue = AddValueLabel(appointmentPanel, 175, 135, 390);
            reasonValue = AddValueLabel(appointmentPanel, 175, 172, 390);
        }

        private void CreateCheckupValueLabels()
        {
            systolicValue = AddValueLabel(checkUpPanel, 235, 53, 190);
            diastolicValue = AddValueLabel(checkUpPanel, 235, 92, 190);
            pulseValue = AddValueLabel(checkUpPanel, 235, 131, 190);
            temperatureValue = AddValueLabel(checkUpPanel, 635, 53, 200);
            heightValue = AddValueLabel(checkUpPanel, 635, 92, 200);
            weightValue = AddValueLabel(checkUpPanel, 635, 131, 200);
        }

        private static Label AddValueLabel(Panel parent, int x, int y, int width)
        {
            var label = new Label
            {
                AutoSize = false,
                Location = new Point(x, y),
                Size = new Size(width, 30),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Text = "Not entered yet",
                TextAlign = ContentAlignment.MiddleLeft
            };

            parent.Controls.Add(label);
            label.BringToFront();
            return label;
        }

        private void LoadPageData()
        {
            try
            {
                DataTable details = _summaryDal.GetAppointmentDetails(_appointmentId);
                if (!HasAppointmentDetails(details))
                {
                    ShowAppointmentNotFoundMessage();
                    return;
                }

                DisplayAppointmentDetails(details.Rows[0]);
                DisplaySummary(_summaryDal.GetSummary(_appointmentId));
            }
            catch (Exception ex)
            {
                ShowErrorMessage(
                    "Unable to load appointment details: " + ex.Message,
                    "Database Error");
            }
        }

        private static bool HasAppointmentDetails(DataTable details)
        {
            return details.Rows.Count > 0;
        }

        private void ShowAppointmentNotFoundMessage()
        {
            MessageBox.Show(
                "The selected appointment could not be found.",
                "Appointment Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void DisplayAppointmentDetails(DataRow row)
        {
            DisplayPatientInformation(row);
            DisplayAppointmentInformation(row);
        }

        private void DisplayPatientInformation(DataRow row)
        {
            patientIdValue.Text = Display(row, "patient_id");
            firstNameValue.Text = Display(row, "first_name");
            lastNameValue.Text = Display(row, "last_name");
            dobValue.Text = FormatDate(row, "date_of_birth");
            phoneValue.Text = Display(row, "phone");
        }

        private void DisplayAppointmentInformation(DataRow row)
        {
            appointmentIdValue.Text = Display(row, "appointment_id");
            dateTimeValue.Text = FormatDateTime(row, "appointment_datetime");
            doctorValue.Text = Display(row, "doctor_name");
            reasonValue.Text = Display(row, "reason");
        }

        private void DisplaySummary(AppointmentSummary? summary)
        {
            if (summary == null)
            {
                DisplayEmptySummary();
                return;
            }

            DisplayMeasurements(summary);
            DisplaySymptomsAndDiagnoses(summary);
            DisplayOrderedTests();
        }

        private void DisplayEmptySummary()
        {
            SetMeasurementDefaults();
            symptomsTextBox.Text = "Not entered yet.";
            initialDiagnosisTextBox.Text = "Not entered yet.";
            finalDiagnosisTextBox.Text = "Not entered yet.";

            SetVisitLocked(false);

            // No check-up yet, so there cannot be any ordered tests.
            orderedTestDataGridView.Rows.Clear();
        }

        private void DisplayMeasurements(AppointmentSummary summary)
        {
            systolicValue.Text = summary.SystolicReading?.ToString() ?? "Not entered yet";
            diastolicValue.Text = summary.DiastolicReading?.ToString() ?? "Not entered yet";
            pulseValue.Text = summary.Pulse?.ToString() ?? "Not entered yet";
            temperatureValue.Text = summary.BodyTemperature?.ToString("0.0") ?? "Not entered yet";
            heightValue.Text = summary.Height?.ToString("0.00") ?? "Not entered yet";
            weightValue.Text = summary.Weight?.ToString("0.00") ?? "Not entered yet";
        }

        private void DisplaySymptomsAndDiagnoses(AppointmentSummary summary)
        {
            symptomsTextBox.Text = DisplayText(summary.Symptoms);
            initialDiagnosisTextBox.Text = DisplayText(summary.InitialDiagnosis);

            finalDiagnosisTextBox.Text = DisplayText(summary.FinalDiagnosis);

            SetVisitLocked(!string.IsNullOrWhiteSpace(summary.FinalDiagnosis));
        }

        private void SetMeasurementDefaults()
        {
            systolicValue.Text = "Not entered yet";
            diastolicValue.Text = "Not entered yet";
            pulseValue.Text = "Not entered yet";
            temperatureValue.Text = "Not entered yet";
            heightValue.Text = "Not entered yet";
            weightValue.Text = "Not entered yet";
        }

        private static string DisplayText(string? value)
        {
            return string.IsNullOrWhiteSpace(value) ? "Not entered yet." : value;
        }

        private static string Display(DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
            {
                return "Not entered yet";
            }

            string value = Convert.ToString(row[column]) ?? string.Empty;
            return string.IsNullOrWhiteSpace(value) ? "Not entered yet" : value;
        }

        private static string FormatDate(DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
            {
                return "Not entered yet";
            }

            return Convert.ToDateTime(row[column]).ToString("MM/dd/yyyy");
        }

        private static string FormatDateTime(DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
            {
                return "Not entered yet";
            }

            return Convert.ToDateTime(row[column]).ToString("MM/dd/yyyy h:mm tt");
        }

        private void checkUpButton_Click(object? sender, EventArgs e)
        {
            if (!EnsureAppointmentSelected())
            {
                return;
            }

            if (!TryGetSignedInNurseId(out int nurseId))
            {
                ShowWarningMessage(
                    "Unable to identify the logged-in nurse.",
                    "Login Required");
                return;
            }

            try
            {
                using var checkupPage = new RoutineCheckUpPage(_appointmentId, nurseId);
                RefreshAfterSuccessfulDialog(checkupPage);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(
                    "Unable to open the routine check-up page: " + ex.Message,
                    "Check-Up Error");
            }
        }

        private bool TryGetSignedInNurseId(out int nurseId)
        {
            return int.TryParse(Convert.ToString(SignedInUser.UserID), out nurseId)
                && nurseId > 0;
        }

        private void initialDiagnosisButton_Click(object? sender, EventArgs e)
        {
            if (!EnsureAppointmentSelected())
            {
                return;
            }

            try
            {
                using var diagnosisPage = new InitialDiagnosisPage(_appointmentId);
                RefreshAfterSuccessfulDialog(diagnosisPage);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(
                    "Unable to open the initial diagnosis page: " + ex.Message,
                    "Diagnosis Error");
            }
        }

        private void viewTestButton_Click(object? sender, EventArgs e)
        {
            if (!EnsureAppointmentSelected())
            {
                return;
            }

            try
            {
                using var resultsPage = new EnterTestResultsPage(_appointmentId);
                resultsPage.ShowDialog(this);

                // Always refresh: results may have been saved before the page closed.
                LoadPageData();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(
                    "Unable to open the test results page: " + ex.Message,
                    "Test Results Error");
            }
        }

        private void finalDiagnosisButton_Click(object? sender, EventArgs e)
        {
            if (!EnsureAppointmentSelected())
            {
                return;
            }

            try
            {
                using var finalDiagnosisPage = new EnterFinalDiagnosisPage(_appointmentId);
                RefreshAfterSuccessfulDialog(finalDiagnosisPage);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(
                    "Unable to open the final diagnosis page: " + ex.Message,
                    "Final Diagnosis Error");
            }
        }

        /// <summary>
        /// Once a final diagnosis exists the visit is read-only, so the buttons
        /// that change it are turned off. View Test Result stays on so the
        /// results can still be read.
        /// </summary>
        private void SetVisitLocked(bool locked)
        {
            checkUpButton.Enabled = !locked;
            initialDiagnosisButton.Enabled = !locked;
            orderTestButton.Enabled = !locked;
            finalDiagnosisButton.Enabled = !locked;
        }

        private void DisplayOrderedTests()
        {
            orderedTestDataGridView.Rows.Clear();

            foreach (OrderedTest test in _testDal.GetOrderedTests(_appointmentId))
            {
                string performed = test.PerformedDateTime?.ToString("MM/dd/yyyy h:mm tt")
                    ?? "Not performed";

                string result = test.HasResult
                    ? $"{test.Result} {test.UnitMeasurement}".Trim()
                    : "Not entered yet";

                orderedTestDataGridView.Rows.Add(
                    test.TestCode,
                    test.TestName,
                    performed,
                    result,
                    test.StatusText);
            }
        }

        private void orderTestButton_Click(object? sender, EventArgs e)
        {
            if (!EnsureAppointmentSelected())
            {
                return;
            }

            try
            {
                using var orderPage = new OrderTestsPage(_appointmentId);
                orderPage.ShowDialog(this);

                // Always refresh: a test may have been removed before the page closed.
                LoadPageData();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(
                    "Unable to open the order tests page: " + ex.Message,
                    "Order Tests Error");
            }
        }

        private bool EnsureAppointmentSelected()
        {
            if (_appointmentId > 0)
            {
                return true;
            }

            ShowWarningMessage("Select an appointment first.", "Appointment Required");
            return false;
        }

        private void RefreshAfterSuccessfulDialog(Form dialog)
        {
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadPageData();
            }
        }

        private void backButton_Click(object? sender, EventArgs e)
        {
            ReturnToAppointmentsPage();
        }

        private void ReturnToAppointmentsPage()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is ViewAppointmentsPage appointmentsPage)
                {
                    appointmentsPage.PopulateAppointments();
                    appointmentsPage.Show();
                    appointmentsPage.BringToFront();
                    Close();
                    return;
                }
            }

            new ViewAppointmentsPage().Show();
            Close();
        }

        private static void ShowWarningMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void ShowErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void profileLabel_Click(object? sender, EventArgs e)
        {

        }
    }
}