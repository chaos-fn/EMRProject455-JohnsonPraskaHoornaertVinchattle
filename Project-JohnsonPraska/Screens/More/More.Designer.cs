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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblMore = new Label();
            lblPR = new Label();
            lblHome = new Label();
            lblLeftMain = new Label();
            lblPatientProfile = new Label();
            lblAppoint = new Label();
            lblPrescriptions = new Label();
            lblReportBill = new Label();
            lblSearch = new Label();
            dataPatient = new DataGridView();
            EmpID = new DataGridViewTextBoxColumn();
            EmpName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            lblFnameL = new Label();
            lblFname = new Label();
            lblLname = new Label();
            lblLnameL = new Label();
            lblDOB = new Label();
            lblDOBL = new Label();
            lblAddress = new Label();
            lblAddressL = new Label();
            lblIDL = new Label();
            lblID = new Label();
            lblRoom = new Label();
            lblRoomL = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataPatient).BeginInit();
            SuspendLayout();
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Enabled = false;
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1016, 791);
            lblMore.Margin = new Padding(2, 0, 2, 0);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(508, 122);
            lblMore.TabIndex = 39;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPR
            // 
            lblPR.BackColor = Color.FromArgb(30, 76, 99);
            lblPR.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPR.ForeColor = Color.White;
            lblPR.Location = new Point(508, 791);
            lblPR.Margin = new Padding(2, 0, 2, 0);
            lblPR.Name = "lblPR";
            lblPR.Size = new Size(508, 122);
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
            lblHome.Location = new Point(0, 791);
            lblHome.Margin = new Padding(2, 0, 2, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(508, 122);
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
            lblLeftMain.Margin = new Padding(2, 0, 2, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(1508, 96);
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
            lblPatientProfile.Margin = new Padding(2, 0, 2, 0);
            lblPatientProfile.Name = "lblPatientProfile";
            lblPatientProfile.Size = new Size(300, 139);
            lblPatientProfile.TabIndex = 41;
            lblPatientProfile.Text = "Patient Profile";
            lblPatientProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppoint
            // 
            lblAppoint.BorderStyle = BorderStyle.Fixed3D;
            lblAppoint.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblAppoint.ForeColor = Color.White;
            lblAppoint.Location = new Point(0, 235);
            lblAppoint.Margin = new Padding(2, 0, 2, 0);
            lblAppoint.Name = "lblAppoint";
            lblAppoint.Size = new Size(300, 139);
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
            lblPrescriptions.Location = new Point(0, 374);
            lblPrescriptions.Margin = new Padding(2, 0, 2, 0);
            lblPrescriptions.Name = "lblPrescriptions";
            lblPrescriptions.Size = new Size(300, 139);
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
            lblReportBill.Location = new Point(0, 513);
            lblReportBill.Margin = new Padding(2, 0, 2, 0);
            lblReportBill.Name = "lblReportBill";
            lblReportBill.Size = new Size(300, 139);
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
            lblSearch.Location = new Point(0, 652);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(300, 139);
            lblSearch.TabIndex = 45;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            lblSearch.Click += lblHelp_Click;
            // 
            // dataPatient
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 76, 99);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPatient.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 76, 99);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPatient.Columns.AddRange(new DataGridViewColumn[] { EmpID, EmpName, Description });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 76, 99);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataPatient.DefaultCellStyle = dataGridViewCellStyle3;
            dataPatient.Location = new Point(711, 225);
            dataPatient.Name = "dataPatient";
            dataPatient.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(30, 76, 99);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(30, 76, 99);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataPatient.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataPatient.ScrollBars = ScrollBars.Vertical;
            dataPatient.Size = new Size(750, 500);
            dataPatient.TabIndex = 131;
            // 
            // EmpID
            // 
            EmpID.FillWeight = 21.2535515F;
            EmpID.HeaderText = "Employee ID";
            EmpID.MinimumWidth = 100;
            EmpID.Name = "EmpID";
            EmpID.ReadOnly = true;
            // 
            // EmpName
            // 
            EmpName.FillWeight = 216.404663F;
            EmpName.HeaderText = "Employee Name";
            EmpName.MinimumWidth = 250;
            EmpName.Name = "EmpName";
            EmpName.ReadOnly = true;
            // 
            // Description
            // 
            Description.FillWeight = 20.8550453F;
            Description.HeaderText = "Description";
            Description.MinimumWidth = 300;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // lblFnameL
            // 
            lblFnameL.BorderStyle = BorderStyle.FixedSingle;
            lblFnameL.Font = new Font("Cambria", 18F, FontStyle.Bold);
            lblFnameL.ForeColor = SystemColors.ControlLightLight;
            lblFnameL.Location = new Point(375, 165);
            lblFnameL.Name = "lblFnameL";
            lblFnameL.Size = new Size(275, 50);
            lblFnameL.TabIndex = 130;
            lblFnameL.Text = "First Name";
            lblFnameL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFname
            // 
            lblFname.BorderStyle = BorderStyle.FixedSingle;
            lblFname.Font = new Font("Cambria", 16F);
            lblFname.ForeColor = SystemColors.ControlLightLight;
            lblFname.Location = new Point(375, 215);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(275, 50);
            lblFname.TabIndex = 132;
            lblFname.Text = "Jane";
            lblFname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLname
            // 
            lblLname.BorderStyle = BorderStyle.FixedSingle;
            lblLname.Font = new Font("Cambria", 16F);
            lblLname.ForeColor = SystemColors.ControlLightLight;
            lblLname.Location = new Point(375, 340);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(275, 50);
            lblLname.TabIndex = 134;
            lblLname.Text = "Doe";
            lblLname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLnameL
            // 
            lblLnameL.BorderStyle = BorderStyle.FixedSingle;
            lblLnameL.Font = new Font("Cambria", 18F, FontStyle.Bold);
            lblLnameL.ForeColor = SystemColors.ControlLightLight;
            lblLnameL.Location = new Point(375, 290);
            lblLnameL.Name = "lblLnameL";
            lblLnameL.Size = new Size(275, 50);
            lblLnameL.TabIndex = 133;
            lblLnameL.Text = "Last Name";
            lblLnameL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDOB
            // 
            lblDOB.BorderStyle = BorderStyle.FixedSingle;
            lblDOB.Font = new Font("Cambria", 16F);
            lblDOB.ForeColor = SystemColors.ControlLightLight;
            lblDOB.Location = new Point(375, 465);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(275, 50);
            lblDOB.TabIndex = 136;
            lblDOB.Text = "1864-06-23";
            lblDOB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDOBL
            // 
            lblDOBL.BorderStyle = BorderStyle.FixedSingle;
            lblDOBL.Font = new Font("Cambria", 18F, FontStyle.Bold);
            lblDOBL.ForeColor = SystemColors.ControlLightLight;
            lblDOBL.Location = new Point(375, 415);
            lblDOBL.Name = "lblDOBL";
            lblDOBL.Size = new Size(275, 50);
            lblDOBL.TabIndex = 135;
            lblDOBL.Text = "Date of Birth";
            lblDOBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.BorderStyle = BorderStyle.FixedSingle;
            lblAddress.Font = new Font("Cambria", 12F);
            lblAddress.ForeColor = SystemColors.ControlLightLight;
            lblAddress.Location = new Point(375, 590);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(275, 50);
            lblAddress.TabIndex = 138;
            lblAddress.Text = "123 Main Street";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddressL
            // 
            lblAddressL.BorderStyle = BorderStyle.FixedSingle;
            lblAddressL.Font = new Font("Cambria", 18F, FontStyle.Bold);
            lblAddressL.ForeColor = SystemColors.ControlLightLight;
            lblAddressL.Location = new Point(375, 540);
            lblAddressL.Name = "lblAddressL";
            lblAddressL.Size = new Size(275, 50);
            lblAddressL.TabIndex = 137;
            lblAddressL.Text = "Address";
            lblAddressL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIDL
            // 
            lblIDL.Font = new Font("Cambria", 14F);
            lblIDL.ForeColor = SystemColors.ControlLightLight;
            lblIDL.Location = new Point(325, 115);
            lblIDL.Name = "lblIDL";
            lblIDL.Size = new Size(100, 30);
            lblIDL.TabIndex = 139;
            lblIDL.Text = "Patient ID:";
            lblIDL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            lblID.Font = new Font("Cambria", 14F);
            lblID.ForeColor = SystemColors.ControlLightLight;
            lblID.Location = new Point(422, 115);
            lblID.Name = "lblID";
            lblID.Size = new Size(100, 30);
            lblID.TabIndex = 140;
            lblID.Text = "2423";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoom
            // 
            lblRoom.BorderStyle = BorderStyle.FixedSingle;
            lblRoom.Font = new Font("Cambria", 16F);
            lblRoom.ForeColor = SystemColors.ControlLightLight;
            lblRoom.Location = new Point(375, 715);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(275, 50);
            lblRoom.TabIndex = 142;
            lblRoom.Text = "404";
            lblRoom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoomL
            // 
            lblRoomL.BorderStyle = BorderStyle.FixedSingle;
            lblRoomL.Font = new Font("Cambria", 18F, FontStyle.Bold);
            lblRoomL.ForeColor = SystemColors.ControlLightLight;
            lblRoomL.Location = new Point(375, 665);
            lblRoomL.Name = "lblRoomL";
            lblRoomL.Size = new Size(275, 50);
            lblRoomL.TabIndex = 141;
            lblRoomL.Text = "Room";
            lblRoomL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria", 22F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(711, 165);
            label3.Name = "label3";
            label3.Size = new Size(750, 50);
            label3.TabIndex = 143;
            label3.Text = "Patient Doctor's Notes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // More
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1508, 913);
            Controls.Add(label3);
            Controls.Add(lblRoom);
            Controls.Add(lblRoomL);
            Controls.Add(lblID);
            Controls.Add(lblIDL);
            Controls.Add(lblAddress);
            Controls.Add(lblAddressL);
            Controls.Add(lblDOB);
            Controls.Add(lblDOBL);
            Controls.Add(lblLname);
            Controls.Add(lblLnameL);
            Controls.Add(lblFname);
            Controls.Add(dataPatient);
            Controls.Add(lblFnameL);
            Controls.Add(lblSearch);
            Controls.Add(lblReportBill);
            Controls.Add(lblPrescriptions);
            Controls.Add(lblAppoint);
            Controls.Add(lblPatientProfile);
            Controls.Add(lblMore);
            Controls.Add(lblPR);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Font = new Font("Cambria", 12F);
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1524, 952);
            Name = "More";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Profile";
            Load += More_Load;
            ((System.ComponentModel.ISupportInitialize)dataPatient).EndInit();
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
        private DataGridView dataPatient;
        private Label lblFnameL;
        private Label lblFname;
        private Label lblLname;
        private Label lblLnameL;
        private Label lblDOB;
        private Label lblDOBL;
        private Label lblAddress;
        private Label lblAddressL;
        private Label lblIDL;
        private Label lblID;
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn Description;
        private Label lblRoom;
        private Label lblRoomL;
        private Label label3;
    }
}