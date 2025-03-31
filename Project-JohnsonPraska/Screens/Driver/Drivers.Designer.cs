namespace Project_JohnsonPraska
{
    partial class Drivers
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
            picBattery = new PictureBox();
            picWifi = new PictureBox();
            pictureBox3 = new PictureBox();
            picMore = new PictureBox();
            picMap = new PictureBox();
            picHome = new PictureBox();
            lblHelp = new Label();
            lblActivity = new Label();
            lblDrivers = new Label();
            lblVehicles = new Label();
            lblAccount = new Label();
            lblMore = new Label();
            lblMap = new Label();
            lblHome = new Label();
            lblRightMain = new Label();
            lblLeftMain = new Label();
            btnAddDelDriver = new Button();
            btnEditDriver = new Button();
            lblDefaultVH = new Label();
            lblDefaultVHL = new Label();
            lblAge = new Label();
            lblAgeL = new Label();
            lblName = new Label();
            lblNameL = new Label();
            cmbDrivers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picBattery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            SuspendLayout();
            // 
            // picBattery
            // 
            picBattery.BackColor = Color.FromArgb(30, 76, 99);
            picBattery.Image = Properties.Resources.Battery1;
            picBattery.Location = new Point(1840, 20);
            picBattery.Name = "picBattery";
            picBattery.Size = new Size(50, 35);
            picBattery.SizeMode = PictureBoxSizeMode.Zoom;
            picBattery.TabIndex = 93;
            picBattery.TabStop = false;
            // 
            // picWifi
            // 
            picWifi.BackColor = Color.FromArgb(30, 76, 99);
            picWifi.Image = Properties.Resources.Cellular3;
            picWifi.Location = new Point(1725, 10);
            picWifi.Name = "picWifi";
            picWifi.Size = new Size(55, 55);
            picWifi.SizeMode = PictureBoxSizeMode.Zoom;
            picWifi.TabIndex = 92;
            picWifi.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IMG_5789;
            pictureBox3.Location = new Point(1350, 550);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 91;
            pictureBox3.TabStop = false;
            // 
            // picMore
            // 
            picMore.BackColor = Color.FromArgb(30, 76, 99);
            picMore.Image = Properties.Resources.More1;
            picMore.Location = new Point(1638, 850);
            picMore.Name = "picMore";
            picMore.Size = new Size(60, 60);
            picMore.SizeMode = PictureBoxSizeMode.Zoom;
            picMore.TabIndex = 90;
            picMore.TabStop = false;
            // 
            // picMap
            // 
            picMap.BackColor = Color.FromArgb(30, 76, 99);
            picMap.Image = Properties.Resources.Map1;
            picMap.Location = new Point(927, 853);
            picMap.Name = "picMap";
            picMap.Size = new Size(60, 60);
            picMap.SizeMode = PictureBoxSizeMode.Zoom;
            picMap.TabIndex = 89;
            picMap.TabStop = false;
            picMap.Click += picMap_Click;
            // 
            // picHome
            // 
            picHome.BackColor = Color.FromArgb(30, 76, 99);
            picHome.Image = Properties.Resources.Home1;
            picHome.Location = new Point(220, 853);
            picHome.Name = "picHome";
            picHome.Size = new Size(60, 60);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 88;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // lblHelp
            // 
            lblHelp.BorderStyle = BorderStyle.Fixed3D;
            lblHelp.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblHelp.ForeColor = Color.White;
            lblHelp.Location = new Point(0, 695);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(240, 155);
            lblHelp.TabIndex = 87;
            lblHelp.Text = "Help";
            lblHelp.TextAlign = ContentAlignment.MiddleCenter;
            lblHelp.Click += lblHelp_Click;
            // 
            // lblActivity
            // 
            lblActivity.BorderStyle = BorderStyle.Fixed3D;
            lblActivity.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblActivity.ForeColor = Color.White;
            lblActivity.Location = new Point(0, 540);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(240, 155);
            lblActivity.TabIndex = 86;
            lblActivity.Text = "Activity";
            lblActivity.TextAlign = ContentAlignment.MiddleCenter;
            lblActivity.Click += lblActivity_Click;
            // 
            // lblDrivers
            // 
            lblDrivers.BorderStyle = BorderStyle.Fixed3D;
            lblDrivers.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblDrivers.ForeColor = Color.White;
            lblDrivers.Location = new Point(0, 385);
            lblDrivers.Name = "lblDrivers";
            lblDrivers.Size = new Size(240, 155);
            lblDrivers.TabIndex = 85;
            lblDrivers.Text = "Drivers";
            lblDrivers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVehicles
            // 
            lblVehicles.BorderStyle = BorderStyle.Fixed3D;
            lblVehicles.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblVehicles.ForeColor = Color.White;
            lblVehicles.Location = new Point(0, 230);
            lblVehicles.Name = "lblVehicles";
            lblVehicles.Size = new Size(240, 155);
            lblVehicles.TabIndex = 84;
            lblVehicles.Text = "Vehicles";
            lblVehicles.TextAlign = ContentAlignment.MiddleCenter;
            lblVehicles.Click += lblVehicles_Click;
            // 
            // lblAccount
            // 
            lblAccount.BorderStyle = BorderStyle.Fixed3D;
            lblAccount.Font = new Font("Cambria", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.White;
            lblAccount.Location = new Point(0, 75);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(240, 155);
            lblAccount.TabIndex = 83;
            lblAccount.Text = "Account";
            lblAccount.TextAlign = ContentAlignment.MiddleCenter;
            lblAccount.Click += lblAccount_Click;
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Enabled = false;
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1420, 850);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(500, 150);
            lblMore.TabIndex = 82;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMap
            // 
            lblMap.BackColor = Color.FromArgb(30, 76, 99);
            lblMap.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMap.ForeColor = Color.White;
            lblMap.Location = new Point(500, 850);
            lblMap.Name = "lblMap";
            lblMap.Size = new Size(920, 150);
            lblMap.TabIndex = 81;
            lblMap.Text = "Map";
            lblMap.TextAlign = ContentAlignment.MiddleCenter;
            lblMap.Click += lblMap_Click;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 850);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(500, 150);
            lblHome.TabIndex = 80;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
            // 
            // lblRightMain
            // 
            lblRightMain.BackColor = Color.FromArgb(30, 76, 99);
            lblRightMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblRightMain.ForeColor = Color.White;
            lblRightMain.Location = new Point(186, 0);
            lblRightMain.Name = "lblRightMain";
            lblRightMain.Size = new Size(1712, 75);
            lblRightMain.TabIndex = 78;
            lblRightMain.Text = "23         ";
            lblRightMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLeftMain
            // 
            lblLeftMain.BackColor = Color.FromArgb(30, 76, 99);
            lblLeftMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblLeftMain.ForeColor = Color.White;
            lblLeftMain.Location = new Point(0, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(1920, 75);
            lblLeftMain.TabIndex = 79;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddDelDriver
            // 
            btnAddDelDriver.BackColor = Color.White;
            btnAddDelDriver.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnAddDelDriver.ForeColor = Color.Black;
            btnAddDelDriver.Location = new Point(1300, 325);
            btnAddDelDriver.Name = "btnAddDelDriver";
            btnAddDelDriver.Size = new Size(350, 100);
            btnAddDelDriver.TabIndex = 103;
            btnAddDelDriver.Text = "Add/Delete Driver";
            btnAddDelDriver.UseVisualStyleBackColor = false;
            btnAddDelDriver.Click += btnAddDelDriver_Click;
            // 
            // btnEditDriver
            // 
            btnEditDriver.BackColor = Color.White;
            btnEditDriver.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnEditDriver.Location = new Point(1300, 175);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(350, 100);
            btnEditDriver.TabIndex = 102;
            btnEditDriver.Text = "Edit Driver Info";
            btnEditDriver.UseVisualStyleBackColor = false;
            btnEditDriver.Click += btnEditDriver_Click;
            // 
            // lblDefaultVH
            // 
            lblDefaultVH.BackColor = Color.FromArgb(64, 64, 64);
            lblDefaultVH.BorderStyle = BorderStyle.FixedSingle;
            lblDefaultVH.Font = new Font("Cambria", 14F);
            lblDefaultVH.ForeColor = Color.White;
            lblDefaultVH.Location = new Point(375, 525);
            lblDefaultVH.Name = "lblDefaultVH";
            lblDefaultVH.Size = new Size(400, 40);
            lblDefaultVH.TabIndex = 99;
            lblDefaultVH.Text = "Connor's Car";
            lblDefaultVH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDefaultVHL
            // 
            lblDefaultVHL.BackColor = Color.FromArgb(64, 64, 64);
            lblDefaultVHL.BorderStyle = BorderStyle.FixedSingle;
            lblDefaultVHL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblDefaultVHL.ForeColor = Color.White;
            lblDefaultVHL.Location = new Point(375, 475);
            lblDefaultVHL.Name = "lblDefaultVHL";
            lblDefaultVHL.Size = new Size(400, 50);
            lblDefaultVHL.TabIndex = 98;
            lblDefaultVHL.Text = "Default Vehicle";
            lblDefaultVHL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            lblAge.BackColor = Color.FromArgb(64, 64, 64);
            lblAge.BorderStyle = BorderStyle.FixedSingle;
            lblAge.Font = new Font("Cambria", 14F);
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(375, 375);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(400, 40);
            lblAge.TabIndex = 97;
            lblAge.Text = "20";
            lblAge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAgeL
            // 
            lblAgeL.BackColor = Color.FromArgb(64, 64, 64);
            lblAgeL.BorderStyle = BorderStyle.FixedSingle;
            lblAgeL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblAgeL.ForeColor = Color.White;
            lblAgeL.Location = new Point(375, 325);
            lblAgeL.Name = "lblAgeL";
            lblAgeL.Size = new Size(400, 50);
            lblAgeL.TabIndex = 96;
            lblAgeL.Text = "Age";
            lblAgeL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = Color.FromArgb(64, 64, 64);
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Font = new Font("Cambria", 14F);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(375, 225);
            lblName.Name = "lblName";
            lblName.Size = new Size(400, 40);
            lblName.TabIndex = 95;
            lblName.Text = "Connor Praska";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameL
            // 
            lblNameL.BackColor = Color.FromArgb(64, 64, 64);
            lblNameL.BorderStyle = BorderStyle.FixedSingle;
            lblNameL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblNameL.ForeColor = Color.White;
            lblNameL.Location = new Point(375, 175);
            lblNameL.Name = "lblNameL";
            lblNameL.Size = new Size(400, 50);
            lblNameL.TabIndex = 94;
            lblNameL.Text = "Name";
            lblNameL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbDrivers
            // 
            cmbDrivers.Font = new Font("Cambria", 14F);
            cmbDrivers.FormattingEnabled = true;
            cmbDrivers.Location = new Point(750, 17);
            cmbDrivers.Name = "cmbDrivers";
            cmbDrivers.Size = new Size(400, 41);
            cmbDrivers.TabIndex = 104;
            cmbDrivers.SelectedIndexChanged += cmbDrivers_SelectedIndexChanged;
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1898, 949);
            Controls.Add(cmbDrivers);
            Controls.Add(btnAddDelDriver);
            Controls.Add(btnEditDriver);
            Controls.Add(lblDefaultVH);
            Controls.Add(lblDefaultVHL);
            Controls.Add(lblAge);
            Controls.Add(lblAgeL);
            Controls.Add(lblName);
            Controls.Add(lblNameL);
            Controls.Add(picBattery);
            Controls.Add(picWifi);
            Controls.Add(pictureBox3);
            Controls.Add(picMore);
            Controls.Add(picMap);
            Controls.Add(picHome);
            Controls.Add(lblHelp);
            Controls.Add(lblActivity);
            Controls.Add(lblDrivers);
            Controls.Add(lblVehicles);
            Controls.Add(lblAccount);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblRightMain);
            Controls.Add(lblLeftMain);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Drivers";
            Text = "Drivers";
            WindowState = FormWindowState.Maximized;
            Load += Drivers_Load;
            ((System.ComponentModel.ISupportInitialize)picBattery).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBattery;
        private PictureBox picWifi;
        private PictureBox pictureBox3;
        private PictureBox picMore;
        private PictureBox picMap;
        private PictureBox picHome;
        private Label lblHelp;
        private Label lblActivity;
        private Label lblDrivers;
        private Label lblVehicles;
        private Label lblAccount;
        private Label lblMore;
        private Label lblMap;
        private Label lblHome;
        private Label lblRightMain;
        private Label lblLeftMain;
        private Button btnAddDelDriver;
        private Button btnEditDriver;
        private Label lblDefaultVH;
        private Label lblDefaultVHL;
        private Label lblAge;
        private Label lblAgeL;
        private Label lblName;
        private Label lblNameL;
        private ComboBox cmbDrivers;
    }
}