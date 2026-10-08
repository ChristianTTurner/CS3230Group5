namespace CS3230_Group5.View.Nurse_View
{
    partial class SearchPatientPage
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
            patientList = new ListView();
            searchPatientTextBox = new TextBox();
            addPatientButton = new Button();
            profileLink = new LinkLabel();
            SuspendLayout();
            // 
            // patientList
            // 
            patientList.Location = new Point(12, 89);
            patientList.Name = "patientList";
            patientList.Size = new Size(776, 349);
            patientList.TabIndex = 0;
            patientList.UseCompatibleStateImageBehavior = false;
            // 
            // searchPatientTextBox
            // 
            searchPatientTextBox.Location = new Point(135, 45);
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.PlaceholderText = "Patient Name";
            searchPatientTextBox.Size = new Size(653, 27);
            searchPatientTextBox.TabIndex = 1;
            // 
            // addPatientButton
            // 
            addPatientButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addPatientButton.ImageAlign = ContentAlignment.TopCenter;
            addPatientButton.Location = new Point(94, 45);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(35, 27);
            addPatientButton.TabIndex = 2;
            addPatientButton.Text = "+";
            addPatientButton.UseVisualStyleBackColor = true;
            // 
            // profileLink
            // 
            profileLink.AutoSize = true;
            profileLink.Location = new Point(736, 9);
            profileLink.Name = "profileLink";
            profileLink.Size = new Size(52, 20);
            profileLink.TabIndex = 3;
            profileLink.TabStop = true;
            profileLink.Text = "Profile";
            // 
            // SearchPatientPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(profileLink);
            Controls.Add(addPatientButton);
            Controls.Add(searchPatientTextBox);
            Controls.Add(patientList);
            Name = "SearchPatientPage";
            Text = "Patients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView patientList;
        private TextBox searchPatientTextBox;
        private Button addPatientButton;
        private LinkLabel profileLink;
    }
}