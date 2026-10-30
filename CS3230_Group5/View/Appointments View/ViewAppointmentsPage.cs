
using CS3230_Group5.DAL;
using CS3230_Group5.View.Nurse_View;
using MySqlConnector;
using System;
using System.Windows.Forms;
using SearchPatientPage = CS3230_Group5.View.Patient_View.SearchPatientPage;

namespace CS3230_Group5.View.Appointments_View
{
    public partial class ViewAppointmentsPage : Form
    {
        public ViewAppointmentsPage()
        {
            InitializeComponent();

            appointmentDataGridView.AutoGenerateColumns = false;
            appointmentDataGridView.AllowUserToAddRows = false;
            appointmentDataGridView.ReadOnly = true;
            appointmentDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            appointmentDataGridView.MultiSelect = false;

            SearchErrorLabel.Text = "";
            SearchErrorLabel.Visible = false;

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
                var patients = new SearchPatientPage();
                patients.Show();
                this.Hide();
            };

            appointmentButton.Click += (s, e) =>
            {
                LoadAppointments();
            };

            logoutButton.Click += (s, e) =>
            {
                var login = new CS3230_Group5.View.LogInPage();
                login.Show();
                this.Hide();
            };

            createAppointmentButton.Click += (s, e) =>
            {
                var createAppointment = new CreateAppointmentPage();
                createAppointment.Show();
                this.Hide();
            };

            searchButton.Click += searchButton_Click;

            searchAppointmentTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SearchAppointments();
                }
            };

            searchAppointmentTextBox.TextChanged += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(searchAppointmentTextBox.Text))
                {
                    ClearSearchMessage();
                    LoadAppointments();
                }
            };

            btnView.UseColumnTextForButtonValue = true;

            appointmentDataGridView.CellContentClick +=
                appointmentDataGridView_CellContentClick;
        }

        private void ViewAppointmentsPage_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        /// <summary>
        /// Loads appointments and optionally filters by patient name,
        /// phone number, or date of birth.
        /// </summary>
        private void LoadAppointments(string search = "")
        {
            try
            {
                appointmentDataGridView.Rows.Clear();

                const string query = @"
                    SELECT
                        a.appointment_id,
                        CONCAT(p.first_name, ' ', p.last_name)
                            AS patient_name,
                        p.date_of_birth AS patient_dob,
                        CONCAT(d.first_name, ' ', d.last_name)
                            AS doctor_name,
                        a.datetime AS appointment_datetime,
                        a.reason
                    FROM appointment a
                    INNER JOIN patient p
                        ON a.patient_id = p.patient_id
                    INNER JOIN doctor d
                        ON a.doctor_id = d.doctor_id
                    WHERE CONCAT(p.first_name, ' ', p.last_name)
                              LIKE @search
                       OR p.first_name LIKE @search
                       OR p.last_name LIKE @search
                       OR p.phone LIKE @search
                       OR DATE_FORMAT(
                              p.date_of_birth, '%m/%d/%Y'
                          ) LIKE @search
                       OR DATE_FORMAT(
                              p.date_of_birth, '%Y-%m-%d'
                          ) LIKE @search
                    ORDER BY a.datetime DESC;";

                using var connection =
                    new MySqlConnection(
                        Connection.ConnectionString());

                connection.Open();

                using var command =
                    new MySqlCommand(query, connection);

                command.Parameters.Add(
                    "@search",
                    MySqlDbType.VarChar,
                    100
                ).Value = "%" + search.Trim() + "%";

                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int appointmentId =
                        reader.GetInt32("appointment_id");

                    string patientName =
                        reader["patient_name"]?.ToString() ?? "";

                    string patientDob = "";

                    if (!reader.IsDBNull(
                        reader.GetOrdinal("patient_dob")))
                    {
                        patientDob = reader
                            .GetDateTime("patient_dob")
                            .ToString("MM/dd/yyyy");
                    }

                    string doctorName =
                        reader["doctor_name"]?.ToString() ?? "";

                    string appointmentDateTime = "";

                    if (!reader.IsDBNull(
                        reader.GetOrdinal("appointment_datetime")))
                    {
                        appointmentDateTime = reader
                            .GetDateTime("appointment_datetime")
                            .ToString("MM/dd/yyyy h:mm tt");
                    }

                    string reason = "";

                    if (!reader.IsDBNull(
                        reader.GetOrdinal("reason")))
                    {
                        reason = reader.GetString("reason");
                    }

                    appointmentDataGridView.Rows.Add(
                        appointmentId,
                        patientName,
                        patientDob,
                        doctorName,
                        appointmentDateTime,
                        reason,
                        "View"
                    );
                }

                if (appointmentDataGridView.Rows.Count == 0)
                {
                    ShowSearchMessage(
                        string.IsNullOrWhiteSpace(search)
                            ? "No appointments are available."
                            : "No appointments found. Check your search and try again."
                    );
                }
                else
                {
                    ClearSearchMessage();
                }
            }
            catch (Exception ex)
            {
                ShowSearchMessage(
                    "Unable to load appointments: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles clicks on the Search button.
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchAppointments();
        }

        /// <summary>
        /// Validates and executes the appointment search.
        /// </summary>
        private void SearchAppointments()
        {
            string search =
                searchAppointmentTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(search))
            {
                ShowSearchMessage(
                    "Please enter a patient name, phone number, or date of birth.");

                searchAppointmentTextBox.Focus();
                return;
            }

            LoadAppointments(search);
        }

        /// <summary>
        /// Displays an error or information message beneath the search box.
        /// </summary>
        private void ShowSearchMessage(string message)
        {
            SearchErrorLabel.Text = message;
            SearchErrorLabel.Visible = true;
        }

        /// <summary>
        /// Clears the search message.
        /// </summary>
        private void ClearSearchMessage()
        {
            SearchErrorLabel.Text = "";
            SearchErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles clicks on the View button in the appointment grid.
        /// </summary>
        private void appointmentDataGridView_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (appointmentDataGridView
                .Columns[e.ColumnIndex].Name != "btnView")
            {
                return;
            }

            object idValue = appointmentDataGridView
                .Rows[e.RowIndex]
                .Cells["appointment_id"].Value;

            if (idValue == null ||
                !int.TryParse(idValue.ToString(), out int appointmentId))
            {
                ShowSearchMessage(
                    "Unable to identify the selected appointment.");
                return;
            }

            var detailsPage = new AppointmentDetailsPage(appointmentId);
            detailsPage.Show();
            this.Hide();
        }
    }
}
