namespace CS3230_Group5.View.Appointments_View
{
    partial class EnterTestResultsPage
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
            testsListView = new ListView();
            selectedTestLabel = new Label();
            rangeLabel = new Label();
            performedLabel = new Label();
            performedPicker = new DateTimePicker();
            performedErrorLabel = new Label();
            resultLabel = new Label();
            resultTextBox = new TextBox();
            unitLabel = new Label();
            resultErrorLabel = new Label();
            abnormalLabel = new Label();
            abnormalComboBox = new ComboBox();
            abnormalErrorLabel = new Label();
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
            titleLabel.Text = "Enter Test Results";
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
            // testsListView
            // 
            testsListView.FullRowSelect = true;
            testsListView.GridLines = true;
            testsListView.HideSelection = false;
            testsListView.Location = new Point(20, 165);
            testsListView.MultiSelect = false;
            testsListView.Name = "testsListView";
            testsListView.Size = new Size(860, 180);
            testsListView.TabIndex = 4;
            testsListView.UseCompatibleStateImageBehavior = false;
            testsListView.View = System.Windows.Forms.View.Details;
            // 
            // selectedTestLabel
            // 
            selectedTestLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectedTestLabel.Location = new Point(20, 358);
            selectedTestLabel.Name = "selectedTestLabel";
            selectedTestLabel.Size = new Size(860, 30);
            selectedTestLabel.TabIndex = 5;
            selectedTestLabel.Text = "Select a test above to enter its result.";
            selectedTestLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rangeLabel
            // 
            rangeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rangeLabel.Location = new Point(20, 388);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(860, 30);
            rangeLabel.TabIndex = 6;
            rangeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // performedLabel
            // 
            performedLabel.AutoSize = true;
            performedLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            performedLabel.Location = new Point(20, 435);
            performedLabel.Name = "performedLabel";
            performedLabel.Size = new Size(176, 28);
            performedLabel.TabIndex = 7;
            performedLabel.Text = "Date/Time Performed:";
            // 
            // performedPicker
            // 
            performedPicker.CustomFormat = "MM/dd/yyyy h:mm tt";
            performedPicker.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            performedPicker.Format = DateTimePickerFormat.Custom;
            performedPicker.Location = new Point(260, 431);
            performedPicker.Name = "performedPicker";
            performedPicker.Size = new Size(300, 34);
            performedPicker.TabIndex = 8;
            // 
            // performedErrorLabel
            // 
            performedErrorLabel.AutoSize = true;
            performedErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            performedErrorLabel.ForeColor = Color.Red;
            performedErrorLabel.Location = new Point(260, 466);
            performedErrorLabel.Name = "performedErrorLabel";
            performedErrorLabel.Size = new Size(45, 21);
            performedErrorLabel.TabIndex = 9;
            performedErrorLabel.Text = "error";
            performedErrorLabel.Visible = false;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(20, 497);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(70, 28);
            resultLabel.TabIndex = 10;
            resultLabel.Text = "Result:";
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.FixedSingle;
            resultTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(260, 493);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(300, 34);
            resultTextBox.TabIndex = 11;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitLabel.Location = new Point(570, 497);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(0, 28);
            unitLabel.TabIndex = 12;
            // 
            // resultErrorLabel
            // 
            resultErrorLabel.AutoSize = true;
            resultErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultErrorLabel.ForeColor = Color.Red;
            resultErrorLabel.Location = new Point(260, 528);
            resultErrorLabel.Name = "resultErrorLabel";
            resultErrorLabel.Size = new Size(45, 21);
            resultErrorLabel.TabIndex = 13;
            resultErrorLabel.Text = "error";
            resultErrorLabel.Visible = false;
            // 
            // abnormalLabel
            // 
            abnormalLabel.AutoSize = true;
            abnormalLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            abnormalLabel.Location = new Point(20, 558);
            abnormalLabel.Name = "abnormalLabel";
            abnormalLabel.Size = new Size(97, 28);
            abnormalLabel.TabIndex = 14;
            abnormalLabel.Text = "Result is:";
            // 
            // abnormalComboBox
            // 
            abnormalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            abnormalComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abnormalComboBox.FormattingEnabled = true;
            abnormalComboBox.Location = new Point(260, 554);
            abnormalComboBox.Name = "abnormalComboBox";
            abnormalComboBox.Size = new Size(300, 36);
            abnormalComboBox.TabIndex = 15;
            // 
            // abnormalErrorLabel
            // 
            abnormalErrorLabel.AutoSize = true;
            abnormalErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abnormalErrorLabel.ForeColor = Color.Red;
            abnormalErrorLabel.Location = new Point(260, 592);
            abnormalErrorLabel.Name = "abnormalErrorLabel";
            abnormalErrorLabel.Size = new Size(45, 21);
            abnormalErrorLabel.TabIndex = 16;
            abnormalErrorLabel.Text = "error";
            abnormalErrorLabel.Visible = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(620, 625);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 47);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.White;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.Black;
            closeButton.Location = new Point(760, 625);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(120, 47);
            closeButton.TabIndex = 18;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // EnterTestResultsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 695);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(abnormalErrorLabel);
            Controls.Add(abnormalComboBox);
            Controls.Add(abnormalLabel);
            Controls.Add(resultErrorLabel);
            Controls.Add(unitLabel);
            Controls.Add(resultTextBox);
            Controls.Add(resultLabel);
            Controls.Add(performedErrorLabel);
            Controls.Add(performedPicker);
            Controls.Add(performedLabel);
            Controls.Add(rangeLabel);
            Controls.Add(selectedTestLabel);
            Controls.Add(testsListView);
            Controls.Add(noticeLabel);
            Controls.Add(visitInfoLabel);
            Controls.Add(patientInfoLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnterTestResultsPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enter Test Results";
            Load += EnterTestResultsPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label patientInfoLabel;
        private Label visitInfoLabel;
        private Label noticeLabel;
        private ListView testsListView;
        private Label selectedTestLabel;
        private Label rangeLabel;
        private Label performedLabel;
        private DateTimePicker performedPicker;
        private Label performedErrorLabel;
        private Label resultLabel;
        private TextBox resultTextBox;
        private Label unitLabel;
        private Label resultErrorLabel;
        private Label abnormalLabel;
        private ComboBox abnormalComboBox;
        private Label abnormalErrorLabel;
        private Button saveButton;
        private Button closeButton;
    }
}
