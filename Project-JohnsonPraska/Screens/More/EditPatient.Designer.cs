namespace Project_JohnsonPraska.Screens.More
{
    partial class EditPatient
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
            lblDOB = new Label();
            datePickerDOB = new DateTimePicker();
            lblAddress = new Label();
            lblRoom = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnConfirmPatient = new Button();
            txtAddress = new TextBox();
            txtRoom = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblRegistrationTitle = new Label();
            SuspendLayout();
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.ForeColor = SystemColors.ControlLightLight;
            lblDOB.Location = new Point(225, 277);
            lblDOB.Margin = new Padding(4, 0, 4, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(193, 51);
            lblDOB.TabIndex = 138;
            lblDOB.Text = "Date of Birth*";
            lblDOB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // datePickerDOB
            // 
            datePickerDOB.CalendarForeColor = Color.White;
            datePickerDOB.CalendarTitleBackColor = Color.FromArgb(64, 64, 64);
            datePickerDOB.CalendarTitleForeColor = Color.White;
            datePickerDOB.Location = new Point(431, 290);
            datePickerDOB.Margin = new Padding(4);
            datePickerDOB.Name = "datePickerDOB";
            datePickerDOB.Size = new Size(320, 26);
            datePickerDOB.TabIndex = 137;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlLightLight;
            lblAddress.Location = new Point(225, 376);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(193, 51);
            lblAddress.TabIndex = 136;
            lblAddress.Text = "Address*";
            lblAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRoom
            // 
            lblRoom.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.ForeColor = SystemColors.ControlLightLight;
            lblRoom.Location = new Point(225, 322);
            lblRoom.Margin = new Padding(4, 0, 4, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(193, 51);
            lblRoom.TabIndex = 135;
            lblRoom.Text = "Room";
            lblRoom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = SystemColors.ControlLightLight;
            lblLastName.Location = new Point(225, 229);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(193, 51);
            lblLastName.TabIndex = 134;
            lblLastName.Text = "Last Name*";
            lblLastName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.ControlLightLight;
            lblFirstName.Location = new Point(225, 175);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(193, 51);
            lblFirstName.TabIndex = 133;
            lblFirstName.Text = "First Name*";
            lblFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnConfirmPatient
            // 
            btnConfirmPatient.BackColor = Color.White;
            btnConfirmPatient.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPatient.Location = new Point(491, 452);
            btnConfirmPatient.Margin = new Padding(4);
            btnConfirmPatient.Name = "btnConfirmPatient";
            btnConfirmPatient.Size = new Size(193, 51);
            btnConfirmPatient.TabIndex = 131;
            btnConfirmPatient.Text = "Confirm";
            btnConfirmPatient.UseVisualStyleBackColor = false;
            btnConfirmPatient.Click += btnConfirmPatient_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Cambria", 12F);
            txtAddress.Location = new Point(431, 389);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(320, 26);
            txtAddress.TabIndex = 130;
            // 
            // txtRoom
            // 
            txtRoom.Font = new Font("Cambria", 12F);
            txtRoom.Location = new Point(431, 334);
            txtRoom.Margin = new Padding(4);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(320, 26);
            txtRoom.TabIndex = 129;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Cambria", 12F);
            txtLastName.Location = new Point(431, 242);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(320, 26);
            txtLastName.TabIndex = 128;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Cambria", 12F);
            txtFirstName.Location = new Point(431, 187);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(320, 26);
            txtFirstName.TabIndex = 127;
            // 
            // lblRegistrationTitle
            // 
            lblRegistrationTitle.AutoSize = true;
            lblRegistrationTitle.Font = new Font("Cambria", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrationTitle.ForeColor = SystemColors.ControlLightLight;
            lblRegistrationTitle.Location = new Point(252, 67);
            lblRegistrationTitle.Margin = new Padding(4, 0, 4, 0);
            lblRegistrationTitle.Name = "lblRegistrationTitle";
            lblRegistrationTitle.Size = new Size(426, 57);
            lblRegistrationTitle.TabIndex = 132;
            lblRegistrationTitle.Text = "Patient Information";
            // 
            // EditPatient
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1029, 570);
            Controls.Add(lblDOB);
            Controls.Add(datePickerDOB);
            Controls.Add(lblAddress);
            Controls.Add(lblRoom);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnConfirmPatient);
            Controls.Add(txtAddress);
            Controls.Add(txtRoom);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblRegistrationTitle);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EditPatient";
            Text = "EditPatient";
            Load += EditPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDOB;
        private DateTimePicker datePickerDOB;
        private Label lblAddress;
        private Label lblRoom;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnConfirmPatient;
        private TextBox txtAddress;
        private TextBox txtRoom;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblRegistrationTitle;
    }
}