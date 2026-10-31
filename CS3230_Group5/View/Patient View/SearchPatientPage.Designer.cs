namespace CS3230_Group5.View.Patient_View
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            editPatientButton = new Button();
            dataGridView1 = new DataGridView();
            patient_id = new DataGridViewTextBoxColumn();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            active = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewButtonColumn();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchPatientTextBox
            // 
            searchPatientTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPatientTextBox.Location = new Point(342, 190);
            searchPatientTextBox.Margin = new Padding(4);
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.PlaceholderText = "Search by name, phone or DOB";
            searchPatientTextBox.Size = new Size(828, 39);
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
            addPatientButton.Location = new Point(936, 118);
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
            panel1.Size = new Size(1331, 71);
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
            searchButton.Location = new Point(1192, 190);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 39);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // editPatientButton
            // 
            editPatientButton.BackColor = Color.RoyalBlue;
            editPatientButton.FlatAppearance.BorderSize = 0;
            editPatientButton.FlatStyle = FlatStyle.Flat;
            editPatientButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPatientButton.ForeColor = Color.White;
            editPatientButton.Location = new Point(1128, 118);
            editPatientButton.Name = "editPatientButton";
            editPatientButton.Size = new Size(176, 46);
            editPatientButton.TabIndex = 11;
            editPatientButton.Text = "Edit Patient";
            editPatientButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { patient_id, first_name, last_name, dob, phone, gender, active, btnView });
            dataGridView1.Location = new Point(342, 236);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(962, 495);
            dataGridView1.TabIndex = 12;
            // 
            // patient_id
            // 
            patient_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patient_id.HeaderText = "Patient ID";
            patient_id.MinimumWidth = 8;
            patient_id.Name = "patient_id";
            patient_id.ReadOnly = true;
            // 
            // first_name
            // 
            first_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            first_name.HeaderText = "First Name";
            first_name.MinimumWidth = 8;
            first_name.Name = "first_name";
            first_name.ReadOnly = true;
            // 
            // last_name
            // 
            last_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            last_name.HeaderText = "Last Name";
            last_name.MinimumWidth = 8;
            last_name.Name = "last_name";
            last_name.ReadOnly = true;
            // 
            // dob
            // 
            dob.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dob.HeaderText = "DOB";
            dob.MinimumWidth = 8;
            dob.Name = "dob";
            dob.ReadOnly = true;
            // 
            // phone
            // 
            phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 8;
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // active
            // 
            active.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            active.HeaderText = "Active";
            active.MinimumWidth = 8;
            active.Name = "active";
            active.ReadOnly = true;
            // 
            // btnView
            // 
            btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            btnView.DefaultCellStyle = dataGridViewCellStyle2;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.HeaderText = "Visits";
            btnView.MinimumWidth = 8;
            btnView.Name = "btnView";
            btnView.ReadOnly = true;
            btnView.Resizable = DataGridViewTriState.True;
            btnView.Text = "View Visits";
            btnView.UseColumnTextForButtonValue = true;
            btnView.Width = 110;
            // 
            // SearchPatientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1331, 743);
            Controls.Add(dataGridView1);
            Controls.Add(editPatientButton);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuPanel);
            Controls.Add(addPatientButton);
            Controls.Add(searchPatientTextBox);
            Margin = new Padding(4);
            Name = "SearchPatientPage";
            Text = "Patients";
            Load += SearchPatientPage_Load;
            menuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button editPatientButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn patient_id;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn active;
        private DataGridViewButtonColumn btnView;
    }
}