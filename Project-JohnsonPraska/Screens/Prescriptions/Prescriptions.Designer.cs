namespace Project_JohnsonPraska
{
    partial class Prescriptions
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            lblSearch = new Label();
            lblReportBill = new Label();
            lblPrescriptions = new Label();
            lblAppoint = new Label();
            lblPatientProfile = new Label();
            lblMore = new Label();
            lblPG = new Label();
            lblHome = new Label();
            lblLeftMain = new Label();
            splitter1 = new Splitter();
            splitContainer1 = new SplitContainer();
            buttonSendRx = new Button();
            comboBoxFrequency = new ComboBox();
            frequencylbl = new Label();
            comboBoxRoute = new ComboBox();
            routelbl = new Label();
            comboBoxDoseUnit = new ComboBox();
            doselbl = new Label();
            numericUpDownDose = new NumericUpDown();
            drugNamelbl = new Label();
            drugNameTextBox = new TextBox();
            pescriptionComposelbl = new Label();
            listViewHistory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.BorderStyle = BorderStyle.Fixed3D;
            lblSearch.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(0, 655);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(307, 129);
            lblSearch.TabIndex = 87;
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
            lblReportBill.TabIndex = 86;
            lblReportBill.Text = "Reports/Billing";
            lblReportBill.TextAlign = ContentAlignment.MiddleCenter;
            lblReportBill.Click += lblActivity_Click;
            // 
            // lblPrescriptions
            // 
            lblPrescriptions.BorderStyle = BorderStyle.Fixed3D;
            lblPrescriptions.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline);
            lblPrescriptions.ForeColor = Color.White;
            lblPrescriptions.Location = new Point(1, 388);
            lblPrescriptions.Margin = new Padding(4, 0, 4, 0);
            lblPrescriptions.Name = "lblPrescriptions";
            lblPrescriptions.Size = new Size(306, 137);
            lblPrescriptions.TabIndex = 85;
            lblPrescriptions.Text = "Prescriptions";
            lblPrescriptions.TextAlign = ContentAlignment.MiddleCenter;
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
            lblAppoint.TabIndex = 84;
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
            lblPatientProfile.TabIndex = 83;
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
            lblMore.TabIndex = 82;
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
            lblPG.TabIndex = 81;
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
            lblHome.TabIndex = 80;
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
            lblLeftMain.TabIndex = 79;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 1009);
            splitter1.TabIndex = 88;
            splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(314, 122);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonSendRx);
            splitContainer1.Panel1.Controls.Add(comboBoxFrequency);
            splitContainer1.Panel1.Controls.Add(frequencylbl);
            splitContainer1.Panel1.Controls.Add(comboBoxRoute);
            splitContainer1.Panel1.Controls.Add(routelbl);
            splitContainer1.Panel1.Controls.Add(comboBoxDoseUnit);
            splitContainer1.Panel1.Controls.Add(doselbl);
            splitContainer1.Panel1.Controls.Add(numericUpDownDose);
            splitContainer1.Panel1.Controls.Add(drugNamelbl);
            splitContainer1.Panel1.Controls.Add(drugNameTextBox);
            splitContainer1.Panel1.Controls.Add(pescriptionComposelbl);
            splitContainer1.Panel1.ForeColor = SystemColors.Control;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listViewHistory);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1457, 702);
            splitContainer1.SplitterDistance = 485;
            splitContainer1.TabIndex = 89;
            // 
            // buttonSendRx
            // 
            buttonSendRx.BackColor = Color.DarkSlateGray;
            buttonSendRx.Location = new Point(147, 603);
            buttonSendRx.Name = "buttonSendRx";
            buttonSendRx.Size = new Size(207, 72);
            buttonSendRx.TabIndex = 10;
            buttonSendRx.Text = "Send To Pharmacy";
            buttonSendRx.UseVisualStyleBackColor = false;
            buttonSendRx.Click += buttonSendRx_Click;
            // 
            // comboBoxFrequency
            // 
            comboBoxFrequency.FormattingEnabled = true;
            comboBoxFrequency.Location = new Point(38, 518);
            comboBoxFrequency.Name = "comboBoxFrequency";
            comboBoxFrequency.Size = new Size(366, 45);
            comboBoxFrequency.TabIndex = 9;
            comboBoxFrequency.SelectedIndexChanged += comboBoxFrequency_SelectedIndexChanged;
            // 
            // frequencylbl
            // 
            frequencylbl.AutoSize = true;
            frequencylbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frequencylbl.ForeColor = SystemColors.ControlLightLight;
            frequencylbl.Location = new Point(22, 466);
            frequencylbl.Name = "frequencylbl";
            frequencylbl.Size = new Size(209, 49);
            frequencylbl.TabIndex = 8;
            frequencylbl.Text = "Frequency";
            // 
            // comboBoxRoute
            // 
            comboBoxRoute.FormattingEnabled = true;
            comboBoxRoute.Location = new Point(38, 400);
            comboBoxRoute.Name = "comboBoxRoute";
            comboBoxRoute.Size = new Size(366, 45);
            comboBoxRoute.TabIndex = 7;
            comboBoxRoute.SelectedIndexChanged += comboBoxRoute_SelectedIndexChanged;
            // 
            // routelbl
            // 
            routelbl.AutoSize = true;
            routelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            routelbl.ForeColor = SystemColors.ControlLightLight;
            routelbl.Location = new Point(22, 348);
            routelbl.Name = "routelbl";
            routelbl.Size = new Size(126, 49);
            routelbl.TabIndex = 6;
            routelbl.Text = "Route";
            // 
            // comboBoxDoseUnit
            // 
            comboBoxDoseUnit.FormattingEnabled = true;
            comboBoxDoseUnit.Location = new Point(209, 289);
            comboBoxDoseUnit.Name = "comboBoxDoseUnit";
            comboBoxDoseUnit.Size = new Size(121, 45);
            comboBoxDoseUnit.TabIndex = 5;
            comboBoxDoseUnit.SelectedIndexChanged += comboBoxDoseUnit_SelectedIndexChanged;
            // 
            // doselbl
            // 
            doselbl.AutoSize = true;
            doselbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doselbl.ForeColor = SystemColors.ControlLightLight;
            doselbl.Location = new Point(22, 237);
            doselbl.Name = "doselbl";
            doselbl.Size = new Size(262, 49);
            doselbl.TabIndex = 4;
            doselbl.Text = "Dose Amount";
            // 
            // numericUpDownDose
            // 
            numericUpDownDose.Location = new Point(38, 289);
            numericUpDownDose.Name = "numericUpDownDose";
            numericUpDownDose.Size = new Size(133, 45);
            numericUpDownDose.TabIndex = 3;
            numericUpDownDose.ValueChanged += numericUpDownDose_ValueChanged;
            // 
            // drugNamelbl
            // 
            drugNamelbl.AutoSize = true;
            drugNamelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drugNamelbl.ForeColor = SystemColors.ButtonHighlight;
            drugNamelbl.Location = new Point(22, 104);
            drugNamelbl.Name = "drugNamelbl";
            drugNamelbl.Size = new Size(225, 49);
            drugNamelbl.TabIndex = 2;
            drugNamelbl.Text = "Drug Name";
            // 
            // drugNameTextBox
            // 
            drugNameTextBox.Location = new Point(38, 156);
            drugNameTextBox.Name = "drugNameTextBox";
            drugNameTextBox.Size = new Size(408, 45);
            drugNameTextBox.TabIndex = 1;
            drugNameTextBox.TextChanged += drugNameTextBox_TextChanged;
            // 
            // pescriptionComposelbl
            // 
            pescriptionComposelbl.AutoSize = true;
            pescriptionComposelbl.Font = new Font("Cambria", 14F, FontStyle.Bold);
            pescriptionComposelbl.ForeColor = SystemColors.ControlLightLight;
            pescriptionComposelbl.Location = new Point(22, 13);
            pescriptionComposelbl.Name = "pescriptionComposelbl";
            pescriptionComposelbl.Size = new Size(424, 44);
            pescriptionComposelbl.TabIndex = 0;
            pescriptionComposelbl.Text = "Perscription Composer";
            // 
            // listViewHistory
            // 
            listViewHistory.BackColor = Color.FromArgb(64, 64, 64);
            listViewHistory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewHistory.Dock = DockStyle.Fill;
            listViewHistory.ForeColor = SystemColors.Window;
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
            listViewHistory.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewHistory.Location = new Point(0, 0);
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(968, 702);
            listViewHistory.TabIndex = 0;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            listViewHistory.SelectedIndexChanged += listViewHistory_SelectedIndexChanged;
            listViewHistory.MouseDoubleClick += listViewHistory_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Drug";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dose";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Status";
            columnHeader4.Width = 100;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Prescriptions
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1894, 1009);
            Controls.Add(splitContainer1);
            Controls.Add(splitter1);
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
            Name = "Prescriptions";
            Text = "Prescriptions";
            Load += Prescriptions_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownDose).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Splitter splitter1;
        private SplitContainer splitContainer1;
        private Label pescriptionComposelbl;
        private Label drugNamelbl;
        private TextBox drugNameTextBox;
        private ComboBox comboBoxDoseUnit;
        private Label doselbl;
        private NumericUpDown numericUpDownDose;
        private ComboBox comboBoxRoute;
        private Label routelbl;
        private ComboBox comboBoxFrequency;
        private Label frequencylbl;
        private Button buttonSendRx;
        private ListView listViewHistory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ErrorProvider errorProvider1;
    }
}