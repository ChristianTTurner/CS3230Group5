using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View
{
    public partial class NurseHomePage : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SignedInID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAdmin { get; set; }

        public NurseHomePage()
        {
            InitializeComponent();

            if (IsAdmin) 
            {
                nurseHomePageTitle.Text = "Admin @ Healthcare Provider";
            }
        }

        private void profileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form2 = new ProfilePage();
            form2.ProfileID = SignedInID;
            form2.IsAdmin = IsAdmin;

            form2.Show();
            this.Hide();
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
