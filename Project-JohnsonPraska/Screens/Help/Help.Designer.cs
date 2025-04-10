namespace Project_JohnsonPraska
{
    partial class Help
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
            lblHelp = new Label();
            lblActivity = new Label();
            lblDrivers = new Label();
            lblVehicles = new Label();
            lblAccount = new Label();
            lblMore = new Label();
            lblMap = new Label();
            lblHome = new Label();
            lblLeftMain = new Label();
            SuspendLayout();
            // 
            // lblHelp
            // 
            lblHelp.BorderStyle = BorderStyle.Fixed3D;
            lblHelp.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblHelp.ForeColor = Color.White;
            lblHelp.Location = new Point(0, 695);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(240, 155);
            lblHelp.TabIndex = 119;
            lblHelp.Text = "Help";
            lblHelp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActivity
            // 
            lblActivity.BorderStyle = BorderStyle.Fixed3D;
            lblActivity.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblActivity.ForeColor = Color.White;
            lblActivity.Location = new Point(0, 540);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(240, 155);
            lblActivity.TabIndex = 118;
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
            lblDrivers.TabIndex = 117;
            lblDrivers.Text = "Drivers";
            lblDrivers.TextAlign = ContentAlignment.MiddleCenter;
            lblDrivers.Click += lblDrivers_Click;
            // 
            // lblVehicles
            // 
            lblVehicles.BorderStyle = BorderStyle.Fixed3D;
            lblVehicles.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblVehicles.ForeColor = Color.White;
            lblVehicles.Location = new Point(0, 230);
            lblVehicles.Name = "lblVehicles";
            lblVehicles.Size = new Size(240, 155);
            lblVehicles.TabIndex = 116;
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
            lblAccount.TabIndex = 115;
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
            lblMore.TabIndex = 114;
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
            lblMap.TabIndex = 113;
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
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(1920, 75);
            lblLeftMain.TabIndex = 111;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(17F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1898, 949);
            Controls.Add(lblHelp);
            Controls.Add(lblActivity);
            Controls.Add(lblDrivers);
            Controls.Add(lblVehicles);
            Controls.Add(lblAccount);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Help";
            Text = "Help";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private Label lblHelp;
        private Label lblActivity;
        private Label lblDrivers;
        private Label lblVehicles;
        private Label lblAccount;
        private Label lblMore;
        private Label lblMap;
        private Label lblHome;
        private Label lblLeftMain;
    }
}