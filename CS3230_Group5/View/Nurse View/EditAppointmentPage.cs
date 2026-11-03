using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class EditAppointmentPage : Form
    {
        private AppointmentDal _Appointment = new AppointmentDal();
        private Appointment selectedAppointment;
        private Dictionary<int,string> doctors = new Dictionary<int,string>();

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

            this.patientName.Text = selectedAppointment.PatientName;

            this.doctorComboBox.DataSource = new BindingSource(doctors, null);
            this.doctorComboBox.DisplayMember = "Value";
            this.doctorComboBox.ValueMember = "Key";
            for (int i = 0; i < doctors.Count; i++)
            {
                if (this.doctorComboBox.GetItemText(doctorComboBox.Items[i]) == selectedAppointment.DoctorName)
                {
                    this.doctorComboBox.SelectedIndex = i;
                    break;
                }
            }

            this.dateTimePicker.Value = selectedAppointment.DateTime;
            this.reasonTextBox.Text = selectedAppointment.Reason;
        }

        private void returnToViewAppointmentsPage()
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

            Close();
        }

        private void confirmAppointmentButton_Click(object sender, EventArgs e)
        {
            int doctorId = getSelectedDoctorId();

            if (doctorId == 0) 
            {
                //TODO implement error
                return;
            }
            Appointment updatedAppointment = new Appointment(selectedAppointment.AppointmentId,
                selectedAppointment.PatientId, doctorId, dateTimePicker.Value, reasonTextBox.Text);
            updatedAppointment.PatientName = patientName.Text;
            updatedAppointment.DoctorName = doctorComboBox.SelectedItem.ToString();
            string message = "";

            if (_Appointment.UpdateAppointment(updatedAppointment, out message))
            {
                selectedAppointment.DoctorName = updatedAppointment.DoctorName;
                selectedAppointment.DoctorId = updatedAppointment.DoctorId;
                selectedAppointment.DateTime = updatedAppointment.DateTime;
                selectedAppointment.Reason = updatedAppointment.Reason;

                //TODO implement successful save modal pop up


                returnToViewAppointmentsPage();
            }
            else
            {
                //TODO implement error message modal pop up
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
            //TODO Implement confirmation pop up

            if (_Appointment.DeleteAppointment(selectedAppointment.AppointmentId))
            {
                returnToViewAppointmentsPage();
            } else
            {
                //display error
            }
        }
    }
}
