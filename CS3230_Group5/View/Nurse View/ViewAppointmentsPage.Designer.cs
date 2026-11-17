namespace CS3230_Group5.View.Nurse_View
{
    partial class ViewAppointmentsPage
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
            editButton = new Button();
            label1 = new Label();
            searchAppointmentTextBox = new TextBox();
            appointmentList = new ListView();
            appointmentButton = new Button();
            patientsButton = new Button();
            nurseButton = new Button();
            homeButton = new Button();
            panel1 = new Panel();
            dashboardTitle = new Label();
            menuPanel = new Panel();
            logoutButton = new Button();
            viewSummaryButton = new Button();
            panel1.SuspendLayout();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.BackColor = Color.RoyalBlue;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(954, 143);
            editButton.Margin = new Padding(2);
            editButton.Name = "editButton";
            editButton.Size = new Size(90, 31);
            editButton.TabIndex = 16;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(321, 60);
            label1.TabIndex = 15;
            label1.Text = "Appointments";
            // 
            // searchAppointmentTextBox
            // 
            searchAppointmentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchAppointmentTextBox.Location = new Point(272, 142);
            searchAppointmentTextBox.Name = "searchAppointmentTextBox";
            searchAppointmentTextBox.PlaceholderText = "Search by name, doctor, or appointment date";
            searchAppointmentTextBox.Size = new Size(490, 34);
            searchAppointmentTextBox.TabIndex = 13;
            searchAppointmentTextBox.TextChanged += searchAppointmentTextBox_TextChanged;
            // 
            // appointmentList
            // 
            appointmentList.FullRowSelect = true;
            appointmentList.GridLines = true;
            appointmentList.Location = new Point(272, 194);
            appointmentList.MultiSelect = false;
            appointmentList.Name = "appointmentList";
            appointmentList.Size = new Size(767, 381);
            appointmentList.TabIndex = 12;
            appointmentList.UseCompatibleStateImageBehavior = false;
            appointmentList.View = System.Windows.Forms.View.Details;
            appointmentList.Click += appointmentList_Click;
            appointmentList.Leave += appointmentList_Leave;
            // 
            // appointmentButton
            // 
            appointmentButton.BackColor = Color.MidnightBlue;
            appointmentButton.FlatAppearance.BorderSize = 0;
            appointmentButton.FlatStyle = FlatStyle.Flat;
            appointmentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentButton.ForeColor = Color.White;
            appointmentButton.Location = new Point(2, 219);
            appointmentButton.Margin = new Padding(2);
            appointmentButton.Name = "appointmentButton";
            appointmentButton.Size = new Size(248, 65);
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
            patientsButton.Location = new Point(2, 150);
            patientsButton.Margin = new Padding(2);
            patientsButton.Name = "patientsButton";
            patientsButton.Size = new Size(248, 65);
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
            nurseButton.Location = new Point(2, 82);
            nurseButton.Margin = new Padding(2);
            nurseButton.Name = "nurseButton";
            nurseButton.Size = new Size(248, 63);
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
            homeButton.Location = new Point(2, 2);
            homeButton.Margin = new Padding(2);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(248, 74);
            homeButton.TabIndex = 0;
            homeButton.Text = "🏠︎ Home";
            homeButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 58);
            panel1.TabIndex = 19;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(17, 17);
            dashboardTitle.Margin = new Padding(2, 0, 2, 0);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(261, 23);
            dashboardTitle.TabIndex = 0;
            dashboardTitle.Text = "Healthcare Management System";
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.MidnightBlue;
            menuPanel.Controls.Add(logoutButton);
            menuPanel.Controls.Add(appointmentButton);
            menuPanel.Controls.Add(patientsButton);
            menuPanel.Controls.Add(nurseButton);
            menuPanel.Controls.Add(homeButton);
            menuPanel.Location = new Point(1, 55);
            menuPanel.Margin = new Padding(2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(259, 557);
            menuPanel.TabIndex = 18;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.MidnightBlue;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(2, 473);
            logoutButton.Margin = new Padding(2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(248, 65);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "➜] Logout";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // viewSummaryButton
            // 
            viewSummaryButton.BackColor = SystemColors.WindowFrame;
            viewSummaryButton.FlatStyle = FlatStyle.Flat;
            viewSummaryButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            viewSummaryButton.ForeColor = SystemColors.Control;
            viewSummaryButton.Location = new Point(777, 142);
            viewSummaryButton.Margin = new Padding(2, 2, 2, 2);
            viewSummaryButton.Name = "viewSummaryButton";
            viewSummaryButton.Size = new Size(163, 32);
            viewSummaryButton.TabIndex = 20;
            viewSummaryButton.Text = "View Summary";
            viewSummaryButton.UseVisualStyleBackColor = false;
            viewSummaryButton.Click += viewAppointment_Click;
            // 
            // ViewAppointmentsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 611);
            Controls.Add(viewSummaryButton);
            Controls.Add(panel1);
            Controls.Add(menuPanel);
            Controls.Add(editButton);
            Controls.Add(label1);
            Controls.Add(searchAppointmentTextBox);
            Controls.Add(appointmentList);
            Name = "ViewAppointmentsPage";
            Text = "ViewAppointmentsPage";
            Load += ViewAppointmentsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button editButton;
        private Label label1;
        private TextBox searchAppointmentTextBox;
        private ListView appointmentList;
        private Button appointmentButton;
        private Button patientsButton;
        private Button nurseButton;
        private Button homeButton;
        private Panel panel1;
        private Label dashboardTitle;
        private Panel menuPanel;
        private Button logoutButton;
        private Button viewSummaryButton;
    }
}