namespace Project_JohnsonPraska
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLeftMain = new Label();
            lblHome = new Label();
            lblMap = new Label();
            lblMore = new Label();
            MainDataView = new TabControl();
            todayTab = new TabPage();
            todayDataGridView3 = new DataGridView();
            todayDate = new DataGridViewTextBoxColumn();
            todayPatientFirst = new DataGridViewTextBoxColumn();
            todayPatientLast = new DataGridViewTextBoxColumn();
            todayAge = new DataGridViewTextBoxColumn();
            todayPrescription = new DataGridViewTextBoxColumn();
            todayInvoice = new DataGridViewTextBoxColumn();
            todayReason = new DataGridViewTextBoxColumn();
            todayEmployee = new DataGridViewTextBoxColumn();
            todayStatus = new DataGridViewTextBoxColumn();
            weekTab = new TabPage();
            weekDataGridView1 = new DataGridView();
            weekDate = new DataGridViewTextBoxColumn();
            weekPatientFirst = new DataGridViewTextBoxColumn();
            weekPatientLast = new DataGridViewTextBoxColumn();
            weekAge = new DataGridViewTextBoxColumn();
            weekPrescription = new DataGridViewTextBoxColumn();
            weekInvoice = new DataGridViewTextBoxColumn();
            weekReason = new DataGridViewTextBoxColumn();
            weekEmployee = new DataGridViewTextBoxColumn();
            weekStatus = new DataGridViewTextBoxColumn();
            monthTab = new TabPage();
            monthDataGridView2 = new DataGridView();
            monthDate = new DataGridViewTextBoxColumn();
            monthPatientFirst = new DataGridViewTextBoxColumn();
            monthPatientLast = new DataGridViewTextBoxColumn();
            monthAge = new DataGridViewTextBoxColumn();
            monthPrescription = new DataGridViewTextBoxColumn();
            monthInvoice = new DataGridViewTextBoxColumn();
            mothReason = new DataGridViewTextBoxColumn();
            monthEmployee = new DataGridViewTextBoxColumn();
            monthStatus = new DataGridViewTextBoxColumn();
            label1 = new Label();
            searchButtonbtn = new Button();
            newPresciptionBtn = new Button();
            newAppointBtn = new Button();
            reportBillBtn = new Button();
            lblCurrentID = new Label();
            lblCurrentFName = new Label();
            lblCurrentLName = new Label();
            btnLogout = new Button();
            label2 = new Label();
            quickConfirmBtn = new Button();
            quickCancelBtn = new Button();
            MainDataView.SuspendLayout();
            todayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)todayDataGridView3).BeginInit();
            weekTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weekDataGridView1).BeginInit();
            monthTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monthDataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblLeftMain
            // 
            lblLeftMain.BackColor = Color.FromArgb(30, 76, 99);
            lblLeftMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblLeftMain.ForeColor = Color.White;
            lblLeftMain.Location = new Point(0, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(1920, 75);
            lblLeftMain.TabIndex = 2;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Enabled = false;
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 786);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(500, 150);
            lblHome.TabIndex = 28;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
            // 
            // lblMap
            // 
            lblMap.BackColor = Color.FromArgb(30, 76, 99);
            lblMap.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMap.ForeColor = Color.White;
            lblMap.Location = new Point(327, 786);
            lblMap.Name = "lblMap";
            lblMap.Size = new Size(920, 150);
            lblMap.TabIndex = 29;
            lblMap.Text = "Patient Registration";
            lblMap.TextAlign = ContentAlignment.MiddleCenter;
            lblMap.Click += lblMap_Click;
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1079, 786);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(500, 150);
            lblMore.TabIndex = 30;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            lblMore.Click += lblMore_Click;
            // 
            // MainDataView
            // 
            MainDataView.Controls.Add(todayTab);
            MainDataView.Controls.Add(weekTab);
            MainDataView.Controls.Add(monthTab);
            MainDataView.Location = new Point(52, 153);
            MainDataView.Name = "MainDataView";
            MainDataView.SelectedIndex = 0;
            MainDataView.Size = new Size(1151, 560);
            MainDataView.TabIndex = 79;
            // 
            // todayTab
            // 
            todayTab.Controls.Add(todayDataGridView3);
            todayTab.Location = new Point(4, 32);
            todayTab.Name = "todayTab";
            todayTab.Padding = new Padding(3);
            todayTab.Size = new Size(1143, 524);
            todayTab.TabIndex = 0;
            todayTab.Text = "Today";
            todayTab.UseVisualStyleBackColor = true;
            // 
            // todayDataGridView3
            // 
            todayDataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todayDataGridView3.Columns.AddRange(new DataGridViewColumn[] { todayDate, todayPatientFirst, todayPatientLast, todayAge, todayPrescription, todayInvoice, todayReason, todayEmployee, todayStatus });
            todayDataGridView3.Dock = DockStyle.Fill;
            todayDataGridView3.Location = new Point(3, 3);
            todayDataGridView3.Name = "todayDataGridView3";
            todayDataGridView3.RowHeadersWidth = 82;
            todayDataGridView3.Size = new Size(1137, 518);
            todayDataGridView3.TabIndex = 73;
            // 
            // todayDate
            // 
            todayDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayDate.Frozen = true;
            todayDate.HeaderText = "Date";
            todayDate.MinimumWidth = 300;
            todayDate.Name = "todayDate";
            todayDate.ReadOnly = true;
            todayDate.Width = 300;
            // 
            // todayPatientFirst
            // 
            todayPatientFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayPatientFirst.Frozen = true;
            todayPatientFirst.HeaderText = "PatientFirst";
            todayPatientFirst.MinimumWidth = 150;
            todayPatientFirst.Name = "todayPatientFirst";
            todayPatientFirst.ReadOnly = true;
            todayPatientFirst.Width = 150;
            // 
            // todayPatientLast
            // 
            todayPatientLast.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayPatientLast.Frozen = true;
            todayPatientLast.HeaderText = "PatientLast";
            todayPatientLast.MinimumWidth = 150;
            todayPatientLast.Name = "todayPatientLast";
            todayPatientLast.ReadOnly = true;
            todayPatientLast.Width = 150;
            // 
            // todayAge
            // 
            todayAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayAge.HeaderText = "Age";
            todayAge.MinimumWidth = 20;
            todayAge.Name = "todayAge";
            todayAge.ReadOnly = true;
            todayAge.Width = 71;
            // 
            // todayPrescription
            // 
            todayPrescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayPrescription.HeaderText = "Prescription";
            todayPrescription.MinimumWidth = 200;
            todayPrescription.Name = "todayPrescription";
            todayPrescription.ReadOnly = true;
            todayPrescription.Width = 200;
            // 
            // todayInvoice
            // 
            todayInvoice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayInvoice.HeaderText = "Invoice";
            todayInvoice.MinimumWidth = 150;
            todayInvoice.Name = "todayInvoice";
            todayInvoice.ReadOnly = true;
            todayInvoice.Width = 150;
            // 
            // todayReason
            // 
            todayReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayReason.HeaderText = "Reason";
            todayReason.MinimumWidth = 200;
            todayReason.Name = "todayReason";
            todayReason.ReadOnly = true;
            todayReason.Width = 200;
            // 
            // todayEmployee
            // 
            todayEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayEmployee.HeaderText = "Employee";
            todayEmployee.MinimumWidth = 150;
            todayEmployee.Name = "todayEmployee";
            todayEmployee.ReadOnly = true;
            todayEmployee.Width = 150;
            // 
            // todayStatus
            // 
            todayStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            todayStatus.HeaderText = "Status";
            todayStatus.MinimumWidth = 150;
            todayStatus.Name = "todayStatus";
            todayStatus.ReadOnly = true;
            todayStatus.Width = 150;
            // 
            // weekTab
            // 
            weekTab.Controls.Add(weekDataGridView1);
            weekTab.Location = new Point(4, 29);
            weekTab.Name = "weekTab";
            weekTab.Padding = new Padding(3);
            weekTab.Size = new Size(1143, 527);
            weekTab.TabIndex = 1;
            weekTab.Text = "Week";
            weekTab.UseVisualStyleBackColor = true;
            // 
            // weekDataGridView1
            // 
            weekDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weekDataGridView1.Columns.AddRange(new DataGridViewColumn[] { weekDate, weekPatientFirst, weekPatientLast, weekAge, weekPrescription, weekInvoice, weekReason, weekEmployee, weekStatus });
            weekDataGridView1.Dock = DockStyle.Fill;
            weekDataGridView1.Location = new Point(3, 3);
            weekDataGridView1.Name = "weekDataGridView1";
            weekDataGridView1.RowHeadersWidth = 82;
            weekDataGridView1.Size = new Size(1137, 521);
            weekDataGridView1.TabIndex = 74;
            // 
            // weekDate
            // 
            weekDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekDate.Frozen = true;
            weekDate.HeaderText = "Date";
            weekDate.MinimumWidth = 300;
            weekDate.Name = "weekDate";
            weekDate.ReadOnly = true;
            weekDate.Width = 300;
            // 
            // weekPatientFirst
            // 
            weekPatientFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekPatientFirst.Frozen = true;
            weekPatientFirst.HeaderText = "PatientFirst";
            weekPatientFirst.MinimumWidth = 150;
            weekPatientFirst.Name = "weekPatientFirst";
            weekPatientFirst.ReadOnly = true;
            weekPatientFirst.Width = 150;
            // 
            // weekPatientLast
            // 
            weekPatientLast.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekPatientLast.Frozen = true;
            weekPatientLast.HeaderText = "PatientLast";
            weekPatientLast.MinimumWidth = 150;
            weekPatientLast.Name = "weekPatientLast";
            weekPatientLast.ReadOnly = true;
            weekPatientLast.Width = 150;
            // 
            // weekAge
            // 
            weekAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekAge.HeaderText = "Age";
            weekAge.MinimumWidth = 20;
            weekAge.Name = "weekAge";
            weekAge.ReadOnly = true;
            weekAge.Width = 71;
            // 
            // weekPrescription
            // 
            weekPrescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekPrescription.HeaderText = "Prescription";
            weekPrescription.MinimumWidth = 200;
            weekPrescription.Name = "weekPrescription";
            weekPrescription.ReadOnly = true;
            weekPrescription.Width = 200;
            // 
            // weekInvoice
            // 
            weekInvoice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekInvoice.HeaderText = "Invoice";
            weekInvoice.MinimumWidth = 150;
            weekInvoice.Name = "weekInvoice";
            weekInvoice.ReadOnly = true;
            weekInvoice.Width = 150;
            // 
            // weekReason
            // 
            weekReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekReason.HeaderText = "Reason";
            weekReason.MinimumWidth = 200;
            weekReason.Name = "weekReason";
            weekReason.ReadOnly = true;
            weekReason.Width = 200;
            // 
            // weekEmployee
            // 
            weekEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekEmployee.HeaderText = "Employee";
            weekEmployee.MinimumWidth = 150;
            weekEmployee.Name = "weekEmployee";
            weekEmployee.ReadOnly = true;
            weekEmployee.Width = 150;
            // 
            // weekStatus
            // 
            weekStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weekStatus.HeaderText = "Status";
            weekStatus.MinimumWidth = 150;
            weekStatus.Name = "weekStatus";
            weekStatus.ReadOnly = true;
            weekStatus.Width = 150;
            // 
            // monthTab
            // 
            monthTab.Controls.Add(monthDataGridView2);
            monthTab.Location = new Point(4, 32);
            monthTab.Name = "monthTab";
            monthTab.Padding = new Padding(3);
            monthTab.Size = new Size(1143, 524);
            monthTab.TabIndex = 2;
            monthTab.Text = "Month";
            monthTab.UseVisualStyleBackColor = true;
            // 
            // monthDataGridView2
            // 
            monthDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monthDataGridView2.Columns.AddRange(new DataGridViewColumn[] { monthDate, monthPatientFirst, monthPatientLast, monthAge, monthPrescription, monthInvoice, mothReason, monthEmployee, monthStatus });
            monthDataGridView2.Dock = DockStyle.Fill;
            monthDataGridView2.Location = new Point(3, 3);
            monthDataGridView2.Name = "monthDataGridView2";
            monthDataGridView2.RowHeadersWidth = 82;
            monthDataGridView2.Size = new Size(1137, 518);
            monthDataGridView2.TabIndex = 74;
            // 
            // monthDate
            // 
            monthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthDate.Frozen = true;
            monthDate.HeaderText = "Date";
            monthDate.MinimumWidth = 300;
            monthDate.Name = "monthDate";
            monthDate.ReadOnly = true;
            monthDate.Width = 300;
            // 
            // monthPatientFirst
            // 
            monthPatientFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthPatientFirst.Frozen = true;
            monthPatientFirst.HeaderText = "PatientFirst";
            monthPatientFirst.MinimumWidth = 150;
            monthPatientFirst.Name = "monthPatientFirst";
            monthPatientFirst.ReadOnly = true;
            monthPatientFirst.Width = 150;
            // 
            // monthPatientLast
            // 
            monthPatientLast.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthPatientLast.Frozen = true;
            monthPatientLast.HeaderText = "PatientLast";
            monthPatientLast.MinimumWidth = 150;
            monthPatientLast.Name = "monthPatientLast";
            monthPatientLast.ReadOnly = true;
            monthPatientLast.Width = 150;
            // 
            // monthAge
            // 
            monthAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthAge.HeaderText = "Age";
            monthAge.MinimumWidth = 20;
            monthAge.Name = "monthAge";
            monthAge.ReadOnly = true;
            monthAge.Width = 71;
            // 
            // monthPrescription
            // 
            monthPrescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthPrescription.HeaderText = "Prescription";
            monthPrescription.MinimumWidth = 200;
            monthPrescription.Name = "monthPrescription";
            monthPrescription.ReadOnly = true;
            monthPrescription.Width = 200;
            // 
            // monthInvoice
            // 
            monthInvoice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthInvoice.HeaderText = "Invoice";
            monthInvoice.MinimumWidth = 150;
            monthInvoice.Name = "monthInvoice";
            monthInvoice.ReadOnly = true;
            monthInvoice.Width = 150;
            // 
            // mothReason
            // 
            mothReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mothReason.HeaderText = "Reason";
            mothReason.MinimumWidth = 200;
            mothReason.Name = "mothReason";
            mothReason.ReadOnly = true;
            mothReason.Width = 200;
            // 
            // monthEmployee
            // 
            monthEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthEmployee.HeaderText = "Employee";
            monthEmployee.MinimumWidth = 150;
            monthEmployee.Name = "monthEmployee";
            monthEmployee.ReadOnly = true;
            monthEmployee.Width = 150;
            // 
            // monthStatus
            // 
            monthStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            monthStatus.HeaderText = "Status";
            monthStatus.MinimumWidth = 150;
            monthStatus.Name = "monthStatus";
            monthStatus.ReadOnly = true;
            monthStatus.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(52, 84);
            label1.Name = "label1";
            label1.Size = new Size(468, 47);
            label1.TabIndex = 80;
            label1.Text = "Your Employee Schedule";
            // 
            // searchButtonbtn
            // 
            searchButtonbtn.Location = new Point(1249, 239);
            searchButtonbtn.Name = "searchButtonbtn";
            searchButtonbtn.Size = new Size(198, 82);
            searchButtonbtn.TabIndex = 81;
            searchButtonbtn.Text = "Search Patient";
            searchButtonbtn.UseVisualStyleBackColor = true;
            searchButtonbtn.Click += searchButtonbtn_Click;
            // 
            // newPresciptionBtn
            // 
            newPresciptionBtn.Location = new Point(1249, 358);
            newPresciptionBtn.Name = "newPresciptionBtn";
            newPresciptionBtn.Size = new Size(198, 82);
            newPresciptionBtn.TabIndex = 82;
            newPresciptionBtn.Text = "New Prescription";
            newPresciptionBtn.UseVisualStyleBackColor = true;
            newPresciptionBtn.Click += newPresciptionBtn_Click;
            // 
            // newAppointBtn
            // 
            newAppointBtn.Location = new Point(1249, 477);
            newAppointBtn.Name = "newAppointBtn";
            newAppointBtn.Size = new Size(198, 82);
            newAppointBtn.TabIndex = 83;
            newAppointBtn.Text = "New Appointment";
            newAppointBtn.UseVisualStyleBackColor = true;
            newAppointBtn.Click += newAppointBtn_Click;
            // 
            // reportBillBtn
            // 
            reportBillBtn.Location = new Point(1249, 599);
            reportBillBtn.Name = "reportBillBtn";
            reportBillBtn.Size = new Size(198, 82);
            reportBillBtn.TabIndex = 84;
            reportBillBtn.Text = "Reports/Billing";
            reportBillBtn.UseVisualStyleBackColor = true;
            reportBillBtn.Click += reportBillBtn_Click;
            // 
            // lblCurrentID
            // 
            lblCurrentID.AutoSize = true;
            lblCurrentID.Font = new Font("Cambria", 24F);
            lblCurrentID.ForeColor = SystemColors.ControlLightLight;
            lblCurrentID.Location = new Point(535, 84);
            lblCurrentID.Name = "lblCurrentID";
            lblCurrentID.Size = new Size(227, 47);
            lblCurrentID.TabIndex = 85;
            lblCurrentID.Text = "EmployeeID";
            // 
            // lblCurrentFName
            // 
            lblCurrentFName.AutoSize = true;
            lblCurrentFName.Font = new Font("Cambria", 24F);
            lblCurrentFName.ForeColor = SystemColors.ControlLightLight;
            lblCurrentFName.Location = new Point(857, 84);
            lblCurrentFName.Name = "lblCurrentFName";
            lblCurrentFName.Size = new Size(209, 47);
            lblCurrentFName.TabIndex = 86;
            lblCurrentFName.Text = "First Name";
            // 
            // lblCurrentLName
            // 
            lblCurrentLName.AutoSize = true;
            lblCurrentLName.Font = new Font("Cambria", 24F);
            lblCurrentLName.ForeColor = SystemColors.ControlLightLight;
            lblCurrentLName.Location = new Point(1188, 84);
            lblCurrentLName.Name = "lblCurrentLName";
            lblCurrentLName.Size = new Size(201, 47);
            lblCurrentLName.TabIndex = 87;
            lblCurrentLName.Text = "Last Name";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1318, 21);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 34);
            btnLogout.TabIndex = 88;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1290, 188);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 89;
            label2.Text = "Shortcuts";
            // 
            // quickConfirmBtn
            // 
            quickConfirmBtn.BackColor = Color.Lime;
            quickConfirmBtn.Location = new Point(68, 730);
            quickConfirmBtn.Name = "quickConfirmBtn";
            quickConfirmBtn.Size = new Size(226, 42);
            quickConfirmBtn.TabIndex = 90;
            quickConfirmBtn.Text = "Quick Confirm";
            quickConfirmBtn.UseVisualStyleBackColor = false;
            quickConfirmBtn.Click += quickConfirmBtn_Click;
            // 
            // quickCancelBtn
            // 
            quickCancelBtn.BackColor = Color.Red;
            quickCancelBtn.Location = new Point(966, 730);
            quickCancelBtn.Name = "quickCancelBtn";
            quickCancelBtn.Size = new Size(213, 42);
            quickCancelBtn.TabIndex = 91;
            quickCancelBtn.Text = "Quick Cancel";
            quickCancelBtn.UseVisualStyleBackColor = false;
            quickCancelBtn.Click += quickCancelBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1506, 905);
            Controls.Add(quickCancelBtn);
            Controls.Add(quickConfirmBtn);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(lblCurrentLName);
            Controls.Add(lblCurrentFName);
            Controls.Add(lblCurrentID);
            Controls.Add(reportBillBtn);
            Controls.Add(newAppointBtn);
            Controls.Add(newPresciptionBtn);
            Controls.Add(searchButtonbtn);
            Controls.Add(label1);
            Controls.Add(MainDataView);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Font = new Font("Cambria", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1438, 850);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            MainDataView.ResumeLayout(false);
            todayTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)todayDataGridView3).EndInit();
            weekTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)weekDataGridView1).EndInit();
            monthTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)monthDataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeftMain;
        private Label lblHome;
        private Label lblMap;
        private Label lblMore;
        private TabControl MainDataView;
        private TabPage todayTab;
        private TabPage weekTab;
        private Label label1;
        private Button searchButtonbtn;
        private Button newPresciptionBtn;
        private Button newAppointBtn;
        private Button reportBillBtn;
        private DataGridView weekDataGridView1;
        private DataGridView todayDataGridView3;
        private TabPage monthTab;
        private DataGridView monthDataGridView2;
        private Label lblCurrentID;
        private Label lblCurrentFName;
        private Label lblCurrentLName;
        private Button btnLogout;
        private Label label2;
        private Button quickConfirmBtn;
        private Button quickCancelBtn;
        private DataGridViewTextBoxColumn todayDate;
        private DataGridViewTextBoxColumn todayPatientFirst;
        private DataGridViewTextBoxColumn todayPatientLast;
        private DataGridViewTextBoxColumn todayAge;
        private DataGridViewTextBoxColumn todayPrescription;
        private DataGridViewTextBoxColumn todayInvoice;
        private DataGridViewTextBoxColumn todayReason;
        private DataGridViewTextBoxColumn todayEmployee;
        private DataGridViewTextBoxColumn todayStatus;
        private DataGridViewTextBoxColumn weekDate;
        private DataGridViewTextBoxColumn weekPatientFirst;
        private DataGridViewTextBoxColumn weekPatientLast;
        private DataGridViewTextBoxColumn weekAge;
        private DataGridViewTextBoxColumn weekPrescription;
        private DataGridViewTextBoxColumn weekInvoice;
        private DataGridViewTextBoxColumn weekReason;
        private DataGridViewTextBoxColumn weekEmployee;
        private DataGridViewTextBoxColumn weekStatus;
        private DataGridViewTextBoxColumn monthDate;
        private DataGridViewTextBoxColumn monthPatientFirst;
        private DataGridViewTextBoxColumn monthPatientLast;
        private DataGridViewTextBoxColumn monthAge;
        private DataGridViewTextBoxColumn monthPrescription;
        private DataGridViewTextBoxColumn monthInvoice;
        private DataGridViewTextBoxColumn mothReason;
        private DataGridViewTextBoxColumn monthEmployee;
        private DataGridViewTextBoxColumn monthStatus;
    }
}
