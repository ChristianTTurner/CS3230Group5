namespace CS3230_Group5
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signInButton = new Button();
            linkLabel1 = new LinkLabel();
            homePageTitle = new Label();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.Font = new Font("Segoe UI", 13F);
            signInButton.Location = new Point(287, 247);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(191, 67);
            signInButton.TabIndex = 0;
            signInButton.Text = "SIGN IN";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.Location = new Point(194, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(362, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Contact a Nurse to Book an Appointment!";
            // 
            // homePageTitle
            // 
            homePageTitle.AutoSize = true;
            homePageTitle.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homePageTitle.Location = new Point(27, 110);
            homePageTitle.Name = "homePageTitle";
            homePageTitle.Size = new Size(751, 72);
            homePageTitle.TabIndex = 2;
            homePageTitle.Text = "Healthcare Provider Group 5";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(homePageTitle);
            Controls.Add(linkLabel1);
            Controls.Add(signInButton);
            Name = "HomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signInButton;
        private LinkLabel linkLabel1;
        private Label homePageTitle;
    }
}
