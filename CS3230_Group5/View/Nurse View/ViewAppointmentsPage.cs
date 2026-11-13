using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using CS3230_Group5.View.Appointments_View;
using CS3230_Group5.View.Patient_View;
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
        private List<Appointment> appointments = new List<Appointment>();

        public ViewAppointmentsPage()
        {
            InitializeComponent();
            editButton.Enabled = false;
            viewSummaryButton.Enabled = false;
            initializeMenuButtons();
            configureAppointmentList();

            PopulateAppointments();
        }


        private void initializeMenuButtons()
        {
            homeButton.Click += (s, e) => NavigateTo(new homePageButton());
            nurseButton.Click += (s, e) => NavigateTo(new ViewNursesPage());
            nurseButton.Visible = SignedInUser.IsAdmin;
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

        public void PopulateAppointments(string? filter = null)
        {
            this.editButton.Enabled = false;
            this.viewSummaryButton.Enabled = false;

            appointmentList.Items.Clear();
            appointments.Clear();

            appointments.AddRange(_appointmentDal.GetAppointments(filter));

            foreach (Appointment appointment in appointments)
            {
                var item = new ListViewItem(appointment.AppointmentId.ToString());
                item.SubItems.Add(appointment.PatientName);
                item.SubItems.Add(appointment.DoctorName);
                item.SubItems.Add(appointment.DateTime.ToString("MM-dd-yyyy h:mm tt") ?? string.Empty);
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
            enableEditAndSummaryButtons();
        }

        private void appointmentList_Click(object sender, EventArgs e)
        {
            enableEditAndSummaryButtons();
        }

        private void appointmentList_Leave(object sender, EventArgs e)
        {
            enableEditAndSummaryButtons();
        }

        private void enableEditAndSummaryButtons()
        {
            if (appointmentList.SelectedItems.Count > 0)
            {
                string appointmentDate = appointmentList.SelectedItems[0].SubItems[3].Text.ToString().Substring(0, 10);
                string currDate = DateTime.Now.ToString("MM-dd-yyyy");
                bool isEditable = !appointmentDate.Equals(currDate);

                editButton.Enabled = isEditable;
                viewSummaryButton.Enabled = isEditable;
            }
            else
            {
                editButton.Enabled = false;
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (appointmentList.SelectedItems.Count > 0)
            {
                var selectedAppointment = appointmentList.SelectedItems[0];

                for (int i = 0; i < appointments.Count; i++)
                {
                    bool equal = selectedAppointment.Text == appointments[i].AppointmentId.ToString();

                    if (equal)
                    {
                        NavigateTo(new EditAppointmentPage(appointments[i]));
                        break;
                    }
                }

            }
        }

        private void viewAppointment_Click(object sender, EventArgs e)
        {
            if (appointmentList.SelectedItems.Count > 0)
            {
                var selectedAppointment = appointmentList.SelectedItems[0];

                for (int i = 0; i < appointments.Count; i++)
                {
                    bool equal = selectedAppointment.Text == appointments[i].AppointmentId.ToString();

                    if (equal)
                    {
                        var detailsPage = new AppointmentDetailsPage(appointments[i].AppointmentId);
                        detailsPage.Show();
                        this.Hide(); break;
                    }
                }

            }
        }
    }
}
