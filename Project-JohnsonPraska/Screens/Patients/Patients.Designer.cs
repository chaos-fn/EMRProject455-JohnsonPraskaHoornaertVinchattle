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
            lblRegistrationAddress = new Label();
            lbRegistrationAge = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblRegistrationTitle = new Label();
            lblPatientID = new Label();
            txtPatientID = new TextBox();
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
            btnCompleteRegistration.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompleteRegistration.Location = new Point(458, 345);
            btnCompleteRegistration.Name = "btnCompleteRegistration";
            btnCompleteRegistration.Size = new Size(86, 30);
            btnCompleteRegistration.TabIndex = 58;
            btnCompleteRegistration.Text = "Register";
            btnCompleteRegistration.UseVisualStyleBackColor = true;
            // 
            // lblRegistrationAddress
            // 
            lblRegistrationAddress.AutoSize = true;
            lblRegistrationAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrationAddress.ForeColor = SystemColors.ControlLightLight;
            lblRegistrationAddress.Location = new Point(592, 245);
            lblRegistrationAddress.Name = "lblRegistrationAddress";
            lblRegistrationAddress.Size = new Size(70, 19);
            lblRegistrationAddress.TabIndex = 57;
            lblRegistrationAddress.Text = "Address:";
            // 
            // lbRegistrationAge
            // 
            lbRegistrationAge.AutoSize = true;
            lbRegistrationAge.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRegistrationAge.ForeColor = SystemColors.ControlLightLight;
            lbRegistrationAge.Location = new Point(356, 245);
            lbRegistrationAge.Name = "lbRegistrationAge";
            lbRegistrationAge.Size = new Size(39, 19);
            lbRegistrationAge.TabIndex = 56;
            lbRegistrationAge.Text = "Age:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = SystemColors.ControlLightLight;
            lblLastName.Location = new Point(596, 143);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 19);
            lblLastName.TabIndex = 55;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.ControlLightLight;
            lblFirstName.Location = new Point(332, 143);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 19);
            lblFirstName.TabIndex = 54;
            lblFirstName.Text = "First Name:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(547, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 53;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 52;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(551, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 51;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 50;
            // 
            // lblRegistrationTitle
            // 
            lblRegistrationTitle.AutoSize = true;
            lblRegistrationTitle.Font = new Font("Cambria", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrationTitle.ForeColor = SystemColors.ControlLightLight;
            lblRegistrationTitle.Location = new Point(283, 45);
            lblRegistrationTitle.Name = "lblRegistrationTitle";
            lblRegistrationTitle.Size = new Size(448, 57);
            lblRegistrationTitle.TabIndex = 49;
            lblRegistrationTitle.Text = "Patirent Registration";
            lblRegistrationTitle.Click += lblRegistrationTitle_Click;
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientID.ForeColor = SystemColors.ControlLightLight;
            lblPatientID.Location = new Point(797, 208);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(81, 19);
            lblPatientID.TabIndex = 60;
            lblPatientID.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(752, 241);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(165, 23);
            txtPatientID.TabIndex = 59;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1020, 473);
            Controls.Add(lblPatientID);
            Controls.Add(txtPatientID);
            Controls.Add(btnCompleteRegistration);
            Controls.Add(lblRegistrationAddress);
            Controls.Add(lbRegistrationAge);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblRegistrationTitle);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Patients";
            Text = "Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLeftMain;
        private Label lblMore;
        private Label lblMap;
        private Label lblHome;
        private Button btnCompleteRegistration;
        private Label lblRegistrationAddress;
        private Label lbRegistrationAge;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblRegistrationTitle;
        private Label lblPatientID;
        private TextBox txtPatientID;
    }
}