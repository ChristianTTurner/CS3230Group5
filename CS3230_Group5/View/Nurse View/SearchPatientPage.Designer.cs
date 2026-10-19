namespace CS3230_Group5.View.Nurse_View
{
    partial class SearchPatientPage
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
            patientList = new ListView();
            searchPatientTextBox = new TextBox();
            addPatientButton = new Button();
            deletePatientButton = new Button();
            menuPanel = new Panel();
            logoutButton = new Button();
            appointmentButton = new Button();
            patientsButton = new Button();
            nurseButton = new Button();
            homeButton = new Button();
            dashboardTitle = new Label();
            panel1 = new Panel();
            label1 = new Label();
            searchButton = new Button();
            viewPatientButton = new Button();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // patientList
            // 
            patientList.FullRowSelect = true;
            patientList.Location = new Point(342, 255);
            patientList.Margin = new Padding(4);
            patientList.MultiSelect = false;
            patientList.Name = "patientList";
            patientList.Size = new Size(958, 475);
            patientList.TabIndex = 0;
            patientList.UseCompatibleStateImageBehavior = false;
            patientList.ItemSelectionChanged += patientList_ItemSelectionChanged;
            patientList.DoubleClick += patientList_DoubleClick;
            // 
            // searchPatientTextBox
            // 
            searchPatientTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPatientTextBox.Location = new Point(342, 190);
            searchPatientTextBox.Margin = new Padding(4);
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.PlaceholderText = "Search by name, phone or DOB";
            searchPatientTextBox.Size = new Size(815, 39);
            searchPatientTextBox.TabIndex = 1;
            searchPatientTextBox.TextChanged += searchPatientTextBox_TextChanged;
            // 
            // addPatientButton
            // 
            addPatientButton.BackColor = Color.ForestGreen;
            addPatientButton.FlatAppearance.BorderSize = 0;
            addPatientButton.FlatStyle = FlatStyle.Flat;
            addPatientButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPatientButton.ForeColor = Color.White;
            addPatientButton.ImageAlign = ContentAlignment.TopCenter;
            addPatientButton.Location = new Point(916, 118);
            addPatientButton.Margin = new Padding(4);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(173, 46);
            addPatientButton.TabIndex = 2;
            addPatientButton.Text = "Add Patient";
            addPatientButton.UseVisualStyleBackColor = false;
            addPatientButton.Click += addPatientButton_Click;
            // 
            // deletePatientButton
            // 
            deletePatientButton.Enabled = false;
            deletePatientButton.Location = new Point(12, 45);
            deletePatientButton.Name = "deletePatientButton";
            deletePatientButton.Size = new Size(75, 27);
            deletePatientButton.TabIndex = 4;
            deletePatientButton.Text = "Delete";
            deletePatientButton.UseVisualStyleBackColor = true;
            deletePatientButton.Click += deletePatientButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.MidnightBlue;
            menuPanel.Controls.Add(logoutButton);
            menuPanel.Controls.Add(appointmentButton);
            menuPanel.Controls.Add(patientsButton);
            menuPanel.Controls.Add(nurseButton);
            menuPanel.Controls.Add(homeButton);
            menuPanel.Location = new Point(1, 68);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(316, 675);
            menuPanel.TabIndex = 7;
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
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1315, 71);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 94);
            label1.Name = "label1";
            label1.Size = new Size(226, 70);
            label1.TabIndex = 9;
            label1.Text = "Patients";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.RoyalBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1174, 190);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 39);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // viewPatientButton
            // 
            viewPatientButton.BackColor = Color.RoyalBlue;
            viewPatientButton.FlatAppearance.BorderSize = 0;
            viewPatientButton.FlatStyle = FlatStyle.Flat;
            viewPatientButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewPatientButton.ForeColor = Color.White;
            viewPatientButton.Location = new Point(1110, 118);
            viewPatientButton.Name = "viewPatientButton";
            viewPatientButton.Size = new Size(176, 46);
            viewPatientButton.TabIndex = 11;
            viewPatientButton.Text = "View Patient";
            viewPatientButton.UseVisualStyleBackColor = false;
            // 
            // SearchPatientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1313, 743);
            Controls.Add(viewPatientButton);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuPanel);
            Controls.Add(addPatientButton);
            Controls.Add(searchPatientTextBox);
            Controls.Add(patientList);
            Margin = new Padding(4);
            Name = "SearchPatientPage";
            Text = "Patients";
            Load += SearchPatientPage_Load;
            menuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView patientList;
        private TextBox searchPatientTextBox;
        private Button addPatientButton;
        private Button deletePatientButton;
        private Panel menuPanel;
        private Button logoutButton;
        private Button appointmentButton;
        private Button patientsButton;
        private Button nurseButton;
        private Button homeButton;
        private Label dashboardTitle;
        private Panel panel1;
        private Label label1;
        private Button searchButton;
        private Button viewPatientButton;
    }
}