namespace CS3230_Group5.View.Appointments_View
{
    partial class EnterFinalDiagnosisPage
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
            titleLabel = new Label();
            patientInfoLabel = new Label();
            visitInfoLabel = new Label();
            noticeLabel = new Label();
            initialLabel = new Label();
            initialTextBox = new TextBox();
            testsLabel = new Label();
            testsListView = new ListView();
            finalLabel = new Label();
            finalTextBox = new TextBox();
            finalErrorLabel = new Label();
            saveButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Navy;
            titleLabel.FlatStyle = FlatStyle.Flat;
            titleLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(900, 53);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Enter Final Diagnosis";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // patientInfoLabel
            // 
            patientInfoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientInfoLabel.Location = new Point(20, 65);
            patientInfoLabel.Name = "patientInfoLabel";
            patientInfoLabel.Size = new Size(860, 30);
            patientInfoLabel.TabIndex = 1;
            patientInfoLabel.Text = "Patient:";
            patientInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // visitInfoLabel
            // 
            visitInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visitInfoLabel.Location = new Point(20, 95);
            visitInfoLabel.Name = "visitInfoLabel";
            visitInfoLabel.Size = new Size(860, 30);
            visitInfoLabel.TabIndex = 2;
            visitInfoLabel.Text = "Doctor:";
            visitInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            visitInfoLabel.Click += visitInfoLabel_Click;
            // 
            // noticeLabel
            // 
            noticeLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noticeLabel.ForeColor = Color.Firebrick;
            noticeLabel.Location = new Point(20, 127);
            noticeLabel.Name = "noticeLabel";
            noticeLabel.Size = new Size(860, 30);
            noticeLabel.TabIndex = 3;
            noticeLabel.TextAlign = ContentAlignment.MiddleLeft;
            noticeLabel.Visible = false;
            // 
            // initialLabel
            // 
            initialLabel.AutoSize = true;
            initialLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            initialLabel.Location = new Point(20, 165);
            initialLabel.Name = "initialLabel";
            initialLabel.Size = new Size(161, 28);
            initialLabel.TabIndex = 4;
            initialLabel.Text = "Initial Diagnosis:";
            // 
            // initialTextBox
            // 
            initialTextBox.BackColor = Color.WhiteSmoke;
            initialTextBox.BorderStyle = BorderStyle.FixedSingle;
            initialTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            initialTextBox.Location = new Point(20, 196);
            initialTextBox.Multiline = true;
            initialTextBox.Name = "initialTextBox";
            initialTextBox.ReadOnly = true;
            initialTextBox.ScrollBars = ScrollBars.Vertical;
            initialTextBox.Size = new Size(860, 60);
            initialTextBox.TabIndex = 5;
            // 
            // testsLabel
            // 
            testsLabel.AutoSize = true;
            testsLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testsLabel.Location = new Point(20, 268);
            testsLabel.Name = "testsLabel";
            testsLabel.Size = new Size(143, 28);
            testsLabel.TabIndex = 6;
            testsLabel.Text = "Tests Ordered:";
            // 
            // testsListView
            // 
            testsListView.FullRowSelect = true;
            testsListView.GridLines = true;
            testsListView.Location = new Point(20, 299);
            testsListView.MultiSelect = false;
            testsListView.Name = "testsListView";
            testsListView.Size = new Size(860, 150);
            testsListView.TabIndex = 7;
            testsListView.UseCompatibleStateImageBehavior = false;
            testsListView.View = System.Windows.Forms.View.Details;
            // 
            // finalLabel
            // 
            finalLabel.AutoSize = true;
            finalLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalLabel.Location = new Point(20, 462);
            finalLabel.Name = "finalLabel";
            finalLabel.Size = new Size(153, 28);
            finalLabel.TabIndex = 8;
            finalLabel.Text = "Final Diagnosis:";
            // 
            // finalTextBox
            // 
            finalTextBox.BorderStyle = BorderStyle.FixedSingle;
            finalTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalTextBox.Location = new Point(20, 493);
            finalTextBox.MaxLength = 500;
            finalTextBox.Multiline = true;
            finalTextBox.Name = "finalTextBox";
            finalTextBox.ScrollBars = ScrollBars.Vertical;
            finalTextBox.Size = new Size(860, 100);
            finalTextBox.TabIndex = 9;
            // 
            // finalErrorLabel
            // 
            finalErrorLabel.AutoSize = true;
            finalErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalErrorLabel.ForeColor = Color.Red;
            finalErrorLabel.Location = new Point(20, 598);
            finalErrorLabel.Name = "finalErrorLabel";
            finalErrorLabel.Size = new Size(45, 21);
            finalErrorLabel.TabIndex = 10;
            finalErrorLabel.Text = "error";
            finalErrorLabel.Visible = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(520, 632);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(240, 47);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save Final Diagnosis";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.White;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.Black;
            closeButton.Location = new Point(780, 632);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(100, 47);
            closeButton.TabIndex = 12;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // EnterFinalDiagnosisPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(finalErrorLabel);
            Controls.Add(finalTextBox);
            Controls.Add(finalLabel);
            Controls.Add(testsListView);
            Controls.Add(testsLabel);
            Controls.Add(initialTextBox);
            Controls.Add(initialLabel);
            Controls.Add(noticeLabel);
            Controls.Add(visitInfoLabel);
            Controls.Add(patientInfoLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnterFinalDiagnosisPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enter Final Diagnosis";
            Load += EnterFinalDiagnosisPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label patientInfoLabel;
        private Label visitInfoLabel;
        private Label noticeLabel;
        private Label initialLabel;
        private TextBox initialTextBox;
        private Label testsLabel;
        private ListView testsListView;
        private Label finalLabel;
        private TextBox finalTextBox;
        private Label finalErrorLabel;
        private Button saveButton;
        private Button closeButton;
    }
}
