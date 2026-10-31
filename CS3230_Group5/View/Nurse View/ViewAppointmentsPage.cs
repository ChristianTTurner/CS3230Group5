using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class ViewAppointmentsPage : Form
    {
        private AppointmentDal _appointmentDal = new AppointmentDal();

        public ViewAppointmentsPage()
        {
            InitializeComponent();
            initializeMenuButtons();
            configureAppointmentList();

            PopulateAppointments();
        }


        private void initializeMenuButtons()
        {
            homeButton.Click += (s, e) => NavigateTo(new homePageButton());
            nurseButton.Click += (s, e) => NavigateTo(new ViewNursesPage());
            patientsButton.Click += (s, e) => NavigateTo(new SearchPatientPage());
            appointmentButton.Click += (s, e) => PopulateAppointments();
            logoutButton.Click += (s, e) => NavigateTo(new LogInPage());
        }

        private void NavigateTo(Form nextForm)
        {
            nextForm.Show();
            Hide();
        }

        private void configureAppointmentList()
        {
            appointmentList.View = System.Windows.Forms.View.Details;
            appointmentList.FullRowSelect = true;
            appointmentList.MultiSelect = false;
            appointmentList.Columns.Clear();
            appointmentList.Columns.Add("ID", 60, HorizontalAlignment.Left);
            appointmentList.Columns.Add("Patient", 120, HorizontalAlignment.Left);
            appointmentList.Columns.Add("Doctor", 120, HorizontalAlignment.Left);
            appointmentList.Columns.Add("Date Time", 100, HorizontalAlignment.Left);
            appointmentList.Columns.Add("Reason", 200, HorizontalAlignment.Left);
        }

        private void PopulateAppointments(string? filter = null)
        {
            appointmentList.Items.Clear();

            foreach (Appointment appointment in _appointmentDal.GetAppointments(filter))
            {
                var item = new ListViewItem(appointment.AppointmentID.ToString());
                item.SubItems.Add(appointment.PatientName);
                item.SubItems.Add(appointment.DoctorName);
                item.SubItems.Add(appointment.DateTime?.ToString("MM-dd-yyyy h:mm tt") ?? string.Empty);
                item.SubItems.Add(appointment.Reason);
                appointmentList.Items.Add(item);
            }

            autoResizeAppointmentColumns();
        }

        private void autoResizeAppointmentColumns()
        {
            foreach (ColumnHeader column in appointmentList.Columns)
            {
                column.Width = -2;
            }
        }

        private void searchAppointmentTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateAppointments(searchAppointmentTextBox.Text);
        }

        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {
            NavigateTo(new CreateAppointmentPage());
        }
    }
}
