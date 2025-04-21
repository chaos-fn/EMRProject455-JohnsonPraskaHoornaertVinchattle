namespace Project_JohnsonPraska.Screens.ReportBill
{
    partial class FormExportOptions
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
            lblLeftMain = new Label();
            label1 = new Label();
            comboBoxFileType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            exportButton = new Button();
            cancelButton = new Button();
            checkBoxDate = new CheckBox();
            checkBoxClaimID = new CheckBox();
            checkBoxAmount = new CheckBox();
            checkBoxStatus = new CheckBox();
            SuspendLayout();
            // 
            // lblLeftMain
            // 
            lblLeftMain.BackColor = Color.FromArgb(30, 76, 99);
            lblLeftMain.Dock = DockStyle.Top;
            lblLeftMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblLeftMain.ForeColor = Color.White;
            lblLeftMain.Location = new Point(0, 0);
            lblLeftMain.Margin = new Padding(4, 0, 4, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(386, 58);
            lblLeftMain.TabIndex = 81;
            lblLeftMain.Text = "Form Export Options";
            lblLeftMain.TextAlign = ContentAlignment.MiddleCenter;
            lblLeftMain.Click += lblLeftMain_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 76, 99);
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 392);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 58);
            label1.TabIndex = 82;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFileType
            // 
            comboBoxFileType.FormattingEnabled = true;
            comboBoxFileType.Items.AddRange(new object[] { "PDF", "CSV" });
            comboBoxFileType.Location = new Point(178, 108);
            comboBoxFileType.Name = "comboBoxFileType";
            comboBoxFileType.Size = new Size(121, 23);
            comboBoxFileType.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(47, 101);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 84;
            label2.Text = "File Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(22, 166);
            label3.Name = "label3";
            label3.Size = new Size(150, 30);
            label3.TabIndex = 86;
            label3.Text = "Included Data";
            // 
            // exportButton
            // 
            exportButton.Location = new Point(56, 309);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(104, 37);
            exportButton.TabIndex = 87;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(238, 309);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(104, 37);
            cancelButton.TabIndex = 88;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AutoSize = true;
            checkBoxDate.BackColor = Color.White;
            checkBoxDate.Location = new Point(189, 177);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(50, 19);
            checkBoxDate.TabIndex = 89;
            checkBoxDate.Text = "Date";
            checkBoxDate.UseVisualStyleBackColor = false;
            // 
            // checkBoxClaimID
            // 
            checkBoxClaimID.AutoSize = true;
            checkBoxClaimID.BackColor = Color.White;
            checkBoxClaimID.Location = new Point(189, 202);
            checkBoxClaimID.Name = "checkBoxClaimID";
            checkBoxClaimID.Size = new Size(68, 19);
            checkBoxClaimID.TabIndex = 90;
            checkBoxClaimID.Text = "ClaimID";
            checkBoxClaimID.UseVisualStyleBackColor = false;
            // 
            // checkBoxAmount
            // 
            checkBoxAmount.AutoSize = true;
            checkBoxAmount.BackColor = Color.White;
            checkBoxAmount.Location = new Point(245, 177);
            checkBoxAmount.Name = "checkBoxAmount";
            checkBoxAmount.Size = new Size(70, 19);
            checkBoxAmount.TabIndex = 91;
            checkBoxAmount.Text = "Amount";
            checkBoxAmount.UseVisualStyleBackColor = false;
            // 
            // checkBoxStatus
            // 
            checkBoxStatus.AutoSize = true;
            checkBoxStatus.BackColor = Color.White;
            checkBoxStatus.Location = new Point(263, 202);
            checkBoxStatus.Name = "checkBoxStatus";
            checkBoxStatus.Size = new Size(58, 19);
            checkBoxStatus.TabIndex = 92;
            checkBoxStatus.Text = "Status";
            checkBoxStatus.UseVisualStyleBackColor = false;
            // 
            // FormExportOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(386, 450);
            Controls.Add(checkBoxStatus);
            Controls.Add(checkBoxAmount);
            Controls.Add(checkBoxClaimID);
            Controls.Add(checkBoxDate);
            Controls.Add(cancelButton);
            Controls.Add(exportButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxFileType);
            Controls.Add(label1);
            Controls.Add(lblLeftMain);
            Name = "FormExportOptions";
            Text = "FormExportOptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeftMain;
        private Label label1;
        private ComboBox comboBoxFileType;
        private Label label2;
        private Label label3;
        private Button exportButton;
        private Button cancelButton;
        private CheckBox checkBoxDate;
        private CheckBox checkBoxClaimID;
        private CheckBox checkBoxAmount;
        private CheckBox checkBoxStatus;
    }
}