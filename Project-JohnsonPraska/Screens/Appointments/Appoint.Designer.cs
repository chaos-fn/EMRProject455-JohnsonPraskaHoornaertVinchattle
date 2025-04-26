namespace Project_JohnsonPraska
{
    partial class Appoint
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
            lblSearch = new Label();
            lblReportBill = new Label();
            lblPrescriptions = new Label();
            lblAppoint = new Label();
            lblPatientProfile = new Label();
            lblMore = new Label();
            lblPG = new Label();
            lblHome = new Label();
            lblLeftMain = new Label();
            monthCalendar1 = new MonthCalendar();
            monthTab = new TabPage();
            monthDataGridView = new DataGridView();
            monthDate = new DataGridViewTextBoxColumn();
            monthPatientID = new DataGridViewTextBoxColumn();
            monthPatient = new DataGridViewTextBoxColumn();
            monthPhysicianID = new DataGridViewTextBoxColumn();
            monthPhysician = new DataGridViewTextBoxColumn();
            monthReason = new DataGridViewTextBoxColumn();
            monthEmployeeID = new DataGridViewTextBoxColumn();
            monthEmployee = new DataGridViewTextBoxColumn();
            monthStatus = new DataGridViewTextBoxColumn();
            weekTab = new TabPage();
            weekDataGridView = new DataGridView();
            weekDate = new DataGridViewTextBoxColumn();
            weekPatientID = new DataGridViewTextBoxColumn();
            weekPatient = new DataGridViewTextBoxColumn();
            weekPhysicianID = new DataGridViewTextBoxColumn();
            weekPhysician = new DataGridViewTextBoxColumn();
            weekReason = new DataGridViewTextBoxColumn();
            weekEmployeeID = new DataGridViewTextBoxColumn();
            weekEmployee = new DataGridViewTextBoxColumn();
            weekStatus = new DataGridViewTextBoxColumn();
            todayTab = new TabPage();
            todayDataGridView = new DataGridView();
            Appointments = new TabControl();
            confrmButton = new Button();
            rescheduleButton = new Button();
            cancelButton = new Button();
            deleteAppointbtn = new Button();
            todayDate = new DataGridViewTextBoxColumn();
            todayPatientID = new DataGridViewTextBoxColumn();
            todayPatient = new DataGridViewTextBoxColumn();
            todayPhysicianID = new DataGridViewTextBoxColumn();
            todayPhysician = new DataGridViewTextBoxColumn();
            todayReason = new DataGridViewTextBoxColumn();
            todayEmployeeID = new DataGridViewTextBoxColumn();
            todayEmployee = new DataGridViewTextBoxColumn();
            todayStatus = new DataGridViewTextBoxColumn();
            monthTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monthDataGridView).BeginInit();
            weekTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weekDataGridView).BeginInit();
            todayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)todayDataGridView).BeginInit();
            Appointments.SuspendLayout();
            SuspendLayout();
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
            lblSearch.TabIndex = 71;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            lblSearch.Click += lblHelp_Click;
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
            lblReportBill.TabIndex = 70;
            lblReportBill.Text = "Reports/Billing";
            lblReportBill.TextAlign = ContentAlignment.MiddleCenter;
            lblReportBill.Click += lblActivity_Click;
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
            lblPrescriptions.TabIndex = 69;
            lblPrescriptions.Text = "Prescriptions";
            lblPrescriptions.TextAlign = ContentAlignment.MiddleCenter;
            lblPrescriptions.Click += lblDrivers_Click;
            // 
            // lblAppoint
            // 
            lblAppoint.BorderStyle = BorderStyle.Fixed3D;
            lblAppoint.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline);
            lblAppoint.ForeColor = Color.White;
            lblAppoint.Location = new Point(1, 242);
            lblAppoint.Margin = new Padding(4, 0, 4, 0);
            lblAppoint.Name = "lblAppoint";
            lblAppoint.Size = new Size(306, 146);
            lblAppoint.TabIndex = 68;
            lblAppoint.Text = "Appointments";
            lblAppoint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPatientProfile
            // 
            lblPatientProfile.BorderStyle = BorderStyle.Fixed3D;
            lblPatientProfile.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPatientProfile.ForeColor = Color.White;
            lblPatientProfile.Location = new Point(0, 96);
            lblPatientProfile.Margin = new Padding(4, 0, 4, 0);
            lblPatientProfile.Name = "lblPatientProfile";
            lblPatientProfile.Size = new Size(307, 146);
            lblPatientProfile.TabIndex = 67;
            lblPatientProfile.Text = "Patient Profile";
            lblPatientProfile.TextAlign = ContentAlignment.MiddleCenter;
            lblPatientProfile.Click += lblAccount_Click;
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Enabled = false;
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1420, 861);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(500, 150);
            lblMore.TabIndex = 66;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPG
            // 
            lblPG.BackColor = Color.FromArgb(30, 76, 99);
            lblPG.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPG.ForeColor = Color.White;
            lblPG.Location = new Point(500, 861);
            lblPG.Name = "lblPG";
            lblPG.Size = new Size(920, 150);
            lblPG.TabIndex = 65;
            lblPG.Text = "Patient Registration";
            lblPG.TextAlign = ContentAlignment.MiddleCenter;
            lblPG.Click += lblMap_Click;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 861);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(500, 150);
            lblHome.TabIndex = 64;
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
            lblLeftMain.TabIndex = 63;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(1472, 537);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 72;
            // 
            // monthTab
            // 
            monthTab.Controls.Add(monthDataGridView);
            monthTab.Location = new Point(8, 46);
            monthTab.Name = "monthTab";
            monthTab.Padding = new Padding(3);
            monthTab.Size = new Size(1521, 366);
            monthTab.TabIndex = 2;
            monthTab.Text = "Month";
            monthTab.UseVisualStyleBackColor = true;
            // 
            // monthDataGridView
            // 
            monthDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monthDataGridView.Columns.AddRange(new DataGridViewColumn[] { monthDate, monthPatientID, monthPatient, monthPhysicianID, monthPhysician, monthReason, monthEmployeeID, monthEmployee, monthStatus });
            monthDataGridView.Dock = DockStyle.Fill;
            monthDataGridView.Location = new Point(3, 3);
            monthDataGridView.Name = "monthDataGridView";
            monthDataGridView.RowHeadersWidth = 82;
            monthDataGridView.Size = new Size(1515, 360);
            monthDataGridView.TabIndex = 74;
            // 
            // monthDate
            // 
            monthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthDate.HeaderText = "Date *";
            monthDate.MinimumWidth = 300;
            monthDate.Name = "monthDate";
            monthDate.Width = 300;
            // 
            // monthPatientID
            // 
            monthPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthPatientID.HeaderText = "PatientID *";
            monthPatientID.MinimumWidth = 10;
            monthPatientID.Name = "monthPatientID";
            monthPatientID.Width = 212;
            // 
            // monthPatient
            // 
            monthPatient.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthPatient.HeaderText = "Patient";
            monthPatient.MinimumWidth = 10;
            monthPatient.Name = "monthPatient";
            monthPatient.ReadOnly = true;
            monthPatient.Width = 160;
            // 
            // monthPhysicianID
            // 
            monthPhysicianID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthPhysicianID.HeaderText = "PhysicianID *";
            monthPhysicianID.MinimumWidth = 10;
            monthPhysicianID.Name = "monthPhysicianID";
            monthPhysicianID.Width = 245;
            // 
            // monthPhysician
            // 
            monthPhysician.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthPhysician.HeaderText = "Physician";
            monthPhysician.MinimumWidth = 10;
            monthPhysician.Name = "monthPhysician";
            monthPhysician.ReadOnly = true;
            monthPhysician.Width = 193;
            // 
            // monthReason
            // 
            monthReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthReason.HeaderText = "Reason *";
            monthReason.MinimumWidth = 10;
            monthReason.Name = "monthReason";
            monthReason.Width = 183;
            // 
            // monthEmployeeID
            // 
            monthEmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthEmployeeID.HeaderText = "EmployeeID *";
            monthEmployeeID.MinimumWidth = 10;
            monthEmployeeID.Name = "monthEmployeeID";
            monthEmployeeID.Width = 250;
            // 
            // monthEmployee
            // 
            monthEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthEmployee.HeaderText = "Employee";
            monthEmployee.MinimumWidth = 10;
            monthEmployee.Name = "monthEmployee";
            monthEmployee.Width = 198;
            // 
            // monthStatus
            // 
            monthStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthStatus.HeaderText = "Status";
            monthStatus.MinimumWidth = 10;
            monthStatus.Name = "monthStatus";
            monthStatus.ReadOnly = true;
            monthStatus.Width = 148;
            // 
            // weekTab
            // 
            weekTab.Controls.Add(weekDataGridView);
            weekTab.Location = new Point(8, 46);
            weekTab.Name = "weekTab";
            weekTab.Padding = new Padding(3);
            weekTab.Size = new Size(1521, 366);
            weekTab.TabIndex = 1;
            weekTab.Text = "Week";
            weekTab.UseVisualStyleBackColor = true;
            // 
            // weekDataGridView
            // 
            weekDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weekDataGridView.Columns.AddRange(new DataGridViewColumn[] { weekDate, weekPatientID, weekPatient, weekPhysicianID, weekPhysician, weekReason, weekEmployeeID, weekEmployee, weekStatus });
            weekDataGridView.Dock = DockStyle.Fill;
            weekDataGridView.Location = new Point(3, 3);
            weekDataGridView.Name = "weekDataGridView";
            weekDataGridView.RowHeadersWidth = 82;
            weekDataGridView.Size = new Size(1515, 360);
            weekDataGridView.TabIndex = 78;
            // 
            // weekDate
            // 
            weekDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekDate.FillWeight = 407.692322F;
            weekDate.HeaderText = "Date *";
            weekDate.MinimumWidth = 300;
            weekDate.Name = "weekDate";
            weekDate.Width = 300;
            // 
            // weekPatientID
            // 
            weekPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekPatientID.HeaderText = "PatientID *";
            weekPatientID.MinimumWidth = 10;
            weekPatientID.Name = "weekPatientID";
            weekPatientID.Width = 212;
            // 
            // weekPatient
            // 
            weekPatient.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekPatient.FillWeight = 38.4615364F;
            weekPatient.HeaderText = "Patient";
            weekPatient.MinimumWidth = 10;
            weekPatient.Name = "weekPatient";
            weekPatient.ReadOnly = true;
            weekPatient.Width = 160;
            // 
            // weekPhysicianID
            // 
            weekPhysicianID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekPhysicianID.HeaderText = "PhysicianID *";
            weekPhysicianID.MinimumWidth = 10;
            weekPhysicianID.Name = "weekPhysicianID";
            weekPhysicianID.Width = 245;
            // 
            // weekPhysician
            // 
            weekPhysician.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekPhysician.FillWeight = 38.4615364F;
            weekPhysician.HeaderText = "Physician";
            weekPhysician.MinimumWidth = 10;
            weekPhysician.Name = "weekPhysician";
            weekPhysician.ReadOnly = true;
            weekPhysician.Width = 193;
            // 
            // weekReason
            // 
            weekReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekReason.FillWeight = 38.4615364F;
            weekReason.HeaderText = "Reason *";
            weekReason.MinimumWidth = 10;
            weekReason.Name = "weekReason";
            weekReason.Width = 183;
            // 
            // weekEmployeeID
            // 
            weekEmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekEmployeeID.HeaderText = "EmployeeID *";
            weekEmployeeID.MinimumWidth = 10;
            weekEmployeeID.Name = "weekEmployeeID";
            weekEmployeeID.Width = 250;
            // 
            // weekEmployee
            // 
            weekEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekEmployee.FillWeight = 38.4615364F;
            weekEmployee.HeaderText = "Employee";
            weekEmployee.MinimumWidth = 10;
            weekEmployee.Name = "weekEmployee";
            weekEmployee.ReadOnly = true;
            weekEmployee.Width = 198;
            // 
            // weekStatus
            // 
            weekStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekStatus.FillWeight = 38.4615364F;
            weekStatus.HeaderText = "Status";
            weekStatus.MinimumWidth = 10;
            weekStatus.Name = "weekStatus";
            weekStatus.ReadOnly = true;
            weekStatus.Width = 148;
            // 
            // todayTab
            // 
            todayTab.Controls.Add(todayDataGridView);
            todayTab.Location = new Point(8, 51);
            todayTab.Name = "todayTab";
            todayTab.Padding = new Padding(3);
            todayTab.Size = new Size(1521, 361);
            todayTab.TabIndex = 0;
            todayTab.Text = "Today";
            todayTab.UseVisualStyleBackColor = true;
            // 
            // todayDataGridView
            // 
            todayDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todayDataGridView.Columns.AddRange(new DataGridViewColumn[] { todayDate, todayPatientID, todayPatient, todayPhysicianID, todayPhysician, todayReason, todayEmployeeID, todayEmployee, todayStatus });
            todayDataGridView.Dock = DockStyle.Fill;
            todayDataGridView.Location = new Point(3, 3);
            todayDataGridView.Name = "todayDataGridView";
            todayDataGridView.RowHeadersWidth = 82;
            todayDataGridView.Size = new Size(1515, 355);
            todayDataGridView.TabIndex = 73;
            todayDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Appointments
            // 
            Appointments.Controls.Add(todayTab);
            Appointments.Controls.Add(weekTab);
            Appointments.Controls.Add(monthTab);
            Appointments.Location = new Point(339, 105);
            Appointments.Name = "Appointments";
            Appointments.SelectedIndex = 0;
            Appointments.Size = new Size(1537, 420);
            Appointments.TabIndex = 74;
            // 
            // confrmButton
            // 
            confrmButton.BackColor = Color.FromArgb(0, 192, 0);
            confrmButton.Location = new Point(339, 682);
            confrmButton.Name = "confrmButton";
            confrmButton.Size = new Size(342, 46);
            confrmButton.TabIndex = 75;
            confrmButton.Text = "Confirm Appointment";
            confrmButton.UseVisualStyleBackColor = false;
            confrmButton.Click += confrmButton_Click;
            // 
            // rescheduleButton
            // 
            rescheduleButton.Location = new Point(802, 633);
            rescheduleButton.Name = "rescheduleButton";
            rescheduleButton.Size = new Size(274, 46);
            rescheduleButton.TabIndex = 76;
            rescheduleButton.Text = "Reschedule";
            rescheduleButton.UseVisualStyleBackColor = true;
            rescheduleButton.Click += rescheduleButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.Location = new Point(802, 734);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(274, 46);
            cancelButton.TabIndex = 77;
            cancelButton.Text = "Mark as Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // deleteAppointbtn
            // 
            deleteAppointbtn.BackColor = Color.Red;
            deleteAppointbtn.Location = new Point(1187, 682);
            deleteAppointbtn.Name = "deleteAppointbtn";
            deleteAppointbtn.Size = new Size(259, 46);
            deleteAppointbtn.TabIndex = 78;
            deleteAppointbtn.Text = "Delete";
            deleteAppointbtn.UseVisualStyleBackColor = false;
            deleteAppointbtn.Click += deleteAppointbtn_Click;
            // 
            // todayDate
            // 
            todayDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            todayDate.DefaultCellStyle = dataGridViewCellStyle1;
            todayDate.FillWeight = 384.615448F;
            todayDate.HeaderText = "Date *";
            todayDate.MinimumWidth = 300;
            todayDate.Name = "todayDate";
            todayDate.Width = 300;
            // 
            // todayPatientID
            // 
            todayPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayPatientID.HeaderText = "PatientID *";
            todayPatientID.MinimumWidth = 10;
            todayPatientID.Name = "todayPatientID";
            todayPatientID.Width = 212;
            // 
            // todayPatient
            // 
            todayPatient.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayPatient.FillWeight = 43.0769119F;
            todayPatient.HeaderText = "Patient";
            todayPatient.MinimumWidth = 150;
            todayPatient.Name = "todayPatient";
            todayPatient.ReadOnly = true;
            todayPatient.Width = 160;
            // 
            // todayPhysicianID
            // 
            todayPhysicianID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayPhysicianID.HeaderText = "PhysicianID *";
            todayPhysicianID.MinimumWidth = 10;
            todayPhysicianID.Name = "todayPhysicianID";
            todayPhysicianID.Width = 245;
            // 
            // todayPhysician
            // 
            todayPhysician.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayPhysician.FillWeight = 43.0769119F;
            todayPhysician.HeaderText = "Physician";
            todayPhysician.MinimumWidth = 100;
            todayPhysician.Name = "todayPhysician";
            todayPhysician.ReadOnly = true;
            todayPhysician.Width = 193;
            // 
            // todayReason
            // 
            todayReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayReason.FillWeight = 43.0769119F;
            todayReason.HeaderText = "Reason *";
            todayReason.MinimumWidth = 10;
            todayReason.Name = "todayReason";
            todayReason.Width = 183;
            // 
            // todayEmployeeID
            // 
            todayEmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayEmployeeID.HeaderText = "EmployeeID *";
            todayEmployeeID.MinimumWidth = 10;
            todayEmployeeID.Name = "todayEmployeeID";
            todayEmployeeID.Width = 250;
            // 
            // todayEmployee
            // 
            todayEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayEmployee.FillWeight = 43.0769119F;
            todayEmployee.HeaderText = "Employee";
            todayEmployee.MinimumWidth = 10;
            todayEmployee.Name = "todayEmployee";
            todayEmployee.ReadOnly = true;
            todayEmployee.Width = 198;
            // 
            // todayStatus
            // 
            todayStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayStatus.FillWeight = 43.0769119F;
            todayStatus.HeaderText = "Status";
            todayStatus.MinimumWidth = 10;
            todayStatus.Name = "todayStatus";
            todayStatus.ReadOnly = true;
            todayStatus.Width = 148;
            // 
            // Appoint
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1894, 1009);
            Controls.Add(deleteAppointbtn);
            Controls.Add(cancelButton);
            Controls.Add(rescheduleButton);
            Controls.Add(confrmButton);
            Controls.Add(Appointments);
            Controls.Add(monthCalendar1);
            Controls.Add(lblSearch);
            Controls.Add(lblReportBill);
            Controls.Add(lblPrescriptions);
            Controls.Add(lblAppoint);
            Controls.Add(lblPatientProfile);
            Controls.Add(lblMore);
            Controls.Add(lblPG);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Appoint";
            Text = "Appoint";
            Load += Appoint_Load;
            monthTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)monthDataGridView).EndInit();
            weekTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)weekDataGridView).EndInit();
            todayTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)todayDataGridView).EndInit();
            Appointments.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblSearch;
        private Label lblReportBill;
        private Label lblPrescriptions;
        private Label lblAppoint;
        private Label lblPatientProfile;
        private Label lblMore;
        private Label lblPG;
        private Label lblHome;
        private Label lblLeftMain;
        private MonthCalendar monthCalendar1;
        private TabPage monthTab;
        private TabPage weekTab;
        private TabPage todayTab;
        private DataGridView todayDataGridView;
        private TabControl Appointments;
        private Button confrmButton;
        private Button rescheduleButton;
        private Button cancelButton;
        private DataGridView monthDataGridView;
        private DataGridView weekDataGridView;
        private Button deleteAppointbtn;
        private DataGridViewTextBoxColumn monthDate;
        private DataGridViewTextBoxColumn monthPatientID;
        private DataGridViewTextBoxColumn monthPatient;
        private DataGridViewTextBoxColumn monthPhysicianID;
        private DataGridViewTextBoxColumn monthPhysician;
        private DataGridViewTextBoxColumn monthReason;
        private DataGridViewTextBoxColumn monthEmployeeID;
        private DataGridViewTextBoxColumn monthEmployee;
        private DataGridViewTextBoxColumn monthStatus;
        private DataGridViewTextBoxColumn weekDate;
        private DataGridViewTextBoxColumn weekPatientID;
        private DataGridViewTextBoxColumn weekPatient;
        private DataGridViewTextBoxColumn weekPhysicianID;
        private DataGridViewTextBoxColumn weekPhysician;
        private DataGridViewTextBoxColumn weekReason;
        private DataGridViewTextBoxColumn weekEmployeeID;
        private DataGridViewTextBoxColumn weekEmployee;
        private DataGridViewTextBoxColumn weekStatus;
        private DataGridViewTextBoxColumn todayDate;
        private DataGridViewTextBoxColumn todayPatientID;
        private DataGridViewTextBoxColumn todayPatient;
        private DataGridViewTextBoxColumn todayPhysicianID;
        private DataGridViewTextBoxColumn todayPhysician;
        private DataGridViewTextBoxColumn todayReason;
        private DataGridViewTextBoxColumn todayEmployeeID;
        private DataGridViewTextBoxColumn todayEmployee;
        private DataGridViewTextBoxColumn todayStatus;
    }
}