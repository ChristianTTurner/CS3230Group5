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
            SuspendLayout();
            // 
            // createAppointmentLabel
            // 
            createAppointmentLabel.AutoSize = true;
            createAppointmentLabel.Font = new Font("Segoe UI Semibold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAppointmentLabel.Location = new Point(12, 9);
            createAppointmentLabel.Name = "createAppointmentLabel";
            createAppointmentLabel.Size = new Size(534, 72);
            createAppointmentLabel.TabIndex = 7;
            createAppointmentLabel.Text = "Create Appointment";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 16F);
            patientNameLabel.Location = new Point(12, 114);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(105, 37);
            patientNameLabel.TabIndex = 8;
            patientNameLabel.Text = "Patient:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(13, 167);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 9;
            label1.Text = "Doctor:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Location = new Point(151, 217);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(507, 39);
            dateTimePicker.TabIndex = 12;
            // 
            // patients
            // 
            patients.Font = new Font("Segoe UI", 12F);
            patients.FormattingEnabled = true;
            patients.Location = new Point(123, 115);
            patients.Name = "patients";
            patients.Size = new Size(423, 36);
            patients.TabIndex = 13;
            // 
            // doctor
            // 
            doctor.Font = new Font("Segoe UI", 12F);
            doctor.FormattingEnabled = true;
            doctor.Location = new Point(123, 168);
            doctor.Name = "doctor";
            doctor.Size = new Size(423, 36);
            doctor.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(13, 219);
            label2.Name = "label2";
            label2.Size = new Size(132, 37);
            label2.TabIndex = 15;
            label2.Text = "Datetime:";
            // 
            // bookAppointmentButton
            // 
            bookAppointmentButton.Font = new Font("Segoe UI", 16F);
            bookAppointmentButton.ImageAlign = ContentAlignment.TopLeft;
            bookAppointmentButton.Location = new Point(688, 392);
            bookAppointmentButton.Name = "bookAppointmentButton";
            bookAppointmentButton.Size = new Size(91, 46);
            bookAppointmentButton.TabIndex = 16;
            bookAppointmentButton.Text = "Book";
            bookAppointmentButton.UseVisualStyleBackColor = true;
            bookAppointmentButton.Click += bookAppointmentButton_Click;
            // 
            // reasonTextBox
            // 
            reasonTextBox.Font = new Font("Segoe UI", 11F);
            reasonTextBox.Location = new Point(24, 306);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(644, 132);
            reasonTextBox.TabIndex = 17;
            reasonTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(14, 266);
            label3.Name = "label3";
            label3.Size = new Size(108, 37);
            label3.TabIndex = 18;
            label3.Text = "Reason:";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(567, 32);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(91, 34);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // CreateAppointmentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "CreateAppointmentPage";
            Text = "Create Appointment";
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
    }
}