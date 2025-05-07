namespace Project_JohnsonPraska.Screens.Login
{
    partial class Login
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
            lblBadge = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblPIN = new Label();
            txtPIN = new TextBox();
            lblMessage = new Label();
            btnLogin = new Button();
            btnEnter = new Button();
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
            lblLeftMain.Size = new Size(1038, 51);
            lblLeftMain.TabIndex = 37;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBadge
            // 
            lblBadge.Anchor = AnchorStyles.Top;
            lblBadge.AutoSize = true;
            lblBadge.Font = new Font("Cambria", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBadge.ForeColor = SystemColors.ControlLightLight;
            lblBadge.Location = new Point(273, 114);
            lblBadge.Name = "lblBadge";
            lblBadge.Size = new Size(392, 57);
            lblBadge.TabIndex = 38;
            lblBadge.Text = "Tap badge to start";
            lblBadge.Click += lblBadge_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(306, 255);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(122, 23);
            txtUsername.TabIndex = 1;
            txtUsername.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(493, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(122, 23);
            txtPassword.TabIndex = 2;
            txtPassword.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(294, 218);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(150, 28);
            lblUsername.TabIndex = 41;
            lblUsername.Text = "Employee ID:";
            lblUsername.Visible = false;
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(493, 218);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(119, 28);
            lblPassword.TabIndex = 42;
            lblPassword.Text = "Password:";
            lblPassword.Visible = false;
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.Font = new Font("Cambria", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPIN.ForeColor = SystemColors.ControlLightLight;
            lblPIN.Location = new Point(362, 193);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(226, 57);
            lblPIN.TabIndex = 43;
            lblPIN.Text = "Enter PIN";
            lblPIN.Visible = false;
            lblPIN.Click += lblPIN_Click;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(415, 309);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(93, 23);
            txtPIN.TabIndex = 4;
            txtPIN.Visible = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.ControlLightLight;
            lblMessage.Location = new Point(273, 81);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(401, 64);
            lblMessage.TabIndex = 45;
            lblMessage.Text = "Badge did not register. \r\nEnter employee ID and password.";
            lblMessage.TextAlign = ContentAlignment.TopCenter;
            lblMessage.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(426, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(70, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Visible = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(426, 424);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(70, 28);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Visible = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(947, 504);
            Controls.Add(btnEnter);
            Controls.Add(btnLogin);
            Controls.Add(lblMessage);
            Controls.Add(txtPIN);
            Controls.Add(lblPIN);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblLeftMain);
            Controls.Add(lblBadge);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeftMain;
        private Label lblBadge;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblPIN;
        private TextBox txtPIN;
        private Label lblMessage;
        private Button btnLogin;
        private Button btnEnter;
    }
}