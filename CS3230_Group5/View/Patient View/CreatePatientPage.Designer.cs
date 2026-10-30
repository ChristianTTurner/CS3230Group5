namespace CS3230_Group5.View.Nurse_View
{
    partial class CreatePatientPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelButton = new Button();
            createPatientLabel = new Label();
            patientFNameLabel = new Label();
            patientFName = new TextBox();
            patientLName = new TextBox();
            patientLNameLabel = new Label();
            patientBirthMonth = new NumericUpDown();
            DOBLabel = new Label();
            patientBirthDay = new NumericUpDown();
            patientBirthYear = new NumericUpDown();
            label1 = new Label();
            patientPhoneNumber = new TextBox();
            patientAddress1 = new TextBox();
            patientAddress1Label = new Label();
            patientAddress2 = new TextBox();
            patientAddress2Label = new Label();
            patientCity = new TextBox();
            patientCityLabel = new Label();
            patientStateLabel = new Label();
            patientState = new ComboBox();
            patientZip = new TextBox();
            patientZipLabel = new Label();
            patientIsActive = new CheckBox();
            addPatientButton = new Button();
            patientGenderLabel = new Label();
            patientGender = new ComboBox();
            dashboardTitle = new Label();
            panel1 = new Panel();
            fnameErrorLabel = new Label();
            lnameErrorLabel = new Label();
            dobErrorLabel = new Label();
            phoneErrorLabel = new Label();
            add1ErrorLabel = new Label();
            stateErrorLabel = new Label();
            cityErrorLabel = new Label();
            zipErrorLabel = new Label();
            genderErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)patientBirthMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthYear).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(570, 581);
            cancelButton.Margin = new Padding(4, 3, 4, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 47);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // createPatientLabel
            // 
            createPatientLabel.AutoSize = true;
            createPatientLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPatientLabel.Location = new Point(341, 74);
            createPatientLabel.Margin = new Padding(4, 0, 4, 0);
            createPatientLabel.Name = "createPatientLabel";
            createPatientLabel.Size = new Size(374, 70);
            createPatientLabel.TabIndex = 20;
            createPatientLabel.Text = "Create Patient";
            createPatientLabel.Click += createPatientLabel_Click;
            // 
            // patientFNameLabel
            // 
            patientFNameLabel.AutoSize = true;
            patientFNameLabel.Font = new Font("Segoe UI", 12F);
            patientFNameLabel.Location = new Point(53, 171);
            patientFNameLabel.Margin = new Padding(4, 0, 4, 0);
            patientFNameLabel.Name = "patientFNameLabel";
            patientFNameLabel.Size = new Size(134, 32);
            patientFNameLabel.TabIndex = 22;
            patientFNameLabel.Text = "First Name:";
            // 
            // patientFName
            // 
            patientFName.Font = new Font("Segoe UI", 12F);
            patientFName.Location = new Point(197, 167);
            patientFName.Margin = new Padding(4, 3, 4, 3);
            patientFName.Name = "patientFName";
            patientFName.PlaceholderText = "Patients First Name";
            patientFName.Size = new Size(338, 39);
            patientFName.TabIndex = 23;
            // 
            // patientLName
            // 
            patientLName.Font = new Font("Segoe UI", 12F);
            patientLName.Location = new Point(692, 171);
            patientLName.Margin = new Padding(4, 3, 4, 3);
            patientLName.Name = "patientLName";
            patientLName.PlaceholderText = "Patients Last Name";
            patientLName.Size = new Size(330, 39);
            patientLName.TabIndex = 25;
            // 
            // patientLNameLabel
            // 
            patientLNameLabel.AutoSize = true;
            patientLNameLabel.Font = new Font("Segoe UI", 12F);
            patientLNameLabel.Location = new Point(550, 174);
            patientLNameLabel.Margin = new Padding(4, 0, 4, 0);
            patientLNameLabel.Name = "patientLNameLabel";
            patientLNameLabel.Size = new Size(131, 32);
            patientLNameLabel.TabIndex = 24;
            patientLNameLabel.Text = "Last Name:";
            // 
            // patientBirthMonth
            // 
            patientBirthMonth.Font = new Font("Segoe UI", 9F);
            patientBirthMonth.Location = new Point(301, 250);
            patientBirthMonth.Margin = new Padding(4, 3, 4, 3);
            patientBirthMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            patientBirthMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            patientBirthMonth.Name = "patientBirthMonth";
            patientBirthMonth.Size = new Size(60, 31);
            patientBirthMonth.TabIndex = 26;
            patientBirthMonth.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // DOBLabel
            // 
            DOBLabel.AutoSize = true;
            DOBLabel.Font = new Font("Segoe UI", 12F);
            DOBLabel.Location = new Point(66, 246);
            DOBLabel.Margin = new Padding(4, 0, 4, 0);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(225, 32);
            DOBLabel.TabIndex = 27;
            DOBLabel.Text = "DOB (mm/dd/yyyy):";
            // 
            // patientBirthDay
            // 
            patientBirthDay.Font = new Font("Segoe UI", 9F);
            patientBirthDay.Location = new Point(368, 250);
            patientBirthDay.Margin = new Padding(4, 3, 4, 3);
            patientBirthDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            patientBirthDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            patientBirthDay.Name = "patientBirthDay";
            patientBirthDay.Size = new Size(60, 31);
            patientBirthDay.TabIndex = 28;
            patientBirthDay.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // patientBirthYear
            // 
            patientBirthYear.Font = new Font("Segoe UI", 9F);
            patientBirthYear.Location = new Point(436, 250);
            patientBirthYear.Margin = new Padding(4, 3, 4, 3);
            patientBirthYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            patientBirthYear.Minimum = new decimal(new int[] { 1899, 0, 0, 0 });
            patientBirthYear.Name = "patientBirthYear";
            patientBirthYear.Size = new Size(114, 31);
            patientBirthYear.TabIndex = 29;
            patientBirthYear.Value = new decimal(new int[] { 1899, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(559, 250);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 30;
            label1.Text = "Phone #:";
            // 
            // patientPhoneNumber
            // 
            patientPhoneNumber.Font = new Font("Segoe UI", 12F);
            patientPhoneNumber.Location = new Point(678, 243);
            patientPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            patientPhoneNumber.Name = "patientPhoneNumber";
            patientPhoneNumber.PlaceholderText = "xxx-xxx-xxxx";
            patientPhoneNumber.Size = new Size(353, 39);
            patientPhoneNumber.TabIndex = 31;
            // 
            // patientAddress1
            // 
            patientAddress1.Font = new Font("Segoe UI", 12F);
            patientAddress1.Location = new Point(197, 318);
            patientAddress1.Margin = new Padding(4, 3, 4, 3);
            patientAddress1.Name = "patientAddress1";
            patientAddress1.Size = new Size(338, 39);
            patientAddress1.TabIndex = 35;
            // 
            // patientAddress1Label
            // 
            patientAddress1Label.AutoSize = true;
            patientAddress1Label.Font = new Font("Segoe UI", 12F);
            patientAddress1Label.Location = new Point(65, 321);
            patientAddress1Label.Margin = new Padding(4, 0, 4, 0);
            patientAddress1Label.Name = "patientAddress1Label";
            patientAddress1Label.Size = new Size(123, 32);
            patientAddress1Label.TabIndex = 34;
            patientAddress1Label.Text = "Address 1:";
            // 
            // patientAddress2
            // 
            patientAddress2.Font = new Font("Segoe UI", 12F);
            patientAddress2.Location = new Point(690, 318);
            patientAddress2.Margin = new Padding(4, 3, 4, 3);
            patientAddress2.Name = "patientAddress2";
            patientAddress2.Size = new Size(338, 39);
            patientAddress2.TabIndex = 37;
            // 
            // patientAddress2Label
            // 
            patientAddress2Label.AutoSize = true;
            patientAddress2Label.Font = new Font("Segoe UI", 12F);
            patientAddress2Label.Location = new Point(559, 318);
            patientAddress2Label.Margin = new Padding(4, 0, 4, 0);
            patientAddress2Label.Name = "patientAddress2Label";
            patientAddress2Label.Size = new Size(123, 32);
            patientAddress2Label.TabIndex = 36;
            patientAddress2Label.Text = "Address 2:";
            // 
            // patientCity
            // 
            patientCity.Font = new Font("Segoe UI", 12F);
            patientCity.Location = new Point(460, 394);
            patientCity.Margin = new Padding(4, 3, 4, 3);
            patientCity.Name = "patientCity";
            patientCity.Size = new Size(338, 39);
            patientCity.TabIndex = 39;
            // 
            // patientCityLabel
            // 
            patientCityLabel.AutoSize = true;
            patientCityLabel.Font = new Font("Segoe UI", 12F);
            patientCityLabel.Location = new Point(394, 399);
            patientCityLabel.Margin = new Padding(4, 0, 4, 0);
            patientCityLabel.Name = "patientCityLabel";
            patientCityLabel.Size = new Size(60, 32);
            patientCityLabel.TabIndex = 38;
            patientCityLabel.Text = "City:";
            // 
            // patientStateLabel
            // 
            patientStateLabel.AutoSize = true;
            patientStateLabel.Font = new Font("Segoe UI", 12F);
            patientStateLabel.Location = new Point(67, 399);
            patientStateLabel.Margin = new Padding(4, 0, 4, 0);
            patientStateLabel.Name = "patientStateLabel";
            patientStateLabel.Size = new Size(72, 32);
            patientStateLabel.TabIndex = 40;
            patientStateLabel.Text = "State:";
            // 
            // patientState
            // 
            patientState.FormattingEnabled = true;
            patientState.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            patientState.Location = new Point(147, 399);
            patientState.Margin = new Padding(4, 3, 4, 3);
            patientState.Name = "patientState";
            patientState.Size = new Size(238, 33);
            patientState.TabIndex = 41;
            // 
            // patientZip
            // 
            patientZip.Font = new Font("Segoe UI", 12F);
            patientZip.Location = new Point(873, 394);
            patientZip.Margin = new Padding(4, 3, 4, 3);
            patientZip.Name = "patientZip";
            patientZip.Size = new Size(158, 39);
            patientZip.TabIndex = 43;
            // 
            // patientZipLabel
            // 
            patientZipLabel.AutoSize = true;
            patientZipLabel.Font = new Font("Segoe UI", 12F);
            patientZipLabel.Location = new Point(813, 399);
            patientZipLabel.Margin = new Padding(4, 0, 4, 0);
            patientZipLabel.Name = "patientZipLabel";
            patientZipLabel.Size = new Size(53, 32);
            patientZipLabel.TabIndex = 42;
            patientZipLabel.Text = "Zip:";
            // 
            // patientIsActive
            // 
            patientIsActive.AutoSize = true;
            patientIsActive.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientIsActive.Location = new Point(67, 487);
            patientIsActive.Margin = new Padding(4, 3, 4, 3);
            patientIsActive.Name = "patientIsActive";
            patientIsActive.Size = new Size(93, 32);
            patientIsActive.TabIndex = 44;
            patientIsActive.Text = "Active";
            patientIsActive.UseVisualStyleBackColor = true;
            // 
            // addPatientButton
            // 
            addPatientButton.BackColor = Color.ForestGreen;
            addPatientButton.FlatAppearance.BorderSize = 0;
            addPatientButton.FlatStyle = FlatStyle.Flat;
            addPatientButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPatientButton.ForeColor = Color.White;
            addPatientButton.Location = new Point(413, 581);
            addPatientButton.Margin = new Padding(4, 3, 4, 3);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(137, 47);
            addPatientButton.TabIndex = 45;
            addPatientButton.Text = "Save";
            addPatientButton.UseVisualStyleBackColor = false;
            addPatientButton.Click += addPatientButton_Click;
            // 
            // patientGenderLabel
            // 
            patientGenderLabel.AutoSize = true;
            patientGenderLabel.Font = new Font("Segoe UI", 12F);
            patientGenderLabel.Location = new Point(363, 469);
            patientGenderLabel.Margin = new Padding(4, 0, 4, 0);
            patientGenderLabel.Name = "patientGenderLabel";
            patientGenderLabel.Size = new Size(97, 32);
            patientGenderLabel.TabIndex = 42;
            patientGenderLabel.Text = "Gender:";
            // 
            // patientGender
            // 
            patientGender.Font = new Font("Segoe UI", 12F);
            patientGender.FormattingEnabled = true;
            patientGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            patientGender.Location = new Point(460, 464);
            patientGender.Margin = new Padding(4, 3, 4, 3);
            patientGender.Name = "patientGender";
            patientGender.Size = new Size(198, 40);
            patientGender.TabIndex = 43;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(11, 19);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(308, 28);
            dashboardTitle.TabIndex = 0;
            dashboardTitle.Text = "Healthcare Management System";
            dashboardTitle.Click += dashboardTitle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 62);
            panel1.TabIndex = 46;
            // 
            // fnameErrorLabel
            // 
            fnameErrorLabel.AutoSize = true;
            fnameErrorLabel.ForeColor = Color.Red;
            fnameErrorLabel.Location = new Point(197, 209);
            fnameErrorLabel.Name = "fnameErrorLabel";
            fnameErrorLabel.Size = new Size(50, 25);
            fnameErrorLabel.TabIndex = 47;
            fnameErrorLabel.Text = "error";
            fnameErrorLabel.Visible = false;
            // 
            // lnameErrorLabel
            // 
            lnameErrorLabel.AutoSize = true;
            lnameErrorLabel.ForeColor = Color.Red;
            lnameErrorLabel.Location = new Point(692, 209);
            lnameErrorLabel.Name = "lnameErrorLabel";
            lnameErrorLabel.Size = new Size(50, 25);
            lnameErrorLabel.TabIndex = 48;
            lnameErrorLabel.Text = "error";
            lnameErrorLabel.Visible = false;
            // 
            // dobErrorLabel
            // 
            dobErrorLabel.AutoSize = true;
            dobErrorLabel.ForeColor = Color.Red;
            dobErrorLabel.Location = new Point(301, 284);
            dobErrorLabel.Name = "dobErrorLabel";
            dobErrorLabel.Size = new Size(50, 25);
            dobErrorLabel.TabIndex = 49;
            dobErrorLabel.Text = "error";
            dobErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.ForeColor = Color.Red;
            phoneErrorLabel.Location = new Point(678, 284);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(50, 25);
            phoneErrorLabel.TabIndex = 50;
            phoneErrorLabel.Text = "error";
            phoneErrorLabel.Visible = false;
            // 
            // add1ErrorLabel
            // 
            add1ErrorLabel.AutoSize = true;
            add1ErrorLabel.ForeColor = Color.Red;
            add1ErrorLabel.Location = new Point(197, 360);
            add1ErrorLabel.Name = "add1ErrorLabel";
            add1ErrorLabel.Size = new Size(50, 25);
            add1ErrorLabel.TabIndex = 51;
            add1ErrorLabel.Text = "error";
            add1ErrorLabel.Visible = false;
            // 
            // stateErrorLabel
            // 
            stateErrorLabel.AutoSize = true;
            stateErrorLabel.ForeColor = Color.Red;
            stateErrorLabel.Location = new Point(147, 435);
            stateErrorLabel.Name = "stateErrorLabel";
            stateErrorLabel.Size = new Size(50, 25);
            stateErrorLabel.TabIndex = 52;
            stateErrorLabel.Text = "error";
            stateErrorLabel.Visible = false;
            // 
            // cityErrorLabel
            // 
            cityErrorLabel.AutoSize = true;
            cityErrorLabel.ForeColor = Color.Red;
            cityErrorLabel.Location = new Point(460, 436);
            cityErrorLabel.Name = "cityErrorLabel";
            cityErrorLabel.Size = new Size(50, 25);
            cityErrorLabel.TabIndex = 53;
            cityErrorLabel.Text = "error";
            cityErrorLabel.Visible = false;
            // 
            // zipErrorLabel
            // 
            zipErrorLabel.AutoSize = true;
            zipErrorLabel.ForeColor = Color.Red;
            zipErrorLabel.Location = new Point(873, 436);
            zipErrorLabel.Name = "zipErrorLabel";
            zipErrorLabel.Size = new Size(50, 25);
            zipErrorLabel.TabIndex = 54;
            zipErrorLabel.Text = "error";
            zipErrorLabel.Visible = false;
            // 
            // genderErrorLabel
            // 
            genderErrorLabel.AutoSize = true;
            genderErrorLabel.ForeColor = Color.Red;
            genderErrorLabel.Location = new Point(460, 507);
            genderErrorLabel.Name = "genderErrorLabel";
            genderErrorLabel.Size = new Size(50, 25);
            genderErrorLabel.TabIndex = 55;
            genderErrorLabel.Text = "error";
            genderErrorLabel.Visible = false;
            // 
            // CreatePatientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1055, 640);
            Controls.Add(genderErrorLabel);
            Controls.Add(zipErrorLabel);
            Controls.Add(cityErrorLabel);
            Controls.Add(stateErrorLabel);
            Controls.Add(add1ErrorLabel);
            Controls.Add(phoneErrorLabel);
            Controls.Add(dobErrorLabel);
            Controls.Add(lnameErrorLabel);
            Controls.Add(fnameErrorLabel);
            Controls.Add(panel1);
            Controls.Add(addPatientButton);
            Controls.Add(patientIsActive);
            Controls.Add(patientZip);
            Controls.Add(patientZipLabel);
            Controls.Add(patientGender);
            Controls.Add(patientGenderLabel);
            Controls.Add(patientState);
            Controls.Add(patientStateLabel);
            Controls.Add(patientCity);
            Controls.Add(patientCityLabel);
            Controls.Add(patientAddress2);
            Controls.Add(patientAddress2Label);
            Controls.Add(patientAddress1);
            Controls.Add(patientAddress1Label);
            Controls.Add(patientPhoneNumber);
            Controls.Add(label1);
            Controls.Add(patientBirthYear);
            Controls.Add(patientBirthDay);
            Controls.Add(DOBLabel);
            Controls.Add(patientBirthMonth);
            Controls.Add(patientLName);
            Controls.Add(patientLNameLabel);
            Controls.Add(patientFName);
            Controls.Add(patientFNameLabel);
            Controls.Add(cancelButton);
            Controls.Add(createPatientLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CreatePatientPage";
            Text = "Create Patient";
            Load += CreatePatientPage_Load;
            ((System.ComponentModel.ISupportInitialize)patientBirthMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthYear).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Label createPatientLabel;
        private Label patientFNameLabel;
        private TextBox patientFName;
        private TextBox patientLName;
        private Label patientLNameLabel;
        private NumericUpDown patientBirthMonth;
        private Label DOBLabel;
        private NumericUpDown patientBirthDay;
        private NumericUpDown patientBirthYear;
        private Label label1;
        private TextBox patientPhoneNumber;
        private TextBox patientAddress1;
        private Label patientAddress1Label;
        private TextBox patientAddress2;
        private Label patientAddress2Label;
        private TextBox patientCity;
        private Label patientCityLabel;
        private Label patientStateLabel;
        private ComboBox patientState;
        private Label patientGenderLabel;
        private ComboBox patientGender;
        private TextBox patientZip;
        private Label patientZipLabel;
        private CheckBox patientIsActive;
        private Button addPatientButton;
        private Label dashboardTitle;
        private Panel panel1;
        private Label fnameErrorLabel;
        private Label lnameErrorLabel;
        private Label dobErrorLabel;
        private Label phoneErrorLabel;
        private Label add1ErrorLabel;
        private Label stateErrorLabel;
        private Label cityErrorLabel;
        private Label zipErrorLabel;
        private Label genderErrorLabel;
    }
}