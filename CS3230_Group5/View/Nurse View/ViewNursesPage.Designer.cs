namespace CS3230_Group5.View.Nurse_View
{
    partial class ViewNursesPage
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
            nursesList = new ListView();
            viewNursesLabel = new Label();
            profileLink = new LinkLabel();
            addNurseButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // nursesList
            // 
            nursesList.Location = new Point(12, 138);
            nursesList.Name = "nursesList";
            nursesList.Size = new Size(776, 300);
            nursesList.TabIndex = 0;
            nursesList.UseCompatibleStateImageBehavior = false;
            // 
            // viewNursesLabel
            // 
            viewNursesLabel.AutoSize = true;
            viewNursesLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewNursesLabel.Location = new Point(12, 43);
            viewNursesLabel.Name = "viewNursesLabel";
            viewNursesLabel.Size = new Size(178, 62);
            viewNursesLabel.TabIndex = 1;
            viewNursesLabel.Text = "Nurses";
            // 
            // profileLink
            // 
            profileLink.AutoSize = true;
            profileLink.Font = new Font("Segoe UI", 12F);
            profileLink.Location = new Point(720, 9);
            profileLink.Name = "profileLink";
            profileLink.Size = new Size(68, 28);
            profileLink.TabIndex = 2;
            profileLink.TabStop = true;
            profileLink.Text = "Profile";
            // 
            // addNurseButton
            // 
            addNurseButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addNurseButton.Location = new Point(182, 58);
            addNurseButton.Name = "addNurseButton";
            addNurseButton.Size = new Size(39, 37);
            addNurseButton.TabIndex = 3;
            addNurseButton.Text = "+";
            addNurseButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(32, 29);
            backButton.TabIndex = 4;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            // 
            // ViewNursesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(addNurseButton);
            Controls.Add(profileLink);
            Controls.Add(viewNursesLabel);
            Controls.Add(nursesList);
            Name = "ViewNursesPage";
            Text = "View Nurses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView nursesList;
        private Label viewNursesLabel;
        private LinkLabel profileLink;
        private Button addNurseButton;
        private Button backButton;
    }
}