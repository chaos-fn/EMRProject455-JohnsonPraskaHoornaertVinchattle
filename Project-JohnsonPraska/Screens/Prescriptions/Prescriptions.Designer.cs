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
            groupBox1 = new GroupBox();
            buttonAddRx = new Button();
            numericUpDownQuantity = new NumericUpDown();
            pescriptionComposelbl = new Label();
            quantitylbl = new Label();
            drugNameTextBox = new TextBox();
            textBoxInstruction = new TextBox();
            drugNamelbl = new Label();
            instructionslbl = new Label();
            numericUpDownDose = new NumericUpDown();
            doselbl = new Label();
            comboBoxFrequency = new ComboBox();
            comboBoxDoseUnit = new ComboBox();
            frequencylbl = new Label();
            routelbl = new Label();
            comboBoxRoute = new ComboBox();
            patientLoadBox = new GroupBox();
            btnLoadPatient = new Button();
            txtPatientId = new TextBox();
            patientIDlbl = new Label();
            lblCurrentPatient = new Label();
            currentlbl = new Label();
            buttonDeleteRx = new Button();
            listViewHistory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDose).BeginInit();
            patientLoadBox.SuspendLayout();
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
            lblMore.Location = new Point(1058, 778);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(481, 150);
            lblMore.TabIndex = 82;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPG
            // 
            lblPG.BackColor = Color.FromArgb(30, 76, 99);
            lblPG.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPG.ForeColor = Color.White;
            lblPG.Location = new Point(420, 778);
            lblPG.Name = "lblPG";
            lblPG.Size = new Size(652, 150);
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
            lblHome.Location = new Point(0, 784);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(458, 150);
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
            splitter1.Size = new Size(3, 905);
            splitter1.TabIndex = 88;
            splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(314, 99);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(patientLoadBox);
            splitContainer1.Panel1.ForeColor = SystemColors.Control;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonDeleteRx);
            splitContainer1.Panel2.Controls.Add(listViewHistory);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1189, 682);
            splitContainer1.SplitterDistance = 394;
            splitContainer1.TabIndex = 89;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddRx);
            groupBox1.Controls.Add(numericUpDownQuantity);
            groupBox1.Controls.Add(pescriptionComposelbl);
            groupBox1.Controls.Add(quantitylbl);
            groupBox1.Controls.Add(drugNameTextBox);
            groupBox1.Controls.Add(textBoxInstruction);
            groupBox1.Controls.Add(drugNamelbl);
            groupBox1.Controls.Add(instructionslbl);
            groupBox1.Controls.Add(numericUpDownDose);
            groupBox1.Controls.Add(doselbl);
            groupBox1.Controls.Add(comboBoxFrequency);
            groupBox1.Controls.Add(comboBoxDoseUnit);
            groupBox1.Controls.Add(frequencylbl);
            groupBox1.Controls.Add(routelbl);
            groupBox1.Controls.Add(comboBoxRoute);
            groupBox1.Location = new Point(22, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 558);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // buttonAddRx
            // 
            buttonAddRx.BackColor = Color.DarkSlateGray;
            buttonAddRx.Location = new Point(74, 478);
            buttonAddRx.Name = "buttonAddRx";
            buttonAddRx.Size = new Size(207, 72);
            buttonAddRx.TabIndex = 10;
            buttonAddRx.Text = "Send To Pharmacy";
            buttonAddRx.UseVisualStyleBackColor = false;
            buttonAddRx.Click += buttonSendRx_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(14, 219);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(133, 26);
            numericUpDownQuantity.TabIndex = 19;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pescriptionComposelbl
            // 
            pescriptionComposelbl.AutoSize = true;
            pescriptionComposelbl.Font = new Font("Cambria", 14F, FontStyle.Bold);
            pescriptionComposelbl.ForeColor = SystemColors.ControlLightLight;
            pescriptionComposelbl.Location = new Point(68, 0);
            pescriptionComposelbl.Name = "pescriptionComposelbl";
            pescriptionComposelbl.Size = new Size(213, 22);
            pescriptionComposelbl.TabIndex = 0;
            pescriptionComposelbl.Text = "Perscription Composer";
            // 
            // quantitylbl
            // 
            quantitylbl.AutoSize = true;
            quantitylbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantitylbl.ForeColor = SystemColors.ControlLightLight;
            quantitylbl.Location = new Point(5, 191);
            quantitylbl.Name = "quantitylbl";
            quantitylbl.Size = new Size(96, 25);
            quantitylbl.TabIndex = 18;
            quantitylbl.Text = "Quantity ";
            // 
            // drugNameTextBox
            // 
            drugNameTextBox.Location = new Point(14, 78);
            drugNameTextBox.Name = "drugNameTextBox";
            drugNameTextBox.Size = new Size(330, 26);
            drugNameTextBox.TabIndex = 1;
            drugNameTextBox.TextChanged += drugNameTextBox_TextChanged;
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.Location = new Point(16, 445);
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.Size = new Size(331, 26);
            textBoxInstruction.TabIndex = 12;
            textBoxInstruction.TextChanged += textBoxInstruction_TextChanged;
            // 
            // drugNamelbl
            // 
            drugNamelbl.AutoSize = true;
            drugNamelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drugNamelbl.ForeColor = SystemColors.ButtonHighlight;
            drugNamelbl.Location = new Point(-2, 37);
            drugNamelbl.Name = "drugNamelbl";
            drugNamelbl.Size = new Size(113, 25);
            drugNamelbl.TabIndex = 2;
            drugNamelbl.Text = "Drug Name";
            // 
            // instructionslbl
            // 
            instructionslbl.AutoSize = true;
            instructionslbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionslbl.ForeColor = SystemColors.ControlLightLight;
            instructionslbl.Location = new Point(0, 417);
            instructionslbl.Name = "instructionslbl";
            instructionslbl.Size = new Size(122, 25);
            instructionslbl.TabIndex = 11;
            instructionslbl.Text = "Instructions";
            instructionslbl.Click += instructionslbl_Click;
            // 
            // numericUpDownDose
            // 
            numericUpDownDose.Location = new Point(14, 146);
            numericUpDownDose.Name = "numericUpDownDose";
            numericUpDownDose.Size = new Size(133, 26);
            numericUpDownDose.TabIndex = 3;
            numericUpDownDose.ValueChanged += numericUpDownDose_ValueChanged;
            // 
            // doselbl
            // 
            doselbl.AutoSize = true;
            doselbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doselbl.ForeColor = SystemColors.ControlLightLight;
            doselbl.Location = new Point(-2, 117);
            doselbl.Name = "doselbl";
            doselbl.Size = new Size(133, 25);
            doselbl.TabIndex = 4;
            doselbl.Text = "Dose Amount";
            // 
            // comboBoxFrequency
            // 
            comboBoxFrequency.FormattingEnabled = true;
            comboBoxFrequency.Location = new Point(14, 366);
            comboBoxFrequency.Name = "comboBoxFrequency";
            comboBoxFrequency.Size = new Size(331, 27);
            comboBoxFrequency.TabIndex = 9;
            comboBoxFrequency.SelectedIndexChanged += comboBoxFrequency_SelectedIndexChanged;
            // 
            // comboBoxDoseUnit
            // 
            comboBoxDoseUnit.FormattingEnabled = true;
            comboBoxDoseUnit.Location = new Point(185, 146);
            comboBoxDoseUnit.Name = "comboBoxDoseUnit";
            comboBoxDoseUnit.Size = new Size(121, 27);
            comboBoxDoseUnit.TabIndex = 5;
            comboBoxDoseUnit.SelectedIndexChanged += comboBoxDoseUnit_SelectedIndexChanged;
            // 
            // frequencylbl
            // 
            frequencylbl.AutoSize = true;
            frequencylbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frequencylbl.ForeColor = SystemColors.ControlLightLight;
            frequencylbl.Location = new Point(-2, 338);
            frequencylbl.Name = "frequencylbl";
            frequencylbl.Size = new Size(107, 25);
            frequencylbl.TabIndex = 8;
            frequencylbl.Text = "Frequency";
            frequencylbl.Click += frequencylbl_Click;
            // 
            // routelbl
            // 
            routelbl.AutoSize = true;
            routelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            routelbl.ForeColor = SystemColors.ControlLightLight;
            routelbl.Location = new Point(-2, 254);
            routelbl.Name = "routelbl";
            routelbl.Size = new Size(65, 25);
            routelbl.TabIndex = 6;
            routelbl.Text = "Route";
            routelbl.Click += routelbl_Click;
            // 
            // comboBoxRoute
            // 
            comboBoxRoute.FormattingEnabled = true;
            comboBoxRoute.Location = new Point(14, 282);
            comboBoxRoute.Name = "comboBoxRoute";
            comboBoxRoute.Size = new Size(331, 27);
            comboBoxRoute.TabIndex = 7;
            comboBoxRoute.SelectedIndexChanged += comboBoxRoute_SelectedIndexChanged;
            // 
            // patientLoadBox
            // 
            patientLoadBox.Controls.Add(btnLoadPatient);
            patientLoadBox.Controls.Add(txtPatientId);
            patientLoadBox.Controls.Add(patientIDlbl);
            patientLoadBox.Controls.Add(lblCurrentPatient);
            patientLoadBox.Controls.Add(currentlbl);
            patientLoadBox.Location = new Point(23, 0);
            patientLoadBox.Name = "patientLoadBox";
            patientLoadBox.Size = new Size(358, 120);
            patientLoadBox.TabIndex = 20;
            patientLoadBox.TabStop = false;
            // 
            // btnLoadPatient
            // 
            btnLoadPatient.ForeColor = SystemColors.ActiveCaptionText;
            btnLoadPatient.Location = new Point(148, 50);
            btnLoadPatient.Name = "btnLoadPatient";
            btnLoadPatient.Size = new Size(132, 26);
            btnLoadPatient.TabIndex = 15;
            btnLoadPatient.Text = "Load Patient";
            btnLoadPatient.UseVisualStyleBackColor = true;
            btnLoadPatient.Click += btnLoadPatient_Click;
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new Point(17, 50);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(100, 26);
            txtPatientId.TabIndex = 13;
            // 
            // patientIDlbl
            // 
            patientIDlbl.AutoSize = true;
            patientIDlbl.Location = new Point(17, 28);
            patientIDlbl.Name = "patientIDlbl";
            patientIDlbl.Size = new Size(77, 19);
            patientIDlbl.TabIndex = 14;
            patientIDlbl.Text = "Patient ID";
            // 
            // lblCurrentPatient
            // 
            lblCurrentPatient.AutoSize = true;
            lblCurrentPatient.Location = new Point(148, 90);
            lblCurrentPatient.Name = "lblCurrentPatient";
            lblCurrentPatient.Size = new Size(147, 19);
            lblCurrentPatient.TabIndex = 17;
            lblCurrentPatient.Text = "Patient Not Selected";
            // 
            // currentlbl
            // 
            currentlbl.AutoSize = true;
            currentlbl.Location = new Point(14, 90);
            currentlbl.Name = "currentlbl";
            currentlbl.Size = new Size(119, 19);
            currentlbl.TabIndex = 16;
            currentlbl.Text = "Current Patient:";
            // 
            // buttonDeleteRx
            // 
            buttonDeleteRx.Enabled = false;
            buttonDeleteRx.Location = new Point(346, 647);
            buttonDeleteRx.Name = "buttonDeleteRx";
            buttonDeleteRx.Size = new Size(81, 29);
            buttonDeleteRx.TabIndex = 90;
            buttonDeleteRx.Text = "Delete Rx";
            buttonDeleteRx.UseVisualStyleBackColor = true;
            buttonDeleteRx.Click += buttonDeleteRx_Click;
            // 
            // listViewHistory
            // 
            listViewHistory.AutoArrange = false;
            listViewHistory.BackColor = Color.FromArgb(64, 64, 64);
            listViewHistory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader8, columnHeader6, columnHeader7 });
            listViewHistory.Dock = DockStyle.Top;
            listViewHistory.ForeColor = SystemColors.Window;
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
            listViewHistory.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewHistory.Location = new Point(0, 0);
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(791, 644);
            listViewHistory.TabIndex = 0;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            listViewHistory.SelectedIndexChanged += listViewHistory_SelectedIndexChanged;
            listViewHistory.MouseDoubleClick += listViewHistory_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Drug Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dose";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 4;
            columnHeader4.Text = "Filled";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 5;
            columnHeader5.Text = "Route";
            // 
            // columnHeader8
            // 
            columnHeader8.DisplayIndex = 3;
            columnHeader8.Text = "Quantity";
            columnHeader8.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Frequency";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Instructions";
            columnHeader7.Width = 250;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Prescriptions
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1506, 905);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prescriptions";
            Load += Prescriptions_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDose).EndInit();
            patientLoadBox.ResumeLayout(false);
            patientLoadBox.PerformLayout();
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
        private Button buttonAddRx;
        private ListView listViewHistory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ErrorProvider errorProvider1;
        private TextBox textBoxInstruction;
        private Label instructionslbl;
        private TextBox txtPatientId;
        private Label patientIDlbl;
        private Label lblCurrentPatient;
        private Label currentlbl;
        private Button btnLoadPatient;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private NumericUpDown numericUpDownQuantity;
        private Label quantitylbl;
        private ColumnHeader columnHeader8;
        private Button buttonDeleteRx;
        private GroupBox patientLoadBox;
        private GroupBox groupBox1;
    }
}