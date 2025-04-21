namespace Project_JohnsonPraska.Screens.ReportBill
{
    partial class FormClaimDetails
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
            dataGridViewLines = new DataGridView();
            lineNumber = new DataGridViewTextBoxColumn();
            ServiceCode = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLines).BeginInit();
            SuspendLayout();
            // 
            // lblLeftMain
            // 
            lblLeftMain.BackColor = Color.FromArgb(30, 76, 99);
            lblLeftMain.Dock = DockStyle.Top;
            lblLeftMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblLeftMain.ForeColor = Color.White;
            lblLeftMain.Location = new Point(0, 0);
            lblLeftMain.Margin = new Padding(7, 0, 7, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(1894, 124);
            lblLeftMain.TabIndex = 82;
            lblLeftMain.Text = "Claim Details";
            lblLeftMain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 76, 99);
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 885);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(1894, 124);
            label1.TabIndex = 83;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLines
            // 
            dataGridViewLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLines.Columns.AddRange(new DataGridViewColumn[] { lineNumber, ServiceCode, Description, Amount });
            dataGridViewLines.Dock = DockStyle.Fill;
            dataGridViewLines.Location = new Point(0, 124);
            dataGridViewLines.Margin = new Padding(6, 6, 6, 6);
            dataGridViewLines.Name = "dataGridViewLines";
            dataGridViewLines.RowHeadersWidth = 82;
            dataGridViewLines.Size = new Size(1894, 761);
            dataGridViewLines.TabIndex = 84;
            // 
            // lineNumber
            // 
            lineNumber.HeaderText = "Line #";
            lineNumber.MinimumWidth = 10;
            lineNumber.Name = "lineNumber";
            // 
            // ServiceCode
            // 
            ServiceCode.HeaderText = "Service Code";
            ServiceCode.MinimumWidth = 10;
            ServiceCode.Name = "ServiceCode";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 10;
            Amount.Name = "Amount";
            // 
            // FormClaimDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1894, 1009);
            Controls.Add(dataGridViewLines);
            Controls.Add(label1);
            Controls.Add(lblLeftMain);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormClaimDetails";
            Text = "FormClaimDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLeftMain;
        private Label label1;
        private DataGridView dataGridViewLines;
        private DataGridViewTextBoxColumn lineNumber;
        private DataGridViewTextBoxColumn ServiceCode;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
    }
}