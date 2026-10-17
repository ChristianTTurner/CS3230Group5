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
            patientNameLabel.Location = new Point(36, 68);
            patientNameLabel.Margin = new Padding(4, 0, 4, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(336, 65);
            patientNameLabel.TabIndex = 0;
            patientNameLabel.Text = "Patient Name";
            // 
            // editPatientProfileLink
            // 
            editPatientProfileLink.AutoSize = true;
            editPatientProfileLink.Font = new Font("Segoe UI", 11F);
            editPatientProfileLink.Location = new Point(396, 90);
            editPatientProfileLink.Margin = new Padding(4, 0, 4, 0);
            editPatientProfileLink.Name = "editPatientProfileLink";
            editPatientProfileLink.Size = new Size(50, 30);
            editPatientProfileLink.TabIndex = 1;
            editPatientProfileLink.TabStop = true;
            editPatientProfileLink.Text = "edit";
            editPatientProfileLink.LinkClicked += editPatientProfileLink_LinkClicked;
            // 
            // patientInfo
            // 
            patientInfo.AutoSize = true;
            patientInfo.Font = new Font("Segoe UI", 14F);
            patientInfo.Location = new Point(36, 158);
            patientInfo.Margin = new Padding(4, 0, 4, 0);
            patientInfo.Name = "patientInfo";
            patientInfo.Size = new Size(212, 228);
            patientInfo.TabIndex = 2;
            patientInfo.Text = "Patient ID:\r\nLast Name:\r\nFirst Name:\r\nDOB:\r\nAddress:\r\nPhone Number:";
            // 
            // isActiveRadioButton
            // 
            isActiveRadioButton.AutoSize = true;
            isActiveRadioButton.Font = new Font("Segoe UI", 14F);
            isActiveRadioButton.Location = new Point(36, 401);
            isActiveRadioButton.Margin = new Padding(4, 4, 4, 4);
            isActiveRadioButton.Name = "isActiveRadioButton";
            isActiveRadioButton.Size = new Size(117, 42);
            isActiveRadioButton.TabIndex = 3;
            isActiveRadioButton.TabStop = true;
            isActiveRadioButton.Text = "Active";
            isActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // setUpAppointmentLink
            // 
            setUpAppointmentLink.AutoSize = true;
            setUpAppointmentLink.Font = new Font("Segoe UI", 16F);
            setUpAppointmentLink.Location = new Point(15, 462);
            setUpAppointmentLink.Margin = new Padding(4, 0, 4, 0);
            setUpAppointmentLink.Name = "setUpAppointmentLink";
            setUpAppointmentLink.Size = new Size(309, 45);
            setUpAppointmentLink.TabIndex = 4;
            setUpAppointmentLink.TabStop = true;
            setUpAppointmentLink.Text = "Set up Appointment";
            setUpAppointmentLink.LinkClicked += setUpAppointmentLink_LinkClicked;
            // 
            // backButton
            // 
            backButton.Location = new Point(15, 15);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(46, 38);
            backButton.TabIndex = 5;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ViewPatientProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1000, 562);
            Controls.Add(backButton);
            Controls.Add(setUpAppointmentLink);
            Controls.Add(isActiveRadioButton);
            Controls.Add(patientInfo);
            Controls.Add(editPatientProfileLink);
            Controls.Add(patientNameLabel);
            Margin = new Padding(4, 4, 4, 4);
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