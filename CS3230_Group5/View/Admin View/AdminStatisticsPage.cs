
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

                totalTestsPerformedValueLabel.Text =
                    statistics.TotalTestsPerformed.ToString();

                totalAbnormalResultsValueLabel.Text =
                    statistics.NumAbnormalResults.ToString();

                totalNormalResultsValueLabel.Text =
                    statistics.NumNormalResults.ToString();

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

        private void populateTestStatsGridView(AdminStatistics stats)
        {
            testStatisticsGridView.Rows.Add(new object[] { "Code", "Name", "Times Performed", "Percentage" });

            var hepaStats = new object[] { "HEPA", "Hepatitis A Test", stats.TotalHEPATestsPerformed, stats.HEPATestPercentage };
            var hepbStats = new object[] { "HEPB", "Hepatitis B Test", stats.TotalHEPBTestsPerformed, stats.HEPBTestPercentage };
            var LDLStats = new object[] { "LDL", "Low Density Lipoproteins", stats.TotalLDLTestsPerformed, stats.LDLTestPercentage };
            var WBCStats = new object[] { "WBC", "White Blood Cell Count", stats.TotalWBCTestsPerformed, stats.WBCTestPercentage};

            var testStats = new object[] { hepaStats, hepbStats, LDLStats, WBCStats};

            testStatisticsGridView.Rows.Add(hepaStats);
            testStatisticsGridView.Rows.Add(hepbStats);
            testStatisticsGridView.Rows.Add(LDLStats);
            testStatisticsGridView.Rows.Add(WBCStats);
        }
        private void ResetStatistics()
        {
            totalTestsPerformedValueLabel.Text = "0";
            totalAbnormalResultsValueLabel.Text = "0";
            totalNormalResultsValueLabel.Text = "0";
            testStatisticsGridView.Rows.Clear();
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
