
using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using CS3230_Group5.View.Appointments_View;
using CS3230_Group5.View.Patient_View;

namespace CS3230_Group5.View.Nurse_View
{
    /// <summary>
    /// Provides the form for viewing, searching, editing, and managing appointments.
    /// </summary>
    public partial class ViewAppointmentsPage : Form
    {
        private AppointmentDal _appointmentDal = new AppointmentDal();
        private List<Appointment> appointments = new List<Appointment>();

        /// <summary>
        /// Initializes the appointments page, configures its controls, and loads appointments.
        /// </summary>
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

        /// <summary>
        /// Retrieves appointments from the database and displays them in the appointment list.
        /// </summary>
        /// <param name="filter">
        /// An optional search filter used to retrieve matching appointments.
        /// </param>
        public void PopulateAppointments(string? filter = null)
        {
            editButton.Enabled = false;
            viewSummaryButton.Enabled = false;

            appointmentList.Items.Clear();
            appointments.Clear();

            appointments.AddRange(_appointmentDal.GetAppointments(filter));

            foreach (Appointment appointment in appointments)
            {
                var item = new ListViewItem(appointment.AppointmentId.ToString());

                item.SubItems.Add(appointment.PatientName);
                item.SubItems.Add(appointment.DoctorName);
                item.SubItems.Add(
                    appointment.DateTime.ToString("MM-dd-yyyy h:mm tt") ?? string.Empty);
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

        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {
            NavigateTo(new CreateAppointmentPage());
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
                bool isEditable = isSelectedAppointmentEditable();

                editButton.Enabled = isEditable;
                viewSummaryButton.Enabled = isEditable;
            }
            else
            {
                editButton.Enabled = false;
            }
        }

        private bool isSelectedAppointmentEditable()
        {
            string appointmentDate = appointmentList.SelectedItems[0]
                .SubItems[3].Text.ToString().Substring(0, 10);

            string currDate = DateTime.Now.ToString("MM-dd-yyyy");

            return !appointmentDate.Equals(currDate);
        }

        private Appointment? getSelectedAppointment()
        {
            if (appointmentList.SelectedItems.Count == 0)
                return null;

            string selectedAppointmentId = appointmentList.SelectedItems[0].Text;

            foreach (Appointment appointment in appointments)
            {
                if (selectedAppointmentId == appointment.AppointmentId.ToString())
                {
                    return appointment;
                }
            }

            return null;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Appointment? selectedAppointment = getSelectedAppointment();

            if (selectedAppointment != null)
            {
                NavigateTo(new EditAppointmentPage(selectedAppointment));
            }
        }

        private void viewAppointment_Click(object sender, EventArgs e)
        {
            Appointment? selectedAppointment = getSelectedAppointment();

            if (selectedAppointment != null)
            {
                var detailsPage = new AppointmentDetailsPage(
                    selectedAppointment.AppointmentId);

                detailsPage.Show();
                Hide();
            }
        }

        private void ViewAppointmentsPage_Load(object sender, EventArgs e)
        {

        }
    }
}