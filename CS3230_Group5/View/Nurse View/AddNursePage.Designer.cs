namespace CS3230_Group5.View.Nurse_View
{
    partial class AddNursePage
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
            nurseFirstNameLabel = new Label();
            nurseLastNameLabel = new Label();
            nurseDobLabel = new Label();
            AddNurseTitle = new Label();
            nursePhoneLabel = new Label();
            nurseadd1Label = new Label();
            nurseadd2Label = new Label();
            nurseCityLabel = new Label();
            nurseStateLabel = new Label();
            nurseZipLabel = new Label();
            nurseUsernameLabel = new Label();
            nursePasswordLabel = new Label();
            createLoginLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            nurseFirstName = new TextBox();
            nurseLastName = new TextBox();
            nurseBirthMonth = new NumericUpDown();
            nurseBirthDay = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            nursePhoneNum = new TextBox();
            nurseAddressLine1 = new TextBox();
            nurseAddressLine2 = new TextBox();
            nurseCity = new TextBox();
            nurseState = new TextBox();
            nurseZip = new TextBox();
            nurseUsername = new TextBox();
            nursePassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nurseBirthMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nurseBirthDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // nurseFirstNameLabel
            // 
            nurseFirstNameLabel.AutoSize = true;
            nurseFirstNameLabel.Font = new Font("Segoe UI", 12F);
            nurseFirstNameLabel.Location = new Point(127, 100);
            nurseFirstNameLabel.Margin = new Padding(4, 0, 4, 0);
            nurseFirstNameLabel.Name = "nurseFirstNameLabel";
            nurseFirstNameLabel.Size = new Size(134, 32);
            nurseFirstNameLabel.TabIndex = 0;
            nurseFirstNameLabel.Text = "First Name:";
            nurseFirstNameLabel.Click += label1_Click;
            // 
            // nurseLastNameLabel
            // 
            nurseLastNameLabel.AutoSize = true;
            nurseLastNameLabel.Font = new Font("Segoe UI", 12F);
            nurseLastNameLabel.Location = new Point(557, 100);
            nurseLastNameLabel.Margin = new Padding(4, 0, 4, 0);
            nurseLastNameLabel.Name = "nurseLastNameLabel";
            nurseLastNameLabel.Size = new Size(131, 32);
            nurseLastNameLabel.TabIndex = 1;
            nurseLastNameLabel.Text = "Last Name:";
            // 
            // nurseDobLabel
            // 
            nurseDobLabel.AutoSize = true;
            nurseDobLabel.Font = new Font("Segoe UI", 12F);
            nurseDobLabel.Location = new Point(127, 182);
            nurseDobLabel.Margin = new Padding(4, 0, 4, 0);
            nurseDobLabel.Name = "nurseDobLabel";
            nurseDobLabel.Size = new Size(225, 32);
            nurseDobLabel.TabIndex = 2;
            nurseDobLabel.Text = "DOB (mm/dd/yyyy):";
            nurseDobLabel.Click += label3_Click;
            // 
            // AddNurseTitle
            // 
            AddNurseTitle.AutoSize = true;
            AddNurseTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNurseTitle.Location = new Point(412, 12);
            AddNurseTitle.Margin = new Padding(4, 0, 4, 0);
            AddNurseTitle.Name = "AddNurseTitle";
            AddNurseTitle.Size = new Size(216, 54);
            AddNurseTitle.TabIndex = 3;
            AddNurseTitle.Text = "Add Nurse";
            AddNurseTitle.Click += label4_Click;
            // 
            // nursePhoneLabel
            // 
            nursePhoneLabel.AutoSize = true;
            nursePhoneLabel.Font = new Font("Segoe UI", 12F);
            nursePhoneLabel.Location = new Point(627, 182);
            nursePhoneLabel.Margin = new Padding(4, 0, 4, 0);
            nursePhoneLabel.Name = "nursePhoneLabel";
            nursePhoneLabel.Size = new Size(108, 32);
            nursePhoneLabel.TabIndex = 4;
            nursePhoneLabel.Text = "Phone #:";
            nursePhoneLabel.Click += label5_Click;
            // 
            // nurseadd1Label
            // 
            nurseadd1Label.AutoSize = true;
            nurseadd1Label.Font = new Font("Segoe UI", 12F);
            nurseadd1Label.Location = new Point(127, 256);
            nurseadd1Label.Margin = new Padding(4, 0, 4, 0);
            nurseadd1Label.Name = "nurseadd1Label";
            nurseadd1Label.Size = new Size(179, 32);
            nurseadd1Label.TabIndex = 5;
            nurseadd1Label.Text = "Street Address: ";
            // 
            // nurseadd2Label
            // 
            nurseadd2Label.AutoSize = true;
            nurseadd2Label.Font = new Font("Segoe UI", 12F);
            nurseadd2Label.Location = new Point(127, 321);
            nurseadd2Label.Margin = new Padding(4, 0, 4, 0);
            nurseadd2Label.Name = "nurseadd2Label";
            nurseadd2Label.Size = new Size(174, 32);
            nurseadd2Label.TabIndex = 6;
            nurseadd2Label.Text = "Address Line 2:";
            // 
            // nurseCityLabel
            // 
            nurseCityLabel.AutoSize = true;
            nurseCityLabel.Font = new Font("Segoe UI", 12F);
            nurseCityLabel.Location = new Point(127, 397);
            nurseCityLabel.Margin = new Padding(4, 0, 4, 0);
            nurseCityLabel.Name = "nurseCityLabel";
            nurseCityLabel.Size = new Size(60, 32);
            nurseCityLabel.TabIndex = 7;
            nurseCityLabel.Text = "City:";
            // 
            // nurseStateLabel
            // 
            nurseStateLabel.AutoSize = true;
            nurseStateLabel.Font = new Font("Segoe UI", 12F);
            nurseStateLabel.Location = new Point(426, 394);
            nurseStateLabel.Margin = new Padding(4, 0, 4, 0);
            nurseStateLabel.Name = "nurseStateLabel";
            nurseStateLabel.Size = new Size(72, 32);
            nurseStateLabel.TabIndex = 8;
            nurseStateLabel.Text = "State:";
            nurseStateLabel.Click += label9_Click;
            // 
            // nurseZipLabel
            // 
            nurseZipLabel.AutoSize = true;
            nurseZipLabel.Font = new Font("Segoe UI", 12F);
            nurseZipLabel.Location = new Point(709, 394);
            nurseZipLabel.Margin = new Padding(4, 0, 4, 0);
            nurseZipLabel.Name = "nurseZipLabel";
            nurseZipLabel.Size = new Size(53, 32);
            nurseZipLabel.TabIndex = 9;
            nurseZipLabel.Text = "Zip:";
            // 
            // nurseUsernameLabel
            // 
            nurseUsernameLabel.AutoSize = true;
            nurseUsernameLabel.Font = new Font("Segoe UI", 12F);
            nurseUsernameLabel.Location = new Point(127, 534);
            nurseUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            nurseUsernameLabel.Name = "nurseUsernameLabel";
            nurseUsernameLabel.Size = new Size(126, 32);
            nurseUsernameLabel.TabIndex = 10;
            nurseUsernameLabel.Text = "Username:";
            nurseUsernameLabel.Click += label11_Click;
            // 
            // nursePasswordLabel
            // 
            nursePasswordLabel.AutoSize = true;
            nursePasswordLabel.Font = new Font("Segoe UI", 12F);
            nursePasswordLabel.Location = new Point(127, 586);
            nursePasswordLabel.Margin = new Padding(4, 0, 4, 0);
            nursePasswordLabel.Name = "nursePasswordLabel";
            nursePasswordLabel.Size = new Size(111, 32);
            nursePasswordLabel.TabIndex = 11;
            nursePasswordLabel.Text = "Password";
            // 
            // createLoginLabel
            // 
            createLoginLabel.AutoSize = true;
            createLoginLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createLoginLabel.Location = new Point(127, 468);
            createLoginLabel.Margin = new Padding(4, 0, 4, 0);
            createLoginLabel.Name = "createLoginLabel";
            createLoginLabel.Size = new Size(227, 48);
            createLoginLabel.TabIndex = 12;
            createLoginLabel.Text = "Create Login";
            createLoginLabel.Click += loginLabel_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(354, 696);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(146, 44);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save";
            saveButton.TextAlign = ContentAlignment.TopCenter;
            saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(570, 696);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(146, 44);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // nurseFirstName
            // 
            nurseFirstName.Location = new Point(264, 93);
            nurseFirstName.Name = "nurseFirstName";
            nurseFirstName.PlaceholderText = "Jane";
            nurseFirstName.Size = new Size(268, 39);
            nurseFirstName.TabIndex = 15;
            nurseFirstName.Tag = "";
            // 
            // nurseLastName
            // 
            nurseLastName.Location = new Point(695, 93);
            nurseLastName.Name = "nurseLastName";
            nurseLastName.PlaceholderText = "Doe";
            nurseLastName.Size = new Size(289, 39);
            nurseLastName.TabIndex = 16;
            // 
            // nurseBirthMonth
            // 
            nurseBirthMonth.Location = new Point(351, 180);
            nurseBirthMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nurseBirthMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nurseBirthMonth.Name = "nurseBirthMonth";
            nurseBirthMonth.Size = new Size(62, 39);
            nurseBirthMonth.TabIndex = 17;
            nurseBirthMonth.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // nurseBirthDay
            // 
            nurseBirthDay.Location = new Point(426, 180);
            nurseBirthDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nurseBirthDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nurseBirthDay.Name = "nurseBirthDay";
            nurseBirthDay.Size = new Size(71, 39);
            nurseBirthDay.TabIndex = 18;
            nurseBirthDay.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(508, 180);
            numericUpDown1.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1899, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(89, 39);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.Value = new decimal(new int[] { 1999, 0, 0, 0 });
            // 
            // nursePhoneNum
            // 
            nursePhoneNum.ForeColor = SystemColors.WindowText;
            nursePhoneNum.Location = new Point(742, 175);
            nursePhoneNum.Name = "nursePhoneNum";
            nursePhoneNum.PlaceholderText = "xxx-xxx-xxxx";
            nursePhoneNum.Size = new Size(169, 39);
            nursePhoneNum.TabIndex = 20;
            // 
            // nurseAddressLine1
            // 
            nurseAddressLine1.Location = new Point(313, 249);
            nurseAddressLine1.Name = "nurseAddressLine1";
            nurseAddressLine1.PlaceholderText = "123 Main Rd";
            nurseAddressLine1.Size = new Size(417, 39);
            nurseAddressLine1.TabIndex = 21;
            // 
            // nurseAddressLine2
            // 
            nurseAddressLine2.Location = new Point(313, 314);
            nurseAddressLine2.Name = "nurseAddressLine2";
            nurseAddressLine2.PlaceholderText = "Address Line 2";
            nurseAddressLine2.Size = new Size(417, 39);
            nurseAddressLine2.TabIndex = 22;
            // 
            // nurseCity
            // 
            nurseCity.Location = new Point(192, 391);
            nurseCity.Name = "nurseCity";
            nurseCity.Size = new Size(221, 39);
            nurseCity.TabIndex = 23;
            // 
            // nurseState
            // 
            nurseState.Location = new Point(505, 394);
            nurseState.Name = "nurseState";
            nurseState.Size = new Size(184, 39);
            nurseState.TabIndex = 24;
            // 
            // nurseZip
            // 
            nurseZip.Location = new Point(761, 391);
            nurseZip.Name = "nurseZip";
            nurseZip.Size = new Size(150, 39);
            nurseZip.TabIndex = 25;
            nurseZip.TextChanged += nurseZip_TextChanged;
            // 
            // nurseUsername
            // 
            nurseUsername.Location = new Point(264, 531);
            nurseUsername.Name = "nurseUsername";
            nurseUsername.Size = new Size(327, 39);
            nurseUsername.TabIndex = 26;
            // 
            // nursePassword
            // 
            nursePassword.Location = new Point(264, 586);
            nursePassword.Name = "nursePassword";
            nursePassword.Size = new Size(327, 39);
            nursePassword.TabIndex = 27;
            // 
            // AddNursePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 764);
            Controls.Add(nursePassword);
            Controls.Add(nurseUsername);
            Controls.Add(nurseZip);
            Controls.Add(nurseState);
            Controls.Add(nurseCity);
            Controls.Add(nurseAddressLine2);
            Controls.Add(nurseAddressLine1);
            Controls.Add(nursePhoneNum);
            Controls.Add(numericUpDown1);
            Controls.Add(nurseBirthDay);
            Controls.Add(nurseBirthMonth);
            Controls.Add(nurseLastName);
            Controls.Add(nurseFirstName);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(createLoginLabel);
            Controls.Add(nursePasswordLabel);
            Controls.Add(nurseUsernameLabel);
            Controls.Add(nurseZipLabel);
            Controls.Add(nurseStateLabel);
            Controls.Add(nurseCityLabel);
            Controls.Add(nurseadd2Label);
            Controls.Add(nurseadd1Label);
            Controls.Add(nursePhoneLabel);
            Controls.Add(AddNurseTitle);
            Controls.Add(nurseDobLabel);
            Controls.Add(nurseLastNameLabel);
            Controls.Add(nurseFirstNameLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AddNursePage";
            Text = "AddNursePage";
            Load += AddNursePage_Load;
            ((System.ComponentModel.ISupportInitialize)nurseBirthMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nurseBirthDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nurseFirstNameLabel;
        private Label nurseLastNameLabel;
        private Label nurseDobLabel;
        private Label AddNurseTitle;
        private Label nursePhoneLabel;
        private Label nurseadd1Label;
        private Label nurseadd2Label;
        private Label nurseCityLabel;
        private Label nurseStateLabel;
        private Label nurseZipLabel;
        private Label nurseUsernameLabel;
        private Label nursePasswordLabel;
        private Label createLoginLabel;
        private Button saveButton;
        private Button cancelButton;
        private TextBox nurseFirstName;
        private TextBox nurseLastName;
        private NumericUpDown nurseBirthMonth;
        private NumericUpDown nurseBirthDay;
        private NumericUpDown numericUpDown1;
        private TextBox nursePhoneNum;
        private TextBox nurseAddressLine1;
        private TextBox nurseAddressLine2;
        private TextBox nurseCity;
        private TextBox nurseState;
        private TextBox nurseZip;
        private TextBox nurseUsername;
        private TextBox nursePassword;
    }
}