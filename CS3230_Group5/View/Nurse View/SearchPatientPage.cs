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
    public partial class SearchPatientPage : Form
    {
        public SearchPatientPage()
        {
            InitializeComponent();
            PopulatePatientList(null);
        }

        private void PopulatePatientList(string filter = null)
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
            var nurseHomePage = new View.NurseHomePage();
            nurseHomePage.Show();
            this.Hide();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            var createPatientPage = new View.Nurse_View.CreatePatientPage();
            createPatientPage.Show();
            this.Hide();
        }
    }
}
