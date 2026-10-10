using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class ViewNursesPage : Form
    {
        public ViewNursesPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var nurseHomePage = new View.NurseHomePage();
            nurseHomePage.Show();
            this.Hide();
        }

        private void addNurseButton_Click(object sender, EventArgs e)
        {
            //TODO switch to Add Nurse Page
        }

        private void profileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO switch to profile view of the current signed in nurse
        }
    }
}
