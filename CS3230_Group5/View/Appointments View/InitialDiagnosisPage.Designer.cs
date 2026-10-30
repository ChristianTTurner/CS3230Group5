namespace CS3230_Group5.View.Appointments_View
{
    partial class InitialDiagnosisPage
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
            initialDiagnosisTitleLabel = new Label();
            initialDiagnosisLabel = new Label();
            initialDiagnosisTextBox = new TextBox();
            initialDiagnosisErrorLabel = new Label();
            saveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // initialDiagnosisTitleLabel
            // 
            initialDiagnosisTitleLabel.BackColor = Color.Navy;
            initialDiagnosisTitleLabel.FlatStyle = FlatStyle.Flat;
            initialDiagnosisTitleLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            initialDiagnosisTitleLabel.ForeColor = Color.White;
            initialDiagnosisTitleLabel.Location = new Point(1, 0);
            initialDiagnosisTitleLabel.Name = "initialDiagnosisTitleLabel";
            initialDiagnosisTitleLabel.Size = new Size(600, 53);
            initialDiagnosisTitleLabel.TabIndex = 1;
            initialDiagnosisTitleLabel.Text = "Enter/ Update Initial Diagnosis";
            initialDiagnosisTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // initialDiagnosisLabel
            // 
            initialDiagnosisLabel.AutoSize = true;
            initialDiagnosisLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            initialDiagnosisLabel.Location = new Point(12, 63);
            initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            initialDiagnosisLabel.Size = new Size(161, 28);
            initialDiagnosisLabel.TabIndex = 8;
            initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // initialDiagnosisTextBox
            // 
            initialDiagnosisTextBox.BackColor = Color.White;
            initialDiagnosisTextBox.BorderStyle = BorderStyle.FixedSingle;
            initialDiagnosisTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            initialDiagnosisTextBox.Location = new Point(12, 108);
            initialDiagnosisTextBox.Multiline = true;
            initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            initialDiagnosisTextBox.ScrollBars = ScrollBars.Vertical;
            initialDiagnosisTextBox.Size = new Size(561, 184);
            initialDiagnosisTextBox.TabIndex = 15;
            // 
            // initialDiagnosisErrorLabel
            // 
            initialDiagnosisErrorLabel.AutoSize = true;
            initialDiagnosisErrorLabel.BackColor = Color.Transparent;
            initialDiagnosisErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            initialDiagnosisErrorLabel.ForeColor = Color.Red;
            initialDiagnosisErrorLabel.Location = new Point(12, 307);
            initialDiagnosisErrorLabel.Name = "initialDiagnosisErrorLabel";
            initialDiagnosisErrorLabel.Size = new Size(45, 21);
            initialDiagnosisErrorLabel.TabIndex = 23;
            initialDiagnosisErrorLabel.Text = "error";
            initialDiagnosisErrorLabel.Visible = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(322, 327);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 47);
            saveButton.TabIndex = 24;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.White;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(461, 327);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 47);
            CancelButton.TabIndex = 25;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // InitialDiagnosisPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 399);
            Controls.Add(CancelButton);
            Controls.Add(saveButton);
            Controls.Add(initialDiagnosisErrorLabel);
            Controls.Add(initialDiagnosisTextBox);
            Controls.Add(initialDiagnosisLabel);
            Controls.Add(initialDiagnosisTitleLabel);
            Name = "InitialDiagnosisPage";
            Text = "Initial Diagnosis";
            Load += InitialDiagnosisPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label initialDiagnosisTitleLabel;
        private Label initialDiagnosisLabel;
        private TextBox initialDiagnosisTextBox;
        private Label initialDiagnosisErrorLabel;
        private Button saveButton;
        private new Button CancelButton;
    }
}