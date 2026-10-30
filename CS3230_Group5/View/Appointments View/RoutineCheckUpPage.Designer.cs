namespace CS3230_Group5.View.Appointments_View
{
    partial class RoutineCheckUpPage
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
            checkUpTitleLabel = new Label();
            systolicLabel = new Label();
            diastolicLabel = new Label();
            pulseLabel = new Label();
            tempLabel = new Label();
            heightLabel = new Label();
            weightLabel = new Label();
            symptomsLabel = new Label();
            systolicTextBox = new TextBox();
            diastolicTextBox = new TextBox();
            pulseTextBox = new TextBox();
            tempTextBox = new TextBox();
            heightTextBox = new TextBox();
            weightTextBox = new TextBox();
            symptomsTextBox = new TextBox();
            saveButton = new Button();
            CancelButton = new Button();
            systolicErrorLabel = new Label();
            diastolicErrorLabel = new Label();
            pulseErrorLabel = new Label();
            tempErrorLabel = new Label();
            heightErrorLabel = new Label();
            weightErrorLabel = new Label();
            symptomsErrorLabel = new Label();
            SuspendLayout();
            // 
            // checkUpTitleLabel
            // 
            checkUpTitleLabel.BackColor = Color.Navy;
            checkUpTitleLabel.FlatStyle = FlatStyle.Flat;
            checkUpTitleLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkUpTitleLabel.ForeColor = Color.White;
            checkUpTitleLabel.Location = new Point(4, 2);
            checkUpTitleLabel.Name = "checkUpTitleLabel";
            checkUpTitleLabel.Size = new Size(591, 53);
            checkUpTitleLabel.TabIndex = 0;
            checkUpTitleLabel.Text = "Enter/ Update Routine Check-Up";
            checkUpTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // systolicLabel
            // 
            systolicLabel.AutoSize = true;
            systolicLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            systolicLabel.Location = new Point(17, 72);
            systolicLabel.Name = "systolicLabel";
            systolicLabel.Size = new Size(198, 28);
            systolicLabel.TabIndex = 1;
            systolicLabel.Text = "Systolic BP (mmHg):";
            // 
            // diastolicLabel
            // 
            diastolicLabel.AutoSize = true;
            diastolicLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diastolicLabel.Location = new Point(17, 132);
            diastolicLabel.Name = "diastolicLabel";
            diastolicLabel.Size = new Size(206, 28);
            diastolicLabel.TabIndex = 2;
            diastolicLabel.Text = "Diastolic BP (mmHg):";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pulseLabel.Location = new Point(17, 191);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(128, 28);
            pulseLabel.TabIndex = 3;
            pulseLabel.Text = "Pulse (bpm):";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tempLabel.Location = new Point(17, 246);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(170, 28);
            tempLabel.TabIndex = 4;
            tempLabel.Text = "Temperature (°F):";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heightLabel.Location = new Point(17, 303);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(116, 28);
            heightLabel.TabIndex = 5;
            heightLabel.Text = "Height (in):";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            weightLabel.Location = new Point(17, 359);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(119, 28);
            weightLabel.TabIndex = 6;
            weightLabel.Text = "Weight (lb):";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            symptomsLabel.Location = new Point(17, 418);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(114, 28);
            symptomsLabel.TabIndex = 7;
            symptomsLabel.Text = "Symptoms:";
            // 
            // systolicTextBox
            // 
            systolicTextBox.BackColor = Color.White;
            systolicTextBox.BorderStyle = BorderStyle.FixedSingle;
            systolicTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systolicTextBox.Location = new Point(248, 72);
            systolicTextBox.Name = "systolicTextBox";
            systolicTextBox.Size = new Size(322, 34);
            systolicTextBox.TabIndex = 8;
            // 
            // diastolicTextBox
            // 
            diastolicTextBox.BackColor = Color.White;
            diastolicTextBox.BorderStyle = BorderStyle.FixedSingle;
            diastolicTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diastolicTextBox.Location = new Point(248, 133);
            diastolicTextBox.Name = "diastolicTextBox";
            diastolicTextBox.Size = new Size(322, 34);
            diastolicTextBox.TabIndex = 9;
            // 
            // pulseTextBox
            // 
            pulseTextBox.BackColor = Color.White;
            pulseTextBox.BorderStyle = BorderStyle.FixedSingle;
            pulseTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseTextBox.Location = new Point(248, 191);
            pulseTextBox.Name = "pulseTextBox";
            pulseTextBox.Size = new Size(322, 34);
            pulseTextBox.TabIndex = 10;
            // 
            // tempTextBox
            // 
            tempTextBox.BackColor = Color.White;
            tempTextBox.BorderStyle = BorderStyle.FixedSingle;
            tempTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempTextBox.Location = new Point(248, 246);
            tempTextBox.Name = "tempTextBox";
            tempTextBox.Size = new Size(322, 34);
            tempTextBox.TabIndex = 11;
            // 
            // heightTextBox
            // 
            heightTextBox.BackColor = Color.White;
            heightTextBox.BorderStyle = BorderStyle.FixedSingle;
            heightTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightTextBox.Location = new Point(248, 303);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(322, 34);
            heightTextBox.TabIndex = 12;
            // 
            // weightTextBox
            // 
            weightTextBox.BackColor = Color.White;
            weightTextBox.BorderStyle = BorderStyle.FixedSingle;
            weightTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightTextBox.Location = new Point(248, 357);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(322, 34);
            weightTextBox.TabIndex = 13;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.BackColor = Color.White;
            symptomsTextBox.BorderStyle = BorderStyle.FixedSingle;
            symptomsTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsTextBox.Location = new Point(248, 418);
            symptomsTextBox.Multiline = true;
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.ScrollBars = ScrollBars.Vertical;
            symptomsTextBox.Size = new Size(322, 137);
            symptomsTextBox.TabIndex = 14;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(312, 597);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 47);
            saveButton.TabIndex = 15;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.White;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(458, 597);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 47);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // systolicErrorLabel
            // 
            systolicErrorLabel.AutoSize = true;
            systolicErrorLabel.BackColor = Color.Transparent;
            systolicErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systolicErrorLabel.ForeColor = Color.Red;
            systolicErrorLabel.Location = new Point(250, 108);
            systolicErrorLabel.Name = "systolicErrorLabel";
            systolicErrorLabel.Size = new Size(45, 21);
            systolicErrorLabel.TabIndex = 17;
            systolicErrorLabel.Text = "error";
            systolicErrorLabel.Visible = false;
            systolicErrorLabel.Click += systolicErrorLabel_Click;
            // 
            // diastolicErrorLabel
            // 
            diastolicErrorLabel.AutoSize = true;
            diastolicErrorLabel.BackColor = Color.Transparent;
            diastolicErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diastolicErrorLabel.ForeColor = Color.Red;
            diastolicErrorLabel.Location = new Point(250, 170);
            diastolicErrorLabel.Name = "diastolicErrorLabel";
            diastolicErrorLabel.Size = new Size(45, 21);
            diastolicErrorLabel.TabIndex = 18;
            diastolicErrorLabel.Text = "error";
            diastolicErrorLabel.Visible = false;
            // 
            // pulseErrorLabel
            // 
            pulseErrorLabel.AutoSize = true;
            pulseErrorLabel.BackColor = Color.Transparent;
            pulseErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pulseErrorLabel.ForeColor = Color.Red;
            pulseErrorLabel.Location = new Point(250, 228);
            pulseErrorLabel.Name = "pulseErrorLabel";
            pulseErrorLabel.Size = new Size(45, 21);
            pulseErrorLabel.TabIndex = 19;
            pulseErrorLabel.Text = "error";
            pulseErrorLabel.Visible = false;
            // 
            // tempErrorLabel
            // 
            tempErrorLabel.AutoSize = true;
            tempErrorLabel.BackColor = Color.Transparent;
            tempErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempErrorLabel.ForeColor = Color.Red;
            tempErrorLabel.Location = new Point(250, 279);
            tempErrorLabel.Name = "tempErrorLabel";
            tempErrorLabel.Size = new Size(45, 21);
            tempErrorLabel.TabIndex = 20;
            tempErrorLabel.Text = "error";
            tempErrorLabel.Visible = false;
            // 
            // heightErrorLabel
            // 
            heightErrorLabel.AutoSize = true;
            heightErrorLabel.BackColor = Color.Transparent;
            heightErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightErrorLabel.ForeColor = Color.Red;
            heightErrorLabel.Location = new Point(250, 333);
            heightErrorLabel.Name = "heightErrorLabel";
            heightErrorLabel.Size = new Size(45, 21);
            heightErrorLabel.TabIndex = 21;
            heightErrorLabel.Text = "error";
            heightErrorLabel.Visible = false;
            // 
            // weightErrorLabel
            // 
            weightErrorLabel.AutoSize = true;
            weightErrorLabel.BackColor = Color.Transparent;
            weightErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightErrorLabel.ForeColor = Color.Red;
            weightErrorLabel.Location = new Point(250, 394);
            weightErrorLabel.Name = "weightErrorLabel";
            weightErrorLabel.Size = new Size(45, 21);
            weightErrorLabel.TabIndex = 22;
            weightErrorLabel.Text = "error";
            weightErrorLabel.Visible = false;
            // 
            // symptomsErrorLabel
            // 
            symptomsErrorLabel.AutoSize = true;
            symptomsErrorLabel.BackColor = Color.Transparent;
            symptomsErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsErrorLabel.ForeColor = Color.Red;
            symptomsErrorLabel.Location = new Point(250, 558);
            symptomsErrorLabel.Name = "symptomsErrorLabel";
            symptomsErrorLabel.Size = new Size(45, 21);
            symptomsErrorLabel.TabIndex = 23;
            symptomsErrorLabel.Text = "error";
            symptomsErrorLabel.Visible = false;
            // 
            // RoutineCheckUpPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 658);
            Controls.Add(symptomsErrorLabel);
            Controls.Add(weightErrorLabel);
            Controls.Add(heightErrorLabel);
            Controls.Add(tempErrorLabel);
            Controls.Add(pulseErrorLabel);
            Controls.Add(diastolicErrorLabel);
            Controls.Add(systolicErrorLabel);
            Controls.Add(CancelButton);
            Controls.Add(saveButton);
            Controls.Add(symptomsTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(tempTextBox);
            Controls.Add(pulseTextBox);
            Controls.Add(diastolicTextBox);
            Controls.Add(systolicTextBox);
            Controls.Add(symptomsLabel);
            Controls.Add(weightLabel);
            Controls.Add(heightLabel);
            Controls.Add(tempLabel);
            Controls.Add(pulseLabel);
            Controls.Add(diastolicLabel);
            Controls.Add(systolicLabel);
            Controls.Add(checkUpTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoutineCheckUpPage";
            Text = "Enter Routine Check-Up";
            Load += RoutineCheckUpPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label checkUpTitleLabel;
        private Label systolicLabel;
        private Label diastolicLabel;
        private Label pulseLabel;
        private Label tempLabel;
        private Label heightLabel;
        private Label weightLabel;
        private Label symptomsLabel;
        private TextBox systolicTextBox;
        private TextBox diastolicTextBox;
        private TextBox pulseTextBox;
        private TextBox tempTextBox;
        private TextBox heightTextBox;
        private TextBox weightTextBox;
        private TextBox symptomsTextBox;
        private Button saveButton;
        private new Button CancelButton;
        private Label systolicErrorLabel;
        private Label diastolicErrorLabel;
        private Label pulseErrorLabel;
        private Label tempErrorLabel;
        private Label heightErrorLabel;
        private Label weightErrorLabel;
        private Label symptomsErrorLabel;
    }
}