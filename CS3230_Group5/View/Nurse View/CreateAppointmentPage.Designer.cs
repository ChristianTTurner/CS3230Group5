namespace CS3230_Group5.View.Nurse_View
{
    partial class CreateAppointmentPage
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
            createAppointmentLabel = new Label();
            patientNameLabel = new Label();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            patients = new ComboBox();
            doctor = new ComboBox();
            label2 = new Label();
            bookAppointmentButton = new Button();
            reasonTextBox = new RichTextBox();
            label3 = new Label();
            cancelButton = new Button();
            dashboardTitle = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // createAppointmentLabel
            // 
            createAppointmentLabel.AutoSize = true;
            createAppointmentLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAppointmentLabel.Location = new Point(13, 83);
            createAppointmentLabel.Margin = new Padding(4, 0, 4, 0);
            createAppointmentLabel.Name = "createAppointmentLabel";
            createAppointmentLabel.Size = new Size(527, 70);
            createAppointmentLabel.TabIndex = 7;
            createAppointmentLabel.Text = "Create Appointment";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(44, 179);
            patientNameLabel.Margin = new Padding(4, 0, 4, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(108, 38);
            patientNameLabel.TabIndex = 8;
            patientNameLabel.Text = "Patient:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(45, 246);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 9;
            label1.Text = "Doctor:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Location = new Point(183, 306);
            dateTimePicker.Margin = new Padding(4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(633, 45);
            dateTimePicker.TabIndex = 12;
            // 
            // patients
            // 
            patients.Font = new Font("Segoe UI", 12F);
            patients.FormattingEnabled = true;
            patients.Location = new Point(183, 181);
            patients.Margin = new Padding(4);
            patients.Name = "patients";
            patients.Size = new Size(528, 40);
            patients.TabIndex = 13;
            // 
            // doctor
            // 
            doctor.Font = new Font("Segoe UI", 12F);
            doctor.FormattingEnabled = true;
            doctor.Location = new Point(183, 247);
            doctor.Margin = new Padding(4);
            doctor.Name = "doctor";
            doctor.Size = new Size(528, 40);
            doctor.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(45, 311);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 38);
            label2.TabIndex = 15;
            label2.Text = "Datetime:";
            // 
            // bookAppointmentButton
            // 
            bookAppointmentButton.BackColor = Color.ForestGreen;
            bookAppointmentButton.FlatAppearance.BorderSize = 0;
            bookAppointmentButton.FlatStyle = FlatStyle.Flat;
            bookAppointmentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookAppointmentButton.ForeColor = Color.White;
            bookAppointmentButton.ImageAlign = ContentAlignment.TopLeft;
            bookAppointmentButton.Location = new Point(597, 663);
            bookAppointmentButton.Margin = new Padding(4);
            bookAppointmentButton.Name = "bookAppointmentButton";
            bookAppointmentButton.Size = new Size(114, 44);
            bookAppointmentButton.TabIndex = 16;
            bookAppointmentButton.Text = "Book";
            bookAppointmentButton.UseVisualStyleBackColor = false;
            bookAppointmentButton.Click += bookAppointmentButton_Click;
            // 
            // reasonTextBox
            // 
            reasonTextBox.Font = new Font("Segoe UI", 11F);
            reasonTextBox.Location = new Point(45, 446);
            reasonTextBox.Margin = new Padding(4);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(806, 164);
            reasonTextBox.TabIndex = 17;
            reasonTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(44, 386);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 38);
            label3.TabIndex = 18;
            label3.Text = "Reason:";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(737, 663);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 42);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
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
            panel1.Size = new Size(1000, 71);
            panel1.TabIndex = 20;
            // 
            // CreateAppointmentPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(906, 730);
            Controls.Add(panel1);
            Controls.Add(cancelButton);
            Controls.Add(label3);
            Controls.Add(reasonTextBox);
            Controls.Add(bookAppointmentButton);
            Controls.Add(label2);
            Controls.Add(doctor);
            Controls.Add(patients);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(patientNameLabel);
            Controls.Add(createAppointmentLabel);
            Margin = new Padding(4);
            Name = "CreateAppointmentPage";
            Text = "Create Appointment";
            Load += CreateAppointmentPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createAppointmentLabel;
        private Label patientNameLabel;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private ComboBox patients;
        private ComboBox doctor;
        private Label label2;
        private Button bookAppointmentButton;
        private RichTextBox reasonTextBox;
        private Label label3;
        private Button cancelButton;
        private Label dashboardTitle;
        private Panel panel1;
    }
}