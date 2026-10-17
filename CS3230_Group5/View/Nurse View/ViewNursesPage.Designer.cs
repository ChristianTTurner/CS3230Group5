namespace CS3230_Group5.View.Nurse_View
{
    partial class ViewNursesPage
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
            nursesList = new ListView();
            viewNursesLabel = new Label();
            addNurseButton = new Button();
            menuPanel = new Panel();
            logoutButton = new Button();
            appointmentButton = new Button();
            patientsButton = new Button();
            nurseButton = new Button();
            homeButton = new Button();
            panel1 = new Panel();
            dashboardTitle = new Label();
            viewNurseButton = new Button();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nursesList
            // 
            nursesList.Location = new Point(346, 174);
            nursesList.Margin = new Padding(4);
            nursesList.Name = "nursesList";
            nursesList.Size = new Size(655, 550);
            nursesList.TabIndex = 0;
            nursesList.UseCompatibleStateImageBehavior = false;
            // 
            // viewNursesLabel
            // 
            viewNursesLabel.AutoSize = true;
            viewNursesLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewNursesLabel.Location = new Point(346, 81);
            viewNursesLabel.Margin = new Padding(4, 0, 4, 0);
            viewNursesLabel.Name = "viewNursesLabel";
            viewNursesLabel.Size = new Size(215, 76);
            viewNursesLabel.TabIndex = 1;
            viewNursesLabel.Text = "Nurses";
            viewNursesLabel.Click += viewNursesLabel_Click;
            // 
            // addNurseButton
            // 
            addNurseButton.BackColor = Color.ForestGreen;
            addNurseButton.FlatAppearance.BorderSize = 0;
            addNurseButton.FlatStyle = FlatStyle.Flat;
            addNurseButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addNurseButton.ForeColor = Color.White;
            addNurseButton.Location = new Point(609, 95);
            addNurseButton.Margin = new Padding(4);
            addNurseButton.Name = "addNurseButton";
            addNurseButton.Size = new Size(174, 46);
            addNurseButton.TabIndex = 3;
            addNurseButton.Text = "Add Nurse";
            addNurseButton.UseVisualStyleBackColor = false;
            addNurseButton.Click += addNurseButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.MidnightBlue;
            menuPanel.Controls.Add(logoutButton);
            menuPanel.Controls.Add(appointmentButton);
            menuPanel.Controls.Add(patientsButton);
            menuPanel.Controls.Add(nurseButton);
            menuPanel.Controls.Add(homeButton);
            menuPanel.Location = new Point(1, 61);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(316, 675);
            menuPanel.TabIndex = 6;
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
            panel1.Size = new Size(1010, 62);
            panel1.TabIndex = 7;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(21, 21);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(308, 28);
            dashboardTitle.TabIndex = 0;
            dashboardTitle.Text = "Healthcare Management System";
            // 
            // viewNurseButton
            // 
            viewNurseButton.BackColor = Color.RoyalBlue;
            viewNurseButton.FlatAppearance.BorderSize = 0;
            viewNurseButton.FlatStyle = FlatStyle.Flat;
            viewNurseButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            viewNurseButton.ForeColor = Color.White;
            viewNurseButton.Location = new Point(809, 95);
            viewNurseButton.Margin = new Padding(4);
            viewNurseButton.Name = "viewNurseButton";
            viewNurseButton.Size = new Size(192, 46);
            viewNurseButton.TabIndex = 8;
            viewNurseButton.Text = "View/Edit Profile";
            viewNurseButton.UseVisualStyleBackColor = false;
            // 
            // ViewNursesPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 737);
            Controls.Add(viewNurseButton);
            Controls.Add(panel1);
            Controls.Add(menuPanel);
            Controls.Add(addNurseButton);
            Controls.Add(viewNursesLabel);
            Controls.Add(nursesList);
            Margin = new Padding(4);
            Name = "ViewNursesPage";
            Text = "View Nurses";
            Load += ViewNursesPage_Load;
            menuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView nursesList;
        private Label viewNursesLabel;
        private Button addNurseButton;
        private Panel menuPanel;
        private Button logoutButton;
        private Button appointmentButton;
        private Button patientsButton;
        private Button nurseButton;
        private Button homeButton;
        private Panel panel1;
        private Label dashboardTitle;
        private Button viewNurseButton;
    }
}