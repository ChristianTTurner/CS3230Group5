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
            searchButton = new Button();
            label1 = new Label();
            bookAppointmentButton = new Button();
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
            panel1.SuspendLayout();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.RoyalBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(937, 142);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(90, 31);
            searchButton.TabIndex = 16;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
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
            // bookAppointmentButton
            // 
            bookAppointmentButton.BackColor = Color.ForestGreen;
            bookAppointmentButton.FlatAppearance.BorderSize = 0;
            bookAppointmentButton.FlatStyle = FlatStyle.Flat;
            bookAppointmentButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookAppointmentButton.ForeColor = Color.White;
            bookAppointmentButton.ImageAlign = ContentAlignment.TopCenter;
            bookAppointmentButton.Location = new Point(945, 86);
            bookAppointmentButton.Name = "bookAppointmentButton";
            bookAppointmentButton.Size = new Size(82, 37);
            bookAppointmentButton.TabIndex = 14;
            bookAppointmentButton.Text = "Book";
            bookAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // searchAppointmentTextBox
            // 
            searchAppointmentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchAppointmentTextBox.Location = new Point(272, 142);
            searchAppointmentTextBox.Name = "searchAppointmentTextBox";
            searchAppointmentTextBox.PlaceholderText = "Search by name, doctor, or appointment date";
            searchAppointmentTextBox.Size = new Size(653, 34);
            searchAppointmentTextBox.TabIndex = 13;
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
            // ViewAppointmentsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 611);
            Controls.Add(panel1);
            Controls.Add(menuPanel);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(bookAppointmentButton);
            Controls.Add(searchAppointmentTextBox);
            Controls.Add(appointmentList);
            Name = "ViewAppointmentsPage";
            Text = "ViewAppointmentsPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button searchButton;
        private Label label1;
        private Button bookAppointmentButton;
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
    }
}