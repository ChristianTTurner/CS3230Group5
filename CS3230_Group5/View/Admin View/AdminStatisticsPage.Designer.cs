namespace CS3230_Group5.View.Admin_View
{
    partial class AdminStatisticsPage
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
            panel1 = new Panel();
            dashboardTitle = new Label();
            backButton = new Button();
            adminStatsHeaderLabel = new Label();
            dateFilterPanel = new Panel();
            startDateTimePicker = new DateTimePicker();
            startDateLabel = new Label();
            endDateLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            generateStatsButton = new Button();
            appointmentsPanel = new Panel();
            patientsPanel = new Panel();
            checkupsPanel = new Panel();
            orderedTestsPanel = new Panel();
            performedTestsPanel = new Panel();
            abnormalResultsPanel = new Panel();
            totalAppointmentsLabel = new Label();
            totalAppointmentsValueLabel = new Label();
            uniquePatientsValueLabel = new Label();
            uniquePatientsLabel = new Label();
            completedCheckupsValueLabel = new Label();
            completedCheckupsLabel = new Label();
            testsOrderedValueLabel = new Label();
            testsOrderedLabel = new Label();
            testsPerformedValueLabel = new Label();
            testsPerformedLabel = new Label();
            abnormalResultsValueLabel = new Label();
            abnormalResultsLabel = new Label();
            panel1.SuspendLayout();
            dateFilterPanel.SuspendLayout();
            appointmentsPanel.SuspendLayout();
            patientsPanel.SuspendLayout();
            checkupsPanel.SuspendLayout();
            orderedTestsPanel.SuspendLayout();
            performedTestsPanel.SuspendLayout();
            abnormalResultsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 62);
            panel1.TabIndex = 13;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(11, 18);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(308, 28);
            dashboardTitle.TabIndex = 0;
            dashboardTitle.Text = "Healthcare Management System";
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(13, 69);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(141, 51);
            backButton.TabIndex = 14;
            backButton.Text = "🡠 Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // adminStatsHeaderLabel
            // 
            adminStatsHeaderLabel.AutoSize = true;
            adminStatsHeaderLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminStatsHeaderLabel.Location = new Point(162, 65);
            adminStatsHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            adminStatsHeaderLabel.Name = "adminStatsHeaderLabel";
            adminStatsHeaderLabel.Size = new Size(394, 65);
            adminStatsHeaderLabel.TabIndex = 15;
            adminStatsHeaderLabel.Text = "Admin Statistics";
            // 
            // dateFilterPanel
            // 
            dateFilterPanel.BackColor = Color.White;
            dateFilterPanel.Controls.Add(generateStatsButton);
            dateFilterPanel.Controls.Add(endDateTimePicker);
            dateFilterPanel.Controls.Add(endDateLabel);
            dateFilterPanel.Controls.Add(startDateLabel);
            dateFilterPanel.Controls.Add(startDateTimePicker);
            dateFilterPanel.Location = new Point(13, 154);
            dateFilterPanel.Name = "dateFilterPanel";
            dateFilterPanel.Size = new Size(862, 204);
            dateFilterPanel.TabIndex = 16;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateTimePicker.Format = DateTimePickerFormat.Short;
            startDateTimePicker.Location = new Point(34, 52);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(272, 39);
            startDateTimePicker.TabIndex = 0;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            startDateLabel.Location = new Point(34, 21);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(115, 28);
            startDateLabel.TabIndex = 1;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            endDateLabel.Location = new Point(464, 21);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(103, 28);
            endDateLabel.TabIndex = 2;
            endDateLabel.Text = "End Date:";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateTimePicker.Format = DateTimePickerFormat.Short;
            endDateTimePicker.Location = new Point(464, 52);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(272, 39);
            endDateTimePicker.TabIndex = 3;
            // 
            // generateStatsButton
            // 
            generateStatsButton.BackColor = Color.DarkBlue;
            generateStatsButton.FlatStyle = FlatStyle.Flat;
            generateStatsButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateStatsButton.ForeColor = Color.White;
            generateStatsButton.Location = new Point(34, 131);
            generateStatsButton.Name = "generateStatsButton";
            generateStatsButton.Size = new Size(796, 50);
            generateStatsButton.TabIndex = 4;
            generateStatsButton.Text = "Generate Statistics";
            generateStatsButton.UseVisualStyleBackColor = false;
            // 
            // appointmentsPanel
            // 
            appointmentsPanel.BackColor = Color.LightSteelBlue;
            appointmentsPanel.BorderStyle = BorderStyle.FixedSingle;
            appointmentsPanel.Controls.Add(totalAppointmentsValueLabel);
            appointmentsPanel.Controls.Add(totalAppointmentsLabel);
            appointmentsPanel.Location = new Point(13, 381);
            appointmentsPanel.Name = "appointmentsPanel";
            appointmentsPanel.Size = new Size(418, 150);
            appointmentsPanel.TabIndex = 17;
            // 
            // patientsPanel
            // 
            patientsPanel.BackColor = Color.Wheat;
            patientsPanel.BorderStyle = BorderStyle.FixedSingle;
            patientsPanel.Controls.Add(uniquePatientsValueLabel);
            patientsPanel.Controls.Add(uniquePatientsLabel);
            patientsPanel.Location = new Point(456, 381);
            patientsPanel.Name = "patientsPanel";
            patientsPanel.Size = new Size(419, 150);
            patientsPanel.TabIndex = 18;
            // 
            // checkupsPanel
            // 
            checkupsPanel.BackColor = Color.FromArgb(217, 231, 193);
            checkupsPanel.BorderStyle = BorderStyle.FixedSingle;
            checkupsPanel.Controls.Add(completedCheckupsValueLabel);
            checkupsPanel.Controls.Add(completedCheckupsLabel);
            checkupsPanel.Location = new Point(13, 557);
            checkupsPanel.Name = "checkupsPanel";
            checkupsPanel.Size = new Size(419, 150);
            checkupsPanel.TabIndex = 19;
            // 
            // orderedTestsPanel
            // 
            orderedTestsPanel.BackColor = Color.FromArgb(221, 211, 238);
            orderedTestsPanel.BorderStyle = BorderStyle.FixedSingle;
            orderedTestsPanel.Controls.Add(testsOrderedValueLabel);
            orderedTestsPanel.Controls.Add(testsOrderedLabel);
            orderedTestsPanel.Location = new Point(456, 557);
            orderedTestsPanel.Name = "orderedTestsPanel";
            orderedTestsPanel.Size = new Size(419, 150);
            orderedTestsPanel.TabIndex = 20;
            // 
            // performedTestsPanel
            // 
            performedTestsPanel.BackColor = Color.FromArgb(220, 211, 203);
            performedTestsPanel.BorderStyle = BorderStyle.FixedSingle;
            performedTestsPanel.Controls.Add(testsPerformedValueLabel);
            performedTestsPanel.Controls.Add(testsPerformedLabel);
            performedTestsPanel.Location = new Point(13, 739);
            performedTestsPanel.Name = "performedTestsPanel";
            performedTestsPanel.Size = new Size(419, 150);
            performedTestsPanel.TabIndex = 21;
            // 
            // abnormalResultsPanel
            // 
            abnormalResultsPanel.BackColor = Color.FromArgb(255, 227, 226);
            abnormalResultsPanel.BorderStyle = BorderStyle.FixedSingle;
            abnormalResultsPanel.Controls.Add(abnormalResultsValueLabel);
            abnormalResultsPanel.Controls.Add(abnormalResultsLabel);
            abnormalResultsPanel.Location = new Point(456, 739);
            abnormalResultsPanel.Name = "abnormalResultsPanel";
            abnormalResultsPanel.Size = new Size(419, 150);
            abnormalResultsPanel.TabIndex = 22;
            // 
            // totalAppointmentsLabel
            // 
            totalAppointmentsLabel.AutoSize = true;
            totalAppointmentsLabel.BackColor = Color.Transparent;
            totalAppointmentsLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAppointmentsLabel.Location = new Point(16, 10);
            totalAppointmentsLabel.Name = "totalAppointmentsLabel";
            totalAppointmentsLabel.Size = new Size(209, 30);
            totalAppointmentsLabel.TabIndex = 0;
            totalAppointmentsLabel.Text = "Total Appointments";
            // 
            // totalAppointmentsValueLabel
            // 
            totalAppointmentsValueLabel.AutoSize = true;
            totalAppointmentsValueLabel.BackColor = Color.Transparent;
            totalAppointmentsValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAppointmentsValueLabel.ForeColor = Color.DarkBlue;
            totalAppointmentsValueLabel.Location = new Point(16, 65);
            totalAppointmentsValueLabel.Name = "totalAppointmentsValueLabel";
            totalAppointmentsValueLabel.Size = new Size(50, 60);
            totalAppointmentsValueLabel.TabIndex = 1;
            totalAppointmentsValueLabel.Text = "0";
            // 
            // uniquePatientsValueLabel
            // 
            uniquePatientsValueLabel.AutoSize = true;
            uniquePatientsValueLabel.BackColor = Color.Transparent;
            uniquePatientsValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uniquePatientsValueLabel.ForeColor = Color.DarkBlue;
            uniquePatientsValueLabel.Location = new Point(20, 65);
            uniquePatientsValueLabel.Name = "uniquePatientsValueLabel";
            uniquePatientsValueLabel.Size = new Size(50, 60);
            uniquePatientsValueLabel.TabIndex = 3;
            uniquePatientsValueLabel.Text = "0";
            // 
            // uniquePatientsLabel
            // 
            uniquePatientsLabel.AutoSize = true;
            uniquePatientsLabel.BackColor = Color.Transparent;
            uniquePatientsLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uniquePatientsLabel.Location = new Point(20, 10);
            uniquePatientsLabel.Name = "uniquePatientsLabel";
            uniquePatientsLabel.Size = new Size(170, 30);
            uniquePatientsLabel.TabIndex = 2;
            uniquePatientsLabel.Text = "Unique Patients";
            // 
            // completedCheckupsValueLabel
            // 
            completedCheckupsValueLabel.AutoSize = true;
            completedCheckupsValueLabel.BackColor = Color.Transparent;
            completedCheckupsValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedCheckupsValueLabel.ForeColor = Color.DarkBlue;
            completedCheckupsValueLabel.Location = new Point(16, 74);
            completedCheckupsValueLabel.Name = "completedCheckupsValueLabel";
            completedCheckupsValueLabel.Size = new Size(50, 60);
            completedCheckupsValueLabel.TabIndex = 5;
            completedCheckupsValueLabel.Text = "0";
            // 
            // completedCheckupsLabel
            // 
            completedCheckupsLabel.AutoSize = true;
            completedCheckupsLabel.BackColor = Color.Transparent;
            completedCheckupsLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedCheckupsLabel.Location = new Point(16, 19);
            completedCheckupsLabel.Name = "completedCheckupsLabel";
            completedCheckupsLabel.Size = new Size(225, 30);
            completedCheckupsLabel.TabIndex = 4;
            completedCheckupsLabel.Text = "Completed Checkups";
            // 
            // testsOrderedValueLabel
            // 
            testsOrderedValueLabel.AutoSize = true;
            testsOrderedValueLabel.BackColor = Color.Transparent;
            testsOrderedValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testsOrderedValueLabel.ForeColor = Color.DarkBlue;
            testsOrderedValueLabel.Location = new Point(20, 74);
            testsOrderedValueLabel.Name = "testsOrderedValueLabel";
            testsOrderedValueLabel.Size = new Size(50, 60);
            testsOrderedValueLabel.TabIndex = 7;
            testsOrderedValueLabel.Text = "0";
            // 
            // testsOrderedLabel
            // 
            testsOrderedLabel.AutoSize = true;
            testsOrderedLabel.BackColor = Color.Transparent;
            testsOrderedLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testsOrderedLabel.Location = new Point(20, 19);
            testsOrderedLabel.Name = "testsOrderedLabel";
            testsOrderedLabel.Size = new Size(150, 30);
            testsOrderedLabel.TabIndex = 6;
            testsOrderedLabel.Text = "Tests Ordered";
            // 
            // testsPerformedValueLabel
            // 
            testsPerformedValueLabel.AutoSize = true;
            testsPerformedValueLabel.BackColor = Color.Transparent;
            testsPerformedValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testsPerformedValueLabel.ForeColor = Color.DarkBlue;
            testsPerformedValueLabel.Location = new Point(16, 70);
            testsPerformedValueLabel.Name = "testsPerformedValueLabel";
            testsPerformedValueLabel.Size = new Size(50, 60);
            testsPerformedValueLabel.TabIndex = 9;
            testsPerformedValueLabel.Text = "0";
            // 
            // testsPerformedLabel
            // 
            testsPerformedLabel.AutoSize = true;
            testsPerformedLabel.BackColor = Color.Transparent;
            testsPerformedLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testsPerformedLabel.Location = new Point(16, 15);
            testsPerformedLabel.Name = "testsPerformedLabel";
            testsPerformedLabel.Size = new Size(172, 30);
            testsPerformedLabel.TabIndex = 8;
            testsPerformedLabel.Text = "Tests Performed";
            // 
            // abnormalResultsValueLabel
            // 
            abnormalResultsValueLabel.AutoSize = true;
            abnormalResultsValueLabel.BackColor = Color.Transparent;
            abnormalResultsValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            abnormalResultsValueLabel.ForeColor = Color.DarkBlue;
            abnormalResultsValueLabel.Location = new Point(20, 70);
            abnormalResultsValueLabel.Name = "abnormalResultsValueLabel";
            abnormalResultsValueLabel.Size = new Size(50, 60);
            abnormalResultsValueLabel.TabIndex = 11;
            abnormalResultsValueLabel.Text = "0";
            // 
            // abnormalResultsLabel
            // 
            abnormalResultsLabel.AutoSize = true;
            abnormalResultsLabel.BackColor = Color.Transparent;
            abnormalResultsLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            abnormalResultsLabel.Location = new Point(20, 15);
            abnormalResultsLabel.Name = "abnormalResultsLabel";
            abnormalResultsLabel.Size = new Size(187, 30);
            abnormalResultsLabel.TabIndex = 10;
            abnormalResultsLabel.Text = "Abnormal Results";
            // 
            // AdminStatisticsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(891, 911);
            Controls.Add(abnormalResultsPanel);
            Controls.Add(performedTestsPanel);
            Controls.Add(orderedTestsPanel);
            Controls.Add(checkupsPanel);
            Controls.Add(patientsPanel);
            Controls.Add(appointmentsPanel);
            Controls.Add(dateFilterPanel);
            Controls.Add(adminStatsHeaderLabel);
            Controls.Add(backButton);
            Controls.Add(panel1);
            Name = "AdminStatisticsPage";
            Text = "AdminStatisticsPage";
            Load += AdminStatisticsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            dateFilterPanel.ResumeLayout(false);
            dateFilterPanel.PerformLayout();
            appointmentsPanel.ResumeLayout(false);
            appointmentsPanel.PerformLayout();
            patientsPanel.ResumeLayout(false);
            patientsPanel.PerformLayout();
            checkupsPanel.ResumeLayout(false);
            checkupsPanel.PerformLayout();
            orderedTestsPanel.ResumeLayout(false);
            orderedTestsPanel.PerformLayout();
            performedTestsPanel.ResumeLayout(false);
            performedTestsPanel.PerformLayout();
            abnormalResultsPanel.ResumeLayout(false);
            abnormalResultsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label dashboardTitle;
        private Button backButton;
        private Label adminStatsHeaderLabel;
        private Panel dateFilterPanel;
        private Label startDateLabel;
        private DateTimePicker startDateTimePicker;
        private Button generateStatsButton;
        private DateTimePicker endDateTimePicker;
        private Label endDateLabel;
        private Panel appointmentsPanel;
        private Panel patientsPanel;
        private Panel checkupsPanel;
        private Panel orderedTestsPanel;
        private Panel performedTestsPanel;
        private Panel abnormalResultsPanel;
        private Label totalAppointmentsValueLabel;
        private Label totalAppointmentsLabel;
        private Label uniquePatientsValueLabel;
        private Label uniquePatientsLabel;
        private Label completedCheckupsValueLabel;
        private Label completedCheckupsLabel;
        private Label testsOrderedValueLabel;
        private Label testsOrderedLabel;
        private Label testsPerformedValueLabel;
        private Label testsPerformedLabel;
        private Label abnormalResultsValueLabel;
        private Label abnormalResultsLabel;
    }
}