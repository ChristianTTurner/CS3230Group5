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
            addNurseButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // nursesList
            // 
            nursesList.Location = new Point(15, 172);
            nursesList.Margin = new Padding(4, 4, 4, 4);
            nursesList.Name = "nursesList";
            nursesList.Size = new Size(969, 374);
            nursesList.TabIndex = 0;
            nursesList.UseCompatibleStateImageBehavior = false;
            // 
            // viewNursesLabel
            // 
            viewNursesLabel.AutoSize = true;
            viewNursesLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewNursesLabel.Location = new Point(15, 54);
            viewNursesLabel.Margin = new Padding(4, 0, 4, 0);
            viewNursesLabel.Name = "viewNursesLabel";
            viewNursesLabel.Size = new Size(215, 76);
            viewNursesLabel.TabIndex = 1;
            viewNursesLabel.Text = "Nurses";
            // 
            // addNurseButton
            // 
            addNurseButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addNurseButton.Location = new Point(228, 72);
            addNurseButton.Margin = new Padding(4, 4, 4, 4);
            addNurseButton.Name = "addNurseButton";
            addNurseButton.Size = new Size(49, 46);
            addNurseButton.TabIndex = 3;
            addNurseButton.Text = "+";
            addNurseButton.UseVisualStyleBackColor = true;
            addNurseButton.Click += addNurseButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(15, 15);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(40, 36);
            backButton.TabIndex = 4;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ViewNursesPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(backButton);
            Controls.Add(addNurseButton);
            Controls.Add(viewNursesLabel);
            Controls.Add(nursesList);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ViewNursesPage";
            Text = "View Nurses";
            Load += ViewNursesPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView nursesList;
        private Label viewNursesLabel;
        private Button addNurseButton;
        private Button backButton;
    }
}