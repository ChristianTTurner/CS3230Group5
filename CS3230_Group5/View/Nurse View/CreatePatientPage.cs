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
                var gender = patientGender.SelectedItem?.ToString() ?? string.Empty;
                var isActive = patientIsActive.Checked ? 1 : 0;

                using var conn = new MySqlConnection(Connection.ConnectionString());
                conn.Open();

                // Insert address row and get its id
                var insertAddressSql = @"INSERT INTO address (address1, address2, city, state, zip)
                    VALUES (@a1, @a2, @city, @state, @zip)";
                using var addrCmd = new MySqlCommand(insertAddressSql, conn);
                addrCmd.Parameters.AddWithValue("@a1", address1);
                addrCmd.Parameters.AddWithValue("@a2", address2);
                addrCmd.Parameters.AddWithValue("@city", city);
                addrCmd.Parameters.AddWithValue("@state", state);
                addrCmd.Parameters.AddWithValue("@zip", zip);
                addrCmd.ExecuteNonQuery();

                var getIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn);
                var addressIdObj = getIdCmd.ExecuteScalar();
                var addressId = Convert.ToInt32(addressIdObj);

                var sql = @"INSERT INTO patient
                    (first_name, last_name, date_of_birth, phone, address_id, gender, active)
                    VALUES
                    (@first, @last, @date_of_birth, @phone, @addressId, @gender, @active)";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first", firstName);
                cmd.Parameters.AddWithValue("@last", lastName);
                cmd.Parameters.AddWithValue("@date_of_birth", dob);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@addressId", addressId);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@active", isActive);

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
