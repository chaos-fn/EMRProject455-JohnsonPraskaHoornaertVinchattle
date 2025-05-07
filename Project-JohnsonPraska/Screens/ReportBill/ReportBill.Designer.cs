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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvAppointments = new DataGridView();
            dgvNotes = new DataGridView();
            groupBox1 = new GroupBox();
            lblAllergies = new Label();
            lblHistory = new Label();
            lblAllergiestxt = new Label();
            lblHistorytxt = new Label();
            dgvPrescriptions = new DataGridView();
            patientHistorylbl = new Label();
            btnExportFinancial = new Button();
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
            daysButton3 = new Button();
            button5 = new Button();
            quarterButton3 = new Button();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerTo3 = new DateTimePicker();
            dateTimePickerFrom3 = new DateTimePicker();
            lblCurrentPatient = new Label();
            currentlbl = new Label();
            btnLoadPatient = new Button();
            txtPatientId = new TextBox();
            patientIDlbl = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
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
            lblMore.Location = new Point(1277, 857);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(439, 150);
            lblMore.TabIndex = 98;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPG
            // 
            lblPG.BackColor = Color.FromArgb(30, 76, 99);
            lblPG.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPG.ForeColor = Color.White;
            lblPG.Location = new Point(464, 857);
            lblPG.Name = "lblPG";
            lblPG.Size = new Size(876, 150);
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
            lblLeftMain.Size = new Size(1704, 96);
            lblLeftMain.TabIndex = 95;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(314, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1390, 762);
            tabControl1.TabIndex = 104;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(patientHistorylbl);
            tabPage1.Controls.Add(btnExportFinancial);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(tolbl);
            tabPage1.Controls.Add(fromLbl);
            tabPage1.Controls.Add(dateTimePickerTo);
            tabPage1.Controls.Add(dateTimePickerFrom);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1382, 730);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Clinical";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvAppointments, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvNotes, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(dgvPrescriptions, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 158);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1371, 556);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AllowUserToOrderColumns = true;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(3, 3);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.Size = new Size(679, 272);
            dgvAppointments.TabIndex = 0;
            // 
            // dgvNotes
            // 
            dgvNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotes.Location = new Point(3, 281);
            dgvNotes.Name = "dgvNotes";
            dgvNotes.Size = new Size(679, 272);
            dgvNotes.TabIndex = 2;
            dgvNotes.CellContentClick += dgvNotes_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAllergies);
            groupBox1.Controls.Add(lblHistory);
            groupBox1.Controls.Add(lblAllergiestxt);
            groupBox1.Controls.Add(lblHistorytxt);
            groupBox1.Location = new Point(688, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 272);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient History and Allergies";
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Location = new Point(588, 59);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(0, 19);
            lblAllergies.TabIndex = 3;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(73, 59);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(0, 19);
            lblHistory.TabIndex = 2;
            // 
            // lblAllergiestxt
            // 
            lblAllergiestxt.AutoSize = true;
            lblAllergiestxt.Location = new Point(488, 40);
            lblAllergiestxt.Name = "lblAllergiestxt";
            lblAllergiestxt.Size = new Size(121, 19);
            lblAllergiestxt.TabIndex = 1;
            lblAllergiestxt.Text = "Patient Allergies";
            // 
            // lblHistorytxt
            // 
            lblHistorytxt.AutoSize = true;
            lblHistorytxt.Location = new Point(73, 22);
            lblHistorytxt.Name = "lblHistorytxt";
            lblHistorytxt.Size = new Size(112, 19);
            lblHistorytxt.TabIndex = 0;
            lblHistorytxt.Text = "Patient History";
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.AllowUserToAddRows = false;
            dgvPrescriptions.AllowUserToDeleteRows = false;
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescriptions.Location = new Point(688, 3);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.ReadOnly = true;
            dgvPrescriptions.Size = new Size(680, 272);
            dgvPrescriptions.TabIndex = 1;
            // 
            // patientHistorylbl
            // 
            patientHistorylbl.AutoSize = true;
            patientHistorylbl.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientHistorylbl.Location = new Point(700, 118);
            patientHistorylbl.Name = "patientHistorylbl";
            patientHistorylbl.Size = new Size(181, 19);
            patientHistorylbl.TabIndex = 7;
            patientHistorylbl.Text = "Patient Clinical History";
            // 
            // btnExportFinancial
            // 
            btnExportFinancial.BackColor = Color.FromArgb(192, 255, 255);
            btnExportFinancial.ForeColor = SystemColors.ActiveCaptionText;
            btnExportFinancial.Location = new Point(1226, 87);
            btnExportFinancial.Name = "btnExportFinancial";
            btnExportFinancial.Size = new Size(145, 50);
            btnExportFinancial.TabIndex = 6;
            btnExportFinancial.Text = "Export";
            btnExportFinancial.UseVisualStyleBackColor = false;
            btnExportFinancial.Click += exportButton_Click;
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
            tolbl.Size = new Size(17, 12);
            tolbl.TabIndex = 3;
            tolbl.Text = "To";
            // 
            // fromLbl
            // 
            fromLbl.AutoSize = true;
            fromLbl.Font = new Font("Cambria", 8F);
            fromLbl.Location = new Point(6, 42);
            fromLbl.Name = "fromLbl";
            fromLbl.Size = new Size(31, 12);
            fromLbl.TabIndex = 2;
            fromLbl.Text = "From";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarFont = new Font("Cambria", 8F);
            dateTimePickerTo.Format = DateTimePickerFormat.Short;
            dateTimePickerTo.Location = new Point(409, 29);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(257, 26);
            dateTimePickerTo.TabIndex = 1;
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new Point(87, 28);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(270, 26);
            dateTimePickerFrom.TabIndex = 0;
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1382, 734);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Financial";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // exportButton2
            // 
            exportButton2.BackColor = Color.FromArgb(192, 255, 255);
            exportButton2.ForeColor = SystemColors.ActiveCaptionText;
            exportButton2.Location = new Point(1220, 73);
            exportButton2.Name = "exportButton2";
            exportButton2.Size = new Size(132, 45);
            exportButton2.TabIndex = 13;
            exportButton2.Text = "Export";
            exportButton2.UseVisualStyleBackColor = false;
            exportButton2.Click += exportButton2_Click;
            // 
            // dataGridViewFinancial
            // 
            dataGridViewFinancial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFinancial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinancial.Dock = DockStyle.Bottom;
            dataGridViewFinancial.Location = new Point(3, 126);
            dataGridViewFinancial.MultiSelect = false;
            dataGridViewFinancial.Name = "dataGridViewFinancial";
            dataGridViewFinancial.ReadOnly = true;
            dataGridViewFinancial.RowHeadersWidth = 82;
            dataGridViewFinancial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFinancial.Size = new Size(1376, 605);
            dataGridViewFinancial.TabIndex = 12;
            dataGridViewFinancial.CellContentDoubleClick += dataGridViewFinancial_CellContentDoubleClick;
            dataGridViewFinancial.CellFormatting += dataGridViewFinancial_CellFormatting;
            // 
            // dateTimePickerTo22
            // 
            dateTimePickerTo22.Format = DateTimePickerFormat.Short;
            dateTimePickerTo22.Location = new Point(426, 31);
            dateTimePickerTo22.Name = "dateTimePickerTo22";
            dateTimePickerTo22.Size = new Size(258, 26);
            dateTimePickerTo22.TabIndex = 11;
            dateTimePickerTo22.ValueChanged += dateTimePickerTo22_ValueChanged;
            // 
            // daysButton2
            // 
            daysButton2.Location = new Point(710, 22);
            daysButton2.Name = "daysButton2";
            daysButton2.Size = new Size(219, 48);
            daysButton2.TabIndex = 8;
            daysButton2.Text = "Last 7 days";
            daysButton2.UseVisualStyleBackColor = true;
            daysButton2.Click += daysButton2_Click;
            // 
            // monthButton2
            // 
            monthButton2.Location = new Point(935, 19);
            monthButton2.Name = "monthButton2";
            monthButton2.Size = new Size(211, 49);
            monthButton2.TabIndex = 9;
            monthButton2.Text = "This Month";
            monthButton2.UseVisualStyleBackColor = true;
            monthButton2.Click += monthButton2_Click;
            // 
            // quarterButton2
            // 
            quarterButton2.Location = new Point(1152, 20);
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
            label1.Size = new Size(17, 12);
            label1.TabIndex = 7;
            label1.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 8F);
            label2.Location = new Point(24, 41);
            label2.Name = "label2";
            label2.Size = new Size(31, 12);
            label2.TabIndex = 6;
            label2.Text = "From";
            // 
            // dateTimePickerFrom2
            // 
            dateTimePickerFrom2.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom2.Location = new Point(103, 28);
            dateTimePickerFrom2.Name = "dateTimePickerFrom2";
            dateTimePickerFrom2.Size = new Size(258, 26);
            dateTimePickerFrom2.TabIndex = 4;
            dateTimePickerFrom2.ValueChanged += dateTimePickerFrom2_ValueChanged;
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
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1382, 734);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Insurance";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // exportButton3
            // 
            exportButton3.BackColor = Color.FromArgb(192, 255, 255);
            exportButton3.ForeColor = SystemColors.ActiveCaptionText;
            exportButton3.Location = new Point(1224, 68);
            exportButton3.Name = "exportButton3";
            exportButton3.Size = new Size(133, 50);
            exportButton3.TabIndex = 12;
            exportButton3.Text = "Export";
            exportButton3.UseVisualStyleBackColor = false;
            exportButton3.Click += exportButton3_Click;
            // 
            // dataGridViewInsurance
            // 
            dataGridViewInsurance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInsurance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInsurance.Dock = DockStyle.Bottom;
            dataGridViewInsurance.Location = new Point(3, 126);
            dataGridViewInsurance.Name = "dataGridViewInsurance";
            dataGridViewInsurance.RowHeadersWidth = 82;
            dataGridViewInsurance.Size = new Size(1376, 605);
            dataGridViewInsurance.TabIndex = 11;
            dataGridViewInsurance.CellContentDoubleClick += dataGridViewInsurance_CellContentDoubleClick;
            dataGridViewInsurance.CellFormatting += dataGridViewInsurance_CellFormatting;
            // 
            // daysButton3
            // 
            daysButton3.Location = new Point(675, 12);
            daysButton3.Name = "daysButton3";
            daysButton3.Size = new Size(219, 49);
            daysButton3.TabIndex = 8;
            daysButton3.Text = "Last 7 days";
            daysButton3.UseVisualStyleBackColor = true;
            daysButton3.Click += daysButton3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(900, 12);
            button5.Name = "button5";
            button5.Size = new Size(203, 48);
            button5.TabIndex = 9;
            button5.Text = "This Month";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // quarterButton3
            // 
            quarterButton3.Location = new Point(1109, 13);
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
            label3.Size = new Size(17, 12);
            label3.TabIndex = 7;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 8F);
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(31, 12);
            label4.TabIndex = 6;
            label4.Text = "From";
            // 
            // dateTimePickerTo3
            // 
            dateTimePickerTo3.Format = DateTimePickerFormat.Short;
            dateTimePickerTo3.Location = new Point(401, 32);
            dateTimePickerTo3.Name = "dateTimePickerTo3";
            dateTimePickerTo3.Size = new Size(253, 26);
            dateTimePickerTo3.TabIndex = 5;
            // 
            // dateTimePickerFrom3
            // 
            dateTimePickerFrom3.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom3.Location = new Point(75, 32);
            dateTimePickerFrom3.Name = "dateTimePickerFrom3";
            dateTimePickerFrom3.Size = new Size(265, 26);
            dateTimePickerFrom3.TabIndex = 4;
            // 
            // lblCurrentPatient
            // 
            lblCurrentPatient.AutoSize = true;
            lblCurrentPatient.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPatient.ForeColor = SystemColors.ControlLightLight;
            lblCurrentPatient.Location = new Point(181, 806);
            lblCurrentPatient.Name = "lblCurrentPatient";
            lblCurrentPatient.Size = new Size(111, 14);
            lblCurrentPatient.TabIndex = 22;
            lblCurrentPatient.Text = "Patient Not Selected";
            lblCurrentPatient.Click += lblCurrentPatient_Click;
            // 
            // currentlbl
            // 
            currentlbl.AutoSize = true;
            currentlbl.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentlbl.ForeColor = SystemColors.ControlLightLight;
            currentlbl.Location = new Point(91, 806);
            currentlbl.Name = "currentlbl";
            currentlbl.Size = new Size(91, 14);
            currentlbl.TabIndex = 21;
            currentlbl.Text = "Current Patient:";
            currentlbl.Click += currentlbl_Click;
            // 
            // btnLoadPatient
            // 
            btnLoadPatient.ForeColor = SystemColors.ActiveCaptionText;
            btnLoadPatient.Location = new Point(143, 824);
            btnLoadPatient.Name = "btnLoadPatient";
            btnLoadPatient.Size = new Size(132, 26);
            btnLoadPatient.TabIndex = 20;
            btnLoadPatient.Text = "Load Patient";
            btnLoadPatient.UseVisualStyleBackColor = true;
            btnLoadPatient.Click += btnLoadPatient_Click;
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new Point(12, 825);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(100, 26);
            txtPatientId.TabIndex = 18;
            // 
            // patientIDlbl
            // 
            patientIDlbl.AutoSize = true;
            patientIDlbl.ForeColor = SystemColors.ControlLightLight;
            patientIDlbl.Location = new Point(1, 803);
            patientIDlbl.Name = "patientIDlbl";
            patientIDlbl.Size = new Size(77, 19);
            patientIDlbl.TabIndex = 19;
            patientIDlbl.Text = "Patient ID";
            // 
            // ReportBill
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1704, 975);
            Controls.Add(lblCurrentPatient);
            Controls.Add(tabControl1);
            Controls.Add(currentlbl);
            Controls.Add(lblSearch);
            Controls.Add(btnLoadPatient);
            Controls.Add(lblReportBill);
            Controls.Add(patientIDlbl);
            Controls.Add(lblPrescriptions);
            Controls.Add(txtPatientId);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report/Bill";
            Load += ReportBill_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancial).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInsurance).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dataGridViewFinancial;
        private DataGridView dataGridViewInsurance;
        private Button btnExportFinancial;
        private Button exportButton2;
        private Button exportButton3;
        private Label lblCurrentPatient;
        private Label currentlbl;
        private Button btnLoadPatient;
        private TextBox txtPatientId;
        private Label patientIDlbl;
        private Label patientHistorylbl;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvAppointments;
        private DataGridView dgvPrescriptions;
        private DataGridView dgvNotes;
        private GroupBox groupBox1;
        private Label lblAllergiestxt;
        private Label lblHistorytxt;
        private Label lblAllergies;
        private Label lblHistory;
    }
}