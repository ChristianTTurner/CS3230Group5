namespace CS3230_Group5.View.Appointments_View
{
    partial class OrderTestsPage
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
            availableLabel = new Label();
            availableList = new ListView();
            addButton = new Button();
            removeButton = new Button();
            pendingLabel = new Label();
            pendingList = new ListView();
            orderedLabel = new Label();
            orderedList = new ListView();
            errorLabel = new Label();
            orderButton = new Button();
            removeOrderedButton = new Button();
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
            titleLabel.Text = "Order Tests";
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
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            availableLabel.Location = new Point(20, 165);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new Size(139, 28);
            availableLabel.TabIndex = 4;
            availableLabel.Text = "Available Tests:";
            // 
            // availableList
            // 
            availableList.FullRowSelect = true;
            availableList.GridLines = true;
            availableList.HideSelection = false;
            availableList.Location = new Point(20, 196);
            availableList.Name = "availableList";
            availableList.Size = new Size(360, 220);
            availableList.TabIndex = 5;
            availableList.UseCompatibleStateImageBehavior = false;
            availableList.View = System.Windows.Forms.View.Details;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.Location = new Point(388, 250);
            addButton.Name = "addButton";
            addButton.Size = new Size(104, 44);
            addButton.TabIndex = 6;
            addButton.Text = "Add >";
            addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeButton.Location = new Point(388, 305);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(104, 44);
            removeButton.TabIndex = 7;
            removeButton.Text = "< Remove";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // pendingLabel
            // 
            pendingLabel.AutoSize = true;
            pendingLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingLabel.Location = new Point(500, 165);
            pendingLabel.Name = "pendingLabel";
            pendingLabel.Size = new Size(133, 28);
            pendingLabel.TabIndex = 8;
            pendingLabel.Text = "Tests To Order:";
            // 
            // pendingList
            // 
            pendingList.FullRowSelect = true;
            pendingList.GridLines = true;
            pendingList.HideSelection = false;
            pendingList.Location = new Point(500, 196);
            pendingList.Name = "pendingList";
            pendingList.Size = new Size(380, 220);
            pendingList.TabIndex = 9;
            pendingList.UseCompatibleStateImageBehavior = false;
            pendingList.View = System.Windows.Forms.View.Details;
            // 
            // orderedLabel
            // 
            orderedLabel.AutoSize = true;
            orderedLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderedLabel.Location = new Point(20, 430);
            orderedLabel.Name = "orderedLabel";
            orderedLabel.Size = new Size(274, 28);
            orderedLabel.TabIndex = 10;
            orderedLabel.Text = "Already Ordered For This Visit:";
            // 
            // orderedList
            // 
            orderedList.FullRowSelect = true;
            orderedList.GridLines = true;
            orderedList.HideSelection = false;
            orderedList.Location = new Point(20, 461);
            orderedList.MultiSelect = false;
            orderedList.Name = "orderedList";
            orderedList.Size = new Size(860, 130);
            orderedList.TabIndex = 11;
            orderedList.UseCompatibleStateImageBehavior = false;
            orderedList.View = System.Windows.Forms.View.Details;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(20, 598);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(45, 21);
            errorLabel.TabIndex = 12;
            errorLabel.Text = "error";
            errorLabel.Visible = false;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.ForestGreen;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderButton.ForeColor = Color.White;
            orderButton.Location = new Point(560, 632);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(200, 47);
            orderButton.TabIndex = 13;
            orderButton.Text = "Order Tests";
            orderButton.UseVisualStyleBackColor = false;
            // 
            // removeOrderedButton
            // 
            removeOrderedButton.BackColor = Color.White;
            removeOrderedButton.FlatStyle = FlatStyle.Flat;
            removeOrderedButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeOrderedButton.ForeColor = Color.Firebrick;
            removeOrderedButton.Location = new Point(20, 632);
            removeOrderedButton.Name = "removeOrderedButton";
            removeOrderedButton.Size = new Size(240, 47);
            removeOrderedButton.TabIndex = 15;
            removeOrderedButton.Text = "Remove Ordered Test";
            removeOrderedButton.UseVisualStyleBackColor = false;
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
            closeButton.TabIndex = 14;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // OrderTestsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(removeOrderedButton);
            Controls.Add(closeButton);
            Controls.Add(orderButton);
            Controls.Add(errorLabel);
            Controls.Add(orderedList);
            Controls.Add(orderedLabel);
            Controls.Add(pendingList);
            Controls.Add(pendingLabel);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(availableList);
            Controls.Add(availableLabel);
            Controls.Add(noticeLabel);
            Controls.Add(visitInfoLabel);
            Controls.Add(patientInfoLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderTestsPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Tests";
            Load += OrderTestsPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label patientInfoLabel;
        private Label visitInfoLabel;
        private Label noticeLabel;
        private Label availableLabel;
        private ListView availableList;
        private Button addButton;
        private Button removeButton;
        private Label pendingLabel;
        private ListView pendingList;
        private Label orderedLabel;
        private ListView orderedList;
        private Label errorLabel;
        private Button orderButton;
        private Button removeOrderedButton;
        private Button closeButton;
    }
}
