
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Nurse_View
{
    /// <summary>
    /// Provides the form for editing or canceling an existing appointment.
    /// </summary>
    public partial class EditAppointmentPage : Form
    {
        private AppointmentDal _Appointment = new AppointmentDal();
        private Appointment selectedAppointment;
        private Dictionary<int, string> doctors = new Dictionary<int, string>();

        /// <summary>
        /// Initializes the appointment editing form and loads the selected appointment's information.
        /// </summary>
        /// <param name="selectedAppointment">The appointment to edit.</param>
        public EditAppointmentPage(Appointment selectedAppointment)
        {
            InitializeComponent();

            patientName.Enabled = false;
            this.selectedAppointment = selectedAppointment;

            populateDynamicFields();
        }

        private void populateDynamicFields()
        {
            doctors = _Appointment.GetDoctors();

            patientName.Text = selectedAppointment.PatientName;

            configureDoctorComboBox();
            selectCurrentDoctor();

            dateTimePicker.Value = selectedAppointment.DateTime;
            reasonTextBox.Text = selectedAppointment.Reason;
        }

        private void configureDoctorComboBox()
        {
            doctorComboBox.DataSource = new BindingSource(doctors, null);
            doctorComboBox.DisplayMember = "Value";
            doctorComboBox.ValueMember = "Key";
        }

        private void selectCurrentDoctor()
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctorComboBox.GetItemText(doctorComboBox.Items[i]) ==
                    selectedAppointment.DoctorName)
                {
                    doctorComboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void returnToViewAppointmentsPage()
        {
            refreshAndShowAppointmentsPage();
            Close();
        }

        private void refreshAndShowAppointmentsPage()
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is ViewAppointmentsPage viewAppointments)
                {
                    viewAppointments.PopulateAppointments();
                    viewAppointments.Show();
                    viewAppointments.BringToFront();
                    break;
                }
            }
        }

        private void confirmAppointmentButton_Click(object sender, EventArgs e)
        {
            int doctorId = getSelectedDoctorId();

            if (doctorId == 0)
            {
                displayError("Error: Error saving appointment information.");
                return;
            }

            Appointment updatedAppointment = createUpdatedAppointment(doctorId);

            if (_Appointment.UpdateAppointment(updatedAppointment, out string message))
            {
                updateSelectedAppointment(updatedAppointment);
                showUpdateSuccessMessage();
            }
            else
            {
                displayError("Error: " + message);
            }
        }

        private Appointment createUpdatedAppointment(int doctorId)
        {
            Appointment updatedAppointment = new Appointment(
                selectedAppointment.AppointmentId,
                selectedAppointment.PatientId,
                doctorId,
                dateTimePicker.Value,
                reasonTextBox.Text);

            updatedAppointment.PatientName = patientName.Text;
            updatedAppointment.DoctorName = doctorComboBox.SelectedItem.ToString();

            return updatedAppointment;
        }

        private void updateSelectedAppointment(Appointment updatedAppointment)
        {
            selectedAppointment.DoctorName = updatedAppointment.DoctorName;
            selectedAppointment.DoctorId = updatedAppointment.DoctorId;
            selectedAppointment.DateTime = updatedAppointment.DateTime;
            selectedAppointment.Reason = updatedAppointment.Reason;
        }

        private void showUpdateSuccessMessage()
        {
            DialogResult result = MessageBox.Show(
                "Saved infromation successfully.",
                "Confirmation",
                MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                returnToViewAppointmentsPage();
            }
        }

        private int getSelectedDoctorId()
        {
            if (doctorComboBox.SelectedValue == null)
            {
                return 0;
            }

            int doctorId = (int)doctorComboBox.SelectedValue;

            return doctorId;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            returnToViewAppointmentsPage();
        }

        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel the appointment?",
                "Confirmation",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                deleteSelectedAppointment();
            }
        }

        private void deleteSelectedAppointment()
        {
            if (_Appointment.DeleteAppointment(selectedAppointment.AppointmentId))
            {
                returnToViewAppointmentsPage();
            }
            else
            {
                displayError("Error canceling appointment");
            }
        }

        private void displayError(string message)
        {
            MessageBox.Show(
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void EditAppointmentPage_Load(object sender, EventArgs e)
        {

        }
    }
}