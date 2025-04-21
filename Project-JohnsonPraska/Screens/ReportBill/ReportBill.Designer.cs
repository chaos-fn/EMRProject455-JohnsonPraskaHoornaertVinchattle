namespace Project_JohnsonPraska
{
    //COMMENTS TEST
    partial class ReportBill
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
            lblSearch = new Label();
            lblReportBill = new Label();
            lblPrescriptions = new Label();
            lblAppoint = new Label();
            lblPatientProfile = new Label();
            lblMore = new Label();
            lblPG = new Label();
            lblHome = new Label();
            lblLeftMain = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            exportButton = new Button();
            dataGridViewClinical = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            ClaimID = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            daysButton = new Button();
            monthButton = new Button();
            quarterButton = new Button();
            tolbl = new Label();
            fromLbl = new Label();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            tabPage2 = new TabPage();
            exportButton2 = new Button();
            dataGridViewFinancial = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dateTimePickerTo22 = new DateTimePicker();
            daysButton2 = new Button();
            monthButton2 = new Button();
            quarterButton2 = new Button();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerFrom2 = new DateTimePicker();
            tabPage3 = new TabPage();
            exportButton3 = new Button();
            dataGridViewInsurance = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            daysButton3 = new Button();
            button5 = new Button();
            quarterButton3 = new Button();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerTo3 = new DateTimePicker();
            dateTimePickerFrom3 = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClinical).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancial).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInsurance).BeginInit();
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
            lblSearch.TabIndex = 103;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            lblSearch.Click += lblHelp_Click;
            // 
            // lblReportBill
            // 
            lblReportBill.BorderStyle = BorderStyle.Fixed3D;
            lblReportBill.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline);
            lblReportBill.ForeColor = Color.White;
            lblReportBill.Location = new Point(1, 522);
            lblReportBill.Margin = new Padding(4, 0, 4, 0);
            lblReportBill.Name = "lblReportBill";
            lblReportBill.Size = new Size(306, 143);
            lblReportBill.TabIndex = 102;
            lblReportBill.Text = "Reports/Billing";
            lblReportBill.TextAlign = ContentAlignment.MiddleCenter;
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
            lblPrescriptions.TabIndex = 101;
            lblPrescriptions.Text = "Prescriptions";
            lblPrescriptions.TextAlign = ContentAlignment.MiddleCenter;
            lblPrescriptions.Click += lblDrivers_Click;
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
            lblAppoint.TabIndex = 100;
            lblAppoint.Text = "Appointments";
            lblAppoint.TextAlign = ContentAlignment.MiddleCenter;
            lblAppoint.Click += lblVehicles_Click;
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
            lblPatientProfile.TabIndex = 99;
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
            lblMore.TabIndex = 98;
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
            lblPG.TabIndex = 97;
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
            lblHome.TabIndex = 96;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
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
            lblLeftMain.Size = new Size(1894, 96);
            lblLeftMain.TabIndex = 95;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(307, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1587, 762);
            tabControl1.TabIndex = 104;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(exportButton);
            tabPage1.Controls.Add(dataGridViewClinical);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(tolbl);
            tabPage1.Controls.Add(fromLbl);
            tabPage1.Controls.Add(dateTimePickerTo);
            tabPage1.Controls.Add(dateTimePickerFrom);
            tabPage1.Location = new Point(8, 51);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1571, 703);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Clinical";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(192, 255, 255);
            exportButton.ForeColor = SystemColors.ActiveCaptionText;
            exportButton.Location = new Point(1406, 18);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(145, 50);
            exportButton.TabIndex = 6;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // dataGridViewClinical
            // 
            dataGridViewClinical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClinical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClinical.Columns.AddRange(new DataGridViewColumn[] { Date, ClaimID, Amount, Status });
            dataGridViewClinical.Dock = DockStyle.Bottom;
            dataGridViewClinical.Location = new Point(3, 95);
            dataGridViewClinical.Name = "dataGridViewClinical";
            dataGridViewClinical.RowHeadersWidth = 82;
            dataGridViewClinical.Size = new Size(1565, 605);
            dataGridViewClinical.TabIndex = 5;
            dataGridViewClinical.CellContentClick += dataGridViewClinical_CellContentClick;
            dataGridViewClinical.CellContentDoubleClick += dataGridViewClinical_CellContentDoubleClick;
            dataGridViewClinical.CellFormatting += dataGridViewClinical_CellFormatting;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 10;
            Date.Name = "Date";
            // 
            // ClaimID
            // 
            ClaimID.HeaderText = "ClaimID";
            ClaimID.MinimumWidth = 10;
            ClaimID.Name = "ClaimID";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 10;
            Amount.Name = "Amount";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 10;
            Status.Name = "Status";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(daysButton);
            flowLayoutPanel1.Controls.Add(monthButton);
            flowLayoutPanel1.Controls.Add(quarterButton);
            flowLayoutPanel1.Location = new Point(752, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(625, 56);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // daysButton
            // 
            daysButton.Location = new Point(3, 3);
            daysButton.Name = "daysButton";
            daysButton.Size = new Size(198, 50);
            daysButton.TabIndex = 0;
            daysButton.Text = "Last 7 days";
            daysButton.UseVisualStyleBackColor = true;
            daysButton.Click += daysButton_Click;
            // 
            // monthButton
            // 
            monthButton.Location = new Point(207, 3);
            monthButton.Name = "monthButton";
            monthButton.Size = new Size(197, 50);
            monthButton.TabIndex = 1;
            monthButton.Text = "This Month";
            monthButton.UseVisualStyleBackColor = true;
            monthButton.Click += monthButton_Click;
            // 
            // quarterButton
            // 
            quarterButton.Location = new Point(410, 3);
            quarterButton.Name = "quarterButton";
            quarterButton.Size = new Size(209, 50);
            quarterButton.TabIndex = 2;
            quarterButton.Text = "This Quarter";
            quarterButton.UseVisualStyleBackColor = true;
            quarterButton.Click += quarterButton_Click;
            // 
            // tolbl
            // 
            tolbl.AutoSize = true;
            tolbl.Font = new Font("Cambria", 8F);
            tolbl.Location = new Point(363, 42);
            tolbl.Name = "tolbl";
            tolbl.Size = new Size(35, 26);
            tolbl.TabIndex = 3;
            tolbl.Text = "To";
            // 
            // fromLbl
            // 
            fromLbl.AutoSize = true;
            fromLbl.Font = new Font("Cambria", 8F);
            fromLbl.Location = new Point(6, 42);
            fromLbl.Name = "fromLbl";
            fromLbl.Size = new Size(63, 26);
            fromLbl.TabIndex = 2;
            fromLbl.Text = "From";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarFont = new Font("Cambria", 8F);
            dateTimePickerTo.Format = DateTimePickerFormat.Short;
            dateTimePickerTo.Location = new Point(409, 29);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(257, 45);
            dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new Point(87, 28);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(270, 45);
            dateTimePickerFrom.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(exportButton2);
            tabPage2.Controls.Add(dataGridViewFinancial);
            tabPage2.Controls.Add(dateTimePickerTo22);
            tabPage2.Controls.Add(daysButton2);
            tabPage2.Controls.Add(monthButton2);
            tabPage2.Controls.Add(quarterButton2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dateTimePickerFrom2);
            tabPage2.Location = new Point(8, 51);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1571, 703);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Financial";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // exportButton2
            // 
            exportButton2.BackColor = Color.FromArgb(192, 255, 255);
            exportButton2.ForeColor = SystemColors.ActiveCaptionText;
            exportButton2.Location = new Point(1408, 23);
            exportButton2.Name = "exportButton2";
            exportButton2.Size = new Size(152, 52);
            exportButton2.TabIndex = 13;
            exportButton2.Text = "Export";
            exportButton2.UseVisualStyleBackColor = false;
            exportButton2.Click += exportButton_Click;
            // 
            // dataGridViewFinancial
            // 
            dataGridViewFinancial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFinancial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinancial.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewFinancial.Dock = DockStyle.Bottom;
            dataGridViewFinancial.Location = new Point(3, 95);
            dataGridViewFinancial.Name = "dataGridViewFinancial";
            dataGridViewFinancial.RowHeadersWidth = 82;
            dataGridViewFinancial.Size = new Size(1565, 605);
            dataGridViewFinancial.TabIndex = 12;
            dataGridViewFinancial.CellContentDoubleClick += dataGridViewFinancial_CellContentDoubleClick;
            dataGridViewFinancial.CellFormatting += dataGridViewFinancial_CellFormatting;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Date";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "ClaimID";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Amount";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dateTimePickerTo22
            // 
            dateTimePickerTo22.Format = DateTimePickerFormat.Short;
            dateTimePickerTo22.Location = new Point(426, 31);
            dateTimePickerTo22.Name = "dateTimePickerTo22";
            dateTimePickerTo22.Size = new Size(258, 45);
            dateTimePickerTo22.TabIndex = 11;
            // 
            // daysButton2
            // 
            daysButton2.Location = new Point(722, 28);
            daysButton2.Name = "daysButton2";
            daysButton2.Size = new Size(219, 48);
            daysButton2.TabIndex = 8;
            daysButton2.Text = "Last 7 days";
            daysButton2.UseVisualStyleBackColor = true;
            daysButton2.Click += daysButton2_Click;
            // 
            // monthButton2
            // 
            monthButton2.Location = new Point(947, 25);
            monthButton2.Name = "monthButton2";
            monthButton2.Size = new Size(211, 49);
            monthButton2.TabIndex = 9;
            monthButton2.Text = "This Month";
            monthButton2.UseVisualStyleBackColor = true;
            monthButton2.Click += monthButton2_Click;
            // 
            // quarterButton2
            // 
            quarterButton2.Location = new Point(1164, 26);
            quarterButton2.Name = "quarterButton2";
            quarterButton2.Size = new Size(214, 47);
            quarterButton2.TabIndex = 10;
            quarterButton2.Text = "This Quarter";
            quarterButton2.UseVisualStyleBackColor = true;
            quarterButton2.Click += quarterButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 8F);
            label1.Location = new Point(367, 44);
            label1.Name = "label1";
            label1.Size = new Size(35, 26);
            label1.TabIndex = 7;
            label1.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 8F);
            label2.Location = new Point(24, 41);
            label2.Name = "label2";
            label2.Size = new Size(63, 26);
            label2.TabIndex = 6;
            label2.Text = "From";
            // 
            // dateTimePickerFrom2
            // 
            dateTimePickerFrom2.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom2.Location = new Point(103, 28);
            dateTimePickerFrom2.Name = "dateTimePickerFrom2";
            dateTimePickerFrom2.Size = new Size(258, 45);
            dateTimePickerFrom2.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(exportButton3);
            tabPage3.Controls.Add(dataGridViewInsurance);
            tabPage3.Controls.Add(daysButton3);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(quarterButton3);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dateTimePickerTo3);
            tabPage3.Controls.Add(dateTimePickerFrom3);
            tabPage3.Location = new Point(8, 51);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1571, 703);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Insurance";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // exportButton3
            // 
            exportButton3.BackColor = Color.FromArgb(192, 255, 255);
            exportButton3.ForeColor = SystemColors.ActiveCaptionText;
            exportButton3.Location = new Point(1420, 22);
            exportButton3.Name = "exportButton3";
            exportButton3.Size = new Size(133, 50);
            exportButton3.TabIndex = 12;
            exportButton3.Text = "Export";
            exportButton3.UseVisualStyleBackColor = false;
            exportButton3.Click += exportButton_Click;
            // 
            // dataGridViewInsurance
            // 
            dataGridViewInsurance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInsurance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInsurance.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewInsurance.Dock = DockStyle.Bottom;
            dataGridViewInsurance.Location = new Point(3, 95);
            dataGridViewInsurance.Name = "dataGridViewInsurance";
            dataGridViewInsurance.RowHeadersWidth = 82;
            dataGridViewInsurance.Size = new Size(1565, 605);
            dataGridViewInsurance.TabIndex = 11;
            dataGridViewInsurance.CellContentDoubleClick += dataGridViewInsurance_CellContentDoubleClick;
            dataGridViewInsurance.CellFormatting += dataGridViewInsurance_CellFormatting;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Date";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "ClaimID";
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Amount";
            dataGridViewTextBoxColumn7.MinimumWidth = 10;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Status";
            dataGridViewTextBoxColumn8.MinimumWidth = 10;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // daysButton3
            // 
            daysButton3.Location = new Point(723, 25);
            daysButton3.Name = "daysButton3";
            daysButton3.Size = new Size(219, 49);
            daysButton3.TabIndex = 8;
            daysButton3.Text = "Last 7 days";
            daysButton3.UseVisualStyleBackColor = true;
            daysButton3.Click += daysButton3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(948, 25);
            button5.Name = "button5";
            button5.Size = new Size(203, 48);
            button5.TabIndex = 9;
            button5.Text = "This Month";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // quarterButton3
            // 
            quarterButton3.Location = new Point(1157, 23);
            quarterButton3.Name = "quarterButton3";
            quarterButton3.Size = new Size(248, 49);
            quarterButton3.TabIndex = 10;
            quarterButton3.Text = "This Quarter";
            quarterButton3.UseVisualStyleBackColor = true;
            quarterButton3.Click += quarterButton3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 8F);
            label3.Location = new Point(346, 46);
            label3.Name = "label3";
            label3.Size = new Size(35, 26);
            label3.TabIndex = 7;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 8F);
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(63, 26);
            label4.TabIndex = 6;
            label4.Text = "From";
            // 
            // dateTimePickerTo3
            // 
            dateTimePickerTo3.Format = DateTimePickerFormat.Short;
            dateTimePickerTo3.Location = new Point(401, 32);
            dateTimePickerTo3.Name = "dateTimePickerTo3";
            dateTimePickerTo3.Size = new Size(253, 45);
            dateTimePickerTo3.TabIndex = 5;
            // 
            // dateTimePickerFrom3
            // 
            dateTimePickerFrom3.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom3.Location = new Point(75, 32);
            dateTimePickerFrom3.Name = "dateTimePickerFrom3";
            dateTimePickerFrom3.Size = new Size(265, 45);
            dateTimePickerFrom3.TabIndex = 4;
            // 
            // ReportBill
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1894, 1009);
            Controls.Add(tabControl1);
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
            Name = "ReportBill";
            Text = "Report/Bill";
            Load += ReportBill_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClinical).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancial).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInsurance).EndInit();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label tolbl;
        private Label fromLbl;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePickerFrom2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerTo3;
        private DateTimePicker dateTimePickerFrom3;
        private Button daysButton2;
        private Button monthButton2;
        private Button quarterButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button daysButton;
        private Button monthButton;
        private Button quarterButton;
        private Button daysButton3;
        private Button button5;
        private Button quarterButton3;
        private DateTimePicker dateTimePickerTo22;
        private DataGridView dataGridViewClinical;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ClaimID;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Status;
        private DataGridView dataGridViewFinancial;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridViewInsurance;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Button exportButton;
        private Button exportButton2;
        private Button exportButton3;
    }
}