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
    /// <summary>
    /// The CreatePatientPage class represents a form for creating or editing patient records 
    /// in the application. It provides functionality to load existing patient data for editing, as well as to add new patients to the database. 
    /// The form includes fields for patient information such as name, date of birth, phone number, address, gender, and active status.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CreatePatientPage : Form
    {
        private int? editingPatientId = null;
        private int? editingAddressId = null;
        private bool isEditMode = false;

        public void LoadForEdit(int patientId)
        {
            try
            {
                using var conn = new MySqlConnection(Connection.ConnectionString());
                conn.Open();

                var sql = @"SELECT p.patient_id, p.first_name, p.last_name, p.date_of_birth, p.phone, p.gender, p.active,
                                  p.address_id, a.address1, a.address2, a.city, a.state, a.zip
                             FROM patient p
                             LEFT JOIN address a ON p.address_id = a.address_id
                             WHERE p.patient_id = @pid";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", patientId);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    editingPatientId = patientId;
                    editingAddressId = reader["address_id"] != DBNull.Value ? Convert.ToInt32(reader["address_id"]) : (int?)null;

                    patientFName.Text = reader["first_name"]?.ToString() ?? string.Empty;
                    patientLName.Text = reader["last_name"]?.ToString() ?? string.Empty;

                    if (reader["date_of_birth"] != DBNull.Value)
                    {
                        var dob = Convert.ToDateTime(reader["date_of_birth"]);
                        patientBirthMonth.Value = dob.Month;
                        patientBirthDay.Value = dob.Day;
                        patientBirthYear.Value = Math.Max(patientBirthYear.Minimum, Math.Min(patientBirthYear.Maximum, dob.Year));
                    }

                    patientPhoneNumber.Text = reader["phone"]?.ToString() ?? string.Empty;
                    patientAddress1.Text = reader["address1"]?.ToString() ?? string.Empty;
                    patientAddress2.Text = reader["address2"]?.ToString() ?? string.Empty;
                    patientCity.Text = reader["city"]?.ToString() ?? string.Empty;

                    var stateVal = reader["state"]?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(stateVal))
                    {
                        try { patientState.SelectedItem = stateVal; } catch { }
                    }

                    patientZip.Text = reader["zip"]?.ToString() ?? string.Empty;

                    var genderVal = reader["gender"]?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(genderVal))
                    {
                        try { patientGender.SelectedItem = genderVal; } catch { }
                    }

                    var activeVal = reader["active"]?.ToString() ?? string.Empty;
                    patientIsActive.Checked = (activeVal == "1" || activeVal.Equals("true", StringComparison.OrdinalIgnoreCase));

                    isEditMode = true;
                    addPatientButton.Text = "Update";
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
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePatientPage"/> class.
        /// </summary>
        public CreatePatientPage()
        {
            InitializeComponent();

            patientIsActive.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is View.Nurse_View.SearchPatientPage search)
                {
                    search.Show();
                    Close();
                    return;
                }
            }

            var newSearch = new View.Nurse_View.SearchPatientPage();
            newSearch.Show();
            Close();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            try
            {

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

                if (isEditMode && editingPatientId.HasValue)
                {
                    if (editingAddressId.HasValue)
                    {
                        var updateAddressSql = @"UPDATE address
                                                 SET address1 = @a1, address2 = @a2, city = @city, state = @state, zip = @zip
                                                 WHERE address_id = @aid";
                        using var updateAddrCmd = new MySqlCommand(updateAddressSql, conn);
                        updateAddrCmd.Parameters.AddWithValue("@a1", address1);
                        updateAddrCmd.Parameters.AddWithValue("@a2", address2);
                        updateAddrCmd.Parameters.AddWithValue("@city", city);
                        updateAddrCmd.Parameters.AddWithValue("@state", state);
                        updateAddrCmd.Parameters.AddWithValue("@zip", zip);
                        updateAddrCmd.Parameters.AddWithValue("@aid", editingAddressId.Value);
                        updateAddrCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        var insertAddressSql = @"INSERT INTO address (address1, address2, city, state, zip)
                    VALUES (@a1, @a2, @city, @state, @zip)";
                        using var addrCmd = new MySqlCommand(insertAddressSql, conn);
                        addrCmd.Parameters.AddWithValue("@a1", address1);
                        addrCmd.Parameters.AddWithValue("@a2", address2);
                        addrCmd.Parameters.AddWithValue("@city", city);
                        addrCmd.Parameters.AddWithValue("@state", state);
                        addrCmd.Parameters.AddWithValue("@zip", zip);
                        addrCmd.ExecuteNonQuery();

                        var getNewAddressIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn);
                        var newAddressIdObj = getNewAddressIdCmd.ExecuteScalar();
                        editingAddressId = Convert.ToInt32(newAddressIdObj);
                    }

                    var updatePatientSql = @"UPDATE patient
                                             SET first_name = @first, last_name = @last, date_of_birth = @date_of_birth, phone = @phone, address_id = @addressId, gender = @gender, active = @active
                                             WHERE patient_id = @pid";

                    using var updatePatientCmd = new MySqlCommand(updatePatientSql, conn);
                    updatePatientCmd.Parameters.AddWithValue("@first", firstName);
                    updatePatientCmd.Parameters.AddWithValue("@last", lastName);
                    updatePatientCmd.Parameters.AddWithValue("@date_of_birth", dob);
                    updatePatientCmd.Parameters.AddWithValue("@phone", phone);
                    updatePatientCmd.Parameters.AddWithValue("@addressId", editingAddressId.HasValue ? editingAddressId.Value : DBNull.Value);
                    updatePatientCmd.Parameters.AddWithValue("@gender", gender);
                    updatePatientCmd.Parameters.AddWithValue("@active", isActive);
                    updatePatientCmd.Parameters.AddWithValue("@pid", editingPatientId.Value);

                    var updatedRows = updatePatientCmd.ExecuteNonQuery();
                    if (updatedRows > 0)
                    {
                        MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var searchPatientsPage = new View.Nurse_View.SearchPatientPage();
                        searchPatientsPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return;
                }


                var insertAddressSqlNew = @"INSERT INTO address (address1, address2, city, state, zip)
                    VALUES (@a1, @a2, @city, @state, @zip)";
                using var addrCmdNew = new MySqlCommand(insertAddressSqlNew, conn);
                addrCmdNew.Parameters.AddWithValue("@a1", address1);
                addrCmdNew.Parameters.AddWithValue("@a2", address2);
                addrCmdNew.Parameters.AddWithValue("@city", city);
                addrCmdNew.Parameters.AddWithValue("@state", state);
                addrCmdNew.Parameters.AddWithValue("@zip", zip);
                addrCmdNew.ExecuteNonQuery();

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

        private void createPatientLabel_Click(object sender, EventArgs e)
        {

        }

        private void dashboardTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
