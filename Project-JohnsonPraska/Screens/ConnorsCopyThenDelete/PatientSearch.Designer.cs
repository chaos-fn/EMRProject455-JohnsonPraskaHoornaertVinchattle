namespace Project_JohnsonPraska.Screens.Patient
{
    partial class PatientSearch
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
            lblTitle = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnFilterName = new Button();
            btnFilterAge = new Button();
            btnFilterRoom = new Button();
            btnFilterStatus = new Button();
            btnAddPatient = new Button();
            btnSearch = new Button();
            listView1 = new ListView();
            ID = new ColumnHeader();
            Image = new ColumnHeader();
            Name = new ColumnHeader();
            Age = new ColumnHeader();
            Room = new ColumnHeader();
            Status = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Cambria", 20F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(150, 75);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 50);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "Patient Search";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(150, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 30);
            textBox1.TabIndex = 24;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(600, 75);
            label1.Name = "label1";
            label1.Size = new Size(250, 50);
            label1.TabIndex = 25;
            label1.Text = "Patient Information";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(600, 139);
            label2.Name = "label2";
            label2.Size = new Size(150, 50);
            label2.TabIndex = 27;
            label2.Text = "Filter By:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnFilterName
            // 
            btnFilterName.BackColor = Color.White;
            btnFilterName.FlatAppearance.BorderColor = Color.Black;
            btnFilterName.FlatStyle = FlatStyle.Flat;
            btnFilterName.Font = new Font("Cambria", 12F);
            btnFilterName.Location = new Point(688, 146);
            btnFilterName.Name = "btnFilterName";
            btnFilterName.Size = new Size(100, 40);
            btnFilterName.TabIndex = 28;
            btnFilterName.Text = "Name";
            btnFilterName.UseVisualStyleBackColor = false;
            btnFilterName.Click += btnFilterName_Click;
            // 
            // btnFilterAge
            // 
            btnFilterAge.BackColor = Color.White;
            btnFilterAge.FlatAppearance.BorderColor = Color.Black;
            btnFilterAge.FlatStyle = FlatStyle.Flat;
            btnFilterAge.Font = new Font("Cambria", 12F);
            btnFilterAge.Location = new Point(794, 146);
            btnFilterAge.Name = "btnFilterAge";
            btnFilterAge.Size = new Size(100, 40);
            btnFilterAge.TabIndex = 29;
            btnFilterAge.Text = "Age";
            btnFilterAge.UseVisualStyleBackColor = false;
            btnFilterAge.Click += btnFilterAge_Click;
            // 
            // btnFilterRoom
            // 
            btnFilterRoom.BackColor = Color.White;
            btnFilterRoom.FlatAppearance.BorderColor = Color.Black;
            btnFilterRoom.FlatStyle = FlatStyle.Flat;
            btnFilterRoom.Font = new Font("Cambria", 12F);
            btnFilterRoom.Location = new Point(900, 146);
            btnFilterRoom.Name = "btnFilterRoom";
            btnFilterRoom.Size = new Size(100, 40);
            btnFilterRoom.TabIndex = 30;
            btnFilterRoom.Text = "Room";
            btnFilterRoom.UseVisualStyleBackColor = false;
            btnFilterRoom.Click += btnFilterRoom_Click;
            // 
            // btnFilterStatus
            // 
            btnFilterStatus.BackColor = Color.White;
            btnFilterStatus.FlatAppearance.BorderColor = Color.Black;
            btnFilterStatus.FlatStyle = FlatStyle.Flat;
            btnFilterStatus.Font = new Font("Cambria", 12F);
            btnFilterStatus.Location = new Point(1006, 146);
            btnFilterStatus.Name = "btnFilterStatus";
            btnFilterStatus.Size = new Size(100, 40);
            btnFilterStatus.TabIndex = 31;
            btnFilterStatus.Text = "Status";
            btnFilterStatus.UseVisualStyleBackColor = false;
            btnFilterStatus.Click += btnFilterStatus_Click;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.White;
            btnAddPatient.FlatAppearance.BorderColor = Color.Black;
            btnAddPatient.FlatStyle = FlatStyle.Flat;
            btnAddPatient.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.Location = new Point(1150, 146);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(150, 40);
            btnAddPatient.TabIndex = 32;
            btnAddPatient.Text = "Add New Patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(200, 215);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 40);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Image, Name, Age, Room, Status });
            listView1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(600, 215);
            listView1.Name = "listView1";
            listView1.Size = new Size(700, 500);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // PatientSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1904, 1041);
            Controls.Add(listView1);
            Controls.Add(btnSearch);
            Controls.Add(btnAddPatient);
            Controls.Add(btnFilterStatus);
            Controls.Add(btnFilterRoom);
            Controls.Add(btnFilterAge);
            Controls.Add(btnFilterName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1038);
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button btnFilterName;
        private Button btnFilterAge;
        private Button btnFilterRoom;
        private Button btnFilterStatus;
        private Button btnAddPatient;
        private Button btnSearch;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Image;
        private ColumnHeader Name;
        private ColumnHeader Age;
        private ColumnHeader Room;
        private ColumnHeader Status;
    }
}