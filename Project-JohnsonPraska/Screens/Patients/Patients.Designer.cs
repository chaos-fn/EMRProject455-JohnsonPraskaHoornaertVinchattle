namespace Project_JohnsonPraska
{
    partial class Patients
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
            lblLeftMain = new Label();
            lblMore = new Label();
            lblMap = new Label();
            lblHome = new Label();
            btnCompleteRegistration = new Button();
            txtAddress = new TextBox();
            txtRoom = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblRegistrationTitle = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblRoom = new Label();
            lblAddress = new Label();
            datePickerDOB = new DateTimePicker();
            lblDOB = new Label();
            SuspendLayout();
            // 
            // lblLeftMain
            // 
            lblLeftMain.BackColor = Color.FromArgb(30, 76, 99);
            lblLeftMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblLeftMain.ForeColor = Color.White;
            lblLeftMain.Location = new Point(0, 0);
            lblLeftMain.Margin = new Padding(2, 0, 2, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(1344, 45);
            lblLeftMain.TabIndex = 4;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(765, 404);
            lblMore.Margin = new Padding(2, 0, 2, 0);
            lblMore.Name = "lblMore";
            lblMore.Size = new Size(269, 70);
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
            lblMap.Location = new Point(269, 404);
            lblMap.Margin = new Padding(2, 0, 2, 0);
            lblMap.Name = "lblMap";
            lblMap.Size = new Size(495, 70);
            lblMap.TabIndex = 32;
            lblMap.Text = "Patient Registration";
            lblMap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 404);
            lblHome.Margin = new Padding(2, 0, 2, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(269, 70);
            lblHome.TabIndex = 31;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
            // 
            // btnCompleteRegistration
            // 
            btnCompleteRegistration.BackColor = Color.White;
            btnCompleteRegistration.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteRegistration.Location = new Point(482, 352);
            btnCompleteRegistration.Name = "btnCompleteRegistration";
            btnCompleteRegistration.Size = new Size(150, 40);
            btnCompleteRegistration.TabIndex = 5;
            btnCompleteRegistration.Text = "Register";
            btnCompleteRegistration.UseVisualStyleBackColor = false;
            btnCompleteRegistration.Click += btnCompleteRegistration_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Cambria", 12F);
            txtAddress.Location = new Point(435, 302);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 26);
            txtAddress.TabIndex = 4;
            // 
            // txtRoom
            // 
            txtRoom.Font = new Font("Cambria", 12F);
            txtRoom.Location = new Point(435, 259);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(250, 26);
            txtRoom.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Cambria", 12F);
            txtLastName.Location = new Point(435, 186);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 26);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Cambria", 12F);
            txtFirstName.Location = new Point(435, 143);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 26);
            txtFirstName.TabIndex = 1;
            // 
            // lblRegistrationTitle
            // 
            lblRegistrationTitle.AutoSize = true;
            lblRegistrationTitle.Font = new Font("Cambria", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrationTitle.ForeColor = SystemColors.ControlLightLight;
            lblRegistrationTitle.Location = new Point(296, 48);
            lblRegistrationTitle.Name = "lblRegistrationTitle";
            lblRegistrationTitle.Size = new Size(429, 57);
            lblRegistrationTitle.TabIndex = 49;
            lblRegistrationTitle.Text = "Patient Registration";
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.ControlLightLight;
            lblFirstName.Location = new Point(275, 133);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(150, 40);
            lblFirstName.TabIndex = 121;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = SystemColors.ControlLightLight;
            lblLastName.Location = new Point(275, 176);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(150, 40);
            lblLastName.TabIndex = 122;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRoom
            // 
            lblRoom.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.ForeColor = SystemColors.ControlLightLight;
            lblRoom.Location = new Point(275, 249);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(150, 40);
            lblRoom.TabIndex = 123;
            lblRoom.Text = "Room";
            lblRoom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlLightLight;
            lblAddress.Location = new Point(275, 292);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(150, 40);
            lblAddress.TabIndex = 124;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // datePickerDOB
            // 
            datePickerDOB.Location = new Point(435, 224);
            datePickerDOB.Name = "datePickerDOB";
            datePickerDOB.Size = new Size(200, 23);
            datePickerDOB.TabIndex = 125;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.ForeColor = SystemColors.ControlLightLight;
            lblDOB.Location = new Point(275, 214);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(150, 40);
            lblDOB.TabIndex = 126;
            lblDOB.Text = "Date of Birth";
            lblDOB.TextAlign = ContentAlignment.MiddleRight;
            lblDOB.Click += label1_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1020, 473);
            Controls.Add(lblDOB);
            Controls.Add(datePickerDOB);
            Controls.Add(lblAddress);
            Controls.Add(lblRoom);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnCompleteRegistration);
            Controls.Add(txtAddress);
            Controls.Add(txtRoom);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblRegistrationTitle);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "Patients";
            Text = "Patient";
            Load += Patients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLeftMain;
        private Label lblMore;
        private Label lblMap;
        private Label lblHome;
        private Button btnCompleteRegistration;
        private TextBox txtAddress;
        private TextBox txtRoom;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblRegistrationTitle;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblRoom;
        private Label lblAddress;
        private DateTimePicker datePickerDOB;
        private Label lblDOB;
    }
}