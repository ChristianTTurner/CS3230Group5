
using System;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Admin_View
{
    public partial class AdminStatisticsPage : Form
    {
        private readonly AdminStatisticsDal _statisticsDal =
            new AdminStatisticsDal();

        private readonly Form? _previousPage;

        public AdminStatisticsPage() : this(null)
        {
        }

        public AdminStatisticsPage(Form? previousPage)
        {
            InitializeComponent();

            _previousPage = previousPage;

            generateStatsButton.Click += GenerateStatsButton_Click;
            backButton.Click += BackButton_Click;
        }

        private void AdminStatisticsPage_Load(object sender, EventArgs e)
        {
            if (!SignedInUser.IsAdmin)
            {
                MessageBox.Show(
                    "Only administrators can access statistics.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            startDateTimePicker.Value =
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            endDateTimePicker.Value = DateTime.Today;

            ResetStatistics();
        }

        private void GenerateStatsButton_Click(
            object? sender, EventArgs e)
        {
            DateTime startDate = startDateTimePicker.Value.Date;
            DateTime endDate = endDateTimePicker.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show(
                    "Start date cannot be after the end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                AdminStatistics statistics =
                    _statisticsDal.GetStatistics(startDate, endDate);

                totalAppointmentsValueLabel.Text =
                    statistics.TotalAppointments.ToString();

                uniquePatientsValueLabel.Text =
                    statistics.UniquePatients.ToString();

                completedCheckupsValueLabel.Text =
                    statistics.CompletedCheckups.ToString();

                testsOrderedValueLabel.Text =
                    statistics.TestsOrdered.ToString();

                testsPerformedValueLabel.Text =
                    statistics.TestsPerformed.ToString();

                abnormalResultsValueLabel.Text =
                    statistics.AbnormalResults.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to retrieve statistics.\n\n" + ex.Message,
                    "Statistics Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ResetStatistics()
        {
            totalAppointmentsValueLabel.Text = "0";
            uniquePatientsValueLabel.Text = "0";
            completedCheckupsValueLabel.Text = "0";
            testsOrderedValueLabel.Text = "0";
            testsPerformedValueLabel.Text = "0";
            abnormalResultsValueLabel.Text = "0";
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            if (_previousPage != null)
            {
                _previousPage.Show();
            }
            else
            {
                var homePage = new homePageButton();
                homePage.Show();
            }

            Close();
        }
    }
}
