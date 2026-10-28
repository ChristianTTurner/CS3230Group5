
using CS3230_Group5.DAL;
using CS3230_Group5.Model;
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

        public AppointmentDetailsPage() : this(0)
        {
        }

        public AppointmentDetailsPage(int appointmentId)
        {
            InitializeComponent();

            _appointmentId = appointmentId;

            CreateValueLabels();
            ConfigureReadOnlyFields();
            AttachEventHandlers();
        }

        private void ConfigureReadOnlyFields()
        {
            symptomsTextBox.ReadOnly = true;
            initialDiagnosisTextBox.ReadOnly = true;
            finalDiagnosisTextBox.ReadOnly = true;
        }

        private void AttachEventHandlers()
        {
            checkUpButton.Click += checkUpButton_Click;
            initialDiagnosisButton.Click +=
                initialDiagnosisButton_Click;

            backButton.Click += backButton_Click;

            // TODO (Task B): Connect Edit Appointment.
            editAppointmentButton.Click += (s, e) =>
            {
                // Open the partner's Edit Appointment form.
            };

            // TODO (Task C): Connect test ordering.
            orderTestButton.Click += (s, e) =>
            {
                // Open the partner's Order Tests form.
            };

            // TODO (Task C): Connect test results.
            viewTestButton.Click += (s, e) =>
            {
                // Open the partner's Test Results form.
            };

            // TODO (Task C): Connect final diagnosis and confirmation.
            finalDiagnosisButton.Click += (s, e) =>
            {
                // Open the partner's Final Diagnosis form.
            };
        }

        private void AppointmentDetailsPage_Load(
            object? sender, EventArgs e)
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
                throw new ArgumentOutOfRangeException(
                    nameof(appointmentId));
            }

            _appointmentId = appointmentId;
            LoadPageData();
        }

        private void CreateValueLabels()
        {
            patientIdValue =
                AddValueLabel(patientInfoPanel, 160, 49, 400);

            firstNameValue =
                AddValueLabel(patientInfoPanel, 160, 82, 400);

            lastNameValue =
                AddValueLabel(patientInfoPanel, 160, 121, 400);

            dobValue =
                AddValueLabel(patientInfoPanel, 160, 160, 400);

            phoneValue =
                AddValueLabel(patientInfoPanel, 160, 197, 400);

            appointmentIdValue =
                AddValueLabel(appointmentPanel, 175, 49, 210);

            dateTimeValue =
                AddValueLabel(appointmentPanel, 175, 91, 390);

            doctorValue =
                AddValueLabel(appointmentPanel, 175, 135, 390);

            reasonValue =
                AddValueLabel(appointmentPanel, 175, 172, 390);

            systolicValue =
                AddValueLabel(checkUpPanel, 235, 53, 190);

            diastolicValue =
                AddValueLabel(checkUpPanel, 235, 92, 190);

            pulseValue =
                AddValueLabel(checkUpPanel, 235, 131, 190);

            temperatureValue =
                AddValueLabel(checkUpPanel, 635, 53, 200);

            heightValue =
                AddValueLabel(checkUpPanel, 635, 92, 200);

            weightValue =
                AddValueLabel(checkUpPanel, 635, 131, 200);
        }

        private static Label AddValueLabel(
            Panel parent, int x, int y, int width)
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
                DataTable details =
                    _summaryDal.GetAppointmentDetails(_appointmentId);

                if (details.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "The selected appointment could not be found.",
                        "Appointment Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DataRow row = details.Rows[0];

                DisplayPatientInformation(row);
                DisplayAppointmentInformation(row);

                AppointmentSummary? summary =
                    _summaryDal.GetSummary(_appointmentId);

                DisplaySummary(summary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load appointment details: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
            appointmentIdValue.Text =
                Display(row, "appointment_id");

            dateTimeValue.Text =
                FormatDateTime(row, "appointment_datetime");

            doctorValue.Text = Display(row, "doctor_name");
            reasonValue.Text = Display(row, "reason");
        }

        private void DisplaySummary(AppointmentSummary? summary)
        {
            if (summary == null)
            {
                SetMeasurementDefaults();

                symptomsTextBox.Text = "Not entered yet.";
                initialDiagnosisTextBox.Text = "Not entered yet.";
                finalDiagnosisTextBox.Text = "Not entered yet.";

                // TODO (Task C): Load ordered tests and their results.
                orderedTestDataGridView.Rows.Clear();

                return;
            }

            systolicValue.Text =
                summary.SystolicReading?.ToString()
                ?? "Not entered yet";

            diastolicValue.Text =
                summary.DiastolicReading?.ToString()
                ?? "Not entered yet";

            pulseValue.Text =
                summary.Pulse?.ToString()
                ?? "Not entered yet";

            temperatureValue.Text =
                summary.BodyTemperature?.ToString("0.0")
                ?? "Not entered yet";

            heightValue.Text =
                summary.Height?.ToString("0.00")
                ?? "Not entered yet";

            weightValue.Text =
                summary.Weight?.ToString("0.00")
                ?? "Not entered yet";

            symptomsTextBox.Text =
                DisplayText(summary.Symptoms);

            initialDiagnosisTextBox.Text =
                DisplayText(summary.InitialDiagnosis);

            // TODO (Task C): Apply final-diagnosis workflow and locking rules.
            finalDiagnosisTextBox.Text =
                DisplayText(summary.FinalDiagnosis);

            // TODO (Task C): Populate orderedTestDataGridView.
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
            return string.IsNullOrWhiteSpace(value)
                ? "Not entered yet."
                : value;
        }

        private static string Display(DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
            {
                return "Not entered yet";
            }

            string value = Convert.ToString(row[column]) ?? "";

            return string.IsNullOrWhiteSpace(value)
                ? "Not entered yet"
                : value;
        }

        private static string FormatDate(DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
            {
                return "Not entered yet";
            }

            return Convert.ToDateTime(row[column])
                .ToString("MM/dd/yyyy");
        }

        private static string FormatDateTime(
            DataRow row, string column)
        {
            if (row[column] == DBNull.Value)
            {
                return "Not entered yet";
            }

            return Convert.ToDateTime(row[column])
                .ToString("MM/dd/yyyy h:mm tt");
        }

        private void checkUpButton_Click(
            object? sender, EventArgs e)
        {
            if (_appointmentId <= 0)
            {
                MessageBox.Show(
                    "Select an appointment first.",
                    "Appointment Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                if (!int.TryParse(
                        Convert.ToString(SignedInUser.UserID),
                        out int nurseId) ||
                    nurseId <= 0)
                {
                    MessageBox.Show(
                        "Unable to identify the logged-in nurse.",
                        "Login Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using var checkupPage =
                    new RoutineCheckUpPage(_appointmentId, nurseId);

                if (checkupPage.ShowDialog(this) == DialogResult.OK)
                {
                    LoadPageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open the routine check-up page: "
                    + ex.Message,
                    "Check-Up Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void initialDiagnosisButton_Click(
            object? sender, EventArgs e)
        {
            if (_appointmentId <= 0)
            {
                MessageBox.Show(
                    "Select an appointment first.",
                    "Appointment Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using var diagnosisPage =
                    new InitialDiagnosisPage(_appointmentId);

                if (diagnosisPage.ShowDialog(this) == DialogResult.OK)
                {
                    LoadPageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open the initial diagnosis page: "
                    + ex.Message,
                    "Diagnosis Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void backButton_Click(object? sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is ViewAppointmentsPage appointmentsPage)
                {
                    appointmentsPage.Show();
                    appointmentsPage.BringToFront();
                    Close();
                    return;
                }
            }

            var newAppointmentsPage = new ViewAppointmentsPage();
            newAppointmentsPage.Show();

            Close();
        }

        private void profileLabel_Click(object? sender, EventArgs e)
        {
            
        }
    }
}
