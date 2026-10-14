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
            ((System.ComponentModel.ISupportInitialize)patientBirthMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthYear).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(338, 23);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(80, 26);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // createPatientLabel
            // 
            createPatientLabel.AutoSize = true;
            createPatientLabel.Font = new Font("Segoe UI Semibold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPatientLabel.Location = new Point(2, 7);
            createPatientLabel.Name = "createPatientLabel";
            createPatientLabel.Size = new Size(301, 59);
            createPatientLabel.TabIndex = 20;
            createPatientLabel.Text = "Create Patient";
            // 
            // patientFNameLabel
            // 
            patientFNameLabel.AutoSize = true;
            patientFNameLabel.Font = new Font("Segoe UI", 12F);
            patientFNameLabel.Location = new Point(7, 94);
            patientFNameLabel.Name = "patientFNameLabel";
            patientFNameLabel.Size = new Size(89, 21);
            patientFNameLabel.TabIndex = 22;
            patientFNameLabel.Text = "First Name:";
            // 
            // patientFName
            // 
            patientFName.Font = new Font("Segoe UI", 12F);
            patientFName.Location = new Point(108, 92);
            patientFName.Margin = new Padding(3, 2, 3, 2);
            patientFName.Name = "patientFName";
            patientFName.PlaceholderText = "Patients First Name";
            patientFName.Size = new Size(238, 29);
            patientFName.TabIndex = 23;
            // 
            // patientLName
            // 
            patientLName.Font = new Font("Segoe UI", 12F);
            patientLName.Location = new Point(454, 94);
            patientLName.Margin = new Padding(3, 2, 3, 2);
            patientLName.Name = "patientLName";
            patientLName.PlaceholderText = "Patients Last Name";
            patientLName.Size = new Size(232, 29);
            patientLName.TabIndex = 25;
            // 
            // patientLNameLabel
            // 
            patientLNameLabel.AutoSize = true;
            patientLNameLabel.Font = new Font("Segoe UI", 12F);
            patientLNameLabel.Location = new Point(355, 96);
            patientLNameLabel.Name = "patientLNameLabel";
            patientLNameLabel.Size = new Size(87, 21);
            patientLNameLabel.TabIndex = 24;
            patientLNameLabel.Text = "Last Name:";
            // 
            // patientBirthMonth
            // 
            patientBirthMonth.Font = new Font("Segoe UI", 9F);
            patientBirthMonth.Location = new Point(174, 130);
            patientBirthMonth.Margin = new Padding(3, 2, 3, 2);
            patientBirthMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            patientBirthMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            patientBirthMonth.Name = "patientBirthMonth";
            patientBirthMonth.Size = new Size(42, 23);
            patientBirthMonth.TabIndex = 26;
            patientBirthMonth.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // DOBLabel
            // 
            DOBLabel.AutoSize = true;
            DOBLabel.Font = new Font("Segoe UI", 12F);
            DOBLabel.Location = new Point(10, 128);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(149, 21);
            DOBLabel.TabIndex = 27;
            DOBLabel.Text = "DOB (mm/dd/yyyy):";
            // 
            // patientBirthDay
            // 
            patientBirthDay.Font = new Font("Segoe UI", 9F);
            patientBirthDay.Location = new Point(221, 130);
            patientBirthDay.Margin = new Padding(3, 2, 3, 2);
            patientBirthDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            patientBirthDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            patientBirthDay.Name = "patientBirthDay";
            patientBirthDay.Size = new Size(42, 23);
            patientBirthDay.TabIndex = 28;
            patientBirthDay.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // patientBirthYear
            // 
            patientBirthYear.Font = new Font("Segoe UI", 9F);
            patientBirthYear.Location = new Point(269, 130);
            patientBirthYear.Margin = new Padding(3, 2, 3, 2);
            patientBirthYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            patientBirthYear.Minimum = new decimal(new int[] { 1899, 0, 0, 0 });
            patientBirthYear.Name = "patientBirthYear";
            patientBirthYear.Size = new Size(80, 23);
            patientBirthYear.TabIndex = 29;
            patientBirthYear.Value = new decimal(new int[] { 1899, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(355, 130);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 30;
            label1.Text = "Phone #:";
            // 
            // patientPhoneNumber
            // 
            patientPhoneNumber.Font = new Font("Segoe UI", 12F);
            patientPhoneNumber.Location = new Point(438, 126);
            patientPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            patientPhoneNumber.Name = "patientPhoneNumber";
            patientPhoneNumber.PlaceholderText = "xxx-xxx-xxxx";
            patientPhoneNumber.Size = new Size(248, 29);
            patientPhoneNumber.TabIndex = 31;
            // 
            // patientAddress1
            // 
            patientAddress1.Font = new Font("Segoe UI", 12F);
            patientAddress1.Location = new Point(102, 177);
            patientAddress1.Margin = new Padding(3, 2, 3, 2);
            patientAddress1.Name = "patientAddress1";
            patientAddress1.Size = new Size(238, 29);
            patientAddress1.TabIndex = 35;
            // 
            // patientAddress1Label
            // 
            patientAddress1Label.AutoSize = true;
            patientAddress1Label.Font = new Font("Segoe UI", 12F);
            patientAddress1Label.Location = new Point(10, 179);
            patientAddress1Label.Name = "patientAddress1Label";
            patientAddress1Label.Size = new Size(80, 21);
            patientAddress1Label.TabIndex = 34;
            patientAddress1Label.Text = "address 1:";
            // 
            // patientAddress2
            // 
            patientAddress2.Font = new Font("Segoe UI", 12F);
            patientAddress2.Location = new Point(447, 179);
            patientAddress2.Margin = new Padding(3, 2, 3, 2);
            patientAddress2.Name = "patientAddress2";
            patientAddress2.Size = new Size(238, 29);
            patientAddress2.TabIndex = 37;
            // 
            // patientAddress2Label
            // 
            patientAddress2Label.AutoSize = true;
            patientAddress2Label.Font = new Font("Segoe UI", 12F);
            patientAddress2Label.Location = new Point(355, 182);
            patientAddress2Label.Name = "patientAddress2Label";
            patientAddress2Label.Size = new Size(80, 21);
            patientAddress2Label.TabIndex = 36;
            patientAddress2Label.Text = "address 2:";
            // 
            // patientCity
            // 
            patientCity.Font = new Font("Segoe UI", 12F);
            patientCity.Location = new Point(285, 208);
            patientCity.Margin = new Padding(3, 2, 3, 2);
            patientCity.Name = "patientCity";
            patientCity.Size = new Size(238, 29);
            patientCity.TabIndex = 39;
            // 
            // patientCityLabel
            // 
            patientCityLabel.AutoSize = true;
            patientCityLabel.Font = new Font("Segoe UI", 12F);
            patientCityLabel.Location = new Point(239, 211);
            patientCityLabel.Name = "patientCityLabel";
            patientCityLabel.Size = new Size(37, 21);
            patientCityLabel.TabIndex = 38;
            patientCityLabel.Text = "city:";
            // 
            // patientStateLabel
            // 
            patientStateLabel.AutoSize = true;
            patientStateLabel.Font = new Font("Segoe UI", 12F);
            patientStateLabel.Location = new Point(10, 211);
            patientStateLabel.Name = "patientStateLabel";
            patientStateLabel.Size = new Size(46, 21);
            patientStateLabel.TabIndex = 40;
            patientStateLabel.Text = "state:";
            // 
            // patientState
            // 
            patientState.FormattingEnabled = true;
            patientState.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            patientState.Location = new Point(66, 211);
            patientState.Margin = new Padding(3, 2, 3, 2);
            patientState.Name = "patientState";
            patientState.Size = new Size(168, 23);
            patientState.TabIndex = 41;
            // 
            // patientZip
            // 
            patientZip.Font = new Font("Segoe UI", 12F);
            patientZip.Location = new Point(574, 208);
            patientZip.Margin = new Padding(3, 2, 3, 2);
            patientZip.Name = "patientZip";
            patientZip.Size = new Size(112, 29);
            patientZip.TabIndex = 43;
            // 
            // patientZipLabel
            // 
            patientZipLabel.AutoSize = true;
            patientZipLabel.Font = new Font("Segoe UI", 12F);
            patientZipLabel.Location = new Point(532, 211);
            patientZipLabel.Name = "patientZipLabel";
            patientZipLabel.Size = new Size(33, 21);
            patientZipLabel.TabIndex = 42;
            patientZipLabel.Text = "zip:";
            // 
            // patientIsActive
            // 
            patientIsActive.AutoSize = true;
            patientIsActive.Location = new Point(7, 249);
            patientIsActive.Margin = new Padding(3, 2, 3, 2);
            patientIsActive.Name = "patientIsActive";
            patientIsActive.Size = new Size(58, 19);
            patientIsActive.TabIndex = 44;
            patientIsActive.TabStop = true;
            patientIsActive.Text = "Active";
            patientIsActive.UseVisualStyleBackColor = true;
            // 
            // addPatientButton
            // 
            addPatientButton.Location = new Point(593, 300);
            addPatientButton.Margin = new Padding(3, 2, 3, 2);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(96, 28);
            addPatientButton.TabIndex = 45;
            addPatientButton.Text = "Add";
            addPatientButton.UseVisualStyleBackColor = true;
            addPatientButton.Click += addPatientButton_Click;
            // 
            // patientGenderLabel
            // 
            patientGenderLabel.AutoSize = true;
            patientGenderLabel.Font = new Font("Segoe UI", 12F);
            patientGenderLabel.Location = new Point(214, 246);
            patientGenderLabel.Name = "patientGenderLabel";
            patientGenderLabel.Size = new Size(62, 21);
            patientGenderLabel.TabIndex = 42;
            patientGenderLabel.Text = "gender:";
            // 
            // patientGender
            // 
            patientGender.Font = new Font("Segoe UI", 12F);
            patientGender.FormattingEnabled = true;
            patientGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            patientGender.Location = new Point(282, 243);
            patientGender.Margin = new Padding(3, 2, 3, 2);
            patientGender.Name = "patientGender";
            patientGender.Size = new Size(140, 29);
            patientGender.TabIndex = 43;
            // 
            // CreatePatientPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreatePatientPage";
            Text = "Create Patient";
            ((System.ComponentModel.ISupportInitialize)patientBirthMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthYear).EndInit();
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
    }
}