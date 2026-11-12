using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Nurse_View
{
    /// <summary>
    /// The CreatePatientPage class represents a form for creating or editing patient records 
    /// in the application. It provides functionality to load existing patient data for editing, as well as to add new patients to the database. 
    /// The form includes fields for patient information such as name, date of birth, phone number, address, gender, and active status.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CreatePatientPage : Form
    {
        private readonly PatientDal patientDal = new PatientDal();

        private int? editingPatientId = null;
        private int? editingAddressId = null;
        private bool isEditMode = false;

        public void LoadForEdit(int patientId)
        {
            try
            {
                var result = patientDal.GetPatientForEdit(patientId);

                if (result == null)
                {
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var (patient, address) = result.Value;

                editingPatientId = patient.PatientId;
                editingAddressId = address?.AddressId;

                patientFName.Text = patient.FirstName;
                patientLName.Text = patient.LastName;

                if (patient.DateOfBirth is DateTime dob)
                {
                    patientBirthMonth.Value = dob.Month;
                    patientBirthDay.Value = dob.Day;
                    patientBirthYear.Value = Math.Max(patientBirthYear.Minimum, Math.Min(patientBirthYear.Maximum, dob.Year));
                }

                patientPhoneNumber.Text = patient.Phone;

                if (address != null)
                {
                    patientAddress1.Text = address.Address1;
                    patientAddress2.Text = address.Address2 ?? string.Empty;
                    patientCity.Text = address.City;
                    patientState.SelectedItem = address.State;
                    patientZip.Text = address.Zip;
                }

                if (!string.IsNullOrEmpty(patient.Gender))
                {
                    patientGender.SelectedItem = patient.Gender;
                }

                patientIsActive.Checked = patient.Active;

                isEditMode = true;
                addPatientButton.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePatientPage"/> class.
        /// </summary>
        public CreatePatientPage()
        {
            InitializeComponent();

            patientPhoneNumber.KeyPress += NumericTextBox_KeyPress;
            patientZip.KeyPress += NumericTextBox_KeyPress;

            // Phone: digits only, auto-formatted as (xxx)-xxx-xxxx (14 chars with formatting).
            patientPhoneNumber.MaxLength = 14;
            patientPhoneNumber.PlaceholderText = "(xxx)-xxx-xxxx";
            patientPhoneNumber.TextChanged += patientPhoneNumber_TextChanged;
            patientZip.MaxLength = 5;

            // State must be picked from the list, not typed.
            patientState.DropDownStyle = ComboBoxStyle.DropDownList;
            patientGender.DropDownStyle = ComboBoxStyle.DropDownList;

            patientIsActive.Enabled = true;

            this.Text = "Create Patient";
            createPatientLabel.Text = "Create Patient";
            addPatientButton.Text = "Save";

            InitializeValidationLabels();
            AttachValidationEvents();
        }
        private bool formattingPhone = false;

        private static string DigitsOnly(string? text)
        {
            return new string((text ?? "").Where(char.IsDigit).ToArray());
        }

        private static string FormatPhone(string digits)
        {
            if (digits.Length == 0) return "";
            if (digits.Length <= 3) return "(" + digits;
            if (digits.Length <= 6) return $"({digits[..3]})-{digits[3..]}";
            return $"({digits[..3]})-{digits.Substring(3, 3)}-{digits[6..]}";
        }

        // Also handles pasted/programmatic text: strips non-digits, caps at 10, reformats.
        private void patientPhoneNumber_TextChanged(object? sender, EventArgs e)
        {
            if (formattingPhone) return;

            string digits = DigitsOnly(patientPhoneNumber.Text);
            if (digits.Length > 10) digits = digits[..10];

            string formatted = FormatPhone(digits);
            if (formatted == patientPhoneNumber.Text) return;

            formattingPhone = true;
            patientPhoneNumber.Text = formatted;
            patientPhoneNumber.SelectionStart = patientPhoneNumber.Text.Length;
            formattingPhone = false;
        }

        private Label[] GetValidationLabels()
        {
            return new Label[]
            {
                fnameErrorLabel,
                lnameErrorLabel,
                dobErrorLabel,
                phoneErrorLabel,
                add1ErrorLabel,
                stateErrorLabel,
                cityErrorLabel,
                zipErrorLabel,
                genderErrorLabel
            };
        }

        private void InitializeValidationLabels()
        {
            foreach (Label label in GetValidationLabels())
            {
                label.Text = "";
                label.Visible = false;
            }
        }

        private void ShowValidationError(Label label, string message)
        {
            label.Text = message;
            label.Visible = true;
        }

        private void ClearValidationError(Label label)
        {
            label.Text = "";
            label.Visible = false;
        }

        private void ClearAllValidationErrors()
        {
            foreach (Label label in GetValidationLabels())
            {
                ClearValidationError(label);
            }
        }
        private void AttachValidationEvents()
        {
            patientFName.TextChanged += (s, e) =>
                ClearValidationError(fnameErrorLabel);

            patientLName.TextChanged += (s, e) =>
                ClearValidationError(lnameErrorLabel);

            patientPhoneNumber.TextChanged += (s, e) =>
                ClearValidationError(phoneErrorLabel);

            patientAddress1.TextChanged += (s, e) =>
                ClearValidationError(add1ErrorLabel);

            patientCity.TextChanged += (s, e) =>
                ClearValidationError(cityErrorLabel);

            patientZip.TextChanged += (s, e) =>
                ClearValidationError(zipErrorLabel);

            patientState.SelectedIndexChanged += (s, e) =>
                ClearValidationError(stateErrorLabel);

            patientGender.SelectedIndexChanged += (s, e) =>
                ClearValidationError(genderErrorLabel);

            patientBirthMonth.ValueChanged += (s, e) =>
                ClearValidationError(dobErrorLabel);

            patientBirthDay.ValueChanged += (s, e) =>
                ClearValidationError(dobErrorLabel);

            patientBirthYear.ValueChanged += (s, e) =>
                ClearValidationError(dobErrorLabel);
        }
        private bool ValidatePatientForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(patientFName.Text))
            {
                ShowValidationError(
                    fnameErrorLabel,
                    "First name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(patientLName.Text))
            {
                ShowValidationError(
                    lnameErrorLabel,
                    "Last name is required.");
                isValid = false;
            }

            try
            {
                DateTime dob = new DateTime(
                    (int)patientBirthYear.Value,
                    (int)patientBirthMonth.Value,
                    (int)patientBirthDay.Value);

                if (dob > DateTime.Today)
                {
                    ShowValidationError(
                        dobErrorLabel,
                        "Date of birth cannot be in the future.");
                    isValid = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                ShowValidationError(
                    dobErrorLabel,
                    "Enter a valid date of birth.");
                isValid = false;
            }

            string phone = DigitsOnly(patientPhoneNumber.Text);

            if (phone.Length != 10)
            {
                ShowValidationError(
                    phoneErrorLabel,
                    "Enter a valid 10-digit phone number.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(patientAddress1.Text))
            {
                ShowValidationError(
                    add1ErrorLabel,
                    "Street address is required.");
                isValid = false;
            }

            if (patientState.SelectedIndex == -1)
            {
                ShowValidationError(
                    stateErrorLabel,
                    "Select a state.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(patientCity.Text))
            {
                ShowValidationError(
                    cityErrorLabel,
                    "City is required.");
                isValid = false;
            }

            string zip = patientZip.Text.Trim();

            if (zip.Length != 5 || !zip.All(char.IsDigit))
            {
                ShowValidationError(
                    zipErrorLabel,
                    "Enter a 5-digit ZIP code.");
                isValid = false;
            }

            if (patientGender.SelectedIndex == -1)
            {
                ShowValidationError(
                    genderErrorLabel,
                    "Select a gender.");
                isValid = false;
            }

            return isValid;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is Patient_View.SearchPatientPage search)
                {
                    search.Show();
                    Close();
                    return;
                }
            }

            var newSearch = new Patient_View.SearchPatientPage();
            newSearch.Show();
            Close();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            ClearAllValidationErrors();

            if (!ValidatePatientForm())
                return;

            try
            {
                var dob = new DateTime(
                    (int)patientBirthYear.Value,
                    (int)patientBirthMonth.Value,
                    (int)patientBirthDay.Value);

                var address = new Address(
                    editingAddressId,
                    patientAddress1.Text,
                    patientAddress2.Text,
                    patientCity.Text,
                    patientState.SelectedItem?.ToString() ?? string.Empty,
                    patientZip.Text);

                var patient = new Patient
                {
                    PatientId = editingPatientId ?? 0,
                    FirstName = patientFName.Text.Trim(),
                    LastName = patientLName.Text.Trim(),
                    DateOfBirth = dob,
                    Phone = DigitsOnly(patientPhoneNumber.Text),
                    Gender = patientGender.SelectedItem?.ToString() ?? string.Empty,
                    Active = patientIsActive.Checked,
                    AddressId = editingAddressId
                };

                if (isEditMode && editingPatientId.HasValue)
                {
                    if (!patientDal.UpdatePatient(patient, address))
                    {
                        MessageBox.Show("No rows were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    patientDal.AddPatient(patient, address);

                    MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                var searchPatientsPage = new Patient_View.SearchPatientPage();
                searchPatientsPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NumericTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void createPatientLabel_Click(object sender, EventArgs e)
        {

        }

        private void dashboardTitle_Click(object sender, EventArgs e)
        {

        }

        private void CreatePatientPage_Load(object sender, EventArgs e)
        {

        }
    }
}