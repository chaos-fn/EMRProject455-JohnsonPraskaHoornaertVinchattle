namespace Project_JohnsonPraska
{
    partial class Vehicles
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
            picBattery = new PictureBox();
            picWifi = new PictureBox();
            lblMiles = new Label();
            lblMilesL = new Label();
            lblYear = new Label();
            lblYearL = new Label();
            lblModel = new Label();
            lblModelL = new Label();
            lblMake = new Label();
            lblMakeL = new Label();
            lblEngine = new Label();
            lblEngineL = new Label();
            cmbVehicles = new ComboBox();
            btnAddDelVH = new Button();
            btnEditVH = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBattery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IMG_5789;
            pictureBox3.Location = new Point(1350, 550);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 75;
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
            picMore.TabIndex = 74;
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
            picMap.TabIndex = 73;
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
            picHome.TabIndex = 72;
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
            lblHelp.TabIndex = 71;
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
            lblActivity.TabIndex = 70;
            lblActivity.Text = "Activity";
            lblActivity.TextAlign = ContentAlignment.MiddleCenter;
            lblActivity.Click += lblActivity_Click;
            // 
            // lblDrivers
            // 
            lblDrivers.BorderStyle = BorderStyle.Fixed3D;
            lblDrivers.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblDrivers.ForeColor = Color.White;
            lblDrivers.Location = new Point(0, 385);
            lblDrivers.Name = "lblDrivers";
            lblDrivers.Size = new Size(240, 155);
            lblDrivers.TabIndex = 69;
            lblDrivers.Text = "Drivers";
            lblDrivers.TextAlign = ContentAlignment.MiddleCenter;
            lblDrivers.Click += lblDrivers_Click;
            // 
            // lblVehicles
            // 
            lblVehicles.BorderStyle = BorderStyle.Fixed3D;
            lblVehicles.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblVehicles.ForeColor = Color.White;
            lblVehicles.Location = new Point(0, 230);
            lblVehicles.Name = "lblVehicles";
            lblVehicles.Size = new Size(240, 155);
            lblVehicles.TabIndex = 68;
            lblVehicles.Text = "Vehicles";
            lblVehicles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccount
            // 
            lblAccount.BorderStyle = BorderStyle.Fixed3D;
            lblAccount.Font = new Font("Cambria", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.White;
            lblAccount.Location = new Point(0, 75);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(240, 155);
            lblAccount.TabIndex = 67;
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
            lblMore.TabIndex = 66;
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
            lblMap.TabIndex = 65;
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
            lblHome.TabIndex = 64;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
            // 
            // lblRightMain
            // 
            lblRightMain.BackColor = Color.FromArgb(30, 76, 99);
            lblRightMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblRightMain.ForeColor = Color.White;
            lblRightMain.Location = new Point(202, 0);
            lblRightMain.Name = "lblRightMain";
            lblRightMain.Size = new Size(1696, 75);
            lblRightMain.TabIndex = 62;
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
            lblLeftMain.TabIndex = 63;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picBattery
            // 
            picBattery.BackColor = Color.FromArgb(30, 76, 99);
            picBattery.Image = Properties.Resources.Battery1;
            picBattery.Location = new Point(1840, 20);
            picBattery.Name = "picBattery";
            picBattery.Size = new Size(50, 35);
            picBattery.SizeMode = PictureBoxSizeMode.Zoom;
            picBattery.TabIndex = 77;
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
            picWifi.TabIndex = 76;
            picWifi.TabStop = false;
            // 
            // lblMiles
            // 
            lblMiles.BackColor = Color.FromArgb(64, 64, 64);
            lblMiles.BorderStyle = BorderStyle.FixedSingle;
            lblMiles.Font = new Font("Cambria", 14F);
            lblMiles.ForeColor = Color.White;
            lblMiles.Location = new Point(375, 675);
            lblMiles.Name = "lblMiles";
            lblMiles.Size = new Size(400, 40);
            lblMiles.TabIndex = 85;
            lblMiles.Text = "25,280";
            lblMiles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMilesL
            // 
            lblMilesL.BackColor = Color.FromArgb(64, 64, 64);
            lblMilesL.BorderStyle = BorderStyle.FixedSingle;
            lblMilesL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblMilesL.ForeColor = Color.White;
            lblMilesL.Location = new Point(375, 625);
            lblMilesL.Name = "lblMilesL";
            lblMilesL.Size = new Size(400, 50);
            lblMilesL.TabIndex = 84;
            lblMilesL.Text = "Miles";
            lblMilesL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            lblYear.BackColor = Color.FromArgb(64, 64, 64);
            lblYear.BorderStyle = BorderStyle.FixedSingle;
            lblYear.Font = new Font("Cambria", 14F);
            lblYear.ForeColor = Color.White;
            lblYear.Location = new Point(375, 525);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(400, 40);
            lblYear.TabIndex = 83;
            lblYear.Text = "2019";
            lblYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYearL
            // 
            lblYearL.BackColor = Color.FromArgb(64, 64, 64);
            lblYearL.BorderStyle = BorderStyle.FixedSingle;
            lblYearL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblYearL.ForeColor = Color.White;
            lblYearL.Location = new Point(375, 475);
            lblYearL.Name = "lblYearL";
            lblYearL.Size = new Size(400, 50);
            lblYearL.TabIndex = 82;
            lblYearL.Text = "Year";
            lblYearL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            lblModel.BackColor = Color.FromArgb(64, 64, 64);
            lblModel.BorderStyle = BorderStyle.FixedSingle;
            lblModel.Font = new Font("Cambria", 14F);
            lblModel.ForeColor = Color.White;
            lblModel.Location = new Point(375, 375);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(400, 40);
            lblModel.TabIndex = 81;
            lblModel.Text = "Equinox";
            lblModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModelL
            // 
            lblModelL.BackColor = Color.FromArgb(64, 64, 64);
            lblModelL.BorderStyle = BorderStyle.FixedSingle;
            lblModelL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblModelL.ForeColor = Color.White;
            lblModelL.Location = new Point(375, 325);
            lblModelL.Name = "lblModelL";
            lblModelL.Size = new Size(400, 50);
            lblModelL.TabIndex = 80;
            lblModelL.Text = "Model";
            lblModelL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMake
            // 
            lblMake.BackColor = Color.FromArgb(64, 64, 64);
            lblMake.BorderStyle = BorderStyle.FixedSingle;
            lblMake.Font = new Font("Cambria", 14F);
            lblMake.ForeColor = Color.White;
            lblMake.Location = new Point(375, 225);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(400, 40);
            lblMake.TabIndex = 79;
            lblMake.Text = "Chevrolet";
            lblMake.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMakeL
            // 
            lblMakeL.BackColor = Color.FromArgb(64, 64, 64);
            lblMakeL.BorderStyle = BorderStyle.FixedSingle;
            lblMakeL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblMakeL.ForeColor = Color.White;
            lblMakeL.Location = new Point(375, 175);
            lblMakeL.Name = "lblMakeL";
            lblMakeL.Size = new Size(400, 50);
            lblMakeL.TabIndex = 78;
            lblMakeL.Text = "Make";
            lblMakeL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEngine
            // 
            lblEngine.BackColor = Color.FromArgb(64, 64, 64);
            lblEngine.BorderStyle = BorderStyle.FixedSingle;
            lblEngine.Font = new Font("Cambria", 14F);
            lblEngine.ForeColor = Color.White;
            lblEngine.Location = new Point(837, 225);
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new Size(400, 40);
            lblEngine.TabIndex = 87;
            lblEngine.Text = "Gas";
            lblEngine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEngineL
            // 
            lblEngineL.BackColor = Color.FromArgb(64, 64, 64);
            lblEngineL.BorderStyle = BorderStyle.FixedSingle;
            lblEngineL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblEngineL.ForeColor = Color.White;
            lblEngineL.Location = new Point(837, 175);
            lblEngineL.Name = "lblEngineL";
            lblEngineL.Size = new Size(400, 50);
            lblEngineL.TabIndex = 86;
            lblEngineL.Text = "Engine";
            lblEngineL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbVehicles
            // 
            cmbVehicles.Font = new Font("Cambria", 14F);
            cmbVehicles.FormattingEnabled = true;
            cmbVehicles.Items.AddRange(new object[] { "Connor's Car", "Matthew's Car" });
            cmbVehicles.Location = new Point(750, 17);
            cmbVehicles.Name = "cmbVehicles";
            cmbVehicles.Size = new Size(400, 41);
            cmbVehicles.TabIndex = 88;
            cmbVehicles.SelectedIndexChanged += cmbVehicles_SelectedIndexChanged;
            // 
            // btnAddDelVH
            // 
            btnAddDelVH.BackColor = Color.White;
            btnAddDelVH.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnAddDelVH.ForeColor = Color.Black;
            btnAddDelVH.Location = new Point(1300, 325);
            btnAddDelVH.Name = "btnAddDelVH";
            btnAddDelVH.Size = new Size(350, 100);
            btnAddDelVH.TabIndex = 90;
            btnAddDelVH.Text = "Add/Delete Vehicle";
            btnAddDelVH.UseVisualStyleBackColor = false;
            btnAddDelVH.Click += btnAddDelVH_Click;
            // 
            // btnEditVH
            // 
            btnEditVH.BackColor = Color.White;
            btnEditVH.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnEditVH.Location = new Point(1300, 175);
            btnEditVH.Name = "btnEditVH";
            btnEditVH.Size = new Size(350, 100);
            btnEditVH.TabIndex = 89;
            btnEditVH.Text = "Edit Vehicle Info";
            btnEditVH.UseVisualStyleBackColor = false;
            btnEditVH.Click += btnEditVH_Click;
            // 
            // Vehicles
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1898, 949);
            Controls.Add(btnAddDelVH);
            Controls.Add(btnEditVH);
            Controls.Add(cmbVehicles);
            Controls.Add(lblEngine);
            Controls.Add(lblEngineL);
            Controls.Add(lblMiles);
            Controls.Add(lblMilesL);
            Controls.Add(lblYear);
            Controls.Add(lblYearL);
            Controls.Add(lblModel);
            Controls.Add(lblModelL);
            Controls.Add(lblMake);
            Controls.Add(lblMakeL);
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
            Name = "Vehicles";
            Text = "Vehicles";
            WindowState = FormWindowState.Maximized;
            Load += Vehicles_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBattery).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).EndInit();
            ResumeLayout(false);
        }

        #endregion

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
        private PictureBox picBattery;
        private PictureBox picWifi;
        private Label lblMiles;
        private Label lblMilesL;
        private Label lblYear;
        private Label lblYearL;
        private Label lblModel;
        private Label lblModelL;
        private Label lblMake;
        private Label lblMakeL;
        private Label lblEngine;
        private Label lblEngineL;
        private ComboBox cmbVehicles;
        private Button btnAddDelVH;
        private Button btnEditVH;
    }
}