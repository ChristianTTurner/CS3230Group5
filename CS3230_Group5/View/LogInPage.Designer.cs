namespace CS3230_Group5.View
{
    partial class LogInPage
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
            logInPageTitle = new Label();
            usernameInput = new TextBox();
            usernameLabel = new Label();
            passwordInput = new TextBox();
            passwordLabel = new Label();
            logInButton = new Button();
            logInErrorLabel = new Label();
            SuspendLayout();
            // 
            // logInPageTitle
            // 
            logInPageTitle.AutoSize = true;
            logInPageTitle.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInPageTitle.ForeColor = Color.MidnightBlue;
            logInPageTitle.Location = new Point(58, 110);
            logInPageTitle.Margin = new Padding(4, 0, 4, 0);
            logInPageTitle.Name = "logInPageTitle";
            logInPageTitle.Size = new Size(871, 76);
            logInPageTitle.TabIndex = 3;
            logInPageTitle.Text = "Healthcare Management System";
            logInPageTitle.Click += logInPageTitle_Click;
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Segoe UI", 12F);
            usernameInput.Location = new Point(311, 219);
            usernameInput.Margin = new Padding(4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(526, 39);
            usernameInput.TabIndex = 25;
            usernameInput.Leave += usernameInput_Leave;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 16F);
            usernameLabel.Location = new Point(131, 214);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(166, 45);
            usernameLabel.TabIndex = 24;
            usernameLabel.Text = "username:";
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 12F);
            passwordInput.Location = new Point(311, 300);
            passwordInput.Margin = new Padding(4);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(526, 39);
            passwordInput.TabIndex = 27;
            passwordInput.Leave += passwordInput_Leave;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 16F);
            passwordLabel.Location = new Point(131, 295);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(162, 45);
            passwordLabel.TabIndex = 26;
            passwordLabel.Text = "password:";
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.MidnightBlue;
            logInButton.FlatAppearance.BorderSize = 0;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInButton.ForeColor = Color.White;
            logInButton.Location = new Point(421, 379);
            logInButton.Margin = new Padding(4);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(160, 68);
            logInButton.TabIndex = 29;
            logInButton.Text = "Login";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // logInErrorLabel
            // 
            logInErrorLabel.AutoSize = true;
            logInErrorLabel.Font = new Font("Segoe UI", 10F);
            logInErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            logInErrorLabel.Location = new Point(394, 466);
            logInErrorLabel.Margin = new Padding(4, 0, 4, 0);
            logInErrorLabel.Name = "logInErrorLabel";
            logInErrorLabel.Size = new Size(232, 28);
            logInErrorLabel.TabIndex = 30;
            logInErrorLabel.Text = "invalid log in credentials*";
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(logInErrorLabel);
            Controls.Add(logInButton);
            Controls.Add(passwordInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameInput);
            Controls.Add(usernameLabel);
            Controls.Add(logInPageTitle);
            Margin = new Padding(4);
            Name = "LogInPage";
            Text = "Log In";
            Load += LogInPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logInPageTitle;
        private TextBox usernameInput;
        private Label usernameLabel;
        private TextBox passwordInput;
        private Label passwordLabel;
        private Button logInButton;
        private Label logInErrorLabel;
    }
}