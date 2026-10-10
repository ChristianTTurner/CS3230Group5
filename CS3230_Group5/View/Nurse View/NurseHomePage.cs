using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View
{
    public partial class NurseHomePage : Form
    {
        public NurseHomePage()
        {
            InitializeComponent();
        }

        private void profileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO switch to view the signed in nurses profile
        }

        private void viewPatientsButton_Click(object sender, EventArgs e)
        {
            Form viewPatients = new View.Nurse_View.SearchPatientPage();
            viewPatients.Show();
            this.Hide();
        }

        private void viewNursesButton_Click(object sender, EventArgs e)
        {
            var viewNurses = new View.Nurse_View.ViewNursesPage();
            viewNurses.Show();
            this.Hide();
        }
    }
}
