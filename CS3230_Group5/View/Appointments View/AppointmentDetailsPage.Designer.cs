namespace CS3230_Group5.View.Appointments_View
{
    partial class AppointmentDetailsPage
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
            dashboardTitle = new Label();
            panel1 = new Panel();
            backButton = new Button();
            appointmentDetailsLabel = new Label();
            patientInfoPanel = new Panel();
            phoneLabel = new Label();
            dobLabel = new Label();
            lnameLabel = new Label();
            fnameLabel = new Label();
            patientHeaderLabel = new Label();
            appointmentPanel = new Panel();
            reasonLabel = new Label();
            doctorLabel = new Label();
            datetimeLabel = new Label();
            appointmentIdLabel = new Label();
            appointmentHeaderLabel = new Label();
            patientIdLabel = new Label();
            checkUpHeaderLabel = new Label();
            checkUpPanel = new Panel();
            systolicLabel = new Label();
            diastolicLabel = new Label();
            pulseLabel = new Label();
            symptomsLabel = new Label();
            temperatureLabel = new Label();
            heightLabel = new Label();
            weightLabel = new Label();
            labDiagnosisPanel = new Panel();
            diagnosisLabel = new Label();
            labDiagnosisLabel = new Label();
            editAppointmentButton = new Button();
            symptomsTextBox = new TextBox();
            checkUpButton = new Button();
            initialDiagnosisTextBox = new TextBox();
            initialDiagnosisButton = new Button();
            orderedTestLabel = new Label();
            orderedTestDataGridView = new DataGridView();
            testCodeColumn = new DataGridViewTextBoxColumn();
            testNameColumn = new DataGridViewTextBoxColumn();
            performedDateTimeColumn = new DataGridViewTextBoxColumn();
            resultColumn = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            viewTestButton = new Button();
            orderTestButton = new Button();
            finalDiagnosisTextBox = new TextBox();
            finalDiagnosisButton = new Button();
            finalDiagnosisLabel = new Label();
            panel1.SuspendLayout();
            patientInfoPanel.SuspendLayout();
            appointmentPanel.SuspendLayout();
            checkUpPanel.SuspendLayout();
            labDiagnosisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderedTestDataGridView).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1272, 62);
            panel1.TabIndex = 12;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(13, 79);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(141, 51);
            backButton.TabIndex = 13;
            backButton.Text = "🡠 Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // appointmentDetailsLabel
            // 
            appointmentDetailsLabel.AutoSize = true;
            appointmentDetailsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentDetailsLabel.Location = new Point(171, 65);
            appointmentDetailsLabel.Margin = new Padding(4, 0, 4, 0);
            appointmentDetailsLabel.Name = "appointmentDetailsLabel";
            appointmentDetailsLabel.Size = new Size(499, 65);
            appointmentDetailsLabel.TabIndex = 14;
            appointmentDetailsLabel.Text = "Appointment Details";
            appointmentDetailsLabel.Click += profileLabel_Click;
            // 
            // patientInfoPanel
            // 
            patientInfoPanel.BackColor = Color.White;
            patientInfoPanel.Controls.Add(patientIdLabel);
            patientInfoPanel.Controls.Add(phoneLabel);
            patientInfoPanel.Controls.Add(dobLabel);
            patientInfoPanel.Controls.Add(lnameLabel);
            patientInfoPanel.Controls.Add(fnameLabel);
            patientInfoPanel.Controls.Add(patientHeaderLabel);
            patientInfoPanel.Location = new Point(13, 148);
            patientInfoPanel.Name = "patientInfoPanel";
            patientInfoPanel.Size = new Size(616, 248);
            patientInfoPanel.TabIndex = 15;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(15, 197);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(88, 28);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Phone #:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(15, 160);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(126, 28);
            dobLabel.TabIndex = 1;
            dobLabel.Text = "Date of Birth:";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnameLabel.Location = new Point(17, 121);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(107, 28);
            lnameLabel.TabIndex = 1;
            lnameLabel.Text = "Last Name:";
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fnameLabel.Location = new Point(17, 82);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(110, 28);
            fnameLabel.TabIndex = 1;
            fnameLabel.Text = "First Name:";
            // 
            // patientHeaderLabel
            // 
            patientHeaderLabel.BackColor = Color.LightSteelBlue;
            patientHeaderLabel.FlatStyle = FlatStyle.Flat;
            patientHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientHeaderLabel.ForeColor = Color.Navy;
            patientHeaderLabel.Location = new Point(0, 0);
            patientHeaderLabel.Name = "patientHeaderLabel";
            patientHeaderLabel.Size = new Size(616, 40);
            patientHeaderLabel.TabIndex = 0;
            patientHeaderLabel.Text = "Patient Information";
            patientHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // appointmentPanel
            // 
            appointmentPanel.BackColor = Color.White;
            appointmentPanel.Controls.Add(editAppointmentButton);
            appointmentPanel.Controls.Add(reasonLabel);
            appointmentPanel.Controls.Add(doctorLabel);
            appointmentPanel.Controls.Add(datetimeLabel);
            appointmentPanel.Controls.Add(appointmentIdLabel);
            appointmentPanel.Controls.Add(appointmentHeaderLabel);
            appointmentPanel.Location = new Point(655, 148);
            appointmentPanel.Name = "appointmentPanel";
            appointmentPanel.Size = new Size(606, 248);
            appointmentPanel.TabIndex = 16;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonLabel.Location = new Point(16, 172);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(78, 28);
            reasonLabel.TabIndex = 15;
            reasonLabel.Text = "Reason:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorLabel.Location = new Point(16, 135);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(77, 28);
            doctorLabel.TabIndex = 1;
            doctorLabel.Text = "Doctor:";
            // 
            // datetimeLabel
            // 
            datetimeLabel.AutoSize = true;
            datetimeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datetimeLabel.Location = new Point(16, 91);
            datetimeLabel.Name = "datetimeLabel";
            datetimeLabel.Size = new Size(117, 28);
            datetimeLabel.TabIndex = 1;
            datetimeLabel.Text = "Date / Time:";
            // 
            // appointmentIdLabel
            // 
            appointmentIdLabel.AutoSize = true;
            appointmentIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentIdLabel.Location = new Point(13, 49);
            appointmentIdLabel.Name = "appointmentIdLabel";
            appointmentIdLabel.Size = new Size(157, 28);
            appointmentIdLabel.TabIndex = 1;
            appointmentIdLabel.Text = "Appointment ID:";
            // 
            // appointmentHeaderLabel
            // 
            appointmentHeaderLabel.BackColor = Color.Honeydew;
            appointmentHeaderLabel.FlatStyle = FlatStyle.Flat;
            appointmentHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentHeaderLabel.ForeColor = Color.FromArgb(32, 109, 71);
            appointmentHeaderLabel.Location = new Point(0, 0);
            appointmentHeaderLabel.Name = "appointmentHeaderLabel";
            appointmentHeaderLabel.Size = new Size(606, 40);
            appointmentHeaderLabel.TabIndex = 0;
            appointmentHeaderLabel.Text = "Appointment Information";
            appointmentHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdLabel.Location = new Point(17, 49);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(100, 28);
            patientIdLabel.TabIndex = 16;
            patientIdLabel.Text = "Patient ID:";
            // 
            // checkUpHeaderLabel
            // 
            checkUpHeaderLabel.BackColor = Color.Wheat;
            checkUpHeaderLabel.FlatStyle = FlatStyle.Flat;
            checkUpHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkUpHeaderLabel.ForeColor = Color.FromArgb(196, 98, 16);
            checkUpHeaderLabel.Location = new Point(0, 0);
            checkUpHeaderLabel.Name = "checkUpHeaderLabel";
            checkUpHeaderLabel.Size = new Size(1246, 40);
            checkUpHeaderLabel.TabIndex = 15;
            checkUpHeaderLabel.Text = "Routine Check-up";
            checkUpHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkUpPanel
            // 
            checkUpPanel.BackColor = Color.White;
            checkUpPanel.Controls.Add(checkUpButton);
            checkUpPanel.Controls.Add(symptomsTextBox);
            checkUpPanel.Controls.Add(weightLabel);
            checkUpPanel.Controls.Add(heightLabel);
            checkUpPanel.Controls.Add(temperatureLabel);
            checkUpPanel.Controls.Add(symptomsLabel);
            checkUpPanel.Controls.Add(pulseLabel);
            checkUpPanel.Controls.Add(diastolicLabel);
            checkUpPanel.Controls.Add(systolicLabel);
            checkUpPanel.Controls.Add(checkUpHeaderLabel);
            checkUpPanel.Location = new Point(12, 419);
            checkUpPanel.Name = "checkUpPanel";
            checkUpPanel.Size = new Size(1246, 309);
            checkUpPanel.TabIndex = 17;
            // 
            // systolicLabel
            // 
            systolicLabel.AutoSize = true;
            systolicLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systolicLabel.Location = new Point(16, 53);
            systolicLabel.Name = "systolicLabel";
            systolicLabel.Size = new Size(186, 28);
            systolicLabel.TabIndex = 16;
            systolicLabel.Text = "Systolic BP (mmHg):";
            // 
            // diastolicLabel
            // 
            diastolicLabel.AutoSize = true;
            diastolicLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diastolicLabel.Location = new Point(18, 92);
            diastolicLabel.Name = "diastolicLabel";
            diastolicLabel.Size = new Size(195, 28);
            diastolicLabel.TabIndex = 17;
            diastolicLabel.Text = "Diastolic BP (mmHg):";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseLabel.Location = new Point(18, 131);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(119, 28);
            pulseLabel.TabIndex = 18;
            pulseLabel.Text = "Pulse (bpm):";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsLabel.Location = new Point(18, 174);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(109, 28);
            symptomsLabel.TabIndex = 19;
            symptomsLabel.Text = "Symptoms:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temperatureLabel.Location = new Point(457, 53);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(160, 28);
            temperatureLabel.TabIndex = 20;
            temperatureLabel.Text = "Temperature (°F):";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightLabel.Location = new Point(457, 92);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(108, 28);
            heightLabel.TabIndex = 21;
            heightLabel.Text = "Height (in):";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightLabel.Location = new Point(457, 131);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(121, 28);
            weightLabel.TabIndex = 22;
            weightLabel.Text = "Weight (lbs):";
            // 
            // labDiagnosisPanel
            // 
            labDiagnosisPanel.BackColor = Color.White;
            labDiagnosisPanel.Controls.Add(finalDiagnosisLabel);
            labDiagnosisPanel.Controls.Add(finalDiagnosisButton);
            labDiagnosisPanel.Controls.Add(finalDiagnosisTextBox);
            labDiagnosisPanel.Controls.Add(orderTestButton);
            labDiagnosisPanel.Controls.Add(viewTestButton);
            labDiagnosisPanel.Controls.Add(orderedTestDataGridView);
            labDiagnosisPanel.Controls.Add(orderedTestLabel);
            labDiagnosisPanel.Controls.Add(initialDiagnosisButton);
            labDiagnosisPanel.Controls.Add(initialDiagnosisTextBox);
            labDiagnosisPanel.Controls.Add(diagnosisLabel);
            labDiagnosisPanel.Controls.Add(labDiagnosisLabel);
            labDiagnosisPanel.Location = new Point(12, 744);
            labDiagnosisPanel.Name = "labDiagnosisPanel";
            labDiagnosisPanel.Size = new Size(1246, 293);
            labDiagnosisPanel.TabIndex = 18;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diagnosisLabel.Location = new Point(3, 40);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new Size(161, 28);
            diagnosisLabel.TabIndex = 16;
            diagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // labDiagnosisLabel
            // 
            labDiagnosisLabel.BackColor = Color.FromArgb(192, 192, 255);
            labDiagnosisLabel.FlatStyle = FlatStyle.Flat;
            labDiagnosisLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labDiagnosisLabel.ForeColor = Color.DarkSlateBlue;
            labDiagnosisLabel.Location = new Point(0, 0);
            labDiagnosisLabel.Name = "labDiagnosisLabel";
            labDiagnosisLabel.Size = new Size(1246, 40);
            labDiagnosisLabel.TabIndex = 15;
            labDiagnosisLabel.Text = "Lab Tests / Diagnosis";
            labDiagnosisLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editAppointmentButton
            // 
            editAppointmentButton.BackColor = Color.AliceBlue;
            editAppointmentButton.FlatStyle = FlatStyle.Flat;
            editAppointmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editAppointmentButton.ForeColor = Color.RoyalBlue;
            editAppointmentButton.Location = new Point(406, 43);
            editAppointmentButton.Name = "editAppointmentButton";
            editAppointmentButton.Size = new Size(183, 34);
            editAppointmentButton.TabIndex = 16;
            editAppointmentButton.Text = "Edit Appointment";
            editAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.BackColor = Color.WhiteSmoke;
            symptomsTextBox.BorderStyle = BorderStyle.FixedSingle;
            symptomsTextBox.Location = new Point(24, 208);
            symptomsTextBox.Multiline = true;
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.ReadOnly = true;
            symptomsTextBox.ScrollBars = ScrollBars.Vertical;
            symptomsTextBox.Size = new Size(1208, 88);
            symptomsTextBox.TabIndex = 23;
            symptomsTextBox.TabStop = false;
            // 
            // checkUpButton
            // 
            checkUpButton.BackColor = Color.RoyalBlue;
            checkUpButton.FlatStyle = FlatStyle.Flat;
            checkUpButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkUpButton.ForeColor = Color.White;
            checkUpButton.Location = new Point(965, 43);
            checkUpButton.Name = "checkUpButton";
            checkUpButton.Size = new Size(267, 48);
            checkUpButton.TabIndex = 24;
            checkUpButton.Text = "Enter / Update Check-up";
            checkUpButton.UseVisualStyleBackColor = false;
            // 
            // initialDiagnosisTextBox
            // 
            initialDiagnosisTextBox.BorderStyle = BorderStyle.FixedSingle;
            initialDiagnosisTextBox.Location = new Point(12, 77);
            initialDiagnosisTextBox.Multiline = true;
            initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            initialDiagnosisTextBox.ReadOnly = true;
            initialDiagnosisTextBox.ScrollBars = ScrollBars.Vertical;
            initialDiagnosisTextBox.Size = new Size(296, 144);
            initialDiagnosisTextBox.TabIndex = 17;
            initialDiagnosisTextBox.TabStop = false;
            // 
            // initialDiagnosisButton
            // 
            initialDiagnosisButton.BackColor = Color.GhostWhite;
            initialDiagnosisButton.FlatStyle = FlatStyle.Flat;
            initialDiagnosisButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            initialDiagnosisButton.ForeColor = Color.Indigo;
            initialDiagnosisButton.Location = new Point(8, 227);
            initialDiagnosisButton.Name = "initialDiagnosisButton";
            initialDiagnosisButton.Size = new Size(300, 49);
            initialDiagnosisButton.TabIndex = 18;
            initialDiagnosisButton.Text = "Enter / Update Initial Diagnosis";
            initialDiagnosisButton.UseVisualStyleBackColor = false;
            // 
            // orderedTestLabel
            // 
            orderedTestLabel.AutoSize = true;
            orderedTestLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderedTestLabel.Location = new Point(331, 40);
            orderedTestLabel.Name = "orderedTestLabel";
            orderedTestLabel.Size = new Size(143, 28);
            orderedTestLabel.TabIndex = 19;
            orderedTestLabel.Text = "Ordered Tests:";
            // 
            // orderedTestDataGridView
            // 
            orderedTestDataGridView.AllowUserToAddRows = false;
            orderedTestDataGridView.AllowUserToDeleteRows = false;
            orderedTestDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderedTestDataGridView.BackgroundColor = Color.White;
            orderedTestDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderedTestDataGridView.Columns.AddRange(new DataGridViewColumn[] { testCodeColumn, testNameColumn, performedDateTimeColumn, resultColumn, statusColumn });
            orderedTestDataGridView.GridColor = Color.White;
            orderedTestDataGridView.Location = new Point(331, 77);
            orderedTestDataGridView.Name = "orderedTestDataGridView";
            orderedTestDataGridView.ReadOnly = true;
            orderedTestDataGridView.RowHeadersWidth = 62;
            orderedTestDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderedTestDataGridView.Size = new Size(580, 144);
            orderedTestDataGridView.TabIndex = 20;
            // 
            // testCodeColumn
            // 
            testCodeColumn.HeaderText = "Test Code";
            testCodeColumn.MinimumWidth = 8;
            testCodeColumn.Name = "testCodeColumn";
            testCodeColumn.ReadOnly = true;
            // 
            // testNameColumn
            // 
            testNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            testNameColumn.HeaderText = "Test Name";
            testNameColumn.MinimumWidth = 8;
            testNameColumn.Name = "testNameColumn";
            testNameColumn.ReadOnly = true;
            // 
            // performedDateTimeColumn
            // 
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            performedDateTimeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            performedDateTimeColumn.HeaderText = "Performed DateTime";
            performedDateTimeColumn.MinimumWidth = 8;
            performedDateTimeColumn.Name = "performedDateTimeColumn";
            performedDateTimeColumn.ReadOnly = true;
            // 
            // resultColumn
            // 
            resultColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resultColumn.HeaderText = "Result";
            resultColumn.MinimumWidth = 8;
            resultColumn.Name = "resultColumn";
            resultColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            statusColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            statusColumn.HeaderText = "Status";
            statusColumn.MinimumWidth = 8;
            statusColumn.Name = "statusColumn";
            statusColumn.ReadOnly = true;
            statusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            statusColumn.Width = 66;
            // 
            // viewTestButton
            // 
            viewTestButton.BackColor = Color.AliceBlue;
            viewTestButton.FlatStyle = FlatStyle.Flat;
            viewTestButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewTestButton.ForeColor = Color.RoyalBlue;
            viewTestButton.Location = new Point(331, 227);
            viewTestButton.Name = "viewTestButton";
            viewTestButton.Size = new Size(202, 49);
            viewTestButton.TabIndex = 21;
            viewTestButton.Text = "View Test Result";
            viewTestButton.UseVisualStyleBackColor = false;
            // 
            // orderTestButton
            // 
            orderTestButton.BackColor = Color.AliceBlue;
            orderTestButton.FlatStyle = FlatStyle.Flat;
            orderTestButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderTestButton.ForeColor = Color.RoyalBlue;
            orderTestButton.Location = new Point(709, 227);
            orderTestButton.Name = "orderTestButton";
            orderTestButton.Size = new Size(202, 49);
            orderTestButton.TabIndex = 22;
            orderTestButton.Text = "+ Order Test";
            orderTestButton.UseVisualStyleBackColor = false;
            // 
            // finalDiagnosisTextBox
            // 
            finalDiagnosisTextBox.BorderStyle = BorderStyle.FixedSingle;
            finalDiagnosisTextBox.Location = new Point(936, 77);
            finalDiagnosisTextBox.Multiline = true;
            finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            finalDiagnosisTextBox.ReadOnly = true;
            finalDiagnosisTextBox.ScrollBars = ScrollBars.Vertical;
            finalDiagnosisTextBox.Size = new Size(296, 144);
            finalDiagnosisTextBox.TabIndex = 23;
            finalDiagnosisTextBox.TabStop = false;
            // 
            // finalDiagnosisButton
            // 
            finalDiagnosisButton.BackColor = Color.GhostWhite;
            finalDiagnosisButton.FlatStyle = FlatStyle.Flat;
            finalDiagnosisButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalDiagnosisButton.ForeColor = Color.Indigo;
            finalDiagnosisButton.Location = new Point(936, 227);
            finalDiagnosisButton.Name = "finalDiagnosisButton";
            finalDiagnosisButton.Size = new Size(300, 49);
            finalDiagnosisButton.TabIndex = 24;
            finalDiagnosisButton.Text = "Enter Final Diagnosis";
            finalDiagnosisButton.UseVisualStyleBackColor = false;
            // 
            // finalDiagnosisLabel
            // 
            finalDiagnosisLabel.AutoSize = true;
            finalDiagnosisLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalDiagnosisLabel.Location = new Point(936, 46);
            finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            finalDiagnosisLabel.Size = new Size(153, 28);
            finalDiagnosisLabel.TabIndex = 25;
            finalDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // AppointmentDetailsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 1049);
            Controls.Add(labDiagnosisPanel);
            Controls.Add(checkUpPanel);
            Controls.Add(appointmentPanel);
            Controls.Add(patientInfoPanel);
            Controls.Add(appointmentDetailsLabel);
            Controls.Add(backButton);
            Controls.Add(panel1);
            Name = "AppointmentDetailsPage";
            Text = "EditAppointmentPage";
            Load += this.AppointmentDetailsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            patientInfoPanel.ResumeLayout(false);
            patientInfoPanel.PerformLayout();
            appointmentPanel.ResumeLayout(false);
            appointmentPanel.PerformLayout();
            checkUpPanel.ResumeLayout(false);
            checkUpPanel.PerformLayout();
            labDiagnosisPanel.ResumeLayout(false);
            labDiagnosisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderedTestDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashboardTitle;
        private Panel panel1;
        private Button backButton;
        private Label appointmentDetailsLabel;
        private Panel patientInfoPanel;
        private Label phoneLabel;
        private Label dobLabel;
        private Label lnameLabel;
        private Label fnameLabel;
        private Label patientHeaderLabel;
        private Panel appointmentPanel;
        private Label reasonLabel;
        private Label doctorLabel;
        private Label datetimeLabel;
        private Label appointmentIdLabel;
        private Label appointmentHeaderLabel;
        private Label patientIdLabel;
        private Label checkUpHeaderLabel;
        private Panel checkUpPanel;
        private Label diastolicLabel;
        private Label systolicLabel;
        private Label pulseLabel;
        private Label temperatureLabel;
        private Label symptomsLabel;
        private Label weightLabel;
        private Label heightLabel;
        private Panel labDiagnosisPanel;
        private Label diagnosisLabel;
        private Label labDiagnosisLabel;
        private Button editAppointmentButton;
        private TextBox symptomsTextBox;
        private Button checkUpButton;
        private TextBox initialDiagnosisTextBox;
        private Button initialDiagnosisButton;
        private DataGridView orderedTestDataGridView;
        private Label orderedTestLabel;
        private DataGridViewTextBoxColumn testCodeColumn;
        private DataGridViewTextBoxColumn testNameColumn;
        private DataGridViewTextBoxColumn performedDateTimeColumn;
        private DataGridViewTextBoxColumn resultColumn;
        private DataGridViewTextBoxColumn statusColumn;
        private Button orderTestButton;
        private Button viewTestButton;
        private Label finalDiagnosisLabel;
        private Button finalDiagnosisButton;
        private TextBox finalDiagnosisTextBox;
    }
}