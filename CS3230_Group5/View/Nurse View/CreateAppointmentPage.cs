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
            bookAppointmentButton.Click += bookAppointmentButton_Click;
            cancelButton.Click += cancelButton_Click;
            Load += CreateAppointmentPage_Load;
        }

        private void CreateAppointmentPage_Load(object? sender, EventArgs e)
        {
            patients.DropDownStyle = ComboBoxStyle.DropDownList;
            doctor.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.MinDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today.AddHours(8);
            loadPatients();
            loadDoctors();
        }

        private void loadPatients()
        {
            try
            {
                patients.DataSource = new BindingSource(appointmentDal.GetPatients(), null);
                patients.DisplayMember = "Value";
                patients.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load patients: {ex.Message}");
            }
        }

        private void loadDoctors()
        {
            try
            {
                doctor.DataSource = new BindingSource(appointmentDal.GetDoctors(), null);
                doctor.DisplayMember = "Value";
                doctor.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load doctors: {ex.Message}");
            }
        }

        private void bookAppointmentButton_Click(object? sender, EventArgs e)
        {
            if (patients.SelectedValue == null || doctor.SelectedValue == null)
            {
                MessageBox.Show("Please select a patient and doctor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(reasonTextBox.Text))
            {
                MessageBox.Show("Please enter the appointment reason.");
                return;
            }

            try
            {
                int patientId = Convert.ToInt32(patients.SelectedValue);
                int doctorId = Convert.ToInt32(doctor.SelectedValue);
                int appointmentId = appointmentDal.AddAppointment(patientId, doctorId, dateTimePicker.Value, reasonTextBox.Text);
                MessageBox.Show($"Appointment #{appointmentId} booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Appointment Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not book appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}