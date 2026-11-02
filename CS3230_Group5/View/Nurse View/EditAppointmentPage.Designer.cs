namespace CS3230_Group5.View.Nurse_View
{
    partial class EditAppointmentPage
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
            dashboardTitle = new Label();
            panel1 = new Panel();
            cancelButton = new Button();
            reasonLabel = new Label();
            reasonTextBox = new RichTextBox();
            confirmAppointmentButton = new Button();
            dateTimeLabel = new Label();
            doctorComboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            doctorLabel = new Label();
            patientNameLabel = new Label();
            editAppointmentLabel = new Label();
            patientName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 21;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(681, 486);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(91, 34);
            cancelButton.TabIndex = 29;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 14F);
            reasonLabel.Location = new Point(18, 314);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(95, 32);
            reasonLabel.TabIndex = 28;
            reasonLabel.Text = "Reason:";
            // 
            // reasonTextBox
            // 
            reasonTextBox.Font = new Font("Segoe UI", 11F);
            reasonTextBox.Location = new Point(18, 348);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(646, 132);
            reasonTextBox.TabIndex = 27;
            reasonTextBox.Text = "";
            // 
            // confirmAppointmentButton
            // 
            confirmAppointmentButton.BackColor = Color.ForestGreen;
            confirmAppointmentButton.FlatAppearance.BorderSize = 0;
            confirmAppointmentButton.FlatStyle = FlatStyle.Flat;
            confirmAppointmentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmAppointmentButton.ForeColor = Color.White;
            confirmAppointmentButton.ImageAlign = ContentAlignment.TopLeft;
            confirmAppointmentButton.Location = new Point(570, 485);
            confirmAppointmentButton.Name = "confirmAppointmentButton";
            confirmAppointmentButton.Size = new Size(94, 35);
            confirmAppointmentButton.TabIndex = 26;
            confirmAppointmentButton.Text = "Confirm";
            confirmAppointmentButton.UseVisualStyleBackColor = false;
            confirmAppointmentButton.Click += confirmAppointmentButton_Click;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 14F);
            dateTimeLabel.Location = new Point(18, 256);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(117, 32);
            dateTimeLabel.TabIndex = 25;
            dateTimeLabel.Text = "Datetime:";
            // 
            // doctorComboBox
            // 
            doctorComboBox.Font = new Font("Segoe UI", 12F);
            doctorComboBox.FormattingEnabled = true;
            doctorComboBox.Location = new Point(128, 206);
            doctorComboBox.Name = "doctorComboBox";
            doctorComboBox.Size = new Size(423, 36);
            doctorComboBox.TabIndex = 24;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Location = new Point(141, 250);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(507, 39);
            dateTimePicker.TabIndex = 23;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Segoe UI", 14F);
            doctorLabel.Location = new Point(18, 205);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(91, 32);
            doctorLabel.TabIndex = 22;
            doctorLabel.Text = "Doctor:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(17, 153);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(92, 32);
            patientNameLabel.TabIndex = 31;
            patientNameLabel.Text = "Patient:";
            // 
            // editAppointmentLabel
            // 
            editAppointmentLabel.AutoSize = true;
            editAppointmentLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editAppointmentLabel.Location = new Point(18, 73);
            editAppointmentLabel.Name = "editAppointmentLabel";
            editAppointmentLabel.Size = new Size(394, 60);
            editAppointmentLabel.TabIndex = 30;
            editAppointmentLabel.Text = "Edit Appointment";
            // 
            // patientName
            // 
            patientName.Location = new Point(115, 159);
            patientName.Name = "patientName";
            patientName.ReadOnly = true;
            patientName.Size = new Size(406, 27);
            patientName.TabIndex = 32;
            // 
            // EditAppointmentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(patientName);
            Controls.Add(patientNameLabel);
            Controls.Add(editAppointmentLabel);
            Controls.Add(cancelButton);
            Controls.Add(reasonLabel);
            Controls.Add(reasonTextBox);
            Controls.Add(confirmAppointmentButton);
            Controls.Add(dateTimeLabel);
            Controls.Add(doctorComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(doctorLabel);
            Controls.Add(panel1);
            Name = "EditAppointmentPage";
            Text = "EditAppointmentPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashboardTitle;
        private Panel panel1;
        private Button cancelButton;
        private Label reasonLabel;
        private RichTextBox reasonTextBox;
        private Button confirmAppointmentButton;
        private Label dateTimeLabel;
        private ComboBox doctorComboBox;
        private DateTimePicker dateTimePicker;
        private Label doctorLabel;
        private Label patientNameLabel;
        private Label editAppointmentLabel;
        private TextBox patientName;
    }
}