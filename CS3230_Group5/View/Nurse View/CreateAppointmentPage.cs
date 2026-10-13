using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class CreateAppointmentPage : Form
    {
        public CreateAppointmentPage()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var patientProfilePage = new View.Nurse_View.ViewPatientProfile();
            patientProfilePage.Show();
            this.Hide();
        }

        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {
            //TODO book appointment
            //TODO return to patients profile
        }
    }
}
