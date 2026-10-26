
using System;
using System.Windows.Forms;
using CS3230_Group5.Controller;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class AddNursePage : Form
    {
        private readonly NurseDal nurseDal = new NurseDal();
        private readonly UpdateNurseController updateController = new UpdateNurseController();
        private readonly int? nurseId;

        public AddNursePage() : this(null)
        {
        }

        public AddNursePage(int? nurseId)
        {
            InitializeComponent();

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

            saveButton.Click += saveButton_Click;
            cancelButton.Click += cancelButton_Click;

            nursePassword.UseSystemPasswordChar = true;
            nursePhoneNum.MaxLength = 10;

            nurseBirthMonth.Minimum = 1;
            nurseBirthMonth.Maximum = 12;

            nurseBirthDay.Minimum = 1;
            nurseBirthDay.Maximum = 31;

            numericUpDown1.Minimum = 1900;
            numericUpDown1.Maximum = DateTime.Today.Year;

            if (nurseId.HasValue)
            {
                AddNurseTitle.Text = "Edit Nurse";
                createLoginLabel.Text = "Update Login";
                loadNurseForEditing(nurseId.Value);
            }
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
            try
            {
                if (string.IsNullOrWhiteSpace(nursePassword.Text))
                    throw new ArgumentException("Password is required.");

                if (nurseState.SelectedIndex == -1)
                    throw new ArgumentException("Please select a state.");

                var dateOfBirth = new DateTime(
                    (int)numericUpDown1.Value,
                    (int)nurseBirthMonth.Value,
                    (int)nurseBirthDay.Value);

                if (dateOfBirth > DateTime.Today)
                    throw new ArgumentException("Date of birth cannot be in the future.");

                var address = new Address(
                    nurseId.HasValue ? updateController.Load(nurseId.Value)?.Address.AddressId : null,
                    nurseAddressLine1.Text,
                    nurseAddressLine2.Text,
                    nurseCity.Text,
                    nurseState.SelectedItem!.ToString()!,
                    nurseZip.Text);

                var nurse = new Nurse(
                    nurseId,
                    nurseFirstName.Text,
                    nurseLastName.Text,
                    dateOfBirth,
                    address.AddressId,
                    nursePhoneNum.Text.Replace("-", "").Replace(" ", ""),
                    nurseUsername.Text);

                if (nurseId.HasValue)
                {
                    bool updated = updateController.Update(
                        nurse,
                        address,
                        nursePassword.Text);

                    if (!updated)
                        throw new InvalidOperationException(
                            "The nurse could not be updated. Please try again.");

                    MessageBox.Show(
                        "Nurse updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    nurseDal.AddNurse(nurse, address, nursePassword.Text);

                    MessageBox.Show(
                        "Nurse added successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                foreach (Form open in Application.OpenForms)
                {
                    if (open is ViewNursesPage viewNurses)
                    {
                        viewNurses.Show();
                        viewNurses.Activate();
                        break;
                    }
                }

                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Update Error Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

            Close();
        }

        // Keep these methods because the Designer file references them.
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
