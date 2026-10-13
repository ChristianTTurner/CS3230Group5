using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class SearchPatientPage : Form
    {
        public SearchPatientPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var nurseHomePage = new View.NurseHomePage();
            nurseHomePage.Show();
            this.Hide();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            var createPatientPage = new View.Nurse_View.CreatePatientPage();
            createPatientPage.Show();
            this.Hide();
        }
    }
}
