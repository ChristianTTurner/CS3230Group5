using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using MySqlConnector;

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
            try
            {
                // gather values from form
                var firstName = patientFName.Text?.Trim();
                var lastName = patientLName.Text?.Trim();

                int month = (int)patientBirthMonth.Value;
                int day = (int)patientBirthDay.Value;
                int year = (int)patientBirthYear.Value;
                var dob = new DateTime(year, month, day);

                var phone = patientPhoneNumber.Text?.Trim();
                var address1 = patientAddress1.Text?.Trim();
                var address2 = patientAddress2.Text?.Trim();
                var city = patientCity.Text?.Trim();
                var state = patientState.SelectedItem?.ToString() ?? string.Empty;
                var zip = patientZip.Text?.Trim();
                var isActive = patientIsActive.Checked ? 1 : 0;

                using var conn = new MySqlConnection(Connection.ConnectionString());
                conn.Open();

                var sql = @"INSERT INTO patient
                    (first_name, last_name, dob, phone, address1, address2, city, state, zip, is_active)
                    VALUES
                    (@first, @last, @dob, @phone, @address1, @address2, @city, @state, @zip, @isActive)";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first", firstName);
                cmd.Parameters.AddWithValue("@last", lastName);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address1", address1);
                cmd.Parameters.AddWithValue("@address2", address2);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@zip", zip);
                cmd.Parameters.AddWithValue("@isActive", isActive);

                var rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var searchPatientsPage = new View.Nurse_View.SearchPatientPage();
                    searchPatientsPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No rows were inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
