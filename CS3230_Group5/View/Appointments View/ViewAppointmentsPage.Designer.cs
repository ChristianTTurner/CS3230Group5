namespace CS3230_Group5.View.Appointments_View
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dashboardTitle = new Label();
            panel1 = new Panel();
            logoutButton = new Button();
            appointmentButton = new Button();
            patientsButton = new Button();
            nurseButton = new Button();
            homeButton = new Button();
            menuPanel = new Panel();
            appointmentTitle = new Label();
            searchButton = new Button();
            searchAppointmentTextBox = new TextBox();
            createAppointmentButton = new Button();
            appointmentDataGridView = new DataGridView();
            appointment_id = new DataGridViewTextBoxColumn();
            patient_name = new DataGridViewTextBoxColumn();
            patient_dob = new DataGridViewTextBoxColumn();
            doctor_name = new DataGridViewTextBoxColumn();
            appointment_datetime = new DataGridViewTextBoxColumn();
            reason = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewButtonColumn();
            SearchErrorLabel = new Label();
            panel1.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1317, 85);
            panel1.TabIndex = 9;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.MidnightBlue;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(3, 602);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(310, 70);
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
            appointmentButton.Location = new Point(3, 285);
            appointmentButton.Name = "appointmentButton";
            appointmentButton.Size = new Size(310, 70);
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
            patientsButton.Location = new Point(3, 198);
            patientsButton.Name = "patientsButton";
            patientsButton.Size = new Size(310, 70);
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
            nurseButton.Location = new Point(3, 113);
            nurseButton.Name = "nurseButton";
            nurseButton.Size = new Size(310, 68);
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
            homeButton.Location = new Point(3, 14);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(310, 82);
            homeButton.TabIndex = 0;
            homeButton.Text = "🏠︎ Home";
            homeButton.UseVisualStyleBackColor = false;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.MidnightBlue;
            menuPanel.Controls.Add(logoutButton);
            menuPanel.Controls.Add(appointmentButton);
            menuPanel.Controls.Add(patientsButton);
            menuPanel.Controls.Add(nurseButton);
            menuPanel.Controls.Add(homeButton);
            menuPanel.Location = new Point(1, 77);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(316, 664);
            menuPanel.TabIndex = 10;
            // 
            // appointmentTitle
            // 
            appointmentTitle.AutoSize = true;
            appointmentTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentTitle.Location = new Point(340, 103);
            appointmentTitle.Name = "appointmentTitle";
            appointmentTitle.Size = new Size(379, 70);
            appointmentTitle.TabIndex = 11;
            appointmentTitle.Text = "Appointments";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.RoyalBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1172, 205);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 39);
            searchButton.TabIndex = 13;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // searchAppointmentTextBox
            // 
            searchAppointmentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchAppointmentTextBox.Location = new Point(340, 205);
            searchAppointmentTextBox.Margin = new Padding(4);
            searchAppointmentTextBox.Name = "searchAppointmentTextBox";
            searchAppointmentTextBox.PlaceholderText = "Search by name, phone or DOB";
            searchAppointmentTextBox.Size = new Size(812, 39);
            searchAppointmentTextBox.TabIndex = 12;
            // 
            // createAppointmentButton
            // 
            createAppointmentButton.BackColor = Color.ForestGreen;
            createAppointmentButton.FlatAppearance.BorderSize = 0;
            createAppointmentButton.FlatStyle = FlatStyle.Flat;
            createAppointmentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAppointmentButton.ForeColor = Color.White;
            createAppointmentButton.ImageAlign = ContentAlignment.TopCenter;
            createAppointmentButton.Location = new Point(991, 98);
            createAppointmentButton.Margin = new Padding(4);
            createAppointmentButton.Name = "createAppointmentButton";
            createAppointmentButton.Size = new Size(293, 70);
            createAppointmentButton.TabIndex = 14;
            createAppointmentButton.Text = "Create Appointment";
            createAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // appointmentDataGridView
            // 
            appointmentDataGridView.AllowUserToAddRows = false;
            appointmentDataGridView.AllowUserToDeleteRows = false;
            appointmentDataGridView.AllowUserToOrderColumns = true;
            appointmentDataGridView.AllowUserToResizeColumns = false;
            appointmentDataGridView.AllowUserToResizeRows = false;
            appointmentDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appointmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            appointmentDataGridView.BackgroundColor = Color.White;
            appointmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentDataGridView.Columns.AddRange(new DataGridViewColumn[] { appointment_id, patient_name, patient_dob, doctor_name, appointment_datetime, reason, btnView });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            appointmentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            appointmentDataGridView.GridColor = Color.White;
            appointmentDataGridView.Location = new Point(340, 275);
            appointmentDataGridView.MultiSelect = false;
            appointmentDataGridView.Name = "appointmentDataGridView";
            appointmentDataGridView.RowHeadersWidth = 62;
            appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDataGridView.Size = new Size(944, 454);
            appointmentDataGridView.TabIndex = 15;
            // 
            // appointment_id
            // 
            appointment_id.HeaderText = "Appointment ID";
            appointment_id.MinimumWidth = 8;
            appointment_id.Name = "appointment_id";
            appointment_id.ReadOnly = true;
            appointment_id.Visible = false;
            // 
            // patient_name
            // 
            patient_name.HeaderText = "Patient Name";
            patient_name.MinimumWidth = 8;
            patient_name.Name = "patient_name";
            patient_name.ReadOnly = true;
            // 
            // patient_dob
            // 
            patient_dob.HeaderText = "DOB";
            patient_dob.MinimumWidth = 8;
            patient_dob.Name = "patient_dob";
            patient_dob.ReadOnly = true;
            // 
            // doctor_name
            // 
            doctor_name.HeaderText = "Doctor Name";
            doctor_name.MinimumWidth = 8;
            doctor_name.Name = "doctor_name";
            doctor_name.ReadOnly = true;
            // 
            // appointment_datetime
            // 
            appointment_datetime.HeaderText = "Date & Time";
            appointment_datetime.MinimumWidth = 8;
            appointment_datetime.Name = "appointment_datetime";
            appointment_datetime.ReadOnly = true;
            // 
            // reason
            // 
            reason.HeaderText = "Reason";
            reason.MinimumWidth = 8;
            reason.Name = "reason";
            reason.ReadOnly = true;
            // 
            // btnView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            btnView.DefaultCellStyle = dataGridViewCellStyle1;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.HeaderText = "Action";
            btnView.MinimumWidth = 8;
            btnView.Name = "btnView";
            btnView.ReadOnly = true;
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            // 
            // SearchErrorLabel
            // 
            SearchErrorLabel.AutoSize = true;
            SearchErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchErrorLabel.ForeColor = Color.Red;
            SearchErrorLabel.Location = new Point(344, 244);
            SearchErrorLabel.Name = "SearchErrorLabel";
            SearchErrorLabel.Size = new Size(45, 21);
            SearchErrorLabel.TabIndex = 16;
            SearchErrorLabel.Text = "error";
            // 
            // ViewAppointmentsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 741);
            Controls.Add(SearchErrorLabel);
            Controls.Add(appointmentDataGridView);
            Controls.Add(createAppointmentButton);
            Controls.Add(searchButton);
            Controls.Add(searchAppointmentTextBox);
            Controls.Add(appointmentTitle);
            Controls.Add(menuPanel);
            Controls.Add(panel1);
            Name = "ViewAppointmentsPage";
            Text = "ViewAppointmentsPage";
            Load += ViewAppointmentsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashboardTitle;
        private Panel panel1;
        private Button logoutButton;
        private Button appointmentButton;
        private Button patientsButton;
        private Button nurseButton;
        private Button homeButton;
        private Panel menuPanel;
        private Label appointmentTitle;
        private Button searchButton;
        private TextBox searchAppointmentTextBox;
        private Button createAppointmentButton;
        private DataGridView appointmentDataGridView;
        private DataGridViewTextBoxColumn appointment_id;
        private DataGridViewTextBoxColumn patient_name;
        private DataGridViewTextBoxColumn patient_dob;
        private DataGridViewTextBoxColumn doctor_name;
        private DataGridViewTextBoxColumn appointment_datetime;
        private DataGridViewTextBoxColumn reason;
        private DataGridViewButtonColumn btnView;
        private Label SearchErrorLabel;
    }
}