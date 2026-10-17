
using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Nurse_View
{
    public partial class AddNursePage : Form
    {
        private readonly NurseDal nurseDal = new NurseDal();

        public AddNursePage()
        {
            InitializeComponent();

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

        }

        private void saveButton_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nursePassword.Text))
                    throw new ArgumentException("Password is required.");

                var dateOfBirth = new DateTime(
                    (int)numericUpDown1.Value,
                    (int)nurseBirthMonth.Value,
                    (int)nurseBirthDay.Value);

                if (dateOfBirth > DateTime.Today)
                    throw new ArgumentException(
                        "Date of birth cannot be in the future.");

                var address = new Address(
                    null,
                    nurseAddressLine1.Text,
                    nurseAddressLine2.Text,
                    nurseCity.Text,
                    nurseState.Text.Trim().ToUpperInvariant(),
                    nurseZip.Text);

                var nurse = new Nurse(
                    null,
                    nurseFirstName.Text,
                    nurseLastName.Text,
                    dateOfBirth,
                    null,
                    nursePhoneNum.Text.Replace("-", "").Replace(" ", ""),
                    nurseUsername.Text);

                string passwordHash = hashPassword(nursePassword.Text);

                nurseDal.AddNurse(nurse, address, passwordHash);

                MessageBox.Show(
                    "Nurse added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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
            catch (Exception)
            {
                MessageBox.Show(
                    "Unable to add the nurse. Check the database connection and ensure the username and phone number are unique.",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static string hashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                100000,
                HashAlgorithmName.SHA256,
                32);

            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }

        private void cancelButton_Click(object? sender, EventArgs e)
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
