
using System;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Admin_View
{
    /// <summary>
    /// Shows the administrator statistics report for a chosen date range.
    /// Only administrators can open this page.
    /// </summary>
    public partial class AdminStatisticsPage : Form
    {
        private readonly AdminStatisticsDal _statisticsDal =
            new AdminStatisticsDal();

        private readonly Form? _previousPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminStatisticsPage"/> class.
        /// </summary>
        public AdminStatisticsPage() : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminStatisticsPage"/> class.
        /// </summary>
        /// <param name="previousPage">The previous page.</param>
        public AdminStatisticsPage(Form? previousPage)
        {
            InitializeComponent();

            _previousPage = previousPage;

            generateStatsButton.Click += GenerateStatsButton_Click;
            backButton.Click += BackButton_Click;

            testStatsListView.View = System.Windows.Forms.View.Details;
            testStatsListView.FullRowSelect = true;
            testStatsListView.MultiSelect = false;
            testStatsListView.Columns.Clear();

            testStatsListView.Columns.Add("Code", 60, HorizontalAlignment.Left);
            testStatsListView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            testStatsListView.Columns.Add("Times Performed", 140, HorizontalAlignment.Left);
            testStatsListView.Columns.Add("Percentage", 100, HorizontalAlignment.Left);
            testStatsListView.Columns.Add("Normal", 80, HorizontalAlignment.Left);
            testStatsListView.Columns.Add("AbNormal", 100, HorizontalAlignment.Left);

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

        private void GenerateStatsButton_Click(object? sender, EventArgs e)
        {
            testStatsListView.Items.Clear();
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

                populateTestStatsGridView(statistics);

                if (testStatsListView.Items.Count == 0)
                {
                    MessageBox.Show(
                    "No tests performed during this time period.\n\n",
                    "No qualifying tests",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
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
            foreach (var stat in stats.TestStatistics)
            {
                var item = new ListViewItem(stat.Code);

                item.SubItems.Add(stat.Name);
                item.SubItems.Add(stat.NumPerformed.ToString());
                item.SubItems.Add($"{Math.Round(stat.Percentage, 2)}%");
                item.SubItems.Add(stat.NumNormalResults.ToString());
                item.SubItems.Add(stat.NumAbnormalResults.ToString());

                testStatsListView.Items.Add(item);
            }

        }
        private void ResetStatistics()
        {
            totalTestsPerformedValueLabel.Text = "0";
            totalAbnormalResultsValueLabel.Text = "0";
            totalNormalResultsValueLabel.Text = "0";
            testStatsListView.Items.Clear();
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
