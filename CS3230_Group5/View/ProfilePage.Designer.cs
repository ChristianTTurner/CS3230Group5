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
            profileLabel = new Label();
            logOutButton = new Button();
            dashboardTitle = new Label();
            panel1 = new Panel();
            personalPanel = new Panel();
            phoneLabel = new Label();
            dobLabel = new Label();
            lnameLabel = new Label();
            fnameLabel = new Label();
            personalHeaderLabel = new Label();
            accountPanel = new Panel();
            label1 = new Label();
            usernameLabel = new Label();
            userIdLabel = new Label();
            accountHeaderLabel = new Label();
            addressPanel = new Panel();
            label2 = new Label();
            stateLabel = new Label();
            cityLabel = new Label();
            add2Label = new Label();
            add1Label = new Label();
            addressHeaderLabel = new Label();
            editProfileButton = new Button();
            panel1.SuspendLayout();
            personalPanel.SuspendLayout();
            accountPanel.SuspendLayout();
            addressPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(12, 69);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(141, 51);
            backButton.TabIndex = 9;
            backButton.Text = "🡠 Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileLabel.Location = new Point(144, 124);
            profileLabel.Margin = new Padding(4, 0, 4, 0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(176, 65);
            profileLabel.TabIndex = 6;
            profileLabel.Text = "Profile";
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutButton.Location = new Point(12, 955);
            logOutButton.Margin = new Padding(4);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(172, 50);
            logOutButton.TabIndex = 10;
            logOutButton.Text = "➜] Logout";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
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
            panel1.Size = new Size(1074, 62);
            panel1.TabIndex = 11;
            // 
            // personalPanel
            // 
            personalPanel.BackColor = Color.White;
            personalPanel.Controls.Add(phoneLabel);
            personalPanel.Controls.Add(dobLabel);
            personalPanel.Controls.Add(lnameLabel);
            personalPanel.Controls.Add(fnameLabel);
            personalPanel.Controls.Add(personalHeaderLabel);
            personalPanel.Location = new Point(160, 202);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(816, 213);
            personalPanel.TabIndex = 12;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(16, 172);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(88, 28);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Phone #:";
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
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnameLabel.Location = new Point(16, 91);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(107, 28);
            lnameLabel.TabIndex = 1;
            lnameLabel.Text = "Last Name:";
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fnameLabel.Location = new Point(13, 49);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(110, 28);
            fnameLabel.TabIndex = 1;
            fnameLabel.Text = "First Name:";
            fnameLabel.Click += fnameLabel_Click;
            // 
            // personalHeaderLabel
            // 
            personalHeaderLabel.BackColor = Color.LightSteelBlue;
            personalHeaderLabel.FlatStyle = FlatStyle.Flat;
            personalHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            personalHeaderLabel.ForeColor = Color.Navy;
            personalHeaderLabel.Location = new Point(0, 0);
            personalHeaderLabel.Name = "personalHeaderLabel";
            personalHeaderLabel.Size = new Size(816, 40);
            personalHeaderLabel.TabIndex = 0;
            personalHeaderLabel.Text = "Personal Information";
            personalHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = Color.White;
            accountPanel.Controls.Add(label1);
            accountPanel.Controls.Add(usernameLabel);
            accountPanel.Controls.Add(userIdLabel);
            accountPanel.Controls.Add(accountHeaderLabel);
            accountPanel.Location = new Point(160, 461);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(816, 173);
            accountPanel.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 128);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 17;
            label1.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(16, 89);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(103, 28);
            usernameLabel.TabIndex = 17;
            usernameLabel.Text = "Username:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userIdLabel.Location = new Point(16, 51);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(79, 28);
            userIdLabel.TabIndex = 16;
            userIdLabel.Text = "User ID:";
            // 
            // accountHeaderLabel
            // 
            accountHeaderLabel.BackColor = Color.LightSteelBlue;
            accountHeaderLabel.FlatStyle = FlatStyle.Flat;
            accountHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountHeaderLabel.ForeColor = Color.Navy;
            accountHeaderLabel.Location = new Point(0, 0);
            accountHeaderLabel.Name = "accountHeaderLabel";
            accountHeaderLabel.Size = new Size(816, 40);
            accountHeaderLabel.TabIndex = 15;
            accountHeaderLabel.Text = "Account Information";
            accountHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            accountHeaderLabel.Click += label1_Click;
            // 
            // addressPanel
            // 
            addressPanel.BackColor = Color.White;
            addressPanel.Controls.Add(label2);
            addressPanel.Controls.Add(stateLabel);
            addressPanel.Controls.Add(cityLabel);
            addressPanel.Controls.Add(add2Label);
            addressPanel.Controls.Add(add1Label);
            addressPanel.Controls.Add(addressHeaderLabel);
            addressPanel.Location = new Point(160, 681);
            addressPanel.Name = "addressPanel";
            addressPanel.Size = new Size(816, 252);
            addressPanel.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 207);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 22;
            label2.Text = "Zip:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stateLabel.Location = new Point(17, 168);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(60, 28);
            stateLabel.TabIndex = 21;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cityLabel.Location = new Point(16, 131);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(50, 28);
            cityLabel.TabIndex = 20;
            cityLabel.Text = "City:";
            // 
            // add2Label
            // 
            add2Label.AutoSize = true;
            add2Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add2Label.Location = new Point(16, 91);
            add2Label.Name = "add2Label";
            add2Label.Size = new Size(102, 28);
            add2Label.TabIndex = 19;
            add2Label.Text = "Address 2:";
            // 
            // add1Label
            // 
            add1Label.AutoSize = true;
            add1Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add1Label.Location = new Point(16, 53);
            add1Label.Name = "add1Label";
            add1Label.Size = new Size(102, 28);
            add1Label.TabIndex = 18;
            add1Label.Text = "Address 1:";
            // 
            // addressHeaderLabel
            // 
            addressHeaderLabel.BackColor = Color.LightSteelBlue;
            addressHeaderLabel.FlatStyle = FlatStyle.Flat;
            addressHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressHeaderLabel.ForeColor = Color.Navy;
            addressHeaderLabel.Location = new Point(0, 0);
            addressHeaderLabel.Name = "addressHeaderLabel";
            addressHeaderLabel.Size = new Size(816, 40);
            addressHeaderLabel.TabIndex = 16;
            addressHeaderLabel.Text = "Address";
            addressHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editProfileButton
            // 
            editProfileButton.BackColor = Color.RoyalBlue;
            editProfileButton.FlatAppearance.BorderSize = 0;
            editProfileButton.FlatStyle = FlatStyle.Flat;
            editProfileButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editProfileButton.ForeColor = Color.White;
            editProfileButton.Location = new Point(932, 956);
            editProfileButton.Name = "editProfileButton";
            editProfileButton.Size = new Size(131, 50);
            editProfileButton.TabIndex = 15;
            editProfileButton.Text = "✎ Edit";
            editProfileButton.UseVisualStyleBackColor = false;
            editProfileButton.Click += editProfileButton_Click;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1075, 1018);
            Controls.Add(editProfileButton);
            Controls.Add(addressPanel);
            Controls.Add(accountPanel);
            Controls.Add(personalPanel);
            Controls.Add(panel1);
            Controls.Add(logOutButton);
            Controls.Add(backButton);
            Controls.Add(profileLabel);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "ProfilePage";
            Text = "ProfilePage";
            Load += ProfilePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            addressPanel.ResumeLayout(false);
            addressPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label profileLabel;
        private Button logOutButton;
        private Label dashboardTitle;
        private Panel panel1;
        private Panel personalPanel;
        private Label personalHeaderLabel;
        private Panel accountPanel;
        private Panel addressPanel;
        private Label accountHeaderLabel;
        private Label addressHeaderLabel;
        private Label phoneLabel;
        private Label dobLabel;
        private Label lnameLabel;
        private Label fnameLabel;
        private Label label1;
        private Label usernameLabel;
        private Label userIdLabel;
        private Label add2Label;
        private Label add1Label;
        private Label label2;
        private Label stateLabel;
        private Label cityLabel;
        private Label accountInfo;
        private Button editProfileButton;
    }
}