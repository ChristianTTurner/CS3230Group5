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
            generateStatsButton = new Button();
            endDateTimePicker = new DateTimePicker();
            endDateLabel = new Label();
            startDateLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            totalTestsPerformedPanel = new Panel();
            totalTestsPerformedValueLabel = new Label();
            totalTestsPerformedLabel = new Label();
            totalAbnormalResultsPanel = new Panel();
            totalAbnormalResultsValueLabel = new Label();
            totalAbnormalResultsLabel = new Label();
            totalNormalResultsPanel = new Panel();
            totalNormalResultsValueLabel = new Label();
            totalNormalResultsLabel = new Label();
            testStatsPanel = new Panel();
            testStatsLabel = new Label();
            testStatsListView = new ListView();
            panel1.SuspendLayout();
            dateFilterPanel.SuspendLayout();
            totalTestsPerformedPanel.SuspendLayout();
            totalAbnormalResultsPanel.SuspendLayout();
            totalNormalResultsPanel.SuspendLayout();
            testStatsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(dashboardTitle);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 50);
            panel1.TabIndex = 13;
            // 
            // dashboardTitle
            // 
            dashboardTitle.AutoSize = true;
            dashboardTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.ForeColor = Color.White;
            dashboardTitle.Location = new Point(9, 14);
            dashboardTitle.Margin = new Padding(2, 0, 2, 0);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(261, 23);
            dashboardTitle.TabIndex = 0;
            dashboardTitle.Text = "Healthcare Management System";
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(10, 55);
            backButton.Name = "backButton";
            backButton.Size = new Size(113, 41);
            backButton.TabIndex = 14;
            backButton.Text = "🡠 Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // adminStatsHeaderLabel
            // 
            adminStatsHeaderLabel.AutoSize = true;
            adminStatsHeaderLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminStatsHeaderLabel.Location = new Point(130, 52);
            adminStatsHeaderLabel.Name = "adminStatsHeaderLabel";
            adminStatsHeaderLabel.Size = new Size(327, 54);
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
            dateFilterPanel.Location = new Point(10, 123);
            dateFilterPanel.Margin = new Padding(2);
            dateFilterPanel.Name = "dateFilterPanel";
            dateFilterPanel.Size = new Size(690, 163);
            dateFilterPanel.TabIndex = 16;
            // 
            // generateStatsButton
            // 
            generateStatsButton.BackColor = Color.DarkBlue;
            generateStatsButton.FlatStyle = FlatStyle.Flat;
            generateStatsButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateStatsButton.ForeColor = Color.White;
            generateStatsButton.Location = new Point(27, 105);
            generateStatsButton.Margin = new Padding(2);
            generateStatsButton.Name = "generateStatsButton";
            generateStatsButton.Size = new Size(637, 40);
            generateStatsButton.TabIndex = 4;
            generateStatsButton.Text = "Generate Statistics";
            generateStatsButton.UseVisualStyleBackColor = false;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateTimePicker.Format = DateTimePickerFormat.Short;
            endDateTimePicker.Location = new Point(371, 42);
            endDateTimePicker.Margin = new Padding(2);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(218, 34);
            endDateTimePicker.TabIndex = 3;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            endDateLabel.Location = new Point(371, 17);
            endDateLabel.Margin = new Padding(2, 0, 2, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(88, 23);
            endDateLabel.TabIndex = 2;
            endDateLabel.Text = "End Date:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            startDateLabel.Location = new Point(27, 17);
            startDateLabel.Margin = new Padding(2, 0, 2, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(98, 23);
            startDateLabel.TabIndex = 1;
            startDateLabel.Text = "Start Date:";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateTimePicker.Format = DateTimePickerFormat.Short;
            startDateTimePicker.Location = new Point(27, 42);
            startDateTimePicker.Margin = new Padding(2);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(218, 34);
            startDateTimePicker.TabIndex = 0;
            // 
            // totalTestsPerformedPanel
            // 
            totalTestsPerformedPanel.BackColor = Color.LightSteelBlue;
            totalTestsPerformedPanel.BorderStyle = BorderStyle.FixedSingle;
            totalTestsPerformedPanel.Controls.Add(totalTestsPerformedValueLabel);
            totalTestsPerformedPanel.Controls.Add(totalTestsPerformedLabel);
            totalTestsPerformedPanel.Location = new Point(237, 305);
            totalTestsPerformedPanel.Margin = new Padding(2);
            totalTestsPerformedPanel.Name = "totalTestsPerformedPanel";
            totalTestsPerformedPanel.Size = new Size(232, 120);
            totalTestsPerformedPanel.TabIndex = 17;
            // 
            // totalTestsPerformedValueLabel
            // 
            totalTestsPerformedValueLabel.AutoSize = true;
            totalTestsPerformedValueLabel.BackColor = Color.Transparent;
            totalTestsPerformedValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTestsPerformedValueLabel.ForeColor = Color.DarkBlue;
            totalTestsPerformedValueLabel.Location = new Point(13, 52);
            totalTestsPerformedValueLabel.Margin = new Padding(2, 0, 2, 0);
            totalTestsPerformedValueLabel.Name = "totalTestsPerformedValueLabel";
            totalTestsPerformedValueLabel.Size = new Size(43, 50);
            totalTestsPerformedValueLabel.TabIndex = 1;
            totalTestsPerformedValueLabel.Text = "0";
            // 
            // totalTestsPerformedLabel
            // 
            totalTestsPerformedLabel.AutoSize = true;
            totalTestsPerformedLabel.BackColor = Color.Transparent;
            totalTestsPerformedLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTestsPerformedLabel.Location = new Point(2, 8);
            totalTestsPerformedLabel.Margin = new Padding(2, 0, 2, 0);
            totalTestsPerformedLabel.Name = "totalTestsPerformedLabel";
            totalTestsPerformedLabel.Size = new Size(194, 25);
            totalTestsPerformedLabel.TabIndex = 0;
            totalTestsPerformedLabel.Text = "Total Tests Performed";
            // 
            // totalAbnormalResultsPanel
            // 
            totalAbnormalResultsPanel.BackColor = Color.Wheat;
            totalAbnormalResultsPanel.BorderStyle = BorderStyle.FixedSingle;
            totalAbnormalResultsPanel.Controls.Add(totalAbnormalResultsValueLabel);
            totalAbnormalResultsPanel.Controls.Add(totalAbnormalResultsLabel);
            totalAbnormalResultsPanel.Location = new Point(10, 305);
            totalAbnormalResultsPanel.Margin = new Padding(2);
            totalAbnormalResultsPanel.Name = "totalAbnormalResultsPanel";
            totalAbnormalResultsPanel.Size = new Size(223, 120);
            totalAbnormalResultsPanel.TabIndex = 18;
            // 
            // totalAbnormalResultsValueLabel
            // 
            totalAbnormalResultsValueLabel.AutoSize = true;
            totalAbnormalResultsValueLabel.BackColor = Color.Transparent;
            totalAbnormalResultsValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAbnormalResultsValueLabel.ForeColor = Color.DarkBlue;
            totalAbnormalResultsValueLabel.Location = new Point(16, 52);
            totalAbnormalResultsValueLabel.Margin = new Padding(2, 0, 2, 0);
            totalAbnormalResultsValueLabel.Name = "totalAbnormalResultsValueLabel";
            totalAbnormalResultsValueLabel.Size = new Size(43, 50);
            totalAbnormalResultsValueLabel.TabIndex = 3;
            totalAbnormalResultsValueLabel.Text = "0";
            // 
            // totalAbnormalResultsLabel
            // 
            totalAbnormalResultsLabel.AutoSize = true;
            totalAbnormalResultsLabel.BackColor = Color.Transparent;
            totalAbnormalResultsLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAbnormalResultsLabel.Location = new Point(2, 8);
            totalAbnormalResultsLabel.Margin = new Padding(2, 0, 2, 0);
            totalAbnormalResultsLabel.Name = "totalAbnormalResultsLabel";
            totalAbnormalResultsLabel.Size = new Size(208, 25);
            totalAbnormalResultsLabel.TabIndex = 2;
            totalAbnormalResultsLabel.Text = "Total Abnormal Results";
            // 
            // totalNormalResultsPanel
            // 
            totalNormalResultsPanel.BackColor = Color.FromArgb(217, 231, 193);
            totalNormalResultsPanel.BorderStyle = BorderStyle.FixedSingle;
            totalNormalResultsPanel.Controls.Add(totalNormalResultsValueLabel);
            totalNormalResultsPanel.Controls.Add(totalNormalResultsLabel);
            totalNormalResultsPanel.Location = new Point(473, 305);
            totalNormalResultsPanel.Margin = new Padding(2);
            totalNormalResultsPanel.Name = "totalNormalResultsPanel";
            totalNormalResultsPanel.Size = new Size(227, 120);
            totalNormalResultsPanel.TabIndex = 19;
            // 
            // totalNormalResultsValueLabel
            // 
            totalNormalResultsValueLabel.AutoSize = true;
            totalNormalResultsValueLabel.BackColor = Color.Transparent;
            totalNormalResultsValueLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalNormalResultsValueLabel.ForeColor = Color.DarkBlue;
            totalNormalResultsValueLabel.Location = new Point(13, 59);
            totalNormalResultsValueLabel.Margin = new Padding(2, 0, 2, 0);
            totalNormalResultsValueLabel.Name = "totalNormalResultsValueLabel";
            totalNormalResultsValueLabel.Size = new Size(43, 50);
            totalNormalResultsValueLabel.TabIndex = 5;
            totalNormalResultsValueLabel.Text = "0";
            // 
            // totalNormalResultsLabel
            // 
            totalNormalResultsLabel.AutoSize = true;
            totalNormalResultsLabel.BackColor = Color.Transparent;
            totalNormalResultsLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalNormalResultsLabel.Location = new Point(2, 8);
            totalNormalResultsLabel.Margin = new Padding(2, 0, 2, 0);
            totalNormalResultsLabel.Name = "totalNormalResultsLabel";
            totalNormalResultsLabel.Size = new Size(188, 25);
            totalNormalResultsLabel.TabIndex = 4;
            totalNormalResultsLabel.Text = "Total Normal Results";
            // 
            // testStatsPanel
            // 
            testStatsPanel.BackColor = Color.FromArgb(255, 192, 192);
            testStatsPanel.Controls.Add(testStatsListView);
            testStatsPanel.Controls.Add(testStatsLabel);
            testStatsPanel.Location = new Point(10, 439);
            testStatsPanel.Name = "testStatsPanel";
            testStatsPanel.Size = new Size(690, 168);
            testStatsPanel.TabIndex = 21;
            // 
            // testStatsLabel
            // 
            testStatsLabel.AutoSize = true;
            testStatsLabel.BackColor = Color.Transparent;
            testStatsLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testStatsLabel.Location = new Point(2, 3);
            testStatsLabel.Margin = new Padding(2, 0, 2, 0);
            testStatsLabel.Name = "testStatsLabel";
            testStatsLabel.Size = new Size(125, 25);
            testStatsLabel.TabIndex = 22;
            testStatsLabel.Text = "Test Statistics";
            // 
            // testStatsListView
            // 
            testStatsListView.Location = new Point(3, 31);
            testStatsListView.Name = "testStatsListView";
            testStatsListView.Size = new Size(684, 131);
            testStatsListView.TabIndex = 23;
            testStatsListView.UseCompatibleStateImageBehavior = false;
            // 
            // AdminStatisticsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(713, 673);
            Controls.Add(testStatsPanel);
            Controls.Add(totalNormalResultsPanel);
            Controls.Add(totalAbnormalResultsPanel);
            Controls.Add(totalTestsPerformedPanel);
            Controls.Add(dateFilterPanel);
            Controls.Add(adminStatsHeaderLabel);
            Controls.Add(backButton);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "AdminStatisticsPage";
            Text = "AdminStatisticsPage";
            Load += AdminStatisticsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            dateFilterPanel.ResumeLayout(false);
            dateFilterPanel.PerformLayout();
            totalTestsPerformedPanel.ResumeLayout(false);
            totalTestsPerformedPanel.PerformLayout();
            totalAbnormalResultsPanel.ResumeLayout(false);
            totalAbnormalResultsPanel.PerformLayout();
            totalNormalResultsPanel.ResumeLayout(false);
            totalNormalResultsPanel.PerformLayout();
            testStatsPanel.ResumeLayout(false);
            testStatsPanel.PerformLayout();
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
        private Panel totalTestsPerformedPanel;
        private Panel totalAbnormalResultsPanel;
        private Panel totalNormalResultsPanel;
        private Label totalTestsPerformedValueLabel;
        private Label totalTestsPerformedLabel;
        private Label totalAbnormalResultsValueLabel;
        private Label totalAbnormalResultsLabel;
        private Label totalNormalResultsValueLabel;
        private Label totalNormalResultsLabel;
        private Panel testStatsPanel;
        private Label testStatsLabel;
        private ListView testStatsListView;
    }
}