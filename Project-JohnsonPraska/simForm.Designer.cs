namespace Project_JohnsonPraska
{
    partial class simForm
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
            btnActivateAnom = new Button();
            SuspendLayout();
            // 
            // btnActivateAnom
            // 
            btnActivateAnom.BackColor = Color.FromArgb(64, 64, 64);
            btnActivateAnom.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivateAnom.ForeColor = Color.White;
            btnActivateAnom.Location = new Point(405, 100);
            btnActivateAnom.Name = "btnActivateAnom";
            btnActivateAnom.Size = new Size(150, 100);
            btnActivateAnom.TabIndex = 0;
            btnActivateAnom.Text = "Activate Anomaly";
            btnActivateAnom.UseVisualStyleBackColor = false;
            btnActivateAnom.Click += btnActivateAnom_Click;
            // 
            // simForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(938, 544);
            Controls.Add(btnActivateAnom);
            Name = "simForm";
            Text = "Simulate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnActivateAnom;
    }
}