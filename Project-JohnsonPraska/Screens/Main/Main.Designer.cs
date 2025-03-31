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
            lblRightMain = new Label();
            cmbVehicles = new ComboBox();
            picCar = new PictureBox();
            picLock = new PictureBox();
            picStartStop = new PictureBox();
            picUnlock = new PictureBox();
            lblVehicleInfo = new Label();
            lblVH1L = new Label();
            lblVH2L = new Label();
            lblVH3L = new Label();
            lblVH5L = new Label();
            lblVH1 = new Label();
            lblVH2 = new Label();
            lblVH3 = new Label();
            lblVH4 = new Label();
            lblVH5 = new Label();
            picWindowsUp = new PictureBox();
            picWindowsDown = new PictureBox();
            picSunroofClose = new PictureBox();
            picSunroofOpen = new PictureBox();
            lblLock = new Label();
            lblStartStop = new Label();
            lblUnlock = new Label();
            lblWindowsUp = new Label();
            lblWindowsDown = new Label();
            lblSunroofClose = new Label();
            lblSunroofOpen = new Label();
            lblHome = new Label();
            lblMap = new Label();
            lblMore = new Label();
            lblAlarmOn = new Label();
            lblAlarmOff = new Label();
            picAlarmOn = new PictureBox();
            picAlarmOff = new PictureBox();
            picBattery = new PictureBox();
            picWifi = new PictureBox();
            picHome = new PictureBox();
            picMap = new PictureBox();
            picMore = new PictureBox();
            lblVH4L = new Label();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStartStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUnlock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWindowsUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWindowsDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSunroofClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSunroofOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlarmOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlarmOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBattery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMore).BeginInit();
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
            // lblRightMain
            // 
            lblRightMain.BackColor = Color.FromArgb(30, 76, 99);
            lblRightMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblRightMain.ForeColor = Color.White;
            lblRightMain.Location = new Point(193, 0);
            lblRightMain.Name = "lblRightMain";
            lblRightMain.Size = new Size(1705, 75);
            lblRightMain.TabIndex = 1;
            lblRightMain.Text = " 23         ";
            lblRightMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbVehicles
            // 
            cmbVehicles.Font = new Font("Cambria", 14F);
            cmbVehicles.FormattingEnabled = true;
            cmbVehicles.Items.AddRange(new object[] { "Connor's Car", "Matthew's Car" });
            cmbVehicles.Location = new Point(750, 17);
            cmbVehicles.Name = "cmbVehicles";
            cmbVehicles.Size = new Size(400, 41);
            cmbVehicles.TabIndex = 0;
            cmbVehicles.SelectedIndexChanged += cmbVehicles_SelectedIndexChanged;
            // 
            // picCar
            // 
            picCar.Image = Properties.Resources.Equinox;
            picCar.Location = new Point(550, 125);
            picCar.Name = "picCar";
            picCar.Size = new Size(800, 450);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 2;
            picCar.TabStop = false;
            // 
            // picLock
            // 
            picLock.BackColor = Color.White;
            picLock.Image = Properties.Resources.Lock;
            picLock.Location = new Point(550, 650);
            picLock.Name = "picLock";
            picLock.Size = new Size(175, 175);
            picLock.SizeMode = PictureBoxSizeMode.Zoom;
            picLock.TabIndex = 3;
            picLock.TabStop = false;
            picLock.Click += picLock_Click;
            // 
            // picStartStop
            // 
            picStartStop.BackColor = Color.White;
            picStartStop.Image = Properties.Resources.Power;
            picStartStop.Location = new Point(875, 650);
            picStartStop.Name = "picStartStop";
            picStartStop.Size = new Size(175, 175);
            picStartStop.SizeMode = PictureBoxSizeMode.Zoom;
            picStartStop.TabIndex = 4;
            picStartStop.TabStop = false;
            picStartStop.Click += picStartStop_Click;
            // 
            // picUnlock
            // 
            picUnlock.BackColor = Color.White;
            picUnlock.Image = Properties.Resources.Unlock1;
            picUnlock.Location = new Point(1175, 650);
            picUnlock.Name = "picUnlock";
            picUnlock.Size = new Size(175, 175);
            picUnlock.SizeMode = PictureBoxSizeMode.Zoom;
            picUnlock.TabIndex = 5;
            picUnlock.TabStop = false;
            picUnlock.Click += picUnlock_Click;
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblVehicleInfo.ForeColor = Color.White;
            lblVehicleInfo.Location = new Point(1400, 125);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(450, 125);
            lblVehicleInfo.TabIndex = 6;
            lblVehicleInfo.Text = "Vehicle\r\nInfo";
            lblVehicleInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVH1L
            // 
            lblVH1L.BorderStyle = BorderStyle.Fixed3D;
            lblVH1L.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH1L.ForeColor = Color.White;
            lblVH1L.Location = new Point(1400, 250);
            lblVH1L.Name = "lblVH1L";
            lblVH1L.Size = new Size(225, 50);
            lblVH1L.TabIndex = 7;
            lblVH1L.Text = "Temp";
            lblVH1L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVH2L
            // 
            lblVH2L.BorderStyle = BorderStyle.Fixed3D;
            lblVH2L.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH2L.ForeColor = Color.White;
            lblVH2L.Location = new Point(1400, 300);
            lblVH2L.Name = "lblVH2L";
            lblVH2L.Size = new Size(225, 50);
            lblVH2L.TabIndex = 8;
            lblVH2L.Text = "Oil Life";
            lblVH2L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVH3L
            // 
            lblVH3L.BorderStyle = BorderStyle.Fixed3D;
            lblVH3L.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH3L.ForeColor = Color.White;
            lblVH3L.Location = new Point(1400, 350);
            lblVH3L.Name = "lblVH3L";
            lblVH3L.Size = new Size(225, 50);
            lblVH3L.TabIndex = 9;
            lblVH3L.Text = "Gas";
            lblVH3L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVH5L
            // 
            lblVH5L.BorderStyle = BorderStyle.Fixed3D;
            lblVH5L.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH5L.ForeColor = Color.White;
            lblVH5L.Location = new Point(1400, 450);
            lblVH5L.Name = "lblVH5L";
            lblVH5L.Size = new Size(225, 50);
            lblVH5L.TabIndex = 11;
            lblVH5L.Text = "Power";
            lblVH5L.TextAlign = ContentAlignment.MiddleLeft;
            lblVH5L.Visible = false;
            // 
            // lblVH1
            // 
            lblVH1.BorderStyle = BorderStyle.Fixed3D;
            lblVH1.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH1.ForeColor = Color.White;
            lblVH1.Location = new Point(1625, 250);
            lblVH1.Name = "lblVH1";
            lblVH1.Size = new Size(225, 50);
            lblVH1.TabIndex = 12;
            lblVH1.Text = "47 °F";
            lblVH1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVH2
            // 
            lblVH2.BorderStyle = BorderStyle.Fixed3D;
            lblVH2.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH2.ForeColor = Color.White;
            lblVH2.Location = new Point(1625, 300);
            lblVH2.Name = "lblVH2";
            lblVH2.Size = new Size(225, 50);
            lblVH2.TabIndex = 13;
            lblVH2.Text = "23%";
            lblVH2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVH3
            // 
            lblVH3.BorderStyle = BorderStyle.Fixed3D;
            lblVH3.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH3.ForeColor = Color.White;
            lblVH3.Location = new Point(1625, 350);
            lblVH3.Name = "lblVH3";
            lblVH3.Size = new Size(225, 50);
            lblVH3.TabIndex = 14;
            lblVH3.Text = "128 Miles";
            lblVH3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVH4
            // 
            lblVH4.BorderStyle = BorderStyle.Fixed3D;
            lblVH4.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH4.ForeColor = Color.White;
            lblVH4.Location = new Point(1625, 400);
            lblVH4.Name = "lblVH4";
            lblVH4.Size = new Size(225, 50);
            lblVH4.TabIndex = 15;
            lblVH4.Text = "Off";
            lblVH4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVH5
            // 
            lblVH5.BorderStyle = BorderStyle.Fixed3D;
            lblVH5.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH5.ForeColor = Color.White;
            lblVH5.Location = new Point(1625, 450);
            lblVH5.Name = "lblVH5";
            lblVH5.Size = new Size(225, 50);
            lblVH5.TabIndex = 16;
            lblVH5.Text = "Off";
            lblVH5.TextAlign = ContentAlignment.MiddleLeft;
            lblVH5.Visible = false;
            lblVH5.TextChanged += lblPowerVal_TextChanged;
            // 
            // picWindowsUp
            // 
            picWindowsUp.BackColor = Color.White;
            picWindowsUp.Image = Properties.Resources.Windows;
            picWindowsUp.Location = new Point(100, 175);
            picWindowsUp.Name = "picWindowsUp";
            picWindowsUp.Size = new Size(150, 150);
            picWindowsUp.SizeMode = PictureBoxSizeMode.Zoom;
            picWindowsUp.TabIndex = 17;
            picWindowsUp.TabStop = false;
            picWindowsUp.Click += picWindowsUp_Click;
            // 
            // picWindowsDown
            // 
            picWindowsDown.BackColor = Color.White;
            picWindowsDown.Image = Properties.Resources.Windows;
            picWindowsDown.Location = new Point(300, 175);
            picWindowsDown.Name = "picWindowsDown";
            picWindowsDown.Size = new Size(150, 150);
            picWindowsDown.SizeMode = PictureBoxSizeMode.Zoom;
            picWindowsDown.TabIndex = 18;
            picWindowsDown.TabStop = false;
            picWindowsDown.Click += picWindowsDown_Click;
            // 
            // picSunroofClose
            // 
            picSunroofClose.BackColor = Color.White;
            picSunroofClose.Image = Properties.Resources.Sunroof;
            picSunroofClose.Location = new Point(100, 400);
            picSunroofClose.Name = "picSunroofClose";
            picSunroofClose.Size = new Size(150, 150);
            picSunroofClose.SizeMode = PictureBoxSizeMode.Zoom;
            picSunroofClose.TabIndex = 19;
            picSunroofClose.TabStop = false;
            picSunroofClose.Click += picSunroofClose_Click;
            // 
            // picSunroofOpen
            // 
            picSunroofOpen.BackColor = Color.White;
            picSunroofOpen.Image = Properties.Resources.Sunroof;
            picSunroofOpen.Location = new Point(300, 400);
            picSunroofOpen.Name = "picSunroofOpen";
            picSunroofOpen.Size = new Size(150, 150);
            picSunroofOpen.SizeMode = PictureBoxSizeMode.Zoom;
            picSunroofOpen.TabIndex = 20;
            picSunroofOpen.TabStop = false;
            picSunroofOpen.Click += picSunroofOpen_Click;
            // 
            // lblLock
            // 
            lblLock.BorderStyle = BorderStyle.Fixed3D;
            lblLock.Font = new Font("Cambria", 20F);
            lblLock.ForeColor = Color.White;
            lblLock.Location = new Point(550, 600);
            lblLock.Name = "lblLock";
            lblLock.Size = new Size(175, 50);
            lblLock.TabIndex = 21;
            lblLock.Text = "Lock";
            lblLock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStartStop
            // 
            lblStartStop.BorderStyle = BorderStyle.Fixed3D;
            lblStartStop.Font = new Font("Cambria", 20F);
            lblStartStop.ForeColor = Color.White;
            lblStartStop.Location = new Point(875, 600);
            lblStartStop.Name = "lblStartStop";
            lblStartStop.Size = new Size(175, 50);
            lblStartStop.TabIndex = 22;
            lblStartStop.Text = "Start";
            lblStartStop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnlock
            // 
            lblUnlock.BorderStyle = BorderStyle.Fixed3D;
            lblUnlock.Font = new Font("Cambria", 20F);
            lblUnlock.ForeColor = Color.White;
            lblUnlock.Location = new Point(1175, 600);
            lblUnlock.Name = "lblUnlock";
            lblUnlock.Size = new Size(175, 50);
            lblUnlock.TabIndex = 23;
            lblUnlock.Text = "Unlock";
            lblUnlock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWindowsUp
            // 
            lblWindowsUp.BorderStyle = BorderStyle.Fixed3D;
            lblWindowsUp.Font = new Font("Cambria", 10F);
            lblWindowsUp.ForeColor = Color.White;
            lblWindowsUp.Location = new Point(100, 125);
            lblWindowsUp.Name = "lblWindowsUp";
            lblWindowsUp.Size = new Size(150, 40);
            lblWindowsUp.TabIndex = 24;
            lblWindowsUp.Text = "Windows Up";
            lblWindowsUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWindowsDown
            // 
            lblWindowsDown.BorderStyle = BorderStyle.Fixed3D;
            lblWindowsDown.Font = new Font("Cambria", 10F);
            lblWindowsDown.ForeColor = Color.White;
            lblWindowsDown.Location = new Point(300, 125);
            lblWindowsDown.Name = "lblWindowsDown";
            lblWindowsDown.Size = new Size(150, 40);
            lblWindowsDown.TabIndex = 25;
            lblWindowsDown.Text = "Windows Down";
            lblWindowsDown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSunroofClose
            // 
            lblSunroofClose.BorderStyle = BorderStyle.Fixed3D;
            lblSunroofClose.Font = new Font("Cambria", 10F);
            lblSunroofClose.ForeColor = Color.White;
            lblSunroofClose.Location = new Point(100, 350);
            lblSunroofClose.Name = "lblSunroofClose";
            lblSunroofClose.Size = new Size(150, 40);
            lblSunroofClose.TabIndex = 26;
            lblSunroofClose.Text = "Sunroof Close";
            lblSunroofClose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSunroofOpen
            // 
            lblSunroofOpen.BorderStyle = BorderStyle.Fixed3D;
            lblSunroofOpen.Font = new Font("Cambria", 10F);
            lblSunroofOpen.ForeColor = Color.White;
            lblSunroofOpen.Location = new Point(300, 350);
            lblSunroofOpen.Name = "lblSunroofOpen";
            lblSunroofOpen.Size = new Size(150, 40);
            lblSunroofOpen.TabIndex = 27;
            lblSunroofOpen.Text = "Sunroof Open";
            lblSunroofOpen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Enabled = false;
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 850);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(500, 150);
            lblHome.TabIndex = 28;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMap
            // 
            lblMap.BackColor = Color.FromArgb(30, 76, 99);
            lblMap.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMap.ForeColor = Color.White;
            lblMap.Location = new Point(500, 850);
            lblMap.Name = "lblMap";
            lblMap.Size = new Size(920, 150);
            lblMap.TabIndex = 29;
            lblMap.Text = "Map";
            lblMap.TextAlign = ContentAlignment.MiddleCenter;
            lblMap.Click += lblMap_Click;
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1420, 850);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(500, 150);
            lblMore.TabIndex = 30;
            lblMore.Text = "More";
            lblMore.TextAlign = ContentAlignment.MiddleCenter;
            lblMore.Click += lblMore_Click;
            // 
            // lblAlarmOn
            // 
            lblAlarmOn.BorderStyle = BorderStyle.Fixed3D;
            lblAlarmOn.Font = new Font("Cambria", 10F);
            lblAlarmOn.ForeColor = Color.White;
            lblAlarmOn.Location = new Point(300, 575);
            lblAlarmOn.Name = "lblAlarmOn";
            lblAlarmOn.Size = new Size(150, 40);
            lblAlarmOn.TabIndex = 34;
            lblAlarmOn.Text = "Alarm On";
            lblAlarmOn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlarmOff
            // 
            lblAlarmOff.BorderStyle = BorderStyle.Fixed3D;
            lblAlarmOff.Font = new Font("Cambria", 10F);
            lblAlarmOff.ForeColor = Color.White;
            lblAlarmOff.Location = new Point(100, 575);
            lblAlarmOff.Name = "lblAlarmOff";
            lblAlarmOff.Size = new Size(150, 40);
            lblAlarmOff.TabIndex = 33;
            lblAlarmOff.Text = "Alarm Off";
            lblAlarmOff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picAlarmOn
            // 
            picAlarmOn.BackColor = Color.White;
            picAlarmOn.Image = Properties.Resources.Horns;
            picAlarmOn.Location = new Point(300, 625);
            picAlarmOn.Name = "picAlarmOn";
            picAlarmOn.Size = new Size(150, 150);
            picAlarmOn.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarmOn.TabIndex = 32;
            picAlarmOn.TabStop = false;
            picAlarmOn.Click += picAlarmOn_Click;
            // 
            // picAlarmOff
            // 
            picAlarmOff.BackColor = Color.White;
            picAlarmOff.Image = Properties.Resources.Horns;
            picAlarmOff.Location = new Point(100, 625);
            picAlarmOff.Name = "picAlarmOff";
            picAlarmOff.Size = new Size(150, 150);
            picAlarmOff.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarmOff.TabIndex = 31;
            picAlarmOff.TabStop = false;
            picAlarmOff.Click += picAlarmOff_Click;
            // 
            // picBattery
            // 
            picBattery.BackColor = Color.FromArgb(30, 76, 99);
            picBattery.Image = Properties.Resources.Battery1;
            picBattery.Location = new Point(1840, 20);
            picBattery.Name = "picBattery";
            picBattery.Size = new Size(50, 35);
            picBattery.SizeMode = PictureBoxSizeMode.Zoom;
            picBattery.TabIndex = 39;
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
            picWifi.TabIndex = 38;
            picWifi.TabStop = false;
            // 
            // picHome
            // 
            picHome.BackColor = Color.FromArgb(30, 76, 99);
            picHome.Image = Properties.Resources.Home1;
            picHome.Location = new Point(220, 852);
            picHome.Name = "picHome";
            picHome.Size = new Size(60, 60);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 40;
            picHome.TabStop = false;
            // 
            // picMap
            // 
            picMap.BackColor = Color.FromArgb(30, 76, 99);
            picMap.Image = Properties.Resources.Map1;
            picMap.Location = new Point(928, 852);
            picMap.Name = "picMap";
            picMap.Size = new Size(60, 60);
            picMap.SizeMode = PictureBoxSizeMode.Zoom;
            picMap.TabIndex = 41;
            picMap.TabStop = false;
            picMap.Click += picMap_Click;
            // 
            // picMore
            // 
            picMore.BackColor = Color.FromArgb(30, 76, 99);
            picMore.Image = Properties.Resources.More1;
            picMore.Location = new Point(1638, 850);
            picMore.Name = "picMore";
            picMore.Size = new Size(60, 60);
            picMore.SizeMode = PictureBoxSizeMode.Zoom;
            picMore.TabIndex = 42;
            picMore.TabStop = false;
            picMore.Click += picMore_Click;
            // 
            // lblVH4L
            // 
            lblVH4L.BorderStyle = BorderStyle.Fixed3D;
            lblVH4L.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVH4L.ForeColor = Color.White;
            lblVH4L.Location = new Point(1400, 400);
            lblVH4L.Name = "lblVH4L";
            lblVH4L.Size = new Size(225, 50);
            lblVH4L.TabIndex = 10;
            lblVH4L.Text = "Power";
            lblVH4L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1898, 949);
            Controls.Add(picMore);
            Controls.Add(picMap);
            Controls.Add(picHome);
            Controls.Add(picBattery);
            Controls.Add(picWifi);
            Controls.Add(lblAlarmOn);
            Controls.Add(lblAlarmOff);
            Controls.Add(picAlarmOn);
            Controls.Add(picAlarmOff);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblSunroofOpen);
            Controls.Add(lblSunroofClose);
            Controls.Add(lblWindowsDown);
            Controls.Add(lblWindowsUp);
            Controls.Add(lblUnlock);
            Controls.Add(lblStartStop);
            Controls.Add(lblLock);
            Controls.Add(picSunroofOpen);
            Controls.Add(picSunroofClose);
            Controls.Add(picWindowsDown);
            Controls.Add(picWindowsUp);
            Controls.Add(lblVH5);
            Controls.Add(lblVH4);
            Controls.Add(lblVH3);
            Controls.Add(lblVH2);
            Controls.Add(lblVH1);
            Controls.Add(lblVH5L);
            Controls.Add(lblVH4L);
            Controls.Add(lblVH3L);
            Controls.Add(lblVH2L);
            Controls.Add(lblVH1L);
            Controls.Add(lblVehicleInfo);
            Controls.Add(picUnlock);
            Controls.Add(picStartStop);
            Controls.Add(picLock);
            Controls.Add(picCar);
            Controls.Add(cmbVehicles);
            Controls.Add(lblRightMain);
            Controls.Add(lblLeftMain);
            Font = new Font("Cambria", 12F);
            Margin = new Padding(4);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1005);
            Name = "Main";
            Text = "Main Menu";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStartStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUnlock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWindowsUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWindowsDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSunroofClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSunroofOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlarmOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlarmOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBattery).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWifi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMore).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLeftMain;
        private Label lblRightMain;
        private ComboBox cmbVehicles;
        private PictureBox picCar;
        private PictureBox picLock;
        private PictureBox picStartStop;
        private PictureBox picUnlock;
        private Label lblVehicleInfo;
        private Label lblVH1L;
        private Label lblVH2L;
        private Label lblVH3L;
        private Label lblVH5L;
        private Label lblVH1;
        private Label lblVH2;
        private Label lblVH3;
        private Label lblVH4;
        private Label lblVH5;
        private PictureBox picWindowsUp;
        private PictureBox picWindowsDown;
        private PictureBox picSunroofClose;
        private PictureBox picSunroofOpen;
        private Label lblLock;
        private Label lblStartStop;
        private Label lblUnlock;
        private Label lblWindowsUp;
        private Label lblWindowsDown;
        private Label lblSunroofClose;
        private Label lblSunroofOpen;
        private Label lblHome;
        private Label lblMap;
        private Label lblMore;
        private Label lblAlarmOn;
        private Label lblAlarmOff;
        private PictureBox picAlarmOn;
        private PictureBox picAlarmOff;
        private PictureBox picBattery;
        private PictureBox picWifi;
        private PictureBox picHome;
        private PictureBox picMap;
        private PictureBox picMore;
        private Label lblVH4L;
    }
}
