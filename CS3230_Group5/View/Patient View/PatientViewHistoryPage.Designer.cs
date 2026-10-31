namespace CS3230_Group5.View.Patient_View
{
    partial class PatientViewHistoryPage
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dashboardTitle = new Label();
            backButton = new Button();
            profileLabel = new Label();
            personalPanel = new Panel();
            activeLabel = new Label();
            addressLabel = new Label();
            genderLabel = new Label();
            phoneLabel = new Label();
            dobLabel = new Label();
            patientNameLabel = new Label();
            patientIdLabel = new Label();
            patientHeaderLabel = new Label();
            visitHistoryDataGridView = new DataGridView();
            appointment_id = new DataGridViewTextBoxColumn();
            visit_datetime = new DataGridViewTextBoxColumn();
            doctor_name = new DataGridViewTextBoxColumn();
            visit_reason = new DataGridViewTextBoxColumn();
            initial_diagnosis = new DataGridViewTextBoxColumn();
            final_diagnosis = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewButtonColumn();
            visitsLabel = new Label();
            newAppointmentButton = new Button();
            panel1.SuspendLayout();
            personalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitHistoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 62);
            panel1.TabIndex = 47;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(11, 19);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(308, 28);
            dashboardTitle.TabIndex = 0;
            dashboardTitle.Text = "Healthcare Management System";
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(22, 74);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(229, 51);
            backButton.TabIndex = 48;
            backButton.Text = "🡠 Back to Patients";
            backButton.UseVisualStyleBackColor = true;
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileLabel.Location = new Point(325, 65);
            profileLabel.Margin = new Padding(4, 0, 4, 0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(454, 60);
            profileLabel.TabIndex = 49;
            profileLabel.Text = " Patient Visit History";
            // 
            // personalPanel
            // 
            personalPanel.BackColor = Color.White;
            personalPanel.Controls.Add(activeLabel);
            personalPanel.Controls.Add(addressLabel);
            personalPanel.Controls.Add(genderLabel);
            personalPanel.Controls.Add(phoneLabel);
            personalPanel.Controls.Add(dobLabel);
            personalPanel.Controls.Add(patientNameLabel);
            personalPanel.Controls.Add(patientIdLabel);
            personalPanel.Controls.Add(patientHeaderLabel);
            personalPanel.Location = new Point(22, 149);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(1055, 213);
            personalPanel.TabIndex = 50;
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activeLabel.Location = new Point(533, 173);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(70, 28);
            activeLabel.TabIndex = 51;
            activeLabel.Text = "Active:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.Location = new Point(533, 91);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(86, 28);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Address:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(16, 173);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(80, 28);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(533, 49);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(88, 28);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Phone #:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(16, 135);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(126, 28);
            dobLabel.TabIndex = 1;
            dobLabel.Text = "Date of Birth:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(16, 91);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(68, 28);
            patientNameLabel.TabIndex = 1;
            patientNameLabel.Text = "Name:";
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdLabel.Location = new Point(13, 49);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(100, 28);
            patientIdLabel.TabIndex = 1;
            patientIdLabel.Text = "Patient ID:";
            // 
            // patientHeaderLabel
            // 
            patientHeaderLabel.BackColor = Color.LightSteelBlue;
            patientHeaderLabel.FlatStyle = FlatStyle.Flat;
            patientHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientHeaderLabel.ForeColor = Color.Navy;
            patientHeaderLabel.Location = new Point(0, 0);
            patientHeaderLabel.Name = "patientHeaderLabel";
            patientHeaderLabel.Size = new Size(1055, 40);
            patientHeaderLabel.TabIndex = 0;
            patientHeaderLabel.Text = "Patient Information";
            patientHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // visitHistoryDataGridView
            // 
            visitHistoryDataGridView.AllowUserToAddRows = false;
            visitHistoryDataGridView.AllowUserToDeleteRows = false;
            visitHistoryDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            visitHistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            visitHistoryDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            visitHistoryDataGridView.BackgroundColor = Color.White;
            visitHistoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitHistoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { appointment_id, visit_datetime, doctor_name, visit_reason, initial_diagnosis, final_diagnosis, btnView });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            visitHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            visitHistoryDataGridView.GridColor = Color.White;
            visitHistoryDataGridView.Location = new Point(22, 421);
            visitHistoryDataGridView.MultiSelect = false;
            visitHistoryDataGridView.Name = "visitHistoryDataGridView";
            visitHistoryDataGridView.ReadOnly = true;
            visitHistoryDataGridView.RowHeadersWidth = 62;
            visitHistoryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visitHistoryDataGridView.Size = new Size(1055, 379);
            visitHistoryDataGridView.TabIndex = 51;
            // 
            // appointment_id
            // 
            appointment_id.HeaderText = "Appointment ID";
            appointment_id.MinimumWidth = 8;
            appointment_id.Name = "appointment_id";
            appointment_id.ReadOnly = true;
            appointment_id.SortMode = DataGridViewColumnSortMode.NotSortable;
            appointment_id.Visible = false;
            // 
            // visit_datetime
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            visit_datetime.DefaultCellStyle = dataGridViewCellStyle1;
            visit_datetime.FillWeight = 120F;
            visit_datetime.HeaderText = "Date & Time";
            visit_datetime.MinimumWidth = 8;
            visit_datetime.Name = "visit_datetime";
            visit_datetime.ReadOnly = true;
            // 
            // doctor_name
            // 
            doctor_name.HeaderText = "Doctor";
            doctor_name.MinimumWidth = 8;
            doctor_name.Name = "doctor_name";
            doctor_name.ReadOnly = true;
            // 
            // visit_reason
            // 
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            visit_reason.DefaultCellStyle = dataGridViewCellStyle2;
            visit_reason.FillWeight = 130F;
            visit_reason.HeaderText = "Reason";
            visit_reason.MinimumWidth = 8;
            visit_reason.Name = "visit_reason";
            visit_reason.ReadOnly = true;
            // 
            // initial_diagnosis
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            initial_diagnosis.DefaultCellStyle = dataGridViewCellStyle3;
            initial_diagnosis.FillWeight = 120F;
            initial_diagnosis.HeaderText = "Initial Diagnosis";
            initial_diagnosis.MinimumWidth = 8;
            initial_diagnosis.Name = "initial_diagnosis";
            initial_diagnosis.ReadOnly = true;
            // 
            // final_diagnosis
            // 
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            final_diagnosis.DefaultCellStyle = dataGridViewCellStyle4;
            final_diagnosis.FillWeight = 120F;
            final_diagnosis.HeaderText = "Final Diagnosis";
            final_diagnosis.MinimumWidth = 8;
            final_diagnosis.Name = "final_diagnosis";
            final_diagnosis.ReadOnly = true;
            // 
            // btnView
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            btnView.DefaultCellStyle = dataGridViewCellStyle5;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.HeaderText = "Action";
            btnView.MinimumWidth = 8;
            btnView.Name = "btnView";
            btnView.ReadOnly = true;
            btnView.Text = "Details";
            btnView.UseColumnTextForButtonValue = true;
            // 
            // visitsLabel
            // 
            visitsLabel.BackColor = Color.Honeydew;
            visitsLabel.BorderStyle = BorderStyle.FixedSingle;
            visitsLabel.FlatStyle = FlatStyle.Flat;
            visitsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            visitsLabel.ForeColor = Color.SeaGreen;
            visitsLabel.Location = new Point(22, 383);
            visitsLabel.Name = "visitsLabel";
            visitsLabel.Size = new Size(1055, 35);
            visitsLabel.TabIndex = 52;
            visitsLabel.Text = "Visits";
            visitsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // newAppointmentButton
            // 
            newAppointmentButton.BackColor = Color.RoyalBlue;
            newAppointmentButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAppointmentButton.ForeColor = Color.White;
            newAppointmentButton.Location = new Point(848, 74);
            newAppointmentButton.Margin = new Padding(4);
            newAppointmentButton.Name = "newAppointmentButton";
            newAppointmentButton.Size = new Size(229, 51);
            newAppointmentButton.TabIndex = 53;
            newAppointmentButton.Text = "+ New Appointment";
            newAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // PatientViewHistoryPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 836);
            Controls.Add(newAppointmentButton);
            Controls.Add(visitsLabel);
            Controls.Add(visitHistoryDataGridView);
            Controls.Add(personalPanel);
            Controls.Add(profileLabel);
            Controls.Add(backButton);
            Controls.Add(panel1);
            Name = "PatientViewHistoryPage";
            Text = "Patient Visit History";
            Load += PatientViewHistoryPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitHistoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label dashboardTitle;
        private Button backButton;
        private Label profileLabel;
        private Panel personalPanel;
        private Label phoneLabel;
        private Label dobLabel;
        private Label patientNameLabel;
        private Label patientIdLabel;
        private Label patientHeaderLabel;
        private Label activeLabel;
        private Label addressLabel;
        private Label genderLabel;
        private DataGridView visitHistoryDataGridView;
        private Label visitsLabel;
        private DataGridViewTextBoxColumn appointment_id;
        private DataGridViewTextBoxColumn visit_datetime;
        private DataGridViewTextBoxColumn doctor_name;
        private DataGridViewTextBoxColumn visit_reason;
        private DataGridViewTextBoxColumn initial_diagnosis;
        private DataGridViewTextBoxColumn final_diagnosis;
        private DataGridViewButtonColumn btnView;
        private Button newAppointmentButton;
    }
}