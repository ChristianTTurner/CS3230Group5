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
            backButton = new Button();
            SuspendLayout();
            // 
            // logInPageTitle
            // 
            logInPageTitle.AutoSize = true;
            logInPageTitle.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInPageTitle.Location = new Point(83, 106);
            logInPageTitle.Name = "logInPageTitle";
            logInPageTitle.Size = new Size(633, 62);
            logInPageTitle.TabIndex = 3;
            logInPageTitle.Text = "Healthcare Provider Group 5";
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Segoe UI", 12F);
            usernameInput.Location = new Point(249, 208);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(422, 34);
            usernameInput.TabIndex = 25;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 16F);
            usernameLabel.Location = new Point(105, 204);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(138, 37);
            usernameLabel.TabIndex = 24;
            usernameLabel.Text = "username:";
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 12F);
            passwordInput.Location = new Point(249, 260);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(422, 34);
            passwordInput.TabIndex = 27;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 16F);
            passwordLabel.Location = new Point(105, 256);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(136, 37);
            passwordLabel.TabIndex = 26;
            passwordLabel.Text = "password:";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(36, 29);
            backButton.TabIndex = 28;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(passwordInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameInput);
            Controls.Add(usernameLabel);
            Controls.Add(logInPageTitle);
            Name = "LogInPage";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logInPageTitle;
        private TextBox usernameInput;
        private Label usernameLabel;
        private TextBox passwordInput;
        private Label passwordLabel;
        private Button backButton;
    }
}