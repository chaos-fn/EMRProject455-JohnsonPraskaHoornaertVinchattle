namespace Project_JohnsonPraska
{
    partial class input1
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
            lblNumberL = new Label();
            lblEmailL = new Label();
            lblNameLbl = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblNumberL
            // 
            lblNumberL.BackColor = Color.FromArgb(64, 64, 64);
            lblNumberL.BorderStyle = BorderStyle.FixedSingle;
            lblNumberL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblNumberL.ForeColor = Color.White;
            lblNumberL.Location = new Point(280, 320);
            lblNumberL.Name = "lblNumberL";
            lblNumberL.Size = new Size(400, 50);
            lblNumberL.TabIndex = 56;
            lblNumberL.Text = "Phone Number";
            lblNumberL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailL
            // 
            lblEmailL.BackColor = Color.FromArgb(64, 64, 64);
            lblEmailL.BorderStyle = BorderStyle.FixedSingle;
            lblEmailL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblEmailL.ForeColor = Color.White;
            lblEmailL.Location = new Point(280, 170);
            lblEmailL.Name = "lblEmailL";
            lblEmailL.Size = new Size(400, 50);
            lblEmailL.TabIndex = 54;
            lblEmailL.Text = "Email";
            lblEmailL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameLbl
            // 
            lblNameLbl.BackColor = Color.FromArgb(64, 64, 64);
            lblNameLbl.BorderStyle = BorderStyle.FixedSingle;
            lblNameLbl.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblNameLbl.ForeColor = Color.White;
            lblNameLbl.Location = new Point(280, 20);
            lblNameLbl.Name = "lblNameLbl";
            lblNameLbl.Size = new Size(400, 50);
            lblNameLbl.TabIndex = 52;
            lblNameLbl.Text = "Name";
            lblNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 64);
            txtName.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(280, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(400, 45);
            txtName.TabIndex = 57;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(64, 64, 64);
            txtEmail.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(280, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 45);
            txtEmail.TabIndex = 58;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(64, 64, 64);
            txtPhone.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(280, 375);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(400, 45);
            txtPhone.TabIndex = 59;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Cambria", 20F, FontStyle.Bold);
            btnSave.Location = new Point(380, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 55);
            btnSave.TabIndex = 60;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // input1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(938, 544);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblNumberL);
            Controls.Add(lblEmailL);
            Controls.Add(lblNameLbl);
            Name = "input1";
            Text = "Edit User Info";
            Load += input1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumberL;
        private Label lblEmailL;
        private Label lblNameLbl;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnSave;
    }
}