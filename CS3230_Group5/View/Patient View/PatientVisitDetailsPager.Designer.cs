namespace CS3230_Group5.View.Patient_View
{
    partial class PatientVisitDetailsPager
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dashboardTitle = new Label();
            panel1 = new Panel();
            patientDetailsHeaderLabel = new Label();
            backButton = new Button();
            appointmentIdLabel = new Label();
            personalPanel = new Panel();
            reasonLabel = new Label();
            dateTimeLabel = new Label();
            phoneNumberLabel = new Label();
            dobLabel = new Label();
            patientNameLabel = new Label();
            patientIdLabel = new Label();
            patientHeaderLabel = new Label();
            doctorIdLabel = new Label();
            doctorNameLabel = new Label();
            patientIdTextBox = new TextBox();
            patientNameTextBox = new TextBox();
            patientDobTextBox = new TextBox();
            patientPhoneTextBox = new TextBox();
            appointmentIdTextBox = new TextBox();
            dateTimeTextBox = new TextBox();
            textBox1 = new TextBox();
            doctorIdTextBox = new TextBox();
            doctorNameTextBox = new TextBox();
            weightTextBox = new TextBox();
            heightTextBox = new TextBox();
            pulseTextBox = new TextBox();
            tempTextBox = new TextBox();
            diastolicTextBox = new TextBox();
            systolicTextBox = new TextBox();
            weightLabel = new Label();
            heightLabel = new Label();
            pulseLabel = new Label();
            tempLabel = new Label();
            diastolicLabel = new Label();
            systolicLabel = new Label();
            checkUpHeaderLabel = new Label();
            checkUpPanel = new Panel();
            symptomsHeaderLabel = new Label();
            panel2 = new Panel();
            finalTextBox = new TextBox();
            initialTextBox = new TextBox();
            symptomsTextBox = new TextBox();
            this.finalLabel = new Label();
            this.initialLabel = new Label();
            symptomsLabel = new Label();
            testPanel = new Panel();
            label4 = new Label();
            testsDataGridView = new DataGridView();
            test_code = new DataGridViewTextBoxColumn();
            performed_datetime = new DataGridViewTextBoxColumn();
            result = new DataGridViewTextBoxColumn();
            abnormal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            personalPanel.SuspendLayout();
            checkUpPanel.SuspendLayout();
            panel2.SuspendLayout();
            testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)testsDataGridView).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 62);
            panel1.TabIndex = 48;
            // 
            // patientDetailsHeaderLabel
            // 
            patientDetailsHeaderLabel.AutoSize = true;
            patientDetailsHeaderLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientDetailsHeaderLabel.Location = new Point(315, 65);
            patientDetailsHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            patientDetailsHeaderLabel.Name = "patientDetailsHeaderLabel";
            patientDetailsHeaderLabel.Size = new Size(442, 60);
            patientDetailsHeaderLabel.TabIndex = 51;
            patientDetailsHeaderLabel.Text = " Patient Visit Details";
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(12, 74);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(229, 51);
            backButton.TabIndex = 50;
            backButton.Text = "🡠 Back to Visits";
            backButton.UseVisualStyleBackColor = true;
            // 
            // appointmentIdLabel
            // 
            appointmentIdLabel.AutoSize = true;
            appointmentIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentIdLabel.Location = new Point(533, 49);
            appointmentIdLabel.Name = "appointmentIdLabel";
            appointmentIdLabel.Size = new Size(157, 28);
            appointmentIdLabel.TabIndex = 15;
            appointmentIdLabel.Text = "Appointment ID:";
            // 
            // personalPanel
            // 
            personalPanel.BackColor = Color.White;
            personalPanel.Controls.Add(doctorNameTextBox);
            personalPanel.Controls.Add(doctorIdTextBox);
            personalPanel.Controls.Add(textBox1);
            personalPanel.Controls.Add(dateTimeTextBox);
            personalPanel.Controls.Add(appointmentIdTextBox);
            personalPanel.Controls.Add(patientPhoneTextBox);
            personalPanel.Controls.Add(patientDobTextBox);
            personalPanel.Controls.Add(patientNameTextBox);
            personalPanel.Controls.Add(patientIdTextBox);
            personalPanel.Controls.Add(doctorNameLabel);
            personalPanel.Controls.Add(doctorIdLabel);
            personalPanel.Controls.Add(reasonLabel);
            personalPanel.Controls.Add(dateTimeLabel);
            personalPanel.Controls.Add(phoneNumberLabel);
            personalPanel.Controls.Add(appointmentIdLabel);
            personalPanel.Controls.Add(dobLabel);
            personalPanel.Controls.Add(patientNameLabel);
            personalPanel.Controls.Add(patientIdLabel);
            personalPanel.Controls.Add(patientHeaderLabel);
            personalPanel.Location = new Point(12, 151);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(1091, 258);
            personalPanel.TabIndex = 52;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonLabel.Location = new Point(535, 135);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(150, 28);
            reasonLabel.TabIndex = 51;
            reasonLabel.Text = "Reason for Visit:";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeLabel.Location = new Point(535, 91);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(117, 28);
            dateTimeLabel.TabIndex = 17;
            dateTimeLabel.Text = "Date / Time:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberLabel.Location = new Point(16, 173);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 28);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "Phone #:";
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
            patientNameLabel.Size = new Size(133, 28);
            patientNameLabel.TabIndex = 1;
            patientNameLabel.Text = "Patient Name:";
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdLabel.Location = new Point(16, 49);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(100, 28);
            patientIdLabel.TabIndex = 1;
            patientIdLabel.Text = "Patient ID:";
            patientIdLabel.Click += fnameLabel_Click;
            // 
            // patientHeaderLabel
            // 
            patientHeaderLabel.BackColor = Color.LightSteelBlue;
            patientHeaderLabel.FlatStyle = FlatStyle.Flat;
            patientHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientHeaderLabel.ForeColor = Color.Navy;
            patientHeaderLabel.Location = new Point(0, 0);
            patientHeaderLabel.Name = "patientHeaderLabel";
            patientHeaderLabel.Size = new Size(1091, 40);
            patientHeaderLabel.TabIndex = 0;
            patientHeaderLabel.Text = "Patient / Appointment Information";
            patientHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorIdLabel.Location = new Point(535, 173);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(101, 28);
            doctorIdLabel.TabIndex = 52;
            doctorIdLabel.Text = "Doctor ID:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorNameLabel.Location = new Point(535, 214);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new Size(134, 28);
            doctorNameLabel.TabIndex = 53;
            doctorNameLabel.Text = "Doctor Name:";
            // 
            // patientIdTextBox
            // 
            patientIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            patientIdTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdTextBox.Location = new Point(159, 48);
            patientIdTextBox.Name = "patientIdTextBox";
            patientIdTextBox.ReadOnly = true;
            patientIdTextBox.Size = new Size(295, 34);
            patientIdTextBox.TabIndex = 54;
            patientIdTextBox.Text = "ID #";
            // 
            // patientNameTextBox
            // 
            patientNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            patientNameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameTextBox.Location = new Point(159, 89);
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.ReadOnly = true;
            patientNameTextBox.Size = new Size(295, 34);
            patientNameTextBox.TabIndex = 55;
            patientNameTextBox.Text = "John Doe";
            // 
            // patientDobTextBox
            // 
            patientDobTextBox.BorderStyle = BorderStyle.FixedSingle;
            patientDobTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientDobTextBox.Location = new Point(159, 135);
            patientDobTextBox.Name = "patientDobTextBox";
            patientDobTextBox.ReadOnly = true;
            patientDobTextBox.Size = new Size(295, 34);
            patientDobTextBox.TabIndex = 56;
            patientDobTextBox.Text = "mm/dd/yyyy";
            // 
            // patientPhoneTextBox
            // 
            patientPhoneTextBox.BorderStyle = BorderStyle.FixedSingle;
            patientPhoneTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientPhoneTextBox.Location = new Point(159, 175);
            patientPhoneTextBox.Name = "patientPhoneTextBox";
            patientPhoneTextBox.ReadOnly = true;
            patientPhoneTextBox.Size = new Size(295, 34);
            patientPhoneTextBox.TabIndex = 57;
            patientPhoneTextBox.Text = "(xxx)-(xxx)-(xxxx)";
            // 
            // appointmentIdTextBox
            // 
            appointmentIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            appointmentIdTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentIdTextBox.Location = new Point(696, 49);
            appointmentIdTextBox.Name = "appointmentIdTextBox";
            appointmentIdTextBox.ReadOnly = true;
            appointmentIdTextBox.Size = new Size(295, 34);
            appointmentIdTextBox.TabIndex = 55;
            appointmentIdTextBox.Text = "ID #";
            // 
            // dateTimeTextBox
            // 
            dateTimeTextBox.BorderStyle = BorderStyle.FixedSingle;
            dateTimeTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTextBox.Location = new Point(696, 91);
            dateTimeTextBox.Name = "dateTimeTextBox";
            dateTimeTextBox.ReadOnly = true;
            dateTimeTextBox.Size = new Size(295, 34);
            dateTimeTextBox.TabIndex = 58;
            dateTimeTextBox.Text = "mm/dd/yyyy hh:mm";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(696, 131);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(295, 34);
            textBox1.TabIndex = 59;
            textBox1.Text = "reason";
            // 
            // doctorIdTextBox
            // 
            doctorIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            doctorIdTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorIdTextBox.Location = new Point(696, 175);
            doctorIdTextBox.Name = "doctorIdTextBox";
            doctorIdTextBox.ReadOnly = true;
            doctorIdTextBox.Size = new Size(295, 34);
            doctorIdTextBox.TabIndex = 60;
            doctorIdTextBox.Text = "ID #";
            // 
            // doctorNameTextBox
            // 
            doctorNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            doctorNameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorNameTextBox.Location = new Point(696, 215);
            doctorNameTextBox.Name = "doctorNameTextBox";
            doctorNameTextBox.ReadOnly = true;
            doctorNameTextBox.Size = new Size(295, 34);
            doctorNameTextBox.TabIndex = 55;
            doctorNameTextBox.Text = "Dr. Name";
            // 
            // weightTextBox
            // 
            weightTextBox.BorderStyle = BorderStyle.FixedSingle;
            weightTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightTextBox.Location = new Point(747, 131);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.ReadOnly = true;
            weightTextBox.Size = new Size(244, 34);
            weightTextBox.TabIndex = 59;
            // 
            // heightTextBox
            // 
            heightTextBox.BorderStyle = BorderStyle.FixedSingle;
            heightTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightTextBox.Location = new Point(747, 91);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.ReadOnly = true;
            heightTextBox.Size = new Size(244, 34);
            heightTextBox.TabIndex = 58;
            // 
            // pulseTextBox
            // 
            pulseTextBox.BorderStyle = BorderStyle.FixedSingle;
            pulseTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseTextBox.Location = new Point(747, 49);
            pulseTextBox.Name = "pulseTextBox";
            pulseTextBox.ReadOnly = true;
            pulseTextBox.Size = new Size(244, 34);
            pulseTextBox.TabIndex = 55;
            // 
            // tempTextBox
            // 
            tempTextBox.BorderStyle = BorderStyle.FixedSingle;
            tempTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempTextBox.Location = new Point(280, 135);
            tempTextBox.Name = "tempTextBox";
            tempTextBox.ReadOnly = true;
            tempTextBox.Size = new Size(244, 34);
            tempTextBox.TabIndex = 56;
            // 
            // diastolicTextBox
            // 
            diastolicTextBox.BorderStyle = BorderStyle.FixedSingle;
            diastolicTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diastolicTextBox.Location = new Point(280, 89);
            diastolicTextBox.Name = "diastolicTextBox";
            diastolicTextBox.ReadOnly = true;
            diastolicTextBox.Size = new Size(244, 34);
            diastolicTextBox.TabIndex = 55;
            // 
            // systolicTextBox
            // 
            systolicTextBox.BorderStyle = BorderStyle.FixedSingle;
            systolicTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systolicTextBox.Location = new Point(280, 48);
            systolicTextBox.Name = "systolicTextBox";
            systolicTextBox.ReadOnly = true;
            systolicTextBox.Size = new Size(244, 34);
            systolicTextBox.TabIndex = 54;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightLabel.Location = new Point(586, 137);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(121, 28);
            weightLabel.TabIndex = 51;
            weightLabel.Text = "Weight (lbs):";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightLabel.Location = new Point(586, 93);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(108, 28);
            heightLabel.TabIndex = 17;
            heightLabel.Text = "Height (in):";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseLabel.Location = new Point(584, 51);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(119, 28);
            pulseLabel.TabIndex = 15;
            pulseLabel.Text = "Pulse (bpm):";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempLabel.Location = new Point(16, 135);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(210, 28);
            tempLabel.TabIndex = 1;
            tempLabel.Text = "Body Temperature (°F):";
            // 
            // diastolicLabel
            // 
            diastolicLabel.AutoSize = true;
            diastolicLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diastolicLabel.Location = new Point(16, 91);
            diastolicLabel.Name = "diastolicLabel";
            diastolicLabel.Size = new Size(244, 28);
            diastolicLabel.TabIndex = 1;
            diastolicLabel.Text = "Diastolic Reading (mmHg):";
            // 
            // systolicLabel
            // 
            systolicLabel.AutoSize = true;
            systolicLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systolicLabel.Location = new Point(16, 49);
            systolicLabel.Name = "systolicLabel";
            systolicLabel.Size = new Size(235, 28);
            systolicLabel.TabIndex = 1;
            systolicLabel.Text = "Systolic Reading (mmHg):";
            // 
            // checkUpHeaderLabel
            // 
            checkUpHeaderLabel.BackColor = Color.Wheat;
            checkUpHeaderLabel.FlatStyle = FlatStyle.Flat;
            checkUpHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkUpHeaderLabel.ForeColor = Color.Chocolate;
            checkUpHeaderLabel.Location = new Point(0, 0);
            checkUpHeaderLabel.Name = "checkUpHeaderLabel";
            checkUpHeaderLabel.Size = new Size(1091, 40);
            checkUpHeaderLabel.TabIndex = 0;
            checkUpHeaderLabel.Text = "Check-up Information";
            checkUpHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkUpPanel
            // 
            checkUpPanel.BackColor = Color.White;
            checkUpPanel.Controls.Add(weightTextBox);
            checkUpPanel.Controls.Add(heightTextBox);
            checkUpPanel.Controls.Add(pulseTextBox);
            checkUpPanel.Controls.Add(tempTextBox);
            checkUpPanel.Controls.Add(diastolicTextBox);
            checkUpPanel.Controls.Add(systolicTextBox);
            checkUpPanel.Controls.Add(weightLabel);
            checkUpPanel.Controls.Add(heightLabel);
            checkUpPanel.Controls.Add(pulseLabel);
            checkUpPanel.Controls.Add(tempLabel);
            checkUpPanel.Controls.Add(diastolicLabel);
            checkUpPanel.Controls.Add(systolicLabel);
            checkUpPanel.Controls.Add(checkUpHeaderLabel);
            checkUpPanel.Location = new Point(12, 424);
            checkUpPanel.Name = "checkUpPanel";
            checkUpPanel.Size = new Size(1091, 193);
            checkUpPanel.TabIndex = 53;
            // 
            // symptomsHeaderLabel
            // 
            symptomsHeaderLabel.BackColor = Color.Thistle;
            symptomsHeaderLabel.FlatStyle = FlatStyle.Flat;
            symptomsHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            symptomsHeaderLabel.ForeColor = Color.DarkMagenta;
            symptomsHeaderLabel.Location = new Point(0, 0);
            symptomsHeaderLabel.Name = "symptomsHeaderLabel";
            symptomsHeaderLabel.Size = new Size(1091, 40);
            symptomsHeaderLabel.TabIndex = 0;
            symptomsHeaderLabel.Text = "Symptoms / Diagnosis";
            symptomsHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            symptomsHeaderLabel.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(finalTextBox);
            panel2.Controls.Add(initialTextBox);
            panel2.Controls.Add(symptomsTextBox);
            panel2.Controls.Add(this.finalLabel);
            panel2.Controls.Add(this.initialLabel);
            panel2.Controls.Add(symptomsLabel);
            panel2.Controls.Add(symptomsHeaderLabel);
            panel2.Location = new Point(12, 634);
            panel2.Name = "panel2";
            panel2.Size = new Size(1091, 193);
            panel2.TabIndex = 54;
            // 
            // finalTextBox
            // 
            finalTextBox.BorderStyle = BorderStyle.FixedSingle;
            finalTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalTextBox.Location = new Point(172, 135);
            finalTextBox.Name = "finalTextBox";
            finalTextBox.ReadOnly = true;
            finalTextBox.Size = new Size(819, 34);
            finalTextBox.TabIndex = 56;
            // 
            // initialTextBox
            // 
            initialTextBox.BorderStyle = BorderStyle.FixedSingle;
            initialTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            initialTextBox.Location = new Point(172, 89);
            initialTextBox.Name = "initialTextBox";
            initialTextBox.ReadOnly = true;
            initialTextBox.Size = new Size(819, 34);
            initialTextBox.TabIndex = 55;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.BorderStyle = BorderStyle.FixedSingle;
            symptomsTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsTextBox.Location = new Point(172, 48);
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.ReadOnly = true;
            symptomsTextBox.Size = new Size(819, 34);
            symptomsTextBox.TabIndex = 54;
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.finalLabel.Location = new Point(16, 135);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new Size(147, 28);
            this.finalLabel.TabIndex = 1;
            this.finalLabel.Text = "Final Diagnosis:";
            // 
            // initialLabel
            // 
            this.initialLabel.AutoSize = true;
            this.initialLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.initialLabel.Location = new Point(16, 91);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new Size(154, 28);
            this.initialLabel.TabIndex = 1;
            this.initialLabel.Text = "Initial Diagnosis:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsLabel.Location = new Point(16, 49);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(109, 28);
            symptomsLabel.TabIndex = 1;
            symptomsLabel.Text = "Symptoms:";
            // 
            // testPanel
            // 
            testPanel.BackColor = Color.White;
            testPanel.Controls.Add(testsDataGridView);
            testPanel.Controls.Add(label4);
            testPanel.Location = new Point(12, 847);
            testPanel.Name = "testPanel";
            testPanel.Size = new Size(1091, 246);
            testPanel.TabIndex = 55;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSteelBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1091, 40);
            label4.TabIndex = 0;
            label4.Text = "Tests Ordered and Performed";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // testsDataGridView
            // 
            testsDataGridView.AllowUserToResizeRows = false;
            testsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            testsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            testsDataGridView.BackgroundColor = Color.White;
            testsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testsDataGridView.Columns.AddRange(new DataGridViewColumn[] { test_code, performed_datetime, result, abnormal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            testsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            testsDataGridView.Location = new Point(16, 53);
            testsDataGridView.MultiSelect = false;
            testsDataGridView.Name = "testsDataGridView";
            testsDataGridView.ReadOnly = true;
            testsDataGridView.RowHeadersWidth = 62;
            testsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            testsDataGridView.Size = new Size(1054, 171);
            testsDataGridView.TabIndex = 1;
            // 
            // test_code
            // 
            test_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            test_code.FillWeight = 102.272728F;
            test_code.HeaderText = "Test Code";
            test_code.MinimumWidth = 90;
            test_code.Name = "test_code";
            test_code.ReadOnly = true;
            test_code.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // performed_datetime
            // 
            performed_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            performed_datetime.DefaultCellStyle = dataGridViewCellStyle1;
            performed_datetime.FillWeight = 97.72727F;
            performed_datetime.HeaderText = "Performed Date & Time";
            performed_datetime.MinimumWidth = 160;
            performed_datetime.Name = "performed_datetime";
            performed_datetime.ReadOnly = true;
            performed_datetime.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // result
            // 
            result.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            result.DefaultCellStyle = dataGridViewCellStyle2;
            result.FillWeight = 180F;
            result.HeaderText = "Result";
            result.MinimumWidth = 150;
            result.Name = "result";
            result.ReadOnly = true;
            result.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // abnormal
            // 
            abnormal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            abnormal.FillWeight = 70F;
            abnormal.HeaderText = "Abnormal";
            abnormal.MinimumWidth = 90;
            abnormal.Name = "abnormal";
            abnormal.ReadOnly = true;
            abnormal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PatientVisitDetailsPager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 1119);
            Controls.Add(testPanel);
            Controls.Add(panel2);
            Controls.Add(checkUpPanel);
            Controls.Add(personalPanel);
            Controls.Add(patientDetailsHeaderLabel);
            Controls.Add(backButton);
            Controls.Add(panel1);
            Name = "PatientVisitDetailsPager";
            Text = "PatientVisitDetailsPager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            checkUpPanel.ResumeLayout(false);
            checkUpPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            testPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)testsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashboardTitle;
        private Panel panel1;
        private Label patientDetailsHeaderLabel;
        private Button backButton;
        private Label appointmentIdLabel;
        private Panel personalPanel;
        private Label reasonLabel;
        private Label dateTimeLabel;
        private Label phoneNumberLabel;
        private Label dobLabel;
        private Label patientNameLabel;
        private Label patientIdLabel;
        private Label patientHeaderLabel;
        private Label doctorNameLabel;
        private Label doctorIdLabel;
        private TextBox patientNameTextBox;
        private TextBox patientIdTextBox;
        private TextBox doctorIdTextBox;
        private TextBox textBox1;
        private TextBox dateTimeTextBox;
        private TextBox appointmentIdTextBox;
        private TextBox patientPhoneTextBox;
        private TextBox patientDobTextBox;
        private TextBox doctorNameTextBox;
        private TextBox weightTextBox;
        private TextBox heightTextBox;
        private TextBox pulseTextBox;
        private TextBox tempTextBox;
        private TextBox diastolicTextBox;
        private TextBox systolicTextBox;
        private Label weightLabel;
        private Label heightLabel;
        private Label pulseLabel;
        private Label tempLabel;
        private Label diastolicLabel;
        private Label systolicLabel;
        private Label checkUpHeaderLabel;
        private Panel checkUpPanel;
        private Label symptomsHeaderLabel;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox finalTextBox;
        private TextBox initialTextBox;
        private TextBox symptomsTextBox;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label symptomsLabel;
        private Panel testPanel;
        private DataGridView testsDataGridView;
        private Label label4;
        private DataGridViewTextBoxColumn test_code;
        private DataGridViewTextBoxColumn performed_datetime;
        private DataGridViewTextBoxColumn result;
        private DataGridViewTextBoxColumn abnormal;
    }
}