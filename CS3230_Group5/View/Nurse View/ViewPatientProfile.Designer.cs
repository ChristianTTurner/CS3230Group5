namespace CS3230_Group5.View.Nurse_View
{
    partial class ViewPatientProfile
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
            patientNameLabel = new Label();
            backButton = new Button();
            personalPanel = new Panel();
            radioButton1 = new RadioButton();
            statusLabel = new Label();
            patientIdLabel = new Label();
            phoneLabel = new Label();
            dobLabel = new Label();
            lnameLabel = new Label();
            fnameLabel = new Label();
            personalHeaderLabel = new Label();
            addressPanel = new Panel();
            label2 = new Label();
            stateLabel = new Label();
            cityLabel = new Label();
            add2Label = new Label();
            add1Label = new Label();
            addressHeaderLabel = new Label();
            dashboardTitle = new Label();
            panel1 = new Panel();
            scheduleButton = new Button();
            logOutButton = new Button();
            personalPanel.SuspendLayout();
            addressPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(113, 117);
            patientNameLabel.Margin = new Padding(4, 0, 4, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(383, 65);
            patientNameLabel.TabIndex = 0;
            patientNameLabel.Text = "Patient's Profile";
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(12, 83);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(121, 42);
            backButton.TabIndex = 5;
            backButton.Text = "🡠 Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // personalPanel
            // 
            personalPanel.BackColor = Color.White;
            personalPanel.Controls.Add(radioButton1);
            personalPanel.Controls.Add(statusLabel);
            personalPanel.Controls.Add(patientIdLabel);
            personalPanel.Controls.Add(phoneLabel);
            personalPanel.Controls.Add(dobLabel);
            personalPanel.Controls.Add(lnameLabel);
            personalPanel.Controls.Add(fnameLabel);
            personalPanel.Controls.Add(personalHeaderLabel);
            personalPanel.Location = new Point(123, 206);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(816, 294);
            personalPanel.TabIndex = 13;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(94, 248);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 32);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Active";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(19, 248);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(69, 28);
            statusLabel.TabIndex = 17;
            statusLabel.Text = "Status:";
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdLabel.Location = new Point(18, 54);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(100, 28);
            patientIdLabel.TabIndex = 16;
            patientIdLabel.Text = "Patient ID:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(19, 208);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(88, 28);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Phone #:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(19, 169);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(126, 28);
            dobLabel.TabIndex = 1;
            dobLabel.Text = "Date of Birth:";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnameLabel.Location = new Point(19, 132);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(107, 28);
            lnameLabel.TabIndex = 1;
            lnameLabel.Text = "Last Name:";
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fnameLabel.Location = new Point(19, 91);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(110, 28);
            fnameLabel.TabIndex = 1;
            fnameLabel.Text = "First Name:";
            // 
            // personalHeaderLabel
            // 
            personalHeaderLabel.BackColor = Color.LightSteelBlue;
            personalHeaderLabel.FlatStyle = FlatStyle.Flat;
            personalHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            personalHeaderLabel.ForeColor = Color.Navy;
            personalHeaderLabel.Location = new Point(0, 0);
            personalHeaderLabel.Name = "personalHeaderLabel";
            personalHeaderLabel.Size = new Size(816, 40);
            personalHeaderLabel.TabIndex = 0;
            personalHeaderLabel.Text = "Personal Information";
            personalHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addressPanel
            // 
            addressPanel.BackColor = Color.White;
            addressPanel.Controls.Add(label2);
            addressPanel.Controls.Add(stateLabel);
            addressPanel.Controls.Add(cityLabel);
            addressPanel.Controls.Add(add2Label);
            addressPanel.Controls.Add(add1Label);
            addressPanel.Controls.Add(addressHeaderLabel);
            addressPanel.Location = new Point(123, 531);
            addressPanel.Name = "addressPanel";
            addressPanel.Size = new Size(816, 252);
            addressPanel.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 207);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 22;
            label2.Text = "Zip:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stateLabel.Location = new Point(17, 168);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(60, 28);
            stateLabel.TabIndex = 21;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cityLabel.Location = new Point(16, 131);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(50, 28);
            cityLabel.TabIndex = 20;
            cityLabel.Text = "City:";
            // 
            // add2Label
            // 
            add2Label.AutoSize = true;
            add2Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add2Label.Location = new Point(16, 91);
            add2Label.Name = "add2Label";
            add2Label.Size = new Size(102, 28);
            add2Label.TabIndex = 19;
            add2Label.Text = "Address 2:";
            // 
            // add1Label
            // 
            add1Label.AutoSize = true;
            add1Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add1Label.Location = new Point(16, 53);
            add1Label.Name = "add1Label";
            add1Label.Size = new Size(102, 28);
            add1Label.TabIndex = 18;
            add1Label.Text = "Address 1:";
            // 
            // addressHeaderLabel
            // 
            addressHeaderLabel.BackColor = Color.LightSteelBlue;
            addressHeaderLabel.FlatStyle = FlatStyle.Flat;
            addressHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressHeaderLabel.ForeColor = Color.Navy;
            addressHeaderLabel.Location = new Point(0, 0);
            addressHeaderLabel.Name = "addressHeaderLabel";
            addressHeaderLabel.Size = new Size(816, 40);
            addressHeaderLabel.TabIndex = 16;
            addressHeaderLabel.Text = "Address";
            addressHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(11, 18);
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
            panel1.Size = new Size(1039, 62);
            panel1.TabIndex = 16;
            // 
            // scheduleButton
            // 
            scheduleButton.BackColor = Color.RoyalBlue;
            scheduleButton.FlatAppearance.BorderSize = 0;
            scheduleButton.FlatStyle = FlatStyle.Flat;
            scheduleButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scheduleButton.ForeColor = Color.White;
            scheduleButton.Location = new Point(774, 812);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(250, 51);
            scheduleButton.TabIndex = 17;
            scheduleButton.Text = "Schedule Appointment";
            scheduleButton.UseVisualStyleBackColor = false;
            scheduleButton.Click += scheduleButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutButton.Location = new Point(13, 813);
            logOutButton.Margin = new Padding(4);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(150, 50);
            logOutButton.TabIndex = 19;
            logOutButton.Text = "➜] Logout";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // ViewPatientProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1036, 876);
            Controls.Add(logOutButton);
            Controls.Add(scheduleButton);
            Controls.Add(panel1);
            Controls.Add(addressPanel);
            Controls.Add(personalPanel);
            Controls.Add(backButton);
            Controls.Add(patientNameLabel);
            Margin = new Padding(4);
            Name = "ViewPatientProfile";
            Text = "Patient Profile";
            Load += ViewPatientProfile_Load;
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            addressPanel.ResumeLayout(false);
            addressPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label patientNameLabel;
        private Button backButton;
        private Panel personalPanel;
        private Label phoneLabel;
        private Label dobLabel;
        private Label lnameLabel;
        private Label fnameLabel;
        private Label personalHeaderLabel;
        private Panel addressPanel;
        private Label label2;
        private Label stateLabel;
        private Label cityLabel;
        private Label add2Label;
        private Label add1Label;
        private Label addressHeaderLabel;
        private Label dashboardTitle;
        private Panel panel1;
        private RadioButton radioButton1;
        private Label statusLabel;
        private Label patientIdLabel;
        private Button scheduleButton;
        private Button logOutButton;
       
    }
}