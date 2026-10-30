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
        private int? _patientId;
        private int? _addressId;

        public ViewPatientProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load patient data into the profile view. Call this after constructing the form.
        /// </summary>
        public void LoadPatient(int patientId)
        {
            _patientId = patientId;

            try
            {
                using var conn = new MySqlConnector.MySqlConnection(CS3230_Group5.DAL.Connection.ConnectionString());
                conn.Open();

                var sql = @"SELECT p.patient_id, p.first_name, p.last_name, p.date_of_birth, p.phone, p.gender, p.active,
                                   p.address_id, a.address1, a.address2, a.city, a.state, a.zip
                              FROM patient p
                              LEFT JOIN address a ON p.address_id = a.address_id
                              WHERE p.patient_id = @pid";

                using var cmd = new MySqlConnector.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", patientId);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var first = reader["first_name"]?.ToString() ?? string.Empty;
                    var last = reader["last_name"]?.ToString() ?? string.Empty;
                    patientNameLabel.Text = $"Patient's Profile - {first} {last}";

                    fnameLabel.Text = $"First Name: {first}";
                    lnameLabel.Text = $"Last Name: {last}";

                    if (reader["date_of_birth"] != DBNull.Value)
                        dobLabel.Text = $"Date of Birth: {Convert.ToDateTime(reader["date_of_birth"]):MM/dd/yyyy}";

                    phoneLabel.Text = $"Phone #: {reader["phone"]?.ToString() ?? string.Empty}";
                    patientIdLabel.Text = $"Patient ID: {reader["patient_id"]?.ToString() ?? string.Empty}";

                    _addressId = reader["address_id"] != DBNull.Value ? Convert.ToInt32(reader["address_id"]) : (int?)null;

                    var activeVal = reader["active"]?.ToString() ?? string.Empty;
                    radioButton1.Checked = (activeVal == "1" || activeVal.Equals("true", StringComparison.OrdinalIgnoreCase));

                    add1Label.Text = $"Address 1: {reader["address1"]?.ToString() ?? string.Empty}";
                    add2Label.Text = $"Address 2: {reader["address2"]?.ToString() ?? string.Empty}";
                    cityLabel.Text = $"City: {reader["city"]?.ToString() ?? string.Empty}";
                    stateLabel.Text = $"State: {reader["state"]?.ToString() ?? string.Empty}";
                    label2.Text = $"Zip: {reader["zip"]?.ToString() ?? string.Empty}";
                }
                else
                {
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var searchPatientsPage = new Patient_View.SearchPatientPage();
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

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            var createAppointment = new View.Nurse_View.CreateAppointmentPage();
            createAppointment.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var login = new View.LogInPage();
            login.Show();
            this.Hide();
        }
        private void ViewPatientProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
