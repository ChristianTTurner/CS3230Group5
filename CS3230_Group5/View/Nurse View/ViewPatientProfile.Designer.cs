namespace CS3230_Group5.View.Nurse_View
{
    partial class ViewPatientProfile
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
            patientNameLabel = new Label();
            editPatientProfileLink = new LinkLabel();
            patientInfo = new Label();
            isActiveRadioButton = new RadioButton();
            setUpAppointmentLink = new LinkLabel();
            backButton = new Button();
            SuspendLayout();
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(29, 54);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(282, 54);
            patientNameLabel.TabIndex = 0;
            patientNameLabel.Text = "Patient Name";
            // 
            // editPatientProfileLink
            // 
            editPatientProfileLink.AutoSize = true;
            editPatientProfileLink.Font = new Font("Segoe UI", 11F);
            editPatientProfileLink.Location = new Point(317, 72);
            editPatientProfileLink.Name = "editPatientProfileLink";
            editPatientProfileLink.Size = new Size(44, 25);
            editPatientProfileLink.TabIndex = 1;
            editPatientProfileLink.TabStop = true;
            editPatientProfileLink.Text = "edit";
            // 
            // patientInfo
            // 
            patientInfo.AutoSize = true;
            patientInfo.Font = new Font("Segoe UI", 14F);
            patientInfo.Location = new Point(29, 126);
            patientInfo.Name = "patientInfo";
            patientInfo.Size = new Size(182, 192);
            patientInfo.TabIndex = 2;
            patientInfo.Text = "Patient ID:\r\nLast Name:\r\nFirst Name:\r\nDOB:\r\nAddress:\r\nPhone Number:";
            // 
            // isActiveRadioButton
            // 
            isActiveRadioButton.AutoSize = true;
            isActiveRadioButton.Font = new Font("Segoe UI", 14F);
            isActiveRadioButton.Location = new Point(29, 321);
            isActiveRadioButton.Name = "isActiveRadioButton";
            isActiveRadioButton.Size = new Size(100, 36);
            isActiveRadioButton.TabIndex = 3;
            isActiveRadioButton.TabStop = true;
            isActiveRadioButton.Text = "Active";
            isActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // setUpAppointmentLink
            // 
            setUpAppointmentLink.AutoSize = true;
            setUpAppointmentLink.Font = new Font("Segoe UI", 16F);
            setUpAppointmentLink.Location = new Point(12, 370);
            setUpAppointmentLink.Name = "setUpAppointmentLink";
            setUpAppointmentLink.Size = new Size(256, 37);
            setUpAppointmentLink.TabIndex = 4;
            setUpAppointmentLink.TabStop = true;
            setUpAppointmentLink.Text = "Set up Appointment";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(37, 30);
            backButton.TabIndex = 5;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            // 
            // ViewPatientProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(setUpAppointmentLink);
            Controls.Add(isActiveRadioButton);
            Controls.Add(patientInfo);
            Controls.Add(editPatientProfileLink);
            Controls.Add(patientNameLabel);
            Name = "ViewPatientProfile";
            Text = "Patient Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label patientNameLabel;
        private LinkLabel editPatientProfileLink;
        private Label patientInfo;
        private RadioButton isActiveRadioButton;
        private LinkLabel setUpAppointmentLink;
        private Button backButton;
    }
}