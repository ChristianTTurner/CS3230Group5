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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListViewItem SelectedItem { get; set; }

        private AppointmentDal _Appointment = new AppointmentDal();
        private Appointment selectedAppointment;

        public EditAppointmentPage(ListViewItem selectedItem)
        {
            InitializeComponent();
            patientName.Enabled = false;
            SelectedItem = selectedItem;
            convertToAppointment(SelectedItem);
            populateDynamicFields();
        }

        private void convertToAppointment(ListViewItem item)
        {
            var appointmentId = 0;
            var patientName = "";
            var doctorName = "";
            DateTime date = DateTime.MinValue;
            var reason = "";

            if (item != null)
            {
                appointmentId = int.Parse(item.SubItems[0].Text);
                patientName = item.SubItems[1].Text;
                doctorName = item.SubItems[2].Text;
                date = DateTime.ParseExact(item.SubItems[3].Text, "MM-dd-yyyy h:mm tt", CultureInfo.InvariantCulture);
                reason = item.SubItems[4].Text;
            }

            selectedAppointment = new Appointment(appointmentId, patientName, doctorName, date, reason);
        }

        private void populateDynamicFields()
        {
            var doctors = _Appointment.GetDoctors();

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            returnToViewAppointmentsPage();
        }
        private void returnToViewAppointmentsPage()
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is ViewAppointmentsPage viewAppointments)
                {
                    viewAppointments.Show();
                    viewAppointments.BringToFront();
                    break;
                }
            }

            Close();
        }
    }
}
