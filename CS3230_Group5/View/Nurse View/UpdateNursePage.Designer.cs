namespace CS3230_Group5.View.Nurse_View
{
    partial class UpdateNursePage
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
            updateNurseLabel = new Label();
            nurseFirstNameLabel = new Label();
            nurseLastNameLabel = new Label();
            nurseDobLabel = new Label();
            nursePhoneLabel = new Label();
            nurseadd1Label = new Label();
            nurseadd2Label = new Label();
            nurseCityLabel = new Label();
            nurseStateLabel = new Label();
            nurseZipLabel = new Label();
            nurseUsernameLabel = new Label();
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
            dashboardTitle = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nurseBirthMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nurseBirthDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // updateNurseLabel
            // 
            updateNurseLabel.AutoSize = true;
            updateNurseLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateNurseLabel.Location = new Point(365, 65);
            updateNurseLabel.Margin = new Padding(4, 0, 4, 0);
            updateNurseLabel.Name = "updateNurseLabel";
            updateNurseLabel.Size = new Size(366, 70);
            updateNurseLabel.TabIndex = 3;
            updateNurseLabel.Text = "Update Nurse";
            updateNurseLabel.Click += label4_Click;
            // 
            // nurseFirstNameLabel
            // 
            nurseFirstNameLabel.AutoSize = true;
            nurseFirstNameLabel.Font = new Font("Segoe UI", 12F);
            nurseFirstNameLabel.Location = new Point(128, 168);
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
            nurseLastNameLabel.Location = new Point(558, 168);
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
            nurseDobLabel.Location = new Point(128, 250);
            nurseDobLabel.Margin = new Padding(4, 0, 4, 0);
            nurseDobLabel.Name = "nurseDobLabel";
            nurseDobLabel.Size = new Size(225, 32);
            nurseDobLabel.TabIndex = 2;
            nurseDobLabel.Text = "DOB (mm/dd/yyyy):";
            nurseDobLabel.Click += label3_Click;
            // 
            // nursePhoneLabel
            // 
            nursePhoneLabel.AutoSize = true;
            nursePhoneLabel.Font = new Font("Segoe UI", 12F);
            nursePhoneLabel.Location = new Point(628, 250);
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
            nurseadd1Label.Location = new Point(128, 324);
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
            nurseadd2Label.Location = new Point(128, 389);
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
            nurseCityLabel.Location = new Point(128, 465);
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
            nurseStateLabel.Location = new Point(427, 462);
            nurseStateLabel.Margin = new Padding(4, 0, 4, 0);
            nurseStateLabel.Name = "nurseStateLabel";
            nurseStateLabel.Size = new Size(72, 32);
            nurseStateLabel.TabIndex = 8;
            nurseStateLabel.Text = "State:";
            // 
            // nurseZipLabel
            // 
            nurseZipLabel.AutoSize = true;
            nurseZipLabel.Font = new Font("Segoe UI", 12F);
            nurseZipLabel.Location = new Point(628, 462);
            nurseZipLabel.Margin = new Padding(4, 0, 4, 0);
            nurseZipLabel.Name = "nurseZipLabel";
            nurseZipLabel.Size = new Size(52, 32);
            nurseZipLabel.TabIndex = 9;
            nurseZipLabel.Text = "ZIP:";
            // 
            // nurseUsernameLabel
            // 
            nurseUsernameLabel.AutoSize = true;
            nurseUsernameLabel.Font = new Font("Segoe UI", 12F);
            nurseUsernameLabel.Location = new Point(128, 523);
            nurseUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            nurseUsernameLabel.Name = "nurseUsernameLabel";
            nurseUsernameLabel.Size = new Size(126, 32);
            nurseUsernameLabel.TabIndex = 10;
            nurseUsernameLabel.Text = "Username:";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(400, 602);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 50);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(558, 602);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 50);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // nurseFirstName
            // 
            nurseFirstName.Location = new Point(268, 168);
            nurseFirstName.Margin = new Padding(4);
            nurseFirstName.Name = "nurseFirstName";
            nurseFirstName.Size = new Size(240, 31);
            nurseFirstName.TabIndex = 13;
            // 
            // nurseLastName
            // 
            nurseLastName.Location = new Point(716, 168);
            nurseLastName.Margin = new Padding(4);
            nurseLastName.Name = "nurseLastName";
            nurseLastName.Size = new Size(240, 31);
            nurseLastName.TabIndex = 14;
            // 
            // nurseBirthMonth
            // 
            nurseBirthMonth.Location = new Point(365, 250);
            nurseBirthMonth.Margin = new Padding(4);
            nurseBirthMonth.Name = "nurseBirthMonth";
            nurseBirthMonth.Size = new Size(61, 31);
            nurseBirthMonth.TabIndex = 15;
            // 
            // nurseBirthDay
            // 
            nurseBirthDay.Location = new Point(436, 250);
            nurseBirthDay.Margin = new Padding(4);
            nurseBirthDay.Name = "nurseBirthDay";
            nurseBirthDay.Size = new Size(61, 31);
            nurseBirthDay.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(506, 250);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(88, 31);
            numericUpDown1.TabIndex = 17;
            // 
            // nursePhoneNum
            // 
            nursePhoneNum.Location = new Point(744, 250);
            nursePhoneNum.Margin = new Padding(4);
            nursePhoneNum.Name = "nursePhoneNum";
            nursePhoneNum.Size = new Size(212, 31);
            nursePhoneNum.TabIndex = 18;
            // 
            // nurseAddressLine1
            // 
            nurseAddressLine1.Location = new Point(315, 324);
            nurseAddressLine1.Margin = new Padding(4);
            nurseAddressLine1.Name = "nurseAddressLine1";
            nurseAddressLine1.Size = new Size(641, 31);
            nurseAddressLine1.TabIndex = 19;
            // 
            // nurseAddressLine2
            // 
            nurseAddressLine2.Location = new Point(315, 389);
            nurseAddressLine2.Margin = new Padding(4);
            nurseAddressLine2.Name = "nurseAddressLine2";
            nurseAddressLine2.Size = new Size(641, 31);
            nurseAddressLine2.TabIndex = 20;
            // 
            // nurseCity
            // 
            nurseCity.Location = new Point(194, 465);
            nurseCity.Margin = new Padding(4);
            nurseCity.Name = "nurseCity";
            nurseCity.Size = new Size(212, 31);
            nurseCity.TabIndex = 21;
            // 
            // nurseState
            // 
            nurseState.Location = new Point(505, 462);
            nurseState.Margin = new Padding(4);
            nurseState.Name = "nurseState";
            nurseState.Size = new Size(88, 31);
            nurseState.TabIndex = 22;
            // 
            // nurseZip
            // 
            nurseZip.Location = new Point(698, 462);
            nurseZip.Margin = new Padding(4);
            nurseZip.Name = "nurseZip";
            nurseZip.Size = new Size(120, 31);
            nurseZip.TabIndex = 23;
            // 
            // nurseUsername
            // 
            nurseUsername.Location = new Point(268, 523);
            nurseUsername.Margin = new Padding(4);
            nurseUsername.Name = "nurseUsername";
            nurseUsername.Size = new Size(472, 31);
            nurseUsername.TabIndex = 24;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(11, 9);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(308, 28);
            dashboardTitle.TabIndex = 0;
            dashboardTitle.Text = "Healthcare Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 62);
            panel1.TabIndex = 29;
            // 
            // UpdateNursePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1095, 681);
            Controls.Add(panel1);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
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
            Controls.Add(nurseUsernameLabel);
            Controls.Add(nurseZipLabel);
            Controls.Add(nurseStateLabel);
            Controls.Add(nurseCityLabel);
            Controls.Add(nurseadd2Label);
            Controls.Add(nurseadd1Label);
            Controls.Add(nursePhoneLabel);
            Controls.Add(updateNurseLabel);
            Controls.Add(nurseDobLabel);
            Controls.Add(nurseLastNameLabel);
            Controls.Add(nurseFirstNameLabel);
            Name = "UpdateNursePage";
            Text = "Update Nurse";
            Load += UpdateNursePage_Load_1;
            ((System.ComponentModel.ISupportInitialize)nurseBirthMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nurseBirthDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nurseFirstNameLabel;
        private Label nurseLastNameLabel;
        private Label nurseDobLabel;
        private Label updateNurseLabel;
        private Label nursePhoneLabel;
        private Label nurseadd1Label;
        private Label nurseadd2Label;
        private Label nurseCityLabel;
        private Label nurseStateLabel;
        private Label nurseZipLabel;
        private Label nurseUsernameLabel;
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
        private Label dashboardTitle;
        private Panel panel1;
    }
}