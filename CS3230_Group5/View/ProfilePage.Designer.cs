namespace CS3230_Group5.View
{
    partial class ProfilePage
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
            backButton = new Button();
            accountInfo = new Label();
            editPatientProfileLink = new LinkLabel();
            accountNameLabel = new Label();
            logOutButton = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(7, 9);
            backButton.Name = "backButton";
            backButton.Size = new Size(37, 30);
            backButton.TabIndex = 9;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // accountInfo
            // 
            accountInfo.AutoSize = true;
            accountInfo.Font = new Font("Segoe UI", 14F);
            accountInfo.Location = new Point(83, 120);
            accountInfo.Name = "accountInfo";
            accountInfo.Size = new Size(182, 192);
            accountInfo.TabIndex = 8;
            accountInfo.Text = "Patient ID:\r\nLast Name:\r\nFirst Name:\r\nDOB:\r\nAddress:\r\nPhone Number:";
            // 
            // editPatientProfileLink
            // 
            editPatientProfileLink.AutoSize = true;
            editPatientProfileLink.Font = new Font("Segoe UI", 11F);
            editPatientProfileLink.Location = new Point(24, 42);
            editPatientProfileLink.Name = "editPatientProfileLink";
            editPatientProfileLink.Size = new Size(44, 25);
            editPatientProfileLink.TabIndex = 7;
            editPatientProfileLink.TabStop = true;
            editPatientProfileLink.Text = "edit";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountNameLabel.Location = new Point(74, 42);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(301, 54);
            accountNameLabel.TabIndex = 6;
            accountNameLabel.Text = "Account Name";
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(24, 384);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 10;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logOutButton);
            Controls.Add(backButton);
            Controls.Add(accountInfo);
            Controls.Add(editPatientProfileLink);
            Controls.Add(accountNameLabel);
            Name = "ProfilePage";
            Text = "ProfilePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label accountInfo;
        private LinkLabel editPatientProfileLink;
        private Label accountNameLabel;
        private Button logOutButton;
    }
}