namespace CS3230_Group5
{
    partial class homePageButton
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPanel = new Panel();
            logoutButton = new Button();
            appointmentButton = new Button();
            patientsButton = new Button();
            nurseButton = new Button();
            homeButton = new Button();
            panel1 = new Panel();
            dashboardTitle = new Label();
            welcomeLabel = new Label();
            idLabel = new Label();
            userNameLabel = new Label();
            managePatients = new Button();
            managePatientLabel = new Label();
            manageAppointmentLabel = new Label();
            manageAppointments = new Button();
            manageNurseLabel = new Label();
            manageNurse = new Button();
            manageProfileLabel = new Label();
            manageProfile = new Button();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.MidnightBlue;
            menuPanel.Controls.Add(logoutButton);
            menuPanel.Controls.Add(appointmentButton);
            menuPanel.Controls.Add(patientsButton);
            menuPanel.Controls.Add(nurseButton);
            menuPanel.Controls.Add(homeButton);
            menuPanel.Location = new Point(1, 56);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(316, 675);
            menuPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.MidnightBlue;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(3, 591);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(310, 81);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "➜] Logout";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // appointmentButton
            // 
            appointmentButton.BackColor = Color.MidnightBlue;
            appointmentButton.FlatAppearance.BorderSize = 0;
            appointmentButton.FlatStyle = FlatStyle.Flat;
            appointmentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentButton.ForeColor = Color.White;
            appointmentButton.Location = new Point(3, 274);
            appointmentButton.Name = "appointmentButton";
            appointmentButton.Size = new Size(310, 81);
            appointmentButton.TabIndex = 3;
            appointmentButton.Text = "🗓️ Appointments";
            appointmentButton.UseVisualStyleBackColor = false;
            // 
            // patientsButton
            // 
            patientsButton.BackColor = Color.MidnightBlue;
            patientsButton.FlatAppearance.BorderSize = 0;
            patientsButton.FlatStyle = FlatStyle.Flat;
            patientsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientsButton.ForeColor = Color.White;
            patientsButton.Location = new Point(3, 187);
            patientsButton.Name = "patientsButton";
            patientsButton.Size = new Size(310, 81);
            patientsButton.TabIndex = 2;
            patientsButton.Text = "👥 Patients";
            patientsButton.UseVisualStyleBackColor = false;
            // 
            // nurseButton
            // 
            nurseButton.BackColor = Color.MidnightBlue;
            nurseButton.FlatAppearance.BorderSize = 0;
            nurseButton.FlatStyle = FlatStyle.Flat;
            nurseButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nurseButton.ForeColor = Color.White;
            nurseButton.Location = new Point(3, 102);
            nurseButton.Name = "nurseButton";
            nurseButton.Size = new Size(310, 79);
            nurseButton.TabIndex = 1;
            nurseButton.Text = "👤 Nurses";
            nurseButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            homeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            homeButton.BackColor = Color.MidnightBlue;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeButton.ForeColor = Color.White;
            homeButton.Location = new Point(3, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(310, 93);
            homeButton.TabIndex = 0;
            homeButton.Text = "🏠︎ Home";
            homeButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 62);
            panel1.TabIndex = 1;
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
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.MidnightBlue;
            welcomeLabel.Location = new Point(342, 89);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(114, 32);
            welcomeLabel.TabIndex = 2;
            welcomeLabel.Text = "Welcome";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(353, 168);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(72, 25);
            idLabel.TabIndex = 3;
            idLabel.Text = "User Id:";
            idLabel.Click += idLabel_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(353, 127);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(95, 25);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "Username:";
            // 
            // managePatients
            // 
            managePatients.BackColor = Color.LightSteelBlue;
            managePatients.FlatAppearance.BorderSize = 0;
            managePatients.FlatStyle = FlatStyle.Flat;
            managePatients.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managePatients.ForeColor = Color.MidnightBlue;
            managePatients.Location = new Point(353, 243);
            managePatients.Name = "managePatients";
            managePatients.Size = new Size(330, 149);
            managePatients.TabIndex = 5;
            managePatients.Text = "👥\r\nManage Patients\r\n\r\n\r\n\r\n";
            managePatients.TextAlign = ContentAlignment.TopCenter;
            managePatients.UseVisualStyleBackColor = false;
            // 
            // managePatientLabel
            // 
            managePatientLabel.AutoSize = true;
            managePatientLabel.BackColor = Color.LightSteelBlue;
            managePatientLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managePatientLabel.ForeColor = Color.Black;
            managePatientLabel.Location = new Point(368, 330);
            managePatientLabel.Name = "managePatientLabel";
            managePatientLabel.Size = new Size(303, 28);
            managePatientLabel.TabIndex = 6;
            managePatientLabel.Text = "Register, search and edit patient";
            // 
            // manageAppointmentLabel
            // 
            manageAppointmentLabel.AutoSize = true;
            manageAppointmentLabel.BackColor = Color.Wheat;
            manageAppointmentLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageAppointmentLabel.ForeColor = Color.Black;
            manageAppointmentLabel.Location = new Point(752, 330);
            manageAppointmentLabel.Name = "manageAppointmentLabel";
            manageAppointmentLabel.Size = new Size(290, 28);
            manageAppointmentLabel.TabIndex = 8;
            manageAppointmentLabel.Text = "Create and view appointments";
            // 
            // manageAppointments
            // 
            manageAppointments.BackColor = Color.Wheat;
            manageAppointments.FlatAppearance.BorderSize = 0;
            manageAppointments.FlatStyle = FlatStyle.Flat;
            manageAppointments.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageAppointments.ForeColor = Color.FromArgb(196, 98, 16);
            manageAppointments.Location = new Point(737, 243);
            manageAppointments.Name = "manageAppointments";
            manageAppointments.Size = new Size(330, 149);
            manageAppointments.TabIndex = 7;
            manageAppointments.Text = "🗓️\r\nAppointments\r\n\r\n\r\n\r\n\r\n";
            manageAppointments.TextAlign = ContentAlignment.TopCenter;
            manageAppointments.UseVisualStyleBackColor = false;
            // 
            // manageNurseLabel
            // 
            manageNurseLabel.AutoSize = true;
            manageNurseLabel.BackColor = Color.Honeydew;
            manageNurseLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageNurseLabel.ForeColor = Color.Black;
            manageNurseLabel.Location = new Point(381, 544);
            manageNurseLabel.Name = "manageNurseLabel";
            manageNurseLabel.Size = new Size(277, 28);
            manageNurseLabel.TabIndex = 10;
            manageNurseLabel.Text = "Add, view and update nurses";
            // 
            // manageNurse
            // 
            manageNurse.BackColor = Color.Honeydew;
            manageNurse.FlatAppearance.BorderSize = 0;
            manageNurse.FlatStyle = FlatStyle.Flat;
            manageNurse.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageNurse.ForeColor = Color.FromArgb(32, 109, 71);
            manageNurse.Location = new Point(353, 456);
            manageNurse.Name = "manageNurse";
            manageNurse.Size = new Size(330, 149);
            manageNurse.TabIndex = 9;
            manageNurse.Text = "👩🏻‍🏭\r\nManage Nurses\r\n\r\n\r\n\r\n\r\n\r\n";
            manageNurse.TextAlign = ContentAlignment.TopCenter;
            manageNurse.UseVisualStyleBackColor = false;
            // 
            // manageProfileLabel
            // 
            manageProfileLabel.AutoSize = true;
            manageProfileLabel.BackColor = Color.Silver;
            manageProfileLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageProfileLabel.ForeColor = Color.Black;
            manageProfileLabel.Location = new Point(780, 544);
            manageProfileLabel.Name = "manageProfileLabel";
            manageProfileLabel.Size = new Size(246, 28);
            manageProfileLabel.TabIndex = 12;
            manageProfileLabel.Text = "View account information";
            // 
            // manageProfile
            // 
            manageProfile.BackColor = Color.Silver;
            manageProfile.FlatAppearance.BorderSize = 0;
            manageProfile.FlatStyle = FlatStyle.Flat;
            manageProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageProfile.ForeColor = Color.Black;
            manageProfile.Location = new Point(737, 456);
            manageProfile.Name = "manageProfile";
            manageProfile.Size = new Size(330, 149);
            manageProfile.TabIndex = 11;
            manageProfile.Text = "👤\r\nMy Profile\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            manageProfile.TextAlign = ContentAlignment.TopCenter;
            manageProfile.UseVisualStyleBackColor = false;
            // 
            // homePageButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1166, 730);
            Controls.Add(manageProfileLabel);
            Controls.Add(manageProfile);
            Controls.Add(manageNurseLabel);
            Controls.Add(manageNurse);
            Controls.Add(manageAppointmentLabel);
            Controls.Add(manageAppointments);
            Controls.Add(managePatientLabel);
            Controls.Add(managePatients);
            Controls.Add(userNameLabel);
            Controls.Add(idLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(panel1);
            Controls.Add(menuPanel);
            Margin = new Padding(4);
            Name = "homePageButton";
            Text = "Home Page";
            Load += HomePage_Load;
            menuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel menuPanel;
        private Button homeButton;
        private Button nurseButton;
        private Button patientsButton;
        private Button appointmentButton;
        private Button logoutButton;
        private Panel panel1;
        private Label dashboardTitle;
        private Label welcomeLabel;
        private Label idLabel;
        private Label userNameLabel;
        private Button managePatients;
        private Label managePatientLabel;
        private Label manageAppointmentLabel;
        private Button manageAppointments;
        private Label manageNurseLabel;
        private Button manageNurse;
        private Label manageProfileLabel;
        private Button manageProfile;
    }
}
