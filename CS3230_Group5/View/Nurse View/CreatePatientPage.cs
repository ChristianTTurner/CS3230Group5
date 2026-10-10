using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class CreatePatientPage : Form
    {
        public CreatePatientPage()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var searchPatientsPage = new View.Nurse_View.SearchPatientPage();
            searchPatientsPage.Show();
            this.Hide();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            //TODO add Patient to database
            //TODO exit to Patients profile or search patients page
        }
    }
}
