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
    /// The SearchPatientPage class represents a form that allows users to search for patients in the database. It provides functionality to display a list 
    /// of patients, search for patients by name, and perform actions such as adding, editing, or deleting patient records.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchPatientPage : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPatientPage"/> class.
        /// </summary>
        public SearchPatientPage()
        {
            InitializeComponent();
            PopulatePatientList(null);

            homeButton.Click += (s, e) =>
            {
                var home = new homePageButton();
                home.Show();
                this.Hide();
            };

            nurseButton.Click += (s, e) =>
            {
                var nurses = new ViewNursesPage();
                nurses.Show();
                this.Hide();
            };

            patientsButton.Click += (s, e) =>
            {
                PopulatePatientList(null);
            };

            appointmentButton.Click += (s, e) =>
            {
                var createAppointment = new CreateAppointmentPage();
                createAppointment.Show();
                this.Hide();
            };

            logoutButton.Click += (s, e) =>
            {
                var login = new View.LogInPage();
                login.Show();
                this.Hide();
            };

            searchButton.Click += (s, e) =>
            {
                PopulatePatientList(searchPatientTextBox.Text.Trim());
            };
        }

        private void patientList_DoubleClick(object sender, EventArgs e)
        {
            if (patientList.SelectedItems.Count == 0)
                return;

            var selected = patientList.SelectedItems[0];
            if (!int.TryParse(selected.SubItems[0].Text, out int patientId))
            {
                MessageBox.Show("Invalid patient id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editForm = new CreatePatientPage();
            editForm.LoadForEdit(patientId);
            editForm.Show();
            this.Hide();
        }

        private void PopulatePatientList(string? filter = null)
        {
            try
            {
                patientList.Clear();
                patientList.View = System.Windows.Forms.View.Details;
                patientList.Columns.Add("ID", 60, HorizontalAlignment.Left);
                patientList.Columns.Add("First Name", 120, HorizontalAlignment.Left);
                patientList.Columns.Add("Last Name", 120, HorizontalAlignment.Left);
                patientList.Columns.Add("DOB", 100, HorizontalAlignment.Left);
                patientList.Columns.Add("Phone", 120, HorizontalAlignment.Left);
                patientList.Columns.Add("Gender", 80, HorizontalAlignment.Left);
                patientList.Columns.Add("Active", 60, HorizontalAlignment.Left);

                using var conn = new MySqlConnection(Connection.ConnectionString());
                conn.Open();
                string sql;
                using var cmd = new MySqlCommand();
                cmd.Connection = conn;
                if (string.IsNullOrWhiteSpace(filter))
                {
                    sql = "SELECT patient_id, first_name, last_name, date_of_birth, phone, gender, active FROM patient";
                    cmd.CommandText = sql;
                }
                else
                {
                    sql = "SELECT patient_id, first_name, last_name, date_of_birth, phone, gender, active FROM patient WHERE CONCAT(first_name, ' ', last_name) LIKE @filter OR first_name LIKE @filter OR last_name LIKE @filter";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@filter", $"%{filter}%");
                }
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["patient_id"]?.ToString() ?? string.Empty;
                    string first = reader["first_name"]?.ToString() ?? string.Empty;
                    string last = reader["last_name"]?.ToString() ?? string.Empty;
                    string dob = string.Empty;
                    if (reader["date_of_birth"] != DBNull.Value)
                    {
                        dob = Convert.ToDateTime(reader["date_of_birth"]).ToString("yyyy-MM-dd");
                    }
                    string phone = reader["phone"]?.ToString() ?? string.Empty;
                    string gender = reader["gender"]?.ToString() ?? string.Empty;
                    string active = reader["active"]?.ToString() ?? string.Empty;

                    var item = new ListViewItem(new[] { id, first, last, dob, phone, gender, active });
                    patientList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchPatientTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulatePatientList(searchPatientTextBox.Text.Trim());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var home = new homePageButton();
            home.Show();
            this.Hide();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            var createPatientPage = new View.Nurse_View.CreatePatientPage();
            createPatientPage.Show();
            this.Hide();
        }

        private void patientList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            deletePatientButton.Enabled = patientList.SelectedItems.Count > 0;
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            if (patientList.SelectedItems.Count == 0)
                return;

            var selected = patientList.SelectedItems[0];
            if (!int.TryParse(selected.SubItems[0].Text, out int patientId))
            {
                MessageBox.Show("Invalid patient id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"Delete patient #{patientId}? This action cannot be undone.", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var conn = new MySqlConnection(Connection.ConnectionString());
                conn.Open();
                using var tran = conn.BeginTransaction();

                int? addressId = null;
                using (var getAddr = new MySqlCommand("SELECT address_id FROM patient WHERE patient_id = @pid", conn, tran))
                {
                    getAddr.Parameters.AddWithValue("@pid", patientId);
                    var res = getAddr.ExecuteScalar();
                    if (res != null && res != DBNull.Value)
                        addressId = Convert.ToInt32(res);
                }

                using (var del = new MySqlCommand("DELETE FROM patient WHERE patient_id = @pid", conn, tran))
                {
                    del.Parameters.AddWithValue("@pid", patientId);
                    del.ExecuteNonQuery();
                }


                if (addressId.HasValue)
                {
                    using var delAddr = new MySqlCommand("DELETE FROM address WHERE address_id = @aid", conn, tran);
                    delAddr.Parameters.AddWithValue("@aid", addressId.Value);
                    delAddr.ExecuteNonQuery();
                }

                tran.Commit();

                patientList.Items.Remove(selected);
                deletePatientButton.Enabled = false;
                MessageBox.Show("Patient deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchPatientPage_Load(object sender, EventArgs e)
        {

        }
    }
}
