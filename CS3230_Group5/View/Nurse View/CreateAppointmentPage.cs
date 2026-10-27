
using System;
using System.Windows.Forms;
using CS3230_Group5.DAL;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class CreateAppointmentPage : Form
    {
        private readonly AppointmentDal appointmentDal = new AppointmentDal();

        public CreateAppointmentPage()
        {
            InitializeComponent();

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
                defaultTime = DateTime.Today.AddDays(1).AddHours(8);
            }

            dateTimePicker.Value = defaultTime;
        }

        private void CreateAppointmentPage_Load(object? sender, EventArgs e)
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

                patients.DataSource = new BindingSource(patientList, null);
                patients.DisplayMember = "Value";
                patients.ValueMember = "Key";
                patients.SelectedIndex = -1;

                clearValidationError(patientValidation);
            }
            catch (Exception)
            {
                patients.DataSource = null;

                MessageBox.Show(
                    "Could not load the current patient list.",
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

                doctor.DataSource = new BindingSource(doctorList, null);
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
        private void bookAppointmentButton_Click(object? sender, EventArgs e)
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

        // Save the appointment and handle expected errors
        private void saveAppointment()
        {
            try
            {
                int patientId = Convert.ToInt32(patients.SelectedValue);
                int doctorId = Convert.ToInt32(doctor.SelectedValue);

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

                returnToHomePage();
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

        private void showValidationError(Label label, string message)
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

        private void returnToHomePage()
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is homePageButton home)
                {
                    home.Show();
                    home.BringToFront();
                    Close();
                    return;
                }
            }

            var newHome = new homePageButton();
            newHome.Show();
            Close();
        }

        private void cancelButton_Click(object? sender, EventArgs e)
        {
            returnToHomePage();
        }
    }
}
