using System;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Appointments_View
{
    public partial class InitialDiagnosisPage : Form
    {
        private readonly int _appointmentId;
        private readonly AppointmentSummaryDal _summaryDal =
            new AppointmentSummaryDal();

        public InitialDiagnosisPage(int appointmentId)
        {
            InitializeComponent();

            if (appointmentId <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(appointmentId));
            }

            _appointmentId = appointmentId;

            initialDiagnosisTextBox.MaxLength = 500;

            initialDiagnosisErrorLabel.Text = "";
            initialDiagnosisErrorLabel.Visible = false;

            saveButton.Click += saveButton_Click;
            CancelButton.Click += cancelButton_Click;

            initialDiagnosisTextBox.TextChanged += (s, e) =>
            {
                initialDiagnosisErrorLabel.Text = "";
                initialDiagnosisErrorLabel.Visible = false;
            };
        }

        private void LoadExistingDiagnosis()
        {
            try
            {
                AppointmentSummary? summary =
                    _summaryDal.GetSummary(_appointmentId);

                if (summary == null)
                {
                    MessageBox.Show(
                        "Save the routine check-up before entering " +
                        "the initial diagnosis.",
                        "Routine Check-Up Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    BeginInvoke(new Action(() =>
                    {
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }));

                    return;
                }

                initialDiagnosisTextBox.Text =
                    summary.InitialDiagnosis ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load the initial diagnosis: " + ex.Message,
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void saveButton_Click(object? sender, EventArgs e)
        {
            string diagnosis = initialDiagnosisTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(diagnosis))
            {
                ShowValidationError(
                    "Please enter the initial diagnosis.");
                return;
            }

            if (diagnosis.Length > 500)
            {
                ShowValidationError(
                    "Initial diagnosis cannot exceed 500 characters.");
                return;
            }

            try
            {
                _summaryDal.SaveInitialDiagnosis(
                    _appointmentId,
                    diagnosis);

                MessageBox.Show(
                    "Initial diagnosis saved successfully.",
                    "Diagnosis Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save the initial diagnosis: " + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowValidationError(string message)
        {
            initialDiagnosisErrorLabel.Text = message;
            initialDiagnosisErrorLabel.Visible = true;
        }

        private void cancelButton_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void InitialDiagnosisPage_Load(object? sender, EventArgs e)
        {
            LoadExistingDiagnosis();
        }

    }
}