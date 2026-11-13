
using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CS3230_Group5.View.Appointments_View
{
    /// <summary>
    /// Provides an interface for entering and saving the final diagnosis
    /// for a patient appointment. Requires confirmation before saving
    /// because finalizing the diagnosis makes the visit read-only.
    /// </summary>
    public partial class EnterFinalDiagnosisPage : Form
    {
        private const string DateTimeFormat = "MM/dd/yyyy h:mm tt";

        private readonly int _appointmentId;
        private readonly OrderedTestDal _visitDal = new OrderedTestDal();
        private readonly AppointmentSummaryDal _summaryDal = new AppointmentSummaryDal();
        private readonly FinalDiagnosisDal _finalDal = new FinalDiagnosisDal();

        private string _patientName = string.Empty;

        /// <summary>
        /// Initializes a new instance of the EnterFinalDiagnosisPage class
        /// for the specified appointment.
        /// </summary>
        /// <param name="appointmentId">
        /// The unique identifier of the appointment.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the appointment identifier is less than or equal to zero.
        /// </exception>
        public EnterFinalDiagnosisPage(int appointmentId)
        {
            InitializeComponent();

            if (appointmentId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            }

            _appointmentId = appointmentId;

            ConfigureList();
            ClearError();
            AttachEventHandlers();
            CancelButton = closeButton;
        }

        private void ConfigureList()
        {
            testsListView.Columns.Clear();
            testsListView.Columns.Add("Code", 70);
            testsListView.Columns.Add("Test", 200);
            testsListView.Columns.Add("Performed", 150);
            testsListView.Columns.Add("Result", 200);
            testsListView.Columns.Add("Status", 100);
        }

        private void ResizeListColumns()
        {
            int total = testsListView.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;

            if (total <= 0 || testsListView.Columns.Count != 5)
            {
                return;
            }

            double[] share = { 0.08, 0.27, 0.22, 0.25, 0.18 };

            for (int i = 0; i < share.Length; i++)
            {
                testsListView.Columns[i].Width = (int)(total * share[i]);
            }
        }

        private void AttachEventHandlers()
        {
            testsListView.SizeChanged += (s, e) => ResizeListColumns();
            saveButton.Click += saveButton_Click;
            closeButton.Click += (s, e) => Close();
            finalTextBox.TextChanged += (s, e) => ClearError();
        }

        private void EnterFinalDiagnosisPage_Load(object? sender, EventArgs e)
        {
            ResizeListColumns();
            LoadVisit();
        }

        private void LoadVisit()
        {
            try
            {
                VisitHeader? header = _visitDal.GetVisitHeader(_appointmentId);

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

                _patientName = header.PatientName;

                patientInfoLabel.Text =
                    $"Patient: {header.PatientName}      DOB: {header.PatientDateOfBirth:MM/dd/yyyy}";

                visitInfoLabel.Text =
                    $"Doctor: {header.DoctorName}      " +
                    $"Nurse: {header.NurseName ?? "Not recorded"}      " +
                    $"Visit: {header.AppointmentDateTime.ToString(DateTimeFormat)}";

                AppointmentSummary? summary = _summaryDal.GetSummary(_appointmentId);
                List<OrderedTest> tests = _visitDal.GetOrderedTests(_appointmentId);

                initialTextBox.Text = string.IsNullOrWhiteSpace(summary?.InitialDiagnosis)
                    ? "Not entered."
                    : summary!.InitialDiagnosis;

                FillList(tests);
                ApplyState(header, summary, tests);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load the visit: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                saveButton.Enabled = false;
                finalTextBox.Enabled = false;
            }
        }

        private void FillList(List<OrderedTest> tests)
        {
            testsListView.BeginUpdate();
            testsListView.Items.Clear();

            foreach (OrderedTest test in tests)
            {
                var item = new ListViewItem(test.TestCode);
                item.SubItems.Add(test.TestName);
                item.SubItems.Add(test.PerformedDateTime?.ToString(DateTimeFormat) ?? "Not performed");
                item.SubItems.Add(test.HasResult ? $"{test.Result} {test.UnitMeasurement}".Trim() : "Not entered");
                item.SubItems.Add(test.StatusText);

                if (test.HasResult && test.Abnormal == true)
                {
                    item.ForeColor = Color.Firebrick;
                }

                testsListView.Items.Add(item);
            }

            testsListView.EndUpdate();
        }

        private void ApplyState(VisitHeader header, AppointmentSummary? summary, List<OrderedTest> tests)
        {
            string notice = string.Empty;
            bool canEdit = false;
            int pendingTests = tests.Count(t => !t.HasResult);

            if (header.IsFinalized)
            {
                notice = "A final diagnosis has been entered, so this visit is read-only.";
                finalTextBox.Text = summary?.FinalDiagnosis ?? string.Empty;
            }
            else if (summary == null)
            {
                notice = "Save the routine check-up before entering a final diagnosis.";
            }
            else if (pendingTests > 0)
            {
                notice = $"{pendingTests} ordered test(s) still need results. " +
                         "Enter every result before the final diagnosis.";
            }
            else
            {
                canEdit = true;
            }

            noticeLabel.Text = notice;
            noticeLabel.Visible = notice.Length > 0;

            finalTextBox.Enabled = canEdit;
            saveButton.Enabled = canEdit;
        }

        private void saveButton_Click(object? sender, EventArgs e)
        {
            ClearError();

            string diagnosis = finalTextBox.Text.Trim();

            if (diagnosis.Length == 0)
            {
                ShowError("Enter the final diagnosis.");
                return;
            }

            if (diagnosis.Length > 500)
            {
                ShowError("The final diagnosis cannot exceed 500 characters.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"You are about to save the final diagnosis for {_patientName}.\n\n" +
                "Once it is saved, this visit becomes READ-ONLY. The routine check-up, " +
                "initial diagnosis, ordered tests, test results and diagnoses can no " +
                "longer be changed.\n\n" +
                "Do you want to save the final diagnosis and lock this visit?",
                "Confirm Final Diagnosis",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _finalDal.SaveFinalDiagnosis(_appointmentId, diagnosis);

                MessageBox.Show(
                    "The final diagnosis was saved. This visit is now read-only.",
                    "Final Diagnosis Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                LoadVisit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save the final diagnosis: " + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowError(string message)
        {
            finalErrorLabel.Text = message;
            finalErrorLabel.Visible = true;
        }

        private void ClearError()
        {
            finalErrorLabel.Text = string.Empty;
            finalErrorLabel.Visible = false;
        }

        private void visitInfoLabel_Click(object sender, EventArgs e)
        {
        }
    }
}