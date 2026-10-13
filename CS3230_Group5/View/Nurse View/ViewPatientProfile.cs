using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class ViewPatientProfile : Form
    {
        public ViewPatientProfile()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var searchPatientsPage = new View.Nurse_View.SearchPatientPage();
            searchPatientsPage.Show();
            this.Hide();
        }

        private void setUpAppointmentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var createAppointment = new View.Nurse_View.CreateAppointmentPage();
            createAppointment.Show();
            this.Hide();
        }

        private void editPatientProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO open edit page for patient
        }
    }
}
