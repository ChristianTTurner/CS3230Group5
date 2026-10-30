using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class ViewAppointmentsPage : Form
    {
        public ViewAppointmentsPage()
        {
            InitializeComponent();
            initializeMenuButtons();
        }


        private void initializeMenuButtons()
        {
            homeButton.Click += (s, e) => NavigateTo(new homePageButton());
            nurseButton.Click += (s, e) => NavigateTo(new ViewNursesPage());
            patientsButton.Click += (s, e) => NavigateTo(new SearchPatientPage());
            //appointmentButton.Click += (s, e) => PopulateAppointments();
            logoutButton.Click += (s, e) => NavigateTo(new LogInPage());
        }

        private void NavigateTo(Form nextForm)
        {
            nextForm.Show();
            Hide();
        }
    }
}
