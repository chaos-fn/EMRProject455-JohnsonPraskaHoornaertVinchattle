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
            lblInvoiceID = new Label();
            txtInvoiceId = new TextBox();
            label2 = new Label();
            txtAppointmentId = new TextBox();
            label3 = new Label();
            txtPatientId = new TextBox();
            label4 = new Label();
            txtDate = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            txtStatus = new TextBox();
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
            lblLeftMain.Size = new Size(545, 58);
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
            label1.Location = new Point(0, 494);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(545, 58);
            label1.TabIndex = 83;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceID
            // 
            lblInvoiceID.AutoSize = true;
            lblInvoiceID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceID.ForeColor = SystemColors.ControlLightLight;
            lblInvoiceID.Location = new Point(105, 115);
            lblInvoiceID.Name = "lblInvoiceID";
            lblInvoiceID.Size = new Size(118, 30);
            lblInvoiceID.TabIndex = 84;
            lblInvoiceID.Text = "Invoice ID:";
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Location = new Point(290, 122);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.ReadOnly = true;
            txtInvoiceId.Size = new Size(136, 23);
            txtInvoiceId.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(105, 160);
            label2.Name = "label2";
            label2.Size = new Size(179, 30);
            label2.TabIndex = 86;
            label2.Text = "Appointment ID:";
            // 
            // txtAppointmentId
            // 
            txtAppointmentId.Location = new Point(290, 169);
            txtAppointmentId.Name = "txtAppointmentId";
            txtAppointmentId.ReadOnly = true;
            txtAppointmentId.Size = new Size(136, 23);
            txtAppointmentId.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(105, 211);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 88;
            label3.Text = "Patient ID:";
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new Point(290, 220);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.ReadOnly = true;
            txtPatientId.Size = new Size(136, 23);
            txtPatientId.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(107, 259);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 90;
            label4.Text = "Date:";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(290, 266);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(136, 23);
            txtDate.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(107, 300);
            label5.Name = "label5";
            label5.Size = new Size(131, 30);
            label5.TabIndex = 92;
            label5.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(290, 309);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(136, 23);
            txtDescription.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(107, 345);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 94;
            label6.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(290, 352);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(136, 23);
            txtPrice.TabIndex = 95;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(107, 387);
            label7.Name = "label7";
            label7.Size = new Size(79, 30);
            label7.TabIndex = 96;
            label7.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(290, 396);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(136, 23);
            txtStatus.TabIndex = 97;
            // 
            // FormClaimDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(545, 552);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtDate);
            Controls.Add(label4);
            Controls.Add(txtPatientId);
            Controls.Add(label3);
            Controls.Add(txtAppointmentId);
            Controls.Add(label2);
            Controls.Add(txtInvoiceId);
            Controls.Add(lblInvoiceID);
            Controls.Add(label1);
            Controls.Add(lblLeftMain);
            Name = "FormClaimDetails";
            Text = "FormClaimDetails";
            Load += FormClaimDetails_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeftMain;
        private Label label1;
        private Label lblInvoiceID;
        private TextBox txtInvoiceId;
        private Label label2;
        private TextBox txtAppointmentId;
        private Label label3;
        private TextBox txtPatientId;
        private Label label4;
        private TextBox txtDate;
        private Label label5;
        private TextBox txtDescription;
        private Label label6;
        private TextBox txtPrice;
        private Label label7;
        private TextBox txtStatus;
    }
}