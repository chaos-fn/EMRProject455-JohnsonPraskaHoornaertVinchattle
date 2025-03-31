namespace Project_JohnsonPraska
{
    partial class input3
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
            lblDefaultVHL = new Label();
            lblAgeL = new Label();
            lblNameL = new Label();
            btnSave = new Button();
            txtDefaultVH = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblDefaultVHL
            // 
            lblDefaultVHL.BackColor = Color.FromArgb(64, 64, 64);
            lblDefaultVHL.BorderStyle = BorderStyle.FixedSingle;
            lblDefaultVHL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblDefaultVHL.ForeColor = Color.White;
            lblDefaultVHL.Location = new Point(280, 320);
            lblDefaultVHL.Name = "lblDefaultVHL";
            lblDefaultVHL.Size = new Size(400, 50);
            lblDefaultVHL.TabIndex = 104;
            lblDefaultVHL.Text = "Default Vehicle";
            lblDefaultVHL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAgeL
            // 
            lblAgeL.BackColor = Color.FromArgb(64, 64, 64);
            lblAgeL.BorderStyle = BorderStyle.FixedSingle;
            lblAgeL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblAgeL.ForeColor = Color.White;
            lblAgeL.Location = new Point(280, 170);
            lblAgeL.Name = "lblAgeL";
            lblAgeL.Size = new Size(400, 50);
            lblAgeL.TabIndex = 102;
            lblAgeL.Text = "Age";
            lblAgeL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameL
            // 
            lblNameL.BackColor = Color.FromArgb(64, 64, 64);
            lblNameL.BorderStyle = BorderStyle.FixedSingle;
            lblNameL.Font = new Font("Cambria", 20F, FontStyle.Bold | FontStyle.Underline);
            lblNameL.ForeColor = Color.White;
            lblNameL.Location = new Point(280, 20);
            lblNameL.Name = "lblNameL";
            lblNameL.Size = new Size(400, 50);
            lblNameL.TabIndex = 100;
            lblNameL.Text = "Name";
            lblNameL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Cambria", 20F, FontStyle.Bold);
            btnSave.Location = new Point(380, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 55);
            btnSave.TabIndex = 106;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDefaultVH
            // 
            txtDefaultVH.BackColor = Color.FromArgb(64, 64, 64);
            txtDefaultVH.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDefaultVH.ForeColor = Color.White;
            txtDefaultVH.Location = new Point(280, 370);
            txtDefaultVH.Name = "txtDefaultVH";
            txtDefaultVH.Size = new Size(400, 45);
            txtDefaultVH.TabIndex = 109;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(64, 64, 64);
            txtAge.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.ForeColor = Color.White;
            txtAge.Location = new Point(280, 220);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(400, 45);
            txtAge.TabIndex = 108;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 64);
            txtName.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(280, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(400, 45);
            txtName.TabIndex = 107;
            // 
            // input3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(938, 544);
            Controls.Add(txtDefaultVH);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(lblDefaultVHL);
            Controls.Add(lblAgeL);
            Controls.Add(lblNameL);
            Name = "input3";
            Text = "Edit Driver Info";
            Load += input3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDefaultVHL;
        private Label lblAgeL;
        private Label lblNameL;
        private Button btnSave;
        private TextBox txtDefaultVH;
        private TextBox txtAge;
        private TextBox txtName;
    }
}