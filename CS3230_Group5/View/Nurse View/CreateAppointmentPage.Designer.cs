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
            createAppointmentLabel.Location = new Point(15, 11);
            createAppointmentLabel.Margin = new Padding(4, 0, 4, 0);
            createAppointmentLabel.Name = "createAppointmentLabel";
            createAppointmentLabel.Size = new Size(629, 86);
            createAppointmentLabel.TabIndex = 7;
            createAppointmentLabel.Text = "Create Appointment";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 16F);
            patientNameLabel.Location = new Point(15, 142);
            patientNameLabel.Margin = new Padding(4, 0, 4, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(125, 45);
            patientNameLabel.TabIndex = 8;
            patientNameLabel.Text = "Patient:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(16, 209);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 9;
            label1.Text = "Doctor:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Location = new Point(189, 271);
            dateTimePicker.Margin = new Padding(4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(633, 45);
            dateTimePicker.TabIndex = 12;
            // 
            // patients
            // 
            patients.Font = new Font("Segoe UI", 12F);
            patients.FormattingEnabled = true;
            patients.Location = new Point(154, 144);
            patients.Margin = new Padding(4);
            patients.Name = "patients";
            patients.Size = new Size(528, 40);
            patients.TabIndex = 13;
            // 
            // doctor
            // 
            doctor.Font = new Font("Segoe UI", 12F);
            doctor.FormattingEnabled = true;
            doctor.Location = new Point(154, 210);
            doctor.Margin = new Padding(4);
            doctor.Name = "doctor";
            doctor.Size = new Size(528, 40);
            doctor.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(16, 274);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 45);
            label2.TabIndex = 15;
            label2.Text = "Datetime:";
            // 
            // bookAppointmentButton
            // 
            bookAppointmentButton.Font = new Font("Segoe UI", 16F);
            bookAppointmentButton.ImageAlign = ContentAlignment.TopLeft;
            bookAppointmentButton.Location = new Point(860, 490);
            bookAppointmentButton.Margin = new Padding(4);
            bookAppointmentButton.Name = "bookAppointmentButton";
            bookAppointmentButton.Size = new Size(114, 58);
            bookAppointmentButton.TabIndex = 16;
            bookAppointmentButton.Text = "Book";
            bookAppointmentButton.UseVisualStyleBackColor = true;
            bookAppointmentButton.Click += bookAppointmentButton_Click;
            // 
            // reasonTextBox
            // 
            reasonTextBox.Font = new Font("Segoe UI", 11F);
            reasonTextBox.Location = new Point(30, 382);
            reasonTextBox.Margin = new Padding(4);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(804, 164);
            reasonTextBox.TabIndex = 17;
            reasonTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(18, 332);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 45);
            label3.TabIndex = 18;
            label3.Text = "Reason:";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(709, 40);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 42);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // CreateAppointmentPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1000, 562);
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