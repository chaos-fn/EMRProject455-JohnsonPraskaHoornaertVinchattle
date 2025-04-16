namespace Project_JohnsonPraska
{
    partial class More
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
            lblMore = new Label();
            lblPR = new Label();
            lblHome = new Label();
            lblLeftMain = new Label();
            lblPatientProfile = new Label();
            lblAppoint = new Label();
            lblPrescriptions = new Label();
            lblReportBill = new Label();
            lblSearch = new Label();
            SuspendLayout();
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Enabled = false;
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1420, 861);
            lblMore.Margin = new Padding(4, 0, 4, 0);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(500, 150);
            lblMore.TabIndex = 39;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPR
            // 
            lblPR.BackColor = Color.FromArgb(30, 76, 99);
            lblPR.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPR.ForeColor = Color.White;
            lblPR.Location = new Point(500, 861);
            lblPR.Margin = new Padding(4, 0, 4, 0);
            lblPR.Name = "lblPR";
            lblPR.Size = new Size(920, 150);
            lblPR.TabIndex = 38;
            lblPR.Text = "Patient Registration";
            lblPR.TextAlign = ContentAlignment.MiddleCenter;
            lblPR.Click += lblMap_Click;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 861);
            lblHome.Margin = new Padding(4, 0, 4, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(500, 150);
            lblHome.TabIndex = 37;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
            // 
            // lblLeftMain
            // 
            lblLeftMain.BackColor = Color.FromArgb(30, 76, 99);
            lblLeftMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblLeftMain.ForeColor = Color.White;
            lblLeftMain.Location = new Point(0, 0);
            lblLeftMain.Margin = new Padding(4, 0, 4, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(2496, 96);
            lblLeftMain.TabIndex = 36;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPatientProfile
            // 
            lblPatientProfile.BorderStyle = BorderStyle.Fixed3D;
            lblPatientProfile.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline);
            lblPatientProfile.ForeColor = Color.White;
            lblPatientProfile.Location = new Point(0, 96);
            lblPatientProfile.Margin = new Padding(4, 0, 4, 0);
            lblPatientProfile.Name = "lblPatientProfile";
            lblPatientProfile.Size = new Size(307, 146);
            lblPatientProfile.TabIndex = 41;
            lblPatientProfile.Text = "Patient Profile";
            lblPatientProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppoint
            // 
            lblAppoint.BorderStyle = BorderStyle.Fixed3D;
            lblAppoint.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblAppoint.ForeColor = Color.White;
            lblAppoint.Location = new Point(1, 242);
            lblAppoint.Margin = new Padding(4, 0, 4, 0);
            lblAppoint.Name = "lblAppoint";
            lblAppoint.Size = new Size(306, 146);
            lblAppoint.TabIndex = 42;
            lblAppoint.Text = "Appointments";
            lblAppoint.TextAlign = ContentAlignment.MiddleCenter;
            lblAppoint.Click += lblVehicles_Click;
            // 
            // lblPrescriptions
            // 
            lblPrescriptions.BorderStyle = BorderStyle.Fixed3D;
            lblPrescriptions.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPrescriptions.ForeColor = Color.White;
            lblPrescriptions.Location = new Point(1, 388);
            lblPrescriptions.Margin = new Padding(4, 0, 4, 0);
            lblPrescriptions.Name = "lblPrescriptions";
            lblPrescriptions.Size = new Size(306, 137);
            lblPrescriptions.TabIndex = 43;
            lblPrescriptions.Text = "Prescriptions";
            lblPrescriptions.TextAlign = ContentAlignment.MiddleCenter;
            lblPrescriptions.Click += lblDrivers_Click;
            // 
            // lblReportBill
            // 
            lblReportBill.BorderStyle = BorderStyle.Fixed3D;
            lblReportBill.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblReportBill.ForeColor = Color.White;
            lblReportBill.Location = new Point(1, 522);
            lblReportBill.Margin = new Padding(4, 0, 4, 0);
            lblReportBill.Name = "lblReportBill";
            lblReportBill.Size = new Size(306, 143);
            lblReportBill.TabIndex = 44;
            lblReportBill.Text = "Reports/Billing";
            lblReportBill.TextAlign = ContentAlignment.MiddleCenter;
            lblReportBill.Click += lblActivity_Click;
            // 
            // lblSearch
            // 
            lblSearch.BorderStyle = BorderStyle.Fixed3D;
            lblSearch.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(0, 665);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(307, 129);
            lblSearch.TabIndex = 45;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            lblSearch.Click += lblHelp_Click;
            // 
            // More
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1894, 1009);
            Controls.Add(lblSearch);
            Controls.Add(lblReportBill);
            Controls.Add(lblPrescriptions);
            Controls.Add(lblAppoint);
            Controls.Add(lblPatientProfile);
            Controls.Add(lblMore);
            Controls.Add(lblPR);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "More";
            Text = "Patient Profile";
            ResumeLayout(false);
        }

        #endregion
        private Label lblMore;
        private Label lblPR;
        private Label lblHome;
        private Label lblLeftMain;
        private Label lblPatientProfile;
        private Label lblAppoint;
        private Label lblPrescriptions;
        private Label lblReportBill;
        private Label lblSearch;
    }
}