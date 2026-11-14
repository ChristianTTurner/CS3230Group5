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
            cancelAppointmentButton = new Button();
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
            backButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(21, 21);
            dashboardTitle.Margin = new Padding(2, 0, 2, 0);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(308, 28);
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
            panel1.Size = new Size(1000, 74);
            panel1.TabIndex = 21;
            // 
            // cancelAppointmentButton
            // 
            cancelAppointmentButton.BackColor = Color.White;
            cancelAppointmentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelAppointmentButton.Location = new Point(701, 606);
            cancelAppointmentButton.Margin = new Padding(4, 4, 4, 4);
            cancelAppointmentButton.Name = "cancelAppointmentButton";
            cancelAppointmentButton.Size = new Size(264, 44);
            cancelAppointmentButton.TabIndex = 29;
            cancelAppointmentButton.Text = "Cancel Appointment";
            cancelAppointmentButton.UseVisualStyleBackColor = false;
            cancelAppointmentButton.Click += cancelAppointmentButton_Click;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 14F);
            reasonLabel.Location = new Point(22, 392);
            reasonLabel.Margin = new Padding(4, 0, 4, 0);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(112, 38);
            reasonLabel.TabIndex = 28;
            reasonLabel.Text = "Reason:";
            // 
            // reasonTextBox
            // 
            reasonTextBox.Font = new Font("Segoe UI", 11F);
            reasonTextBox.Location = new Point(22, 435);
            reasonTextBox.Margin = new Padding(4, 4, 4, 4);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(806, 164);
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
            confirmAppointmentButton.Location = new Point(576, 606);
            confirmAppointmentButton.Margin = new Padding(4, 4, 4, 4);
            confirmAppointmentButton.Name = "confirmAppointmentButton";
            confirmAppointmentButton.Size = new Size(118, 44);
            confirmAppointmentButton.TabIndex = 26;
            confirmAppointmentButton.Text = "Save";
            confirmAppointmentButton.UseVisualStyleBackColor = false;
            confirmAppointmentButton.Click += confirmAppointmentButton_Click;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 14F);
            dateTimeLabel.Location = new Point(22, 320);
            dateTimeLabel.Margin = new Padding(4, 0, 4, 0);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(136, 38);
            dateTimeLabel.TabIndex = 25;
            dateTimeLabel.Text = "Datetime:";
            // 
            // doctorComboBox
            // 
            doctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            doctorComboBox.Font = new Font("Segoe UI", 12F);
            doctorComboBox.FormattingEnabled = true;
            doctorComboBox.Location = new Point(160, 258);
            doctorComboBox.Margin = new Padding(4, 4, 4, 4);
            doctorComboBox.Name = "doctorComboBox";
            doctorComboBox.Size = new Size(528, 40);
            doctorComboBox.TabIndex = 24;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Location = new Point(176, 312);
            dateTimePicker.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(633, 45);
            dateTimePicker.TabIndex = 23;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Segoe UI", 14F);
            doctorLabel.Location = new Point(22, 256);
            doctorLabel.Margin = new Padding(4, 0, 4, 0);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(107, 38);
            doctorLabel.TabIndex = 22;
            doctorLabel.Text = "Doctor:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(21, 191);
            patientNameLabel.Margin = new Padding(4, 0, 4, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(108, 38);
            patientNameLabel.TabIndex = 31;
            patientNameLabel.Text = "Patient:";
            // 
            // editAppointmentLabel
            // 
            editAppointmentLabel.AutoSize = true;
            editAppointmentLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editAppointmentLabel.Location = new Point(56, 96);
            editAppointmentLabel.Margin = new Padding(4, 0, 4, 0);
            editAppointmentLabel.Name = "editAppointmentLabel";
            editAppointmentLabel.Size = new Size(465, 70);
            editAppointmentLabel.TabIndex = 30;
            editAppointmentLabel.Text = "Edit Appointment";
            // 
            // patientName
            // 
            patientName.Location = new Point(144, 199);
            patientName.Margin = new Padding(4, 4, 4, 4);
            patientName.Name = "patientName";
            patientName.ReadOnly = true;
            patientName.Size = new Size(506, 31);
            patientName.TabIndex = 32;
            // 
            // backButton
            // 
            backButton.Location = new Point(15, 112);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(49, 39);
            backButton.TabIndex = 33;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // EditAppointmentPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 678);
            Controls.Add(backButton);
            Controls.Add(patientName);
            Controls.Add(patientNameLabel);
            Controls.Add(editAppointmentLabel);
            Controls.Add(cancelAppointmentButton);
            Controls.Add(reasonLabel);
            Controls.Add(reasonTextBox);
            Controls.Add(confirmAppointmentButton);
            Controls.Add(dateTimeLabel);
            Controls.Add(doctorComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(doctorLabel);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EditAppointmentPage";
            Text = "EditAppointmentPage";
            Load += EditAppointmentPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashboardTitle;
        private Panel panel1;
        private Button cancelAppointmentButton;
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
        private Button backButton;
    }
}