
using System;
using System.Linq;
using System.Windows.Forms;
using CS3230_Group5.Controller;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class AddNursePage : Form
    {
        private readonly NurseDal nurseDal = new NurseDal();
        private readonly UpdateNurseController updateController =
            new UpdateNurseController();

        private readonly int? nurseId;

        public AddNursePage() : this(null)
        {
        }

        public AddNursePage(int? nurseId)
        {
            InitializeComponent();

            saveButton.Click += saveButton_Click;
            cancelButton.Click += cancelButton_Click;

            this.nurseId = nurseId;

            nurseState.DropDownStyle = ComboBoxStyle.DropDownList;
            nurseState.Items.AddRange(new string[]
            {
                "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE",
                "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS",
                "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS",
                "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY",
                "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV",
                "WI", "WY"
            });

            nursePassword.UseSystemPasswordChar = true;
            nursePhoneNum.MaxLength = 10;

            nurseBirthMonth.Minimum = 1;
            nurseBirthMonth.Maximum = 12;
            nurseBirthDay.Minimum = 1;
            nurseBirthDay.Maximum = 31;

            numericUpDown1.Minimum = 1900;
            numericUpDown1.Maximum = DateTime.Today.Year;

            initializeValidationLabels();
            attachValidationEvents();

            if (nurseId.HasValue)
            {
                AddNurseTitle.Text = "Edit Nurse";
                createLoginLabel.Text = "Update Login";
                loadNurseForEditing(nurseId.Value);
            }
        }

        private void initializeValidationLabels()
        {
            foreach (Label label in getValidationLabels())
            {
                label.Text = "";
                label.Visible = false;
            }
        }

        private Label[] getValidationLabels()
        {
            return new Label[]
            {
                fnameValidation,
                lnameValidation,
                dobValidation,
                phoneValidation,
                add1Validation,
                add2Validation,
                cityValidation,
                stateValidation,
                zipValidation,
                usernameValidation,
                passwordValidation
            };
        }

        private void attachValidationEvents()
        {
            nurseFirstName.TextChanged +=
                (s, e) => clearValidationError(fnameValidation);

            nurseLastName.TextChanged +=
                (s, e) => clearValidationError(lnameValidation);

            nursePhoneNum.TextChanged +=
                (s, e) => clearValidationError(phoneValidation);

            nurseAddressLine1.TextChanged +=
                (s, e) => clearValidationError(add1Validation);

            nurseAddressLine2.TextChanged +=
                (s, e) => clearValidationError(add2Validation);

            nurseCity.TextChanged +=
                (s, e) => clearValidationError(cityValidation);

            nurseState.SelectedIndexChanged +=
                (s, e) => clearValidationError(stateValidation);

            nurseZip.TextChanged +=
                (s, e) => clearValidationError(zipValidation);

            nurseUsername.TextChanged +=
                (s, e) => clearValidationError(usernameValidation);

            nursePassword.TextChanged +=
                (s, e) => clearValidationError(passwordValidation);

            nurseBirthMonth.ValueChanged +=
                (s, e) => clearValidationError(dobValidation);

            nurseBirthDay.ValueChanged +=
                (s, e) => clearValidationError(dobValidation);

            numericUpDown1.ValueChanged +=
                (s, e) => clearValidationError(dobValidation);
        }

        private void loadNurseForEditing(int id)
        {
            try
            {
                var result = updateController.Load(id);

                if (result == null)
                {
                    MessageBox.Show(
                        "Nurse not found.",
                        "Load Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    Close();
                    return;
                }

                var nurse = result.Value.Nurse;
                var address = result.Value.Address;

                nurseFirstName.Text = nurse.FirstName;
                nurseLastName.Text = nurse.LastName;
                nursePhoneNum.Text = nurse.Phone;
                nurseUsername.Text = nurse.Username;

                nurseBirthMonth.Value = nurse.DateOfBirth.Month;
                nurseBirthDay.Value = nurse.DateOfBirth.Day;
                numericUpDown1.Value = nurse.DateOfBirth.Year;

                nurseAddressLine1.Text = address.Address1;
                nurseAddressLine2.Text = address.Address2 ?? "";
                nurseCity.Text = address.City;
                nurseState.SelectedItem = address.State;
                nurseZip.Text = address.Zip;

                nursePassword.Text = updateController.LoadPassword(id) ?? "";
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Unable to load the nurse's information.",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        private void saveButton_Click(object? sender, EventArgs e)
        {
            clearAllValidationErrors();

            if (!validateForm())
                return;

            try
            {
                DateTime dateOfBirth = getDateOfBirth();
                Address address = createAddress();
                Nurse nurse = createNurse(dateOfBirth, address);

                saveNurse(nurse, address);
                showSuccessMessage();

                returnToViewNursesPage();
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                    "Some information could not be accepted. Please check your entries.",
                    "Invalid Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Unable to save the nurse. Please try again.",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool validateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(nurseFirstName.Text))
            {
                showValidationError(
                    fnameValidation, "First name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(nurseLastName.Text))
            {
                showValidationError(
                    lnameValidation, "Last name is required.");
                isValid = false;
            }

            if (!isValidDateOfBirth())
            {
                showValidationError(
                    dobValidation,
                    "Enter a valid date of birth that is not in the future.");
                isValid = false;
            }

            string phone = nursePhoneNum.Text
                .Replace("-", "")
                .Replace(" ", "");

            if (phone.Length != 10 ||
                !phone.All(char.IsDigit))
            {
                showValidationError(
                    phoneValidation,
                    "Enter a 10-digit phone number.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(nurseAddressLine1.Text))
            {
                showValidationError(
                    add1Validation, "Street address is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(nurseCity.Text))
            {
                showValidationError(
                    cityValidation, "City is required.");
                isValid = false;
            }

            if (nurseState.SelectedIndex == -1)
            {
                showValidationError(
                    stateValidation, "Select a state.");
                isValid = false;
            }

            if (nurseZip.Text.Length != 5 ||
                !nurseZip.Text.All(char.IsDigit))
            {
                showValidationError(
                    zipValidation, "Enter a 5-digit ZIP code.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(nurseUsername.Text))
            {
                showValidationError(
                    usernameValidation, "Username is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(nursePassword.Text))
            {
                showValidationError(
                    passwordValidation, "Password is required.");
                isValid = false;
            }

            return isValid;
        }

        private bool isValidDateOfBirth()
        {
            try
            {
                DateTime dateOfBirth = getDateOfBirth();
                return dateOfBirth <= DateTime.Today;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        private DateTime getDateOfBirth()
        {
            return new DateTime(
                (int)numericUpDown1.Value,
                (int)nurseBirthMonth.Value,
                (int)nurseBirthDay.Value);
        }

        private Address createAddress()
        {
            int? addressId = null;

            if (nurseId.HasValue)
            {
                var result = updateController.Load(nurseId.Value);
                addressId = result?.Address.AddressId;
            }

            return new Address(
                addressId,
                nurseAddressLine1.Text,
                nurseAddressLine2.Text,
                nurseCity.Text,
                nurseState.SelectedItem!.ToString()!,
                nurseZip.Text);
        }

        private Nurse createNurse(DateTime dateOfBirth, Address address)
        {
            return new Nurse(
                nurseId,
                nurseFirstName.Text,
                nurseLastName.Text,
                dateOfBirth,
                address.AddressId,
                nursePhoneNum.Text.Replace("-", "").Replace(" ", ""),
                nurseUsername.Text);
        }

        private void saveNurse(Nurse nurse, Address address)
        {
            if (nurseId.HasValue)
            {
                bool updated = updateController.Update(
                    nurse,
                    address,
                    nursePassword.Text);

                if (!updated)
                {
                    throw new InvalidOperationException(
                        "The nurse could not be updated.");
                }
            }
            else
            {
                nurseDal.AddNurse(
                    nurse,
                    address,
                    nursePassword.Text);
            }
        }

        private void showSuccessMessage()
        {
            string message = nurseId.HasValue
                ? "Nurse updated successfully."
                : "Nurse added successfully.";

            MessageBox.Show(
                message,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void showValidationError(Label label, string message)
        {
            label.Text = message;
            label.Visible = true;
        }

        private void clearValidationError(Label label)
        {
            label.Text = "";
            label.Visible = false;
        }

        private void clearAllValidationErrors()
        {
            foreach (Label label in getValidationLabels())
            {
                clearValidationError(label);
            }
        }

        private void cancelButton_Click(object? sender, EventArgs e)
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is ViewNursesPage viewNurses)
                {
                    viewNurses.Show();
                    break;
                }
            }

            returnToViewNursesPage();
        }
        private void returnToViewNursesPage()
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is ViewNursesPage viewNurses)
                {
                    viewNurses.Show();
                    viewNurses.BringToFront();
                    break;
                }
            }

            Close();
        }

        // Keep these handlers because the Designer references them.
        private void AddNursePage_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void nurseZip_TextChanged(object sender, EventArgs e) { }
        private void loginLabel_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
