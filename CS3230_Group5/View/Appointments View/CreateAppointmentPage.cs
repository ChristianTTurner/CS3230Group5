
using CS3230_Group5.DAL;
using CS3230_Group5.View.Appointments_View;
using CS3230_Group5.View.Patient_View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class CreateAppointmentPage : Form
    {
        private readonly AppointmentDal appointmentDal =
            new AppointmentDal();

        private readonly int? _preselectedPatientId;
        private readonly Form? _previousPage;

        // Normal constructor: opened without a preselected patient.
        public CreateAppointmentPage() : this(null, null)
        {
        }

        // Constructor: opened with a specific patient.
        public CreateAppointmentPage(int patientId)
            : this((int?)patientId, null)
        {
        }

        // Constructor: accepts a nullable patient ID.
        public CreateAppointmentPage(int? patientId)
            : this(patientId, null)
        {
        }

        // Constructor: opened from another page with a specific patient.
        public CreateAppointmentPage(int patientId, Form previousPage)
            : this((int?)patientId, previousPage)
        {
        }

        private CreateAppointmentPage(
            int? patientId,
            Form? previousPage)
        {
            InitializeComponent();

            _preselectedPatientId = patientId;
            _previousPage = previousPage;

            cancelButton.Click -= cancelButton_Click;
            cancelButton.Click += cancelButton_Click;

            bookAppointmentButton.Click -= bookAppointmentButton_Click;
            bookAppointmentButton.Click += bookAppointmentButton_Click;

            patients.DropDownStyle = ComboBoxStyle.DropDownList;
            doctor.DropDownStyle = ComboBoxStyle.DropDownList;

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.MinDate = DateTime.Today;

            initializeValidationLabels();
            attachValidationEvents();
            setDefaultAppointmentTime();
        }

        private void initializeValidationLabels()
        {
            Label[] labels =
            {
                patientValidation,
                doctorValidation,
                dateValidation,
                reasonValidation
            };

            foreach (Label label in labels)
            {
                label.Text = "";
                label.Visible = false;
            }
        }

        private void attachValidationEvents()
        {
            patients.SelectedIndexChanged +=
                (s, e) => clearValidationError(patientValidation);

            doctor.SelectedIndexChanged +=
                (s, e) => clearValidationError(doctorValidation);

            dateTimePicker.ValueChanged +=
                (s, e) => clearValidationError(dateValidation);

            reasonTextBox.TextChanged +=
                (s, e) => clearValidationError(reasonValidation);
        }

        private void setDefaultAppointmentTime()
        {
            DateTime now = DateTime.Now;
            DateTime defaultTime = DateTime.Today.AddHours(8);

            if (defaultTime <= now)
            {
                defaultTime =
                    DateTime.Today.AddDays(1).AddHours(8);
            }

            dateTimePicker.Value = defaultTime;
        }

        private void CreateAppointmentPage_Load(
            object? sender,
            EventArgs e)
        {
            loadPatients();
            loadDoctors();
        }

        private void loadPatients()
        {
            try
            {
                patients.DataSource = null;
                patients.Items.Clear();

                var patientList = appointmentDal.GetPatients();

                patients.DataSource =
                    new BindingSource(patientList, null);

                patients.DisplayMember = "Value";
                patients.ValueMember = "Key";
                patients.SelectedIndex = -1;

                if (_preselectedPatientId.HasValue)
                {
                    bool patientFound = false;

                    for (int i = 0; i < patients.Items.Count; i++)
                    {
                        if (patients.Items[i]
                                is KeyValuePair<int, string> patient &&
                            patient.Key == _preselectedPatientId.Value)
                        {
                            patients.SelectedIndex = i;
                            patientFound = true;
                            break;
                        }
                    }

                    if (patientFound)
                    {
                        patients.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                            "The current patient was not found in the active patient list.",
                            "Patient Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }

                clearValidationError(patientValidation);
            }
            catch (Exception ex)
            {
                patients.DataSource = null;

                MessageBox.Show(
                    $"Could not load the current patient list: {ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void loadDoctors()
        {
            try
            {
                doctor.DataSource = null;
                doctor.Items.Clear();

                var doctorList = appointmentDal.GetDoctors();

                doctor.DataSource =
                    new BindingSource(doctorList, null);

                doctor.DisplayMember = "Value";
                doctor.ValueMember = "Key";
                doctor.SelectedIndex = -1;

                clearValidationError(doctorValidation);
            }
            catch (Exception)
            {
                doctor.DataSource = null;

                MessageBox.Show(
                    "Could not load the current doctor list.",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void bookAppointmentButton_Click(
            object? sender,
            EventArgs e)
        {
            clearAllValidationErrors();

            if (!validateForm())
                return;

            saveAppointment();
        }
        private bool validateForm()
        {
            bool isValid = true;

            if (patients.SelectedIndex == -1 ||
                patients.SelectedValue == null)
            {
                showValidationError(
                    patientValidation,
                    "Please choose a patient.");

                isValid = false;
            }

            if (doctor.SelectedIndex == -1 ||
                doctor.SelectedValue == null)
            {
                showValidationError(
                    doctorValidation,
                    "Please choose a doctor.");

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(reasonTextBox.Text))
            {
                showValidationError(
                    reasonValidation,
                    "Please enter a reason for your appointment.");

                isValid = false;
            }
            else if (reasonTextBox.Text.Trim().Length > 255)
            {
                showValidationError(
                    reasonValidation,
                    "Reason must not exceed 255 characters.");

                isValid = false;
            }

            if (!validateAppointmentDate())
                isValid = false;

            return isValid;
        }
        private bool validateAppointmentDate()
        {
            DateTime appointmentTime = dateTimePicker.Value;

            if (appointmentTime <= DateTime.Now)
            {
                showValidationError(
                    dateValidation,
                    "Choose a future date and time.");

                return false;
            }

            if (appointmentTime.TimeOfDay < TimeSpan.FromHours(8) ||
                appointmentTime.TimeOfDay > TimeSpan.FromHours(17))
            {
                showValidationError(
                    dateValidation,
                    "Choose a time between 8:00 AM and 5:00 PM.");

                return false;
            }

            if (appointmentTime.Minute % 15 != 0 ||
                appointmentTime.Second != 0 ||
                appointmentTime.Millisecond != 0)
            {
                showValidationError(
                    dateValidation,
                    "Choose a time on a 15-minute interval.");

                return false;
            }

            return true;
        }
        private void saveAppointment()
        {
            try
            {
                int patientId =
                    Convert.ToInt32(patients.SelectedValue);

                int doctorId =
                    Convert.ToInt32(doctor.SelectedValue);

                string reason = reasonTextBox.Text.Trim();

                int appointmentId = appointmentDal.AddAppointment(
                    patientId,
                    doctorId,
                    dateTimePicker.Value,
                    reason);

                MessageBox.Show(
                    $"Appointment #{appointmentId} booked successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                returnToPreviousPage();
            }
            catch (InvalidOperationException ex)
            {
                showValidationError(dateValidation, ex.Message);
            }
            catch (ArgumentException ex)
            {
                showValidationError(dateValidation, ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Could not book the appointment. Please try again.",
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void showValidationError(
            Label label,
            string message)
        {
            label.Text = message;
            label.Visible = true;
        }

        private void clearValidationError(Label label)
        {
            label.Text = "";
            label.Visible = false;
        }

        private void clearAllValidationErrors()
        {
            clearValidationError(patientValidation);
            clearValidationError(doctorValidation);
            clearValidationError(dateValidation);
            clearValidationError(reasonValidation);
        }

        private void returnToPreviousPage()
        {
            if (_previousPage != null &&
                !_previousPage.IsDisposed)
            {

                if (_previousPage is PatientViewHistoryPage historyPage)
                {
                    historyPage.RefreshVisitHistory();
                }

                _previousPage.Show();
                _previousPage.BringToFront();

                Close();
                return;
            }

            foreach (Form open in Application.OpenForms)
            {
                if (open is ViewAppointmentsPage appointmentsPage)
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
        private void cancelButton_Click(
            object? sender,
            EventArgs e)
        {
            returnToPreviousPage();
        }
    }
}
