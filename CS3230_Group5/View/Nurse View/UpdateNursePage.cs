using System;
using System.Windows.Forms;
using CS3230_Group5.Controller;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class UpdateNursePage : Form
    {
        private readonly UpdateNurseController _controller;
        private readonly int _nurseId;

        public UpdateNursePage(int nurseId)
        {
            InitializeComponent();

            _controller = new UpdateNurseController();
            _nurseId = nurseId;

            saveButton.Click += SaveButton_Click;
            cancelButton.Click += CancelButton_Click;

            nursePhoneNum.MaxLength = 10;
            nurseBirthMonth.Minimum = 1;
            nurseBirthMonth.Maximum = 12;
            nurseBirthDay.Minimum = 1;
            nurseBirthDay.Maximum = 31;
            numericUpDown1.Minimum = 1900;
            numericUpDown1.Maximum = DateTime.Today.Year;

            LoadNurse();
        }

        private void LoadNurse()
        {
            var result = _controller.Load(_nurseId);
            if (result == null)
            {
                MessageBox.Show("Nurse not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            var nurse = result.Value.Nurse;
            var address = result.Value.Address;

            nurseFirstName.Text = nurse.FirstName;
            nurseLastName.Text = nurse.LastName;
            nurseUsername.Text = nurse.Username;
            nursePhoneNum.Text = nurse.Phone;

            nurseAddressLine1.Text = address.Address1;
            nurseAddressLine2.Text = address.Address2;
            nurseCity.Text = address.City;
            nurseState.Text = address.State;
            nurseZip.Text = address.Zip;

            var dob = nurse.DateOfBirth;
            nurseBirthMonth.Value = dob.Month;
            nurseBirthDay.Value = dob.Day;
            numericUpDown1.Value = dob.Year;
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            try
            {
                var dateOfBirth = new DateTime((int)numericUpDown1.Value, (int)nurseBirthMonth.Value, (int)nurseBirthDay.Value);

                var address = new Address(
                    null,
                    nurseAddressLine1.Text,
                    nurseAddressLine2.Text,
                    nurseCity.Text,
                    nurseState.Text.Trim().ToUpperInvariant(),
                    nurseZip.Text);

                var nurse = new Nurse(
                    _nurseId,
                    nurseFirstName.Text,
                    nurseLastName.Text,
                    dateOfBirth,
                    null,
                    nursePhoneNum.Text.Replace("-", "").Replace(" ", ""),
                    nurseUsername.Text);

                var existing = _controller.Load(_nurseId);
                if (existing == null)
                {
                    MessageBox.Show("Unable to load existing nurse record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var existingAddress = existing.Value.Address;
                address = new Address(existingAddress.AddressId, address.Address1, address.Address2, address.City, address.State, address.Zip);

                nurse = new Nurse(nurse.NurseId, nurse.FirstName, nurse.LastName, nurse.DateOfBirth, existingAddress.AddressId, nurse.Phone, nurse.Username);

                var ok = _controller.Update(nurse, address);
                if (!ok)
                {
                    MessageBox.Show("No rows were updated. The record may have changed or been deleted.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Nurse updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to update the nurse. Check the database connection and ensure values are valid.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            foreach (Form open in Application.OpenForms)
            {
                if (open is View.Nurse_View.ViewNursesPage viewNurses)
                {
                    viewNurses.Show();
                    break;
                }
            }

            Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void UpdateNursePage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
