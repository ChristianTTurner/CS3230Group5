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
            patientIsActive = new RadioButton();
            addPatientButton = new Button();
            ((System.ComponentModel.ISupportInitialize)patientBirthMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBirthYear).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(386, 31);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(91, 34);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // createPatientLabel
            // 
            createPatientLabel.AutoSize = true;
            createPatientLabel.Font = new Font("Segoe UI Semibold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPatientLabel.Location = new Point(2, 9);
            createPatientLabel.Name = "createPatientLabel";
            createPatientLabel.Size = new Size(378, 72);
            createPatientLabel.TabIndex = 20;
            createPatientLabel.Text = "Create Patient";
            // 
            // patientFNameLabel
            // 
            patientFNameLabel.AutoSize = true;
            patientFNameLabel.Font = new Font("Segoe UI", 12F);
            patientFNameLabel.Location = new Point(8, 125);
            patientFNameLabel.Name = "patientFNameLabel";
            patientFNameLabel.Size = new Size(110, 28);
            patientFNameLabel.TabIndex = 22;
            patientFNameLabel.Text = "First Name:";
            // 
            // patientFName
            // 
            patientFName.Font = new Font("Segoe UI", 12F);
            patientFName.Location = new Point(124, 122);
            patientFName.Name = "patientFName";
            patientFName.PlaceholderText = "Patients First Name";
            patientFName.Size = new Size(272, 34);
            patientFName.TabIndex = 23;
            // 
            // patientLName
            // 
            patientLName.Font = new Font("Segoe UI", 12F);
            patientLName.Location = new Point(519, 125);
            patientLName.Name = "patientLName";
            patientLName.PlaceholderText = "Patients Last Name";
            patientLName.Size = new Size(264, 34);
            patientLName.TabIndex = 25;
            // 
            // patientLNameLabel
            // 
            patientLNameLabel.AutoSize = true;
            patientLNameLabel.Font = new Font("Segoe UI", 12F);
            patientLNameLabel.Location = new Point(406, 128);
            patientLNameLabel.Name = "patientLNameLabel";
            patientLNameLabel.Size = new Size(107, 28);
            patientLNameLabel.TabIndex = 24;
            patientLNameLabel.Text = "Last Name:";
            // 
            // patientBirthMonth
            // 
            patientBirthMonth.Font = new Font("Segoe UI", 9F);
            patientBirthMonth.Location = new Point(199, 174);
            patientBirthMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            patientBirthMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            patientBirthMonth.Name = "patientBirthMonth";
            patientBirthMonth.Size = new Size(48, 27);
            patientBirthMonth.TabIndex = 26;
            patientBirthMonth.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // DOBLabel
            // 
            DOBLabel.AutoSize = true;
            DOBLabel.Font = new Font("Segoe UI", 12F);
            DOBLabel.Location = new Point(11, 171);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(187, 28);
            DOBLabel.TabIndex = 27;
            DOBLabel.Text = "DOB (mm/dd/yyyy):";
            // 
            // patientBirthDay
            // 
            patientBirthDay.Font = new Font("Segoe UI", 9F);
            patientBirthDay.Location = new Point(253, 174);
            patientBirthDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            patientBirthDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            patientBirthDay.Name = "patientBirthDay";
            patientBirthDay.Size = new Size(48, 27);
            patientBirthDay.TabIndex = 28;
            patientBirthDay.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // patientBirthYear
            // 
            patientBirthYear.Font = new Font("Segoe UI", 9F);
            patientBirthYear.Location = new Point(307, 174);
            patientBirthYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            patientBirthYear.Minimum = new decimal(new int[] { 1899, 0, 0, 0 });
            patientBirthYear.Name = "patientBirthYear";
            patientBirthYear.Size = new Size(92, 27);
            patientBirthYear.TabIndex = 29;
            patientBirthYear.Value = new decimal(new int[] { 1899, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(406, 174);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 30;
            label1.Text = "Phone #:";
            // 
            // patientPhoneNumber
            // 
            patientPhoneNumber.Font = new Font("Segoe UI", 12F);
            patientPhoneNumber.Location = new Point(500, 168);
            patientPhoneNumber.Name = "patientPhoneNumber";
            patientPhoneNumber.PlaceholderText = "xxx-xxx-xxxx";
            patientPhoneNumber.Size = new Size(283, 34);
            patientPhoneNumber.TabIndex = 31;
            // 
            // patientAddress1
            // 
            patientAddress1.Font = new Font("Segoe UI", 12F);
            patientAddress1.Location = new Point(116, 236);
            patientAddress1.Name = "patientAddress1";
            patientAddress1.Size = new Size(272, 34);
            patientAddress1.TabIndex = 35;
            // 
            // patientAddress1Label
            // 
            patientAddress1Label.AutoSize = true;
            patientAddress1Label.Font = new Font("Segoe UI", 12F);
            patientAddress1Label.Location = new Point(11, 239);
            patientAddress1Label.Name = "patientAddress1Label";
            patientAddress1Label.Size = new Size(99, 28);
            patientAddress1Label.TabIndex = 34;
            patientAddress1Label.Text = "address 1:";
            // 
            // patientAddress2
            // 
            patientAddress2.Font = new Font("Segoe UI", 12F);
            patientAddress2.Location = new Point(511, 239);
            patientAddress2.Name = "patientAddress2";
            patientAddress2.Size = new Size(272, 34);
            patientAddress2.TabIndex = 37;
            // 
            // patientAddress2Label
            // 
            patientAddress2Label.AutoSize = true;
            patientAddress2Label.Font = new Font("Segoe UI", 12F);
            patientAddress2Label.Location = new Point(406, 242);
            patientAddress2Label.Name = "patientAddress2Label";
            patientAddress2Label.Size = new Size(99, 28);
            patientAddress2Label.TabIndex = 36;
            patientAddress2Label.Text = "address 2:";
            // 
            // patientCity
            // 
            patientCity.Font = new Font("Segoe UI", 12F);
            patientCity.Location = new Point(326, 278);
            patientCity.Name = "patientCity";
            patientCity.Size = new Size(272, 34);
            patientCity.TabIndex = 39;
            // 
            // patientCityLabel
            // 
            patientCityLabel.AutoSize = true;
            patientCityLabel.Font = new Font("Segoe UI", 12F);
            patientCityLabel.Location = new Point(273, 281);
            patientCityLabel.Name = "patientCityLabel";
            patientCityLabel.Size = new Size(47, 28);
            patientCityLabel.TabIndex = 38;
            patientCityLabel.Text = "city:";
            // 
            // patientStateLabel
            // 
            patientStateLabel.AutoSize = true;
            patientStateLabel.Font = new Font("Segoe UI", 12F);
            patientStateLabel.Location = new Point(11, 281);
            patientStateLabel.Name = "patientStateLabel";
            patientStateLabel.Size = new Size(58, 28);
            patientStateLabel.TabIndex = 40;
            patientStateLabel.Text = "state:";
            // 
            // patientState
            // 
            patientState.FormattingEnabled = true;
            patientState.Items.AddRange(new object[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" });
            patientState.Location = new Point(75, 281);
            patientState.Name = "patientState";
            patientState.Size = new Size(192, 28);
            patientState.TabIndex = 41;
            // 
            // patientZip
            // 
            patientZip.Font = new Font("Segoe UI", 12F);
            patientZip.Location = new Point(656, 278);
            patientZip.Name = "patientZip";
            patientZip.Size = new Size(127, 34);
            patientZip.TabIndex = 43;
            // 
            // patientZipLabel
            // 
            patientZipLabel.AutoSize = true;
            patientZipLabel.Font = new Font("Segoe UI", 12F);
            patientZipLabel.Location = new Point(608, 281);
            patientZipLabel.Name = "patientZipLabel";
            patientZipLabel.Size = new Size(42, 28);
            patientZipLabel.TabIndex = 42;
            patientZipLabel.Text = "zip:";
            // 
            // patientIsActive
            // 
            patientIsActive.AutoSize = true;
            patientIsActive.Location = new Point(8, 332);
            patientIsActive.Name = "patientIsActive";
            patientIsActive.Size = new Size(71, 24);
            patientIsActive.TabIndex = 44;
            patientIsActive.TabStop = true;
            patientIsActive.Text = "Active";
            patientIsActive.UseVisualStyleBackColor = true;
            // 
            // addPatientButton
            // 
            addPatientButton.Location = new Point(678, 400);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(110, 38);
            addPatientButton.TabIndex = 45;
            addPatientButton.Text = "Add";
            addPatientButton.UseVisualStyleBackColor = true;
            // 
            // CreatePatientPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addPatientButton);
            Controls.Add(patientIsActive);
            Controls.Add(patientZip);
            Controls.Add(patientZipLabel);
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
        private TextBox patientZip;
        private Label patientZipLabel;
        private RadioButton patientIsActive;
        private Button addPatientButton;
    }
}