namespace CS3230_Group5.View
{
    partial class NurseHomePage
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
            nurseHomePageTitle = new Label();
            viewNursesButton = new Button();
            viewPatientsButton = new Button();
            profileLink = new LinkLabel();
            SuspendLayout();
            // 
            // nurseHomePageTitle
            // 
            nurseHomePageTitle.AutoSize = true;
            nurseHomePageTitle.Font = new Font("Segoe UI Semibold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nurseHomePageTitle.Location = new Point(25, 128);
            nurseHomePageTitle.Name = "nurseHomePageTitle";
            nurseHomePageTitle.Size = new Size(743, 72);
            nurseHomePageTitle.TabIndex = 0;
            nurseHomePageTitle.Text = "Nurse @ Healthcare Provider";
            // 
            // viewNursesButton
            // 
            viewNursesButton.Font = new Font("Segoe UI", 20F);
            viewNursesButton.Location = new Point(168, 256);
            viewNursesButton.Name = "viewNursesButton";
            viewNursesButton.Size = new Size(227, 91);
            viewNursesButton.TabIndex = 1;
            viewNursesButton.Text = "View Nurses";
            viewNursesButton.UseVisualStyleBackColor = true;
            // 
            // viewPatientsButton
            // 
            viewPatientsButton.Font = new Font("Segoe UI", 20F);
            viewPatientsButton.Location = new Point(416, 256);
            viewPatientsButton.Name = "viewPatientsButton";
            viewPatientsButton.Size = new Size(227, 91);
            viewPatientsButton.TabIndex = 2;
            viewPatientsButton.Text = "View Patients";
            viewPatientsButton.UseVisualStyleBackColor = true;
            // 
            // profileLink
            // 
            profileLink.AutoSize = true;
            profileLink.Font = new Font("Segoe UI", 18F);
            profileLink.Location = new Point(686, 9);
            profileLink.Name = "profileLink";
            profileLink.Size = new Size(102, 41);
            profileLink.TabIndex = 3;
            profileLink.TabStop = true;
            profileLink.Text = "Profile";
            // 
            // NurseHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(profileLink);
            Controls.Add(viewPatientsButton);
            Controls.Add(viewNursesButton);
            Controls.Add(nurseHomePageTitle);
            Name = "NurseHomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nurseHomePageTitle;
        private Button viewNursesButton;
        private Button viewPatientsButton;
        private LinkLabel profileLink;
    }
}