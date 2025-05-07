
namespace Project_JohnsonPraska
{
    partial class Search
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
            lblSearch = new Label();
            lblReportBill = new Label();
            lblPrescriptions = new Label();
            lblAppoint = new Label();
            lblPatientProfile = new Label();
            lblMore = new Label();
            lblPG = new Label();
            lblHome = new Label();
            lblLeftMain = new Label();
            lblPatientSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblPatientInfo = new Label();
            lblFilter = new Label();
            btnFilterName = new Button();
            btnFilterAge = new Button();
            btnFilterRoom = new Button();
            dataPatients = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            btnAddPatient = new Button();
            lblInstructions = new Label();
            ((System.ComponentModel.ISupportInitialize)dataPatients).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.BorderStyle = BorderStyle.Fixed3D;
            lblSearch.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(0, 652);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(300, 139);
            lblSearch.TabIndex = 119;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReportBill
            // 
            lblReportBill.BorderStyle = BorderStyle.Fixed3D;
            lblReportBill.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblReportBill.ForeColor = Color.White;
            lblReportBill.Location = new Point(0, 513);
            lblReportBill.Margin = new Padding(4, 0, 4, 0);
            lblReportBill.Name = "lblReportBill";
            lblReportBill.Size = new Size(300, 139);
            lblReportBill.TabIndex = 118;
            lblReportBill.Text = "Reports/Billing";
            lblReportBill.TextAlign = ContentAlignment.MiddleCenter;
            lblReportBill.Click += lblActivity_Click;
            // 
            // lblPrescriptions
            // 
            lblPrescriptions.BorderStyle = BorderStyle.Fixed3D;
            lblPrescriptions.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPrescriptions.ForeColor = Color.White;
            lblPrescriptions.Location = new Point(0, 374);
            lblPrescriptions.Margin = new Padding(4, 0, 4, 0);
            lblPrescriptions.Name = "lblPrescriptions";
            lblPrescriptions.Size = new Size(300, 139);
            lblPrescriptions.TabIndex = 117;
            lblPrescriptions.Text = "Prescriptions";
            lblPrescriptions.TextAlign = ContentAlignment.MiddleCenter;
            lblPrescriptions.Click += lblDrivers_Click;
            // 
            // lblAppoint
            // 
            lblAppoint.BorderStyle = BorderStyle.Fixed3D;
            lblAppoint.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblAppoint.ForeColor = Color.White;
            lblAppoint.Location = new Point(0, 235);
            lblAppoint.Margin = new Padding(4, 0, 4, 0);
            lblAppoint.Name = "lblAppoint";
            lblAppoint.Size = new Size(300, 139);
            lblAppoint.TabIndex = 116;
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
            lblPatientProfile.Name = "lblPatientProfile";
            lblPatientProfile.Size = new Size(300, 139);
            lblPatientProfile.TabIndex = 115;
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
            lblMore.Location = new Point(1016, 791);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(508, 122);
            lblMore.TabIndex = 114;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPG
            // 
            lblPG.BackColor = Color.FromArgb(30, 76, 99);
            lblPG.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblPG.ForeColor = Color.White;
            lblPG.Location = new Point(508, 791);
            lblPG.Name = "lblPG";
            lblPG.Size = new Size(508, 122);
            lblPG.TabIndex = 113;
            lblPG.Text = "Patient Registration";
            lblPG.TextAlign = ContentAlignment.MiddleCenter;
            lblPG.Click += lblMap_Click;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 791);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(508, 122);
            lblHome.TabIndex = 112;
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
            lblLeftMain.TabIndex = 111;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPatientSearch
            // 
            lblPatientSearch.Font = new Font("Cambria", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientSearch.ForeColor = SystemColors.ControlLightLight;
            lblPatientSearch.Location = new Point(350, 150);
            lblPatientSearch.Name = "lblPatientSearch";
            lblPatientSearch.Size = new Size(250, 50);
            lblPatientSearch.TabIndex = 120;
            lblPatientSearch.Text = "Patient Search";
            lblPatientSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(350, 241);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 30);
            txtSearch.TabIndex = 121;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(401, 288);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 40);
            btnSearch.TabIndex = 122;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.Font = new Font("Cambria", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientInfo.ForeColor = SystemColors.ControlLightLight;
            lblPatientInfo.Location = new Point(685, 150);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new Size(400, 50);
            lblPatientInfo.TabIndex = 123;
            lblPatientInfo.Text = "Patient Information";
            lblPatientInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblPatientInfo.Visible = false;
            // 
            // lblFilter
            // 
            lblFilter.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = SystemColors.ControlLightLight;
            lblFilter.Location = new Point(700, 229);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(100, 50);
            lblFilter.TabIndex = 124;
            lblFilter.Text = "Filter By:";
            lblFilter.TextAlign = ContentAlignment.MiddleLeft;
            lblFilter.Visible = false;
            // 
            // btnFilterName
            // 
            btnFilterName.BackColor = Color.White;
            btnFilterName.FlatAppearance.BorderColor = Color.FromArgb(30, 76, 99);
            btnFilterName.FlatAppearance.BorderSize = 2;
            btnFilterName.FlatStyle = FlatStyle.Flat;
            btnFilterName.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterName.Location = new Point(801, 237);
            btnFilterName.Name = "btnFilterName";
            btnFilterName.Size = new Size(100, 35);
            btnFilterName.TabIndex = 125;
            btnFilterName.Text = "Name";
            btnFilterName.UseVisualStyleBackColor = false;
            btnFilterName.Click += btnFilterName_Click;
            // 
            // btnFilterAge
            // 
            btnFilterAge.BackColor = Color.White;
            btnFilterAge.FlatAppearance.BorderColor = Color.FromArgb(30, 76, 99);
            btnFilterAge.FlatAppearance.BorderSize = 2;
            btnFilterAge.FlatStyle = FlatStyle.Flat;
            btnFilterAge.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterAge.Location = new Point(925, 237);
            btnFilterAge.Name = "btnFilterAge";
            btnFilterAge.Size = new Size(100, 35);
            btnFilterAge.TabIndex = 126;
            btnFilterAge.Text = "Age";
            btnFilterAge.UseVisualStyleBackColor = false;
            btnFilterAge.Click += btnFilterAge_Click;
            // 
            // btnFilterRoom
            // 
            btnFilterRoom.BackColor = Color.White;
            btnFilterRoom.FlatAppearance.BorderColor = Color.FromArgb(30, 76, 99);
            btnFilterRoom.FlatAppearance.BorderSize = 2;
            btnFilterRoom.FlatStyle = FlatStyle.Flat;
            btnFilterRoom.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterRoom.Location = new Point(1049, 237);
            btnFilterRoom.Name = "btnFilterRoom";
            btnFilterRoom.Size = new Size(100, 35);
            btnFilterRoom.TabIndex = 127;
            btnFilterRoom.Text = "Room";
            btnFilterRoom.UseVisualStyleBackColor = false;
            btnFilterRoom.Click += btnFilterRoom_Click;
            // 
            // dataPatients
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 76, 99);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPatients.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPatients.Columns.AddRange(new DataGridViewColumn[] { ID, PatientName, Age, Room, View });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 76, 99);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataPatients.DefaultCellStyle = dataGridViewCellStyle2;
            dataPatients.Location = new Point(700, 300);
            dataPatients.Name = "dataPatients";
            dataPatients.ReadOnly = true;
            dataPatients.ScrollBars = ScrollBars.Vertical;
            dataPatients.Size = new Size(700, 400);
            dataPatients.TabIndex = 129;
            dataPatients.CellContentClick += dataPatients_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 21.2535515F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 100;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // PatientName
            // 
            PatientName.FillWeight = 216.404663F;
            PatientName.HeaderText = "Name";
            PatientName.MinimumWidth = 250;
            PatientName.Name = "PatientName";
            PatientName.ReadOnly = true;
            // 
            // Age
            // 
            Age.FillWeight = 20.8550453F;
            Age.HeaderText = "Age";
            Age.MinimumWidth = 100;
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Room
            // 
            Room.FillWeight = 20.8550453F;
            Room.HeaderText = "Room";
            Room.MinimumWidth = 100;
            Room.Name = "Room";
            Room.ReadOnly = true;
            // 
            // View
            // 
            View.FillWeight = 20.8550453F;
            View.HeaderText = "View";
            View.MinimumWidth = 50;
            View.Name = "View";
            View.ReadOnly = true;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.White;
            btnAddPatient.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.Location = new Point(1200, 232);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(200, 45);
            btnAddPatient.TabIndex = 130;
            btnAddPatient.Text = "Add New Patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.Font = new Font("Cambria", 12F);
            lblInstructions.ForeColor = SystemColors.ControlLightLight;
            lblInstructions.Location = new Point(350, 218);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(250, 25);
            lblInstructions.TabIndex = 131;
            lblInstructions.Text = "Enter Patient's First Name";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1508, 913);
            Controls.Add(lblInstructions);
            Controls.Add(btnAddPatient);
            Controls.Add(dataPatients);
            Controls.Add(btnFilterRoom);
            Controls.Add(btnFilterAge);
            Controls.Add(btnFilterName);
            Controls.Add(lblFilter);
            Controls.Add(lblPatientInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblPatientSearch);
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
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1524, 952);
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dataPatients).EndInit();
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
        private Label lblPatientSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblPatientInfo;
        private Label lblFilter;
        private Button btnFilterName;
        private Button btnFilterAge;
        private Button btnFilterRoom;
        private DataGridView dataPatients;
        private Button btnAddPatient;
        private Label lblInstructions;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewButtonColumn View;
    }
}
