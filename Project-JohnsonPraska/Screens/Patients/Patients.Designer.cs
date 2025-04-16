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
            SuspendLayout();
            // 
            // lblLeftMain
            // 
            lblLeftMain.BackColor = Color.FromArgb(30, 76, 99);
            lblLeftMain.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblLeftMain.ForeColor = Color.White;
            lblLeftMain.Location = new Point(0, 0);
            lblLeftMain.Margin = new Padding(4, 0, 4, 0);
            lblLeftMain.Name = "lblLeftMain";
            lblLeftMain.Size = new Size(2496, 96);
            lblLeftMain.TabIndex = 4;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMore
            // 
            lblMore.BackColor = Color.FromArgb(30, 76, 99);
            lblMore.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblMore.ForeColor = Color.White;
            lblMore.Location = new Point(1420, 861);
            lblMore.Margin = new Padding(4, 0, 4, 0);
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
            lblMap.Location = new Point(500, 861);
            lblMap.Margin = new Padding(4, 0, 4, 0);
            lblMap.Name = "lblMap";
            lblMap.Size = new Size(920, 150);
            lblMap.TabIndex = 32;
            lblMap.Text = "Patient Registration";
            lblMap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            lblHome.BackColor = Color.FromArgb(30, 76, 99);
            lblHome.Font = new Font("Cambria", 14F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(0, 861);
            lblHome.Margin = new Padding(4, 0, 4, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(500, 150);
            lblHome.TabIndex = 31;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            lblHome.Click += lblHome_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1894, 1009);
            Controls.Add(lblMore);
            Controls.Add(lblMap);
            Controls.Add(lblHome);
            Controls.Add(lblLeftMain);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Patients";
            Text = "Patient";
            ResumeLayout(false);
        }

        #endregion
        private Label lblLeftMain;
        private Label lblMore;
        private Label lblMap;
        private Label lblHome;
    }
}