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
            numericUpDownQuantity = new NumericUpDown();
            quantitylbl = new Label();
            lblCurrentPatient = new Label();
            currentlbl = new Label();
            btnLoadPatient = new Button();
            patientIDlbl = new Label();
            txtPatientId = new TextBox();
            textBoxInstruction = new TextBox();
            instructionslbl = new Label();
            buttonAddRx = new Button();
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
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            errorProvider1 = new ErrorProvider(components);
            buttonDeleteRx = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
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
            lblMore.Location = new Point(1058, 784);
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
            lblPG.Location = new Point(494, 784);
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
            lblHome.Location = new Point(0, 784);
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
            splitter1.Size = new Size(3, 881);
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
            splitContainer1.Panel1.Controls.Add(numericUpDownQuantity);
            splitContainer1.Panel1.Controls.Add(quantitylbl);
            splitContainer1.Panel1.Controls.Add(lblCurrentPatient);
            splitContainer1.Panel1.Controls.Add(currentlbl);
            splitContainer1.Panel1.Controls.Add(btnLoadPatient);
            splitContainer1.Panel1.Controls.Add(patientIDlbl);
            splitContainer1.Panel1.Controls.Add(txtPatientId);
            splitContainer1.Panel1.Controls.Add(textBoxInstruction);
            splitContainer1.Panel1.Controls.Add(instructionslbl);
            splitContainer1.Panel1.Controls.Add(buttonAddRx);
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
            splitContainer1.Size = new Size(1118, 682);
            splitContainer1.SplitterDistance = 371;
            splitContainer1.TabIndex = 89;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(38, 339);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(133, 26);
            numericUpDownQuantity.TabIndex = 19;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // quantitylbl
            // 
            quantitylbl.AutoSize = true;
            quantitylbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantitylbl.ForeColor = SystemColors.ControlLightLight;
            quantitylbl.Location = new Point(29, 311);
            quantitylbl.Name = "quantitylbl";
            quantitylbl.Size = new Size(96, 25);
            quantitylbl.TabIndex = 18;
            quantitylbl.Text = "Quantity ";
            // 
            // lblCurrentPatient
            // 
            lblCurrentPatient.AutoSize = true;
            lblCurrentPatient.Location = new Point(154, 86);
            lblCurrentPatient.Name = "lblCurrentPatient";
            lblCurrentPatient.Size = new Size(147, 19);
            lblCurrentPatient.TabIndex = 17;
            lblCurrentPatient.Text = "Patient Not Selected";
            // 
            // currentlbl
            // 
            currentlbl.AutoSize = true;
            currentlbl.Location = new Point(29, 86);
            currentlbl.Name = "currentlbl";
            currentlbl.Size = new Size(119, 19);
            currentlbl.TabIndex = 16;
            currentlbl.Text = "Current Patient:";
            // 
            // btnLoadPatient
            // 
            btnLoadPatient.ForeColor = SystemColors.ActiveCaptionText;
            btnLoadPatient.Location = new Point(160, 36);
            btnLoadPatient.Name = "btnLoadPatient";
            btnLoadPatient.Size = new Size(132, 26);
            btnLoadPatient.TabIndex = 15;
            btnLoadPatient.Text = "Load Patient";
            btnLoadPatient.UseVisualStyleBackColor = true;
            btnLoadPatient.Click += btnLoadPatient_Click;
            // 
            // patientIDlbl
            // 
            patientIDlbl.AutoSize = true;
            patientIDlbl.Location = new Point(29, 14);
            patientIDlbl.Name = "patientIDlbl";
            patientIDlbl.Size = new Size(77, 19);
            patientIDlbl.TabIndex = 14;
            patientIDlbl.Text = "Patient ID";
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new Point(29, 36);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(100, 26);
            txtPatientId.TabIndex = 13;
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.Location = new Point(38, 572);
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.Size = new Size(331, 26);
            textBoxInstruction.TabIndex = 12;
            textBoxInstruction.TextChanged += textBoxInstruction_TextChanged;
            // 
            // instructionslbl
            // 
            instructionslbl.AutoSize = true;
            instructionslbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionslbl.ForeColor = SystemColors.ControlLightLight;
            instructionslbl.Location = new Point(22, 544);
            instructionslbl.Name = "instructionslbl";
            instructionslbl.Size = new Size(122, 25);
            instructionslbl.TabIndex = 11;
            instructionslbl.Text = "Instructions";
            instructionslbl.Click += instructionslbl_Click;
            // 
            // buttonAddRx
            // 
            buttonAddRx.BackColor = Color.DarkSlateGray;
            buttonAddRx.Location = new Point(85, 604);
            buttonAddRx.Name = "buttonAddRx";
            buttonAddRx.Size = new Size(207, 72);
            buttonAddRx.TabIndex = 10;
            buttonAddRx.Text = "Send To Pharmacy";
            buttonAddRx.UseVisualStyleBackColor = false;
            buttonAddRx.Click += buttonSendRx_Click;
            // 
            // comboBoxFrequency
            // 
            comboBoxFrequency.FormattingEnabled = true;
            comboBoxFrequency.Location = new Point(38, 486);
            comboBoxFrequency.Name = "comboBoxFrequency";
            comboBoxFrequency.Size = new Size(331, 27);
            comboBoxFrequency.TabIndex = 9;
            comboBoxFrequency.SelectedIndexChanged += comboBoxFrequency_SelectedIndexChanged;
            // 
            // frequencylbl
            // 
            frequencylbl.AutoSize = true;
            frequencylbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frequencylbl.ForeColor = SystemColors.ControlLightLight;
            frequencylbl.Location = new Point(22, 458);
            frequencylbl.Name = "frequencylbl";
            frequencylbl.Size = new Size(107, 25);
            frequencylbl.TabIndex = 8;
            frequencylbl.Text = "Frequency";
            frequencylbl.Click += frequencylbl_Click;
            // 
            // comboBoxRoute
            // 
            comboBoxRoute.FormattingEnabled = true;
            comboBoxRoute.Location = new Point(38, 402);
            comboBoxRoute.Name = "comboBoxRoute";
            comboBoxRoute.Size = new Size(331, 27);
            comboBoxRoute.TabIndex = 7;
            comboBoxRoute.SelectedIndexChanged += comboBoxRoute_SelectedIndexChanged;
            // 
            // routelbl
            // 
            routelbl.AutoSize = true;
            routelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            routelbl.ForeColor = SystemColors.ControlLightLight;
            routelbl.Location = new Point(22, 374);
            routelbl.Name = "routelbl";
            routelbl.Size = new Size(65, 25);
            routelbl.TabIndex = 6;
            routelbl.Text = "Route";
            routelbl.Click += routelbl_Click;
            // 
            // comboBoxDoseUnit
            // 
            comboBoxDoseUnit.FormattingEnabled = true;
            comboBoxDoseUnit.Location = new Point(209, 266);
            comboBoxDoseUnit.Name = "comboBoxDoseUnit";
            comboBoxDoseUnit.Size = new Size(121, 27);
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
            doselbl.Size = new Size(133, 25);
            doselbl.TabIndex = 4;
            doselbl.Text = "Dose Amount";
            // 
            // numericUpDownDose
            // 
            numericUpDownDose.Location = new Point(38, 266);
            numericUpDownDose.Name = "numericUpDownDose";
            numericUpDownDose.Size = new Size(133, 26);
            numericUpDownDose.TabIndex = 3;
            numericUpDownDose.ValueChanged += numericUpDownDose_ValueChanged;
            // 
            // drugNamelbl
            // 
            drugNamelbl.AutoSize = true;
            drugNamelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drugNamelbl.ForeColor = SystemColors.ButtonHighlight;
            drugNamelbl.Location = new Point(22, 157);
            drugNamelbl.Name = "drugNamelbl";
            drugNamelbl.Size = new Size(113, 25);
            drugNamelbl.TabIndex = 2;
            drugNamelbl.Text = "Drug Name";
            // 
            // drugNameTextBox
            // 
            drugNameTextBox.Location = new Point(38, 198);
            drugNameTextBox.Name = "drugNameTextBox";
            drugNameTextBox.Size = new Size(330, 26);
            drugNameTextBox.TabIndex = 1;
            drugNameTextBox.TextChanged += drugNameTextBox_TextChanged;
            // 
            // pescriptionComposelbl
            // 
            pescriptionComposelbl.AutoSize = true;
            pescriptionComposelbl.Font = new Font("Cambria", 14F, FontStyle.Bold);
            pescriptionComposelbl.ForeColor = SystemColors.ControlLightLight;
            pescriptionComposelbl.Location = new Point(106, 120);
            pescriptionComposelbl.Name = "pescriptionComposelbl";
            pescriptionComposelbl.Size = new Size(213, 22);
            pescriptionComposelbl.TabIndex = 0;
            pescriptionComposelbl.Text = "Perscription Composer";
            // 
            // listViewHistory
            // 
            listViewHistory.AutoArrange = false;
            listViewHistory.BackColor = Color.FromArgb(64, 64, 64);
            listViewHistory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader8, columnHeader6, columnHeader7 });
            listViewHistory.Dock = DockStyle.Fill;
            listViewHistory.ForeColor = SystemColors.Window;
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
            listViewHistory.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewHistory.Location = new Point(0, 0);
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(743, 682);
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
            // buttonDeleteRx
            // 
            buttonDeleteRx.Enabled = false;
            buttonDeleteRx.Location = new Point(1281, 784);
            buttonDeleteRx.Name = "buttonDeleteRx";
            buttonDeleteRx.Size = new Size(81, 29);
            buttonDeleteRx.TabIndex = 90;
            buttonDeleteRx.Text = "Delete Rx";
            buttonDeleteRx.UseVisualStyleBackColor = true;
            buttonDeleteRx.Click += buttonDeleteRx_Click;
            // 
            // Prescriptions
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1444, 881);
            Controls.Add(buttonDeleteRx);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
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
    }
}