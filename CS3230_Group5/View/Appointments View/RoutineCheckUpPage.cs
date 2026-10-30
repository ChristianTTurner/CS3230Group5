
using CS3230_Group5.DAL;
using CS3230_Group5.Model;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS3230_Group5.View.Appointments_View
{
    public partial class RoutineCheckUpPage : Form
    {
        private readonly int _appointmentId;
        private readonly int _nurseId;
        private readonly AppointmentSummaryDal _summaryDal;
        private readonly AppointmentSummary? _existingSummary;

        public RoutineCheckUpPage(int appointmentId, int nurseId)
        {
            InitializeComponent();

            if (appointmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(appointmentId));

            if (nurseId <= 0)
                throw new ArgumentOutOfRangeException(nameof(nurseId));

            _appointmentId = appointmentId;
            _nurseId = nurseId;
            _summaryDal = new AppointmentSummaryDal();

            _existingSummary = _summaryDal.GetSummary(_appointmentId);

            saveButton.Click += saveButton_Click;
            CancelButton.Click += cancelButton_Click;

            this.systolicTextBox.MaxLength = 500;

            ClearAllErrors();
            PopulateExistingCheckup();
        }

        /// <summary>
        /// Loads existing checkup information when updating a checkup.
        /// </summary>
        private void PopulateExistingCheckup()
        {
            if (_existingSummary == null)
                return;

            systolicTextBox.Text =
                _existingSummary.SystolicReading?.ToString() ?? "";

            diastolicTextBox.Text =
                _existingSummary.DiastolicReading?.ToString() ?? "";

            pulseTextBox.Text =
                _existingSummary.Pulse?.ToString() ?? "";

            tempTextBox.Text =
                _existingSummary.BodyTemperature?.ToString(
                    CultureInfo.CurrentCulture) ?? "";

            heightTextBox.Text =
                _existingSummary.Height?.ToString(
                    CultureInfo.CurrentCulture) ?? "";

            weightTextBox.Text =
                _existingSummary.Weight?.ToString(
                    CultureInfo.CurrentCulture) ?? "";

            this.symptomsTextBox.Text = _existingSummary.Symptoms ?? "";

            checkUpTitleLabel.Text = "Update Routine Check-Up";
            saveButton.Text = "Update";
        }

        private void saveButton_Click(object? sender, EventArgs e)
        {
            ClearAllErrors();

            bool isValid = ValidateCheckupFields();

            if (!isValid)
                return;

            try
            {
                int systolic = int.Parse(systolicTextBox.Text.Trim());
                int diastolic = int.Parse(diastolicTextBox.Text.Trim());
                int pulse = int.Parse(pulseTextBox.Text.Trim());

                decimal temperature = decimal.Parse(
                    tempTextBox.Text.Trim(),
                    CultureInfo.CurrentCulture);

                decimal height = decimal.Parse(
                    heightTextBox.Text.Trim(),
                    CultureInfo.CurrentCulture);

                decimal weight = decimal.Parse(
                    weightTextBox.Text.Trim(),
                    CultureInfo.CurrentCulture);

                string symptoms = this.symptomsTextBox.Text.Trim();

                var summary = _existingSummary ?? new AppointmentSummary();

                summary.AppointmentId = _appointmentId;
                summary.NurseId = _nurseId;
                summary.SystolicReading = systolic;
                summary.DiastolicReading = diastolic;
                summary.Pulse = pulse;
                summary.BodyTemperature = temperature;
                summary.Height = height;
                summary.Weight = weight;
                summary.Symptoms = symptoms;

                _summaryDal.SaveCheckup(summary);

                MessageBox.Show(
                    "Routine checkup saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save the routine checkup: " + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates each field and displays errors beside the field.
        /// </summary>
        private bool ValidateCheckupFields()
        {
            bool isValid = true;

            if (!int.TryParse(systolicTextBox.Text.Trim(), out int systolic))
            {
                ShowError(
                    systolicErrorLabel,
                    "Enter a whole number.");

                isValid = false;
            }
            else if (systolic <= 0)
            {
                ShowError(
                    systolicErrorLabel,
                    "Must be greater than 0.");

                isValid = false;
            }

            if (!int.TryParse(diastolicTextBox.Text.Trim(), out int diastolic))
            {
                ShowError(
                    diastolicErrorLabel,
                    "Enter a whole number.");

                isValid = false;
            }
            else if (diastolic <= 0)
            {
                ShowError(
                    diastolicErrorLabel,
                    "Must be greater than 0.");

                isValid = false;
            }

            if (!int.TryParse(pulseTextBox.Text.Trim(), out int pulse))
            {
                ShowError(
                    pulseErrorLabel,
                    "Enter a whole number.");

                isValid = false;
            }
            else if (pulse <= 0)
            {
                ShowError(
                    pulseErrorLabel,
                    "Must be greater than 0.");

                isValid = false;
            }

            if (!decimal.TryParse(
                    tempTextBox.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out decimal temperature))
            {
                ShowError(
                    tempErrorLabel,
                    "Enter a valid decimal number.");

                isValid = false;
            }
            else if (temperature <= 0 || temperature > 999.9m)
            {
                ShowError(
                    tempErrorLabel,
                    "Must be between 0 and 999.9 °F.");

                isValid = false;
            }
            else if (decimal.Round(temperature, 1) != temperature)
            {
                ShowError(
                    tempErrorLabel,
                    "Use no more than 1 decimal place.");

                isValid = false;
            }

            if (!decimal.TryParse(
                    heightTextBox.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out decimal height))
            {
                ShowError(
                    heightErrorLabel,
                    "Enter a valid decimal number.");

                isValid = false;
            }
            else if (height <= 0 || height > 999.99m)
            {
                ShowError(
                    heightErrorLabel,
                    "Must be between 0 and 999.99 in.");

                isValid = false;
            }
            else if (decimal.Round(height, 2) != height)
            {
                ShowError(
                    heightErrorLabel,
                    "Use no more than 2 decimal places.");

                isValid = false;
            }

            if (!decimal.TryParse(
                    weightTextBox.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out decimal weight))
            {
                ShowError(
                    weightErrorLabel,
                    "Enter a valid decimal number.");

                isValid = false;
            }
            else if (weight <= 0 || weight > 999.99m)
            {
                ShowError(
                    weightErrorLabel,
                    "Must be between 0 and 999.99 lb.");

                isValid = false;
            }
            else if (decimal.Round(weight, 2) != weight)
            {
                ShowError(
                    weightErrorLabel,
                    "Use no more than 2 decimal places.");

                isValid = false;
            }

            string symptoms = this.symptomsTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(symptoms))
            {
                ShowError(
                    symptomsErrorLabel,
                    "Enter symptoms or 'None reported'.");

                isValid = false;
            }
            else if (symptoms.Length > 500)
            {
                ShowError(
                    symptomsErrorLabel,
                    "Maximum 500 characters.");

                isValid = false;
            }

            return isValid;
        }

        private static void ShowError(Label label, string message)
        {
            label.Text = message;
            label.Visible = true;
        }

        private void ClearAllErrors()
        {
            systolicErrorLabel.Text = "";
            systolicErrorLabel.Visible = false;

            diastolicErrorLabel.Text = "";
            diastolicErrorLabel.Visible = false;

            pulseErrorLabel.Text = "";
            pulseErrorLabel.Visible = false;

            tempErrorLabel.Text = "";
            tempErrorLabel.Visible = false;

            heightErrorLabel.Text = "";
            heightErrorLabel.Visible = false;

            weightErrorLabel.Text = "";
            weightErrorLabel.Visible = false;

            symptomsErrorLabel.Text = "";
            symptomsErrorLabel.Visible = false;
        }

        private void cancelButton_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void systolicErrorLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void RoutineCheckUpPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
