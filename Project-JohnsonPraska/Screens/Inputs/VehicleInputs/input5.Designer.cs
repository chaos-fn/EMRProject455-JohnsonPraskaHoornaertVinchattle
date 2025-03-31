namespace Project_JohnsonPraska
{
    partial class input5
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
            btnDelete = new Button();
            btnAdd = new Button();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(380, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 50);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(380, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(64, 64, 64);
            txtInput.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(330, 150);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(300, 40);
            txtInput.TabIndex = 3;
            // 
            // input5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(938, 544);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtInput);
            Name = "input5";
            Text = "Driver Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtInput;
    }
}