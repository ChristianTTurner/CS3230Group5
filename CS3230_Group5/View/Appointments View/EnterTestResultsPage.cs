using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CS3230_Group5.View.Appointments_View
{
    /// <summary>
    /// Lets a nurse enter the performed date/time and result for each test
    /// ordered during a visit. Becomes read-only once a final diagnosis exists.
    /// </summary>
    public partial class EnterTestResultsPage : Form
    {
        private const string DateTimeFormat = "MM/dd/yyyy h:mm tt";

        private readonly int _appointmentId;
        private readonly OrderedTestDal _testDal = new OrderedTestDal();

        private List<OrderedTest> _tests = new List<OrderedTest>();
        private DateTime _appointmentDateTime;
        private bool _isLocked;

        public EnterTestResultsPage(int appointmentId)
        {
            InitializeComponent();

            if (appointmentId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            }

            _appointmentId = appointmentId;

            ConfigureList();
            ConfigureInputs();
            ClearErrors();
            AttachEventHandlers();
        }

        private void ConfigureList()
        {
            testsListView.Columns.Clear();
            testsListView.Columns.Add("Code", 70);
            testsListView.Columns.Add("Test", 230);
            testsListView.Columns.Add("Normal Range", 200);
            testsListView.Columns.Add("Performed", 140);
            testsListView.Columns.Add("Result", 120);
            testsListView.Columns.Add("Status", 90);
        }

        private void ResizeListColumns()
        {
            int total = testsListView.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;

            if (total <= 0 || testsListView.Columns.Count != 6)
            {
                return;
            }

            double[] share = { 0.07, 0.25, 0.21, 0.20, 0.15, 0.12 };

            for (int i = 0; i < share.Length; i++)
            {
                testsListView.Columns[i].Width = (int)(total * share[i]);
            }
        }

        private void ConfigureInputs()
        {
            resultTextBox.MaxLength = 255;

            abnormalComboBox.Items.Clear();
            abnormalComboBox.Items.Add("Normal");
            abnormalComboBox.Items.Add("Abnormal");

            performedPicker.Value = NowToTheMinute();
            SetEditorEnabled(false);
            SetAbnormalRowVisible(false);

            CancelButton = closeButton;
        }

        private void AttachEventHandlers()
        {
            testsListView.SelectedIndexChanged += (s, e) => ShowEditorForSelection();
            testsListView.SizeChanged += (s, e) => ResizeListColumns();
            saveButton.Click += saveButton_Click;
            closeButton.Click += (s, e) => Close();

            resultTextBox.TextChanged += (s, e) => ClearError(resultErrorLabel);
            performedPicker.ValueChanged += (s, e) => ClearError(performedErrorLabel);
            abnormalComboBox.SelectedIndexChanged += (s, e) => ClearError(abnormalErrorLabel);
        }

        private void EnterTestResultsPage_Load(object? sender, EventArgs e)
        {
            ResizeListColumns();
            LoadVisit(null);
        }


        private void LoadVisit(string? reselectTestCode)
        {
            try
            {
                VisitHeader? header = _testDal.GetVisitHeader(_appointmentId);

                if (header == null)
                {
                    MessageBox.Show(
                        "The selected appointment could not be found.",
                        "Appointment Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    BeginInvoke(new Action(Close));
                    return;
                }

                _appointmentDateTime = header.AppointmentDateTime;
                _isLocked = header.IsFinalized;

                ShowHeader(header);

                _tests = _testDal.GetOrderedTests(_appointmentId);
                FillList(reselectTestCode);
                ShowNotice();
                ShowEditorForSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load the test results: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowHeader(VisitHeader header)
        {
            patientInfoLabel.Text =
                $"Patient: {header.PatientName}      DOB: {header.PatientDateOfBirth:MM/dd/yyyy}";

            visitInfoLabel.Text =
                $"Doctor: {header.DoctorName}      " +
                $"Nurse: {header.NurseName ?? "Not recorded"}      " +
                $"Visit: {header.AppointmentDateTime.ToString(DateTimeFormat)}";
        }

        private void FillList(string? selectTestCode)
        {
            testsListView.BeginUpdate();
            testsListView.Items.Clear();

            foreach (OrderedTest test in _tests)
            {
                var item = new ListViewItem(test.TestCode) { Tag = test };
                item.SubItems.Add(test.TestName);
                item.SubItems.Add(test.NormalRangeText);
                item.SubItems.Add(test.PerformedDateTime?.ToString(DateTimeFormat) ?? "Not performed");
                item.SubItems.Add(test.HasResult ? FormatResult(test) : "Not entered");
                item.SubItems.Add(test.StatusText);

                if (test.HasResult && test.Abnormal == true)
                {
                    item.ForeColor = Color.Firebrick;
                }

                testsListView.Items.Add(item);

                if (test.TestCode == selectTestCode)
                {
                    item.Selected = true;
                }
            }

            testsListView.EndUpdate();
        }

        private static string FormatResult(OrderedTest test)
        {
            return $"{test.Result} {test.UnitMeasurement}".Trim();
        }

        private void ShowNotice()
        {
            string notice = string.Empty;

            if (_isLocked)
            {
                notice = "A final diagnosis has been entered, so this visit is read-only.";
            }
            else if (_tests.Count == 0)
            {
                notice = "No tests have been ordered for this visit.";
            }

            noticeLabel.Text = notice;
            noticeLabel.Visible = notice.Length > 0;
        }


        private OrderedTest? GetSelectedTest()
        {
            if (testsListView.SelectedItems.Count == 0)
            {
                return null;
            }

            return testsListView.SelectedItems[0].Tag as OrderedTest;
        }

        private void ShowEditorForSelection()
        {
            ClearErrors();

            OrderedTest? test = GetSelectedTest();

            if (test == null)
            {
                selectedTestLabel.Text = _tests.Count == 0
                    ? string.Empty
                    : "Select a test above to enter its result.";
                rangeLabel.Text = string.Empty;
                unitLabel.Text = string.Empty;
                resultTextBox.Text = string.Empty;
                abnormalComboBox.SelectedIndex = -1;
                SetAbnormalRowVisible(false);
                SetEditorEnabled(false);
                return;
            }

            selectedTestLabel.Text = $"{test.TestCode} - {test.TestName}";

            rangeLabel.Text = test.HasRange
                ? $"Normal range: {test.NormalRangeText}. Normal or abnormal is worked out automatically."
                : "This test has no normal range. Choose whether the result is normal or abnormal.";

            unitLabel.Text = test.UnitMeasurement ?? string.Empty;
            performedPicker.Value = test.PerformedDateTime ?? NowToTheMinute();
            resultTextBox.Text = test.Result ?? string.Empty;

            SetAbnormalRowVisible(!test.HasRange);

            abnormalComboBox.SelectedIndex =
                (!test.HasRange && test.HasResult)
                    ? (test.Abnormal == true ? 1 : 0)
                    : -1;

            ClearErrors();

            SetEditorEnabled(!_isLocked);
        }

        private void SetEditorEnabled(bool enabled)
        {
            performedPicker.Enabled = enabled;
            resultTextBox.Enabled = enabled;
            abnormalComboBox.Enabled = enabled;
            saveButton.Enabled = enabled;
        }

        private void SetAbnormalRowVisible(bool visible)
        {
            abnormalLabel.Visible = visible;
            abnormalComboBox.Visible = visible;
        }

        private static DateTime NowToTheMinute()
        {
            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
        }


        private void saveButton_Click(object? sender, EventArgs e)
        {
            ClearErrors();

            if (_isLocked)
            {
                MessageBox.Show(
                    "A final diagnosis has been entered, so this visit is read-only.",
                    "Visit Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            OrderedTest? test = GetSelectedTest();

            if (test == null)
            {
                MessageBox.Show(
                    "Select a test first.",
                    "No Test Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!TryReadInputs(test, out DateTime performed, out string result, out bool? manualAbnormal))
            {
                return;
            }

            try
            {
                _testDal.SaveResult(_appointmentId, test.TestCode, performed, result, manualAbnormal);

                LoadVisit(test.TestCode);

                OrderedTest? saved = GetSelectedTest();

                MessageBox.Show(
                    $"Result saved for {test.TestName}. Status: {saved?.StatusText ?? "Saved"}.",
                    "Result Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                // Not ordered, or the visit was finalized while this page was open.
                MessageBox.Show(
                    ex.Message,
                    "Unable to Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                LoadVisit(test.TestCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save the test result: " + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool TryReadInputs(
            OrderedTest test,
            out DateTime performed,
            out string result,
            out bool? manualAbnormal)
        {
            bool isValid = true;

            DateTime picked = performedPicker.Value;
            performed = new DateTime(picked.Year, picked.Month, picked.Day, picked.Hour, picked.Minute, 0);

            if (performed > DateTime.Now)
            {
                ShowError(performedErrorLabel, "Date and time performed cannot be in the future.");
                isValid = false;
            }
            else if (performed.Date < _appointmentDateTime.Date)
            {
                ShowError(
                    performedErrorLabel,
                    $"A test cannot be performed before the visit ({_appointmentDateTime:MM/dd/yyyy}).");
                isValid = false;
            }

            result = resultTextBox.Text.Trim();

            if (result.Length == 0)
            {
                ShowError(resultErrorLabel, "Enter the test result.");
                isValid = false;
            }
            else if (result.Length > 255)
            {
                ShowError(resultErrorLabel, "The result cannot exceed 255 characters.");
                isValid = false;
            }
            else if (test.HasRange && !OrderedTest.TryParseNumericResult(result, out _))
            {
                ShowError(resultErrorLabel, "This test needs a numeric result, for example 7.20.");
                isValid = false;
            }

            manualAbnormal = null;

            if (!test.HasRange)
            {
                if (abnormalComboBox.SelectedIndex == -1)
                {
                    ShowError(abnormalErrorLabel, "Select normal or abnormal.");
                    isValid = false;
                }
                else
                {
                    manualAbnormal = abnormalComboBox.SelectedIndex == 1;
                }
            }

            return isValid;
        }

        // ---------- Error labels ----------

        private static void ShowError(Label label, string message)
        {
            label.Text = message;
            label.Visible = true;
        }

        private static void ClearError(Label label)
        {
            label.Text = string.Empty;
            label.Visible = false;
        }

        private void ClearErrors()
        {
            ClearError(performedErrorLabel);
            ClearError(resultErrorLabel);
            ClearError(abnormalErrorLabel);
        }
    }
}
