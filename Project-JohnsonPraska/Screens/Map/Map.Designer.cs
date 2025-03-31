namespace Project_JohnsonPraska
{
    partial class Map
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
            lblRightMain = new Label();
            lblLeftMain = new Label();
            lblMore = new Label();
            lblMap = new Label();
            lblHome = new Label();
            cmbVehicles = new ComboBox();
            picMap = new PictureBox();
            picWifi = new PictureBox();
            picBattery = new PictureBox();
            picMore = new PictureBox();
            picMapIcon = new PictureBox();
            picHome = new PictureBox();
            picRefresh = new PictureBox();
            lblRefresh = new Label();
            btnShowGeo = new Button();
            btnHideGeo = new Button();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBattery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMapIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).BeginInit();
            SuspendLayout();
            // 
            // lblRightMain
            // 
            lblRightMain.BackColor = Color.FromArgb(30, 76, 99);
            lblRightMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblRightMain.ForeColor = Color.White;
            lblRightMain.Location = new Point(178, 0);
            lblRightMain.Name = "lblRightMain";
            lblRightMain.Size = new Size(1720, 75);
            lblRightMain.TabIndex = 3;
            lblRightMain.Text = " 23         ";
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
            lblLeftMain.TabIndex = 4;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1420, 850);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(500, 150);
            lblMore.TabIndex = 33;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            lblMore.Click += lblMore_Click;
            // 
            // lblMap
            // 
            lblMap.BackColor = Color.FromArgb(30, 76, 99);
            lblMap.Enabled = false;
            lblMap.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMap.ForeColor = Color.White;
            lblMap.Location = new Point(500, 850);
            lblMap.Name = "lblMap";
            lblMap.Size = new Size(920, 150);
            lblMap.TabIndex = 32;
            lblMap.Text = "Map";
            lblMap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 850);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(500, 150);
            lblHome.TabIndex = 31;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
            // 
            // cmbVehicles
            // 
            cmbVehicles.Font = new Font("Cambria", 14F);
            cmbVehicles.FormattingEnabled = true;
            cmbVehicles.Items.AddRange(new object[] { "Connor's Car", "Matthew's Car" });
            cmbVehicles.Location = new Point(750, 17);
            cmbVehicles.Name = "cmbVehicles";
            cmbVehicles.Size = new Size(400, 41);
            cmbVehicles.TabIndex = 34;
            // 
            // picMap
            // 
            picMap.Image = Properties.Resources.Map;
            picMap.Location = new Point(0, 75);
            picMap.Name = "picMap";
            picMap.Size = new Size(1920, 775);
            picMap.SizeMode = PictureBoxSizeMode.Zoom;
            picMap.TabIndex = 35;
            picMap.TabStop = false;
            // 
            // picWifi
            // 
            picWifi.BackColor = Color.FromArgb(30, 76, 99);
            picWifi.Image = Properties.Resources.Cellular3;
            picWifi.Location = new Point(1725, 10);
            picWifi.Name = "picWifi";
            picWifi.Size = new Size(55, 55);
            picWifi.SizeMode = PictureBoxSizeMode.Zoom;
            picWifi.TabIndex = 36;
            picWifi.TabStop = false;
            // 
            // picBattery
            // 
            picBattery.BackColor = Color.FromArgb(30, 76, 99);
            picBattery.Image = Properties.Resources.Battery1;
            picBattery.Location = new Point(1840, 20);
            picBattery.Name = "picBattery";
            picBattery.Size = new Size(50, 35);
            picBattery.SizeMode = PictureBoxSizeMode.Zoom;
            picBattery.TabIndex = 37;
            picBattery.TabStop = false;
            // 
            // picMore
            // 
            picMore.BackColor = Color.FromArgb(30, 76, 99);
            picMore.Image = Properties.Resources.More1;
            picMore.Location = new Point(1638, 853);
            picMore.Name = "picMore";
            picMore.Size = new Size(60, 60);
            picMore.SizeMode = PictureBoxSizeMode.Zoom;
            picMore.TabIndex = 45;
            picMore.TabStop = false;
            picMore.Click += picMore_Click;
            // 
            // picMapIcon
            // 
            picMapIcon.BackColor = Color.FromArgb(30, 76, 99);
            picMapIcon.Image = Properties.Resources.Map1;
            picMapIcon.Location = new Point(928, 853);
            picMapIcon.Name = "picMapIcon";
            picMapIcon.Size = new Size(60, 60);
            picMapIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picMapIcon.TabIndex = 44;
            picMapIcon.TabStop = false;
            // 
            // picHome
            // 
            picHome.BackColor = Color.FromArgb(30, 76, 99);
            picHome.Image = Properties.Resources.Home1;
            picHome.Location = new Point(220, 853);
            picHome.Name = "picHome";
            picHome.Size = new Size(60, 60);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 43;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picRefresh
            // 
            picRefresh.BorderStyle = BorderStyle.Fixed3D;
            picRefresh.Image = Properties.Resources.Refresh1;
            picRefresh.Location = new Point(85, 150);
            picRefresh.Name = "picRefresh";
            picRefresh.Size = new Size(100, 100);
            picRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            picRefresh.TabIndex = 46;
            picRefresh.TabStop = false;
            picRefresh.Click += picRefresh_Click;
            // 
            // lblRefresh
            // 
            lblRefresh.Font = new Font("Cambria", 13F);
            lblRefresh.ForeColor = Color.White;
            lblRefresh.Location = new Point(85, 110);
            lblRefresh.Name = "lblRefresh";
            lblRefresh.Size = new Size(100, 40);
            lblRefresh.TabIndex = 47;
            lblRefresh.Text = "Refresh";
            lblRefresh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShowGeo
            // 
            btnShowGeo.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowGeo.Location = new Point(1670, 125);
            btnShowGeo.Name = "btnShowGeo";
            btnShowGeo.Size = new Size(200, 100);
            btnShowGeo.TabIndex = 48;
            btnShowGeo.Text = "Show Geofence";
            btnShowGeo.UseVisualStyleBackColor = true;
            btnShowGeo.Click += btnShowGeo_Click;
            // 
            // btnHideGeo
            // 
            btnHideGeo.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHideGeo.Location = new Point(1670, 250);
            btnHideGeo.Name = "btnHideGeo";
            btnHideGeo.Size = new Size(200, 100);
            btnHideGeo.TabIndex = 49;
            btnHideGeo.Text = "Hide Geofence";
            btnHideGeo.UseVisualStyleBackColor = true;
            btnHideGeo.Click += btnHideGeo_Click;
            // 
            // Map
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1898, 949);
            Controls.Add(btnHideGeo);
            Controls.Add(btnShowGeo);
            Controls.Add(lblRefresh);
            Controls.Add(picRefresh);
            Controls.Add(picMore);
            Controls.Add(picMapIcon);
            Controls.Add(picHome);
            Controls.Add(picBattery);
            Controls.Add(picWifi);
            Controls.Add(picMap);
            Controls.Add(cmbVehicles);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblRightMain);
            Controls.Add(lblLeftMain);
            Name = "Map";
            Text = "Map";
            WindowState = FormWindowState.Maximized;
            Load += Map_Load;
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBattery).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMapIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRefresh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRightMain;
        private Label lblLeftMain;
        private Label lblMore;
        private Label lblMap;
        private Label lblHome;
        private ComboBox cmbVehicles;
        private PictureBox picMap;
        private PictureBox picWifi;
        private PictureBox picBattery;
        private PictureBox picMore;
        private PictureBox picMapIcon;
        private PictureBox picHome;
        private PictureBox picRefresh;
        private Label lblRefresh;
        private Button btnShowGeo;
        private Button btnHideGeo;
    }
}