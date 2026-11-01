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
        public ListViewItem SelectedItem {  get; set; }

        private Appointment selectedAppointment;

        public EditAppointmentPage(ListViewItem selectedItem)
        {
            InitializeComponent();
            SelectedItem = selectedItem;
            convertToAppointment(SelectedItem);
        }

        private void convertToAppointment(ListViewItem item)
        {
            var appointmentId = 0;
            var patientName = "";
            var doctorName = "";
            DateTime date = DateTime.MinValue;
            var reason = "";
            
            if (item != null) {
                appointmentId = int.Parse(item.SubItems[0].Text);
                patientName = item.SubItems[1].Text;
                doctorName = item.SubItems[2].Text;
                date = DateTime.ParseExact(item.SubItems[3].Text, "MM-dd-yyyy h:mm tt", CultureInfo.InvariantCulture);
                reason = item.SubItems[4].Text;
            }

            selectedAppointment = new Appointment(appointmentId, patientName, doctorName,date, reason);
        }
    }
}
