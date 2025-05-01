namespace Project_JohnsonPraska.Screens.Prescriptions
{
    partial class FormEditMed
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
            bottomBar = new Label();
            saveButton = new Button();
            comboBoxFrequency = new ComboBox();
            frequencylbl = new Label();
            comboBoxRoute = new ComboBox();
            routelbl = new Label();
            comboBoxDoseUnit = new ComboBox();
            doselbl = new Label();
            numericUpDownDose = new NumericUpDown();
            drugNamelbl = new Label();
            drugNameTextBox = new TextBox();
            pescriptionComposelbl = new Label();
            textBoxInstruction = new TextBox();
            instructionslbl = new Label();
            checkBoxFilled = new CheckBox();
            buttonCancel = new Button();
            Quantitylbl = new Label();
            numericUpDownQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
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
            lblLeftMain.Size = new Size(801, 51);
            lblLeftMain.TabIndex = 80;
            lblLeftMain.Text = "  Wed. 10:12";
            lblLeftMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bottomBar
            // 
            bottomBar.BackColor = Color.FromArgb(30, 76, 99);
            bottomBar.Font = new Font("Cambria", 14F, FontStyle.Bold);
            bottomBar.ForeColor = Color.White;
            bottomBar.Location = new Point(0, 691);
            bottomBar.Margin = new Padding(4, 0, 4, 0);
            bottomBar.Name = "bottomBar";
            bottomBar.Size = new Size(801, 51);
            bottomBar.TabIndex = 81;
            bottomBar.TextAlign = ContentAlignment.MiddleLeft;
            bottomBar.Click += label1_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DarkSlateGray;
            saveButton.Location = new Point(292, 599);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(207, 72);
            saveButton.TabIndex = 92;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // comboBoxFrequency
            // 
            comboBoxFrequency.FormattingEnabled = true;
            comboBoxFrequency.Location = new Point(188, 402);
            comboBoxFrequency.Name = "comboBoxFrequency";
            comboBoxFrequency.Size = new Size(148, 23);
            comboBoxFrequency.TabIndex = 91;
            // 
            // frequencylbl
            // 
            frequencylbl.AutoSize = true;
            frequencylbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frequencylbl.ForeColor = SystemColors.ControlLightLight;
            frequencylbl.Location = new Point(188, 374);
            frequencylbl.Name = "frequencylbl";
            frequencylbl.Size = new Size(107, 25);
            frequencylbl.TabIndex = 90;
            frequencylbl.Text = "Frequency";
            frequencylbl.Click += frequencylbl_Click;
            // 
            // comboBoxRoute
            // 
            comboBoxRoute.FormattingEnabled = true;
            comboBoxRoute.Location = new Point(188, 320);
            comboBoxRoute.Name = "comboBoxRoute";
            comboBoxRoute.Size = new Size(148, 23);
            comboBoxRoute.TabIndex = 89;
            comboBoxRoute.SelectedIndexChanged += comboBoxRoute_SelectedIndexChanged;
            // 
            // routelbl
            // 
            routelbl.AutoSize = true;
            routelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            routelbl.ForeColor = SystemColors.ControlLightLight;
            routelbl.Location = new Point(188, 292);
            routelbl.Name = "routelbl";
            routelbl.Size = new Size(65, 25);
            routelbl.TabIndex = 88;
            routelbl.Text = "Route";
            routelbl.Click += routelbl_Click;
            // 
            // comboBoxDoseUnit
            // 
            comboBoxDoseUnit.FormattingEnabled = true;
            comboBoxDoseUnit.Location = new Point(336, 244);
            comboBoxDoseUnit.Name = "comboBoxDoseUnit";
            comboBoxDoseUnit.Size = new Size(121, 23);
            comboBoxDoseUnit.TabIndex = 87;
            // 
            // doselbl
            // 
            doselbl.AutoSize = true;
            doselbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doselbl.ForeColor = SystemColors.ControlLightLight;
            doselbl.Location = new Point(188, 217);
            doselbl.Name = "doselbl";
            doselbl.Size = new Size(133, 25);
            doselbl.TabIndex = 86;
            doselbl.Text = "Dose Amount";
            // 
            // numericUpDownDose
            // 
            numericUpDownDose.Location = new Point(188, 245);
            numericUpDownDose.Name = "numericUpDownDose";
            numericUpDownDose.Size = new Size(133, 23);
            numericUpDownDose.TabIndex = 85;
            // 
            // drugNamelbl
            // 
            drugNamelbl.AutoSize = true;
            drugNamelbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drugNamelbl.ForeColor = SystemColors.ButtonHighlight;
            drugNamelbl.Location = new Point(188, 133);
            drugNamelbl.Name = "drugNamelbl";
            drugNamelbl.Size = new Size(113, 25);
            drugNamelbl.TabIndex = 84;
            drugNamelbl.Text = "Drug Name";
            // 
            // drugNameTextBox
            // 
            drugNameTextBox.Location = new Point(188, 161);
            drugNameTextBox.Name = "drugNameTextBox";
            drugNameTextBox.Size = new Size(424, 23);
            drugNameTextBox.TabIndex = 83;
            // 
            // pescriptionComposelbl
            // 
            pescriptionComposelbl.AutoSize = true;
            pescriptionComposelbl.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pescriptionComposelbl.ForeColor = SystemColors.ControlLightLight;
            pescriptionComposelbl.Location = new Point(244, 66);
            pescriptionComposelbl.Name = "pescriptionComposelbl";
            pescriptionComposelbl.Size = new Size(271, 34);
            pescriptionComposelbl.TabIndex = 82;
            pescriptionComposelbl.Text = "Perscription Editor";
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.Location = new Point(188, 486);
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.Size = new Size(424, 23);
            textBoxInstruction.TabIndex = 94;
            // 
            // instructionslbl
            // 
            instructionslbl.AutoSize = true;
            instructionslbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionslbl.ForeColor = SystemColors.ControlLightLight;
            instructionslbl.Location = new Point(188, 458);
            instructionslbl.Name = "instructionslbl";
            instructionslbl.Size = new Size(122, 25);
            instructionslbl.TabIndex = 93;
            instructionslbl.Text = "Instructions";
            // 
            // checkBoxFilled
            // 
            checkBoxFilled.AutoSize = true;
            checkBoxFilled.ForeColor = SystemColors.ControlLightLight;
            checkBoxFilled.Location = new Point(366, 402);
            checkBoxFilled.Name = "checkBoxFilled";
            checkBoxFilled.Size = new Size(54, 19);
            checkBoxFilled.TabIndex = 95;
            checkBoxFilled.Text = "Filled";
            checkBoxFilled.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkSlateGray;
            buttonCancel.Location = new Point(583, 610);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(159, 51);
            buttonCancel.TabIndex = 96;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Quantitylbl
            // 
            Quantitylbl.AutoSize = true;
            Quantitylbl.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quantitylbl.ForeColor = SystemColors.ControlLightLight;
            Quantitylbl.Location = new Point(479, 217);
            Quantitylbl.Name = "Quantitylbl";
            Quantitylbl.Size = new Size(96, 25);
            Quantitylbl.TabIndex = 97;
            Quantitylbl.Text = "Quantity ";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(479, 245);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(133, 23);
            numericUpDownQuantity.TabIndex = 98;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormEditMed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 741);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(Quantitylbl);
            Controls.Add(buttonCancel);
            Controls.Add(checkBoxFilled);
            Controls.Add(textBoxInstruction);
            Controls.Add(instructionslbl);
            Controls.Add(saveButton);
            Controls.Add(comboBoxFrequency);
            Controls.Add(frequencylbl);
            Controls.Add(comboBoxRoute);
            Controls.Add(routelbl);
            Controls.Add(comboBoxDoseUnit);
            Controls.Add(doselbl);
            Controls.Add(numericUpDownDose);
            Controls.Add(drugNamelbl);
            Controls.Add(drugNameTextBox);
            Controls.Add(pescriptionComposelbl);
            Controls.Add(bottomBar);
            Controls.Add(lblLeftMain);
            Name = "FormEditMed";
            Text = "FormEditMed";
            Load += FormEditMed_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDose).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeftMain;
        private Label bottomBar;
        private Button saveButton;
        private ComboBox comboBoxFrequency;
        private Label frequencylbl;
        private ComboBox comboBoxRoute;
        private Label routelbl;
        private ComboBox comboBoxDoseUnit;
        private Label doselbl;
        private NumericUpDown numericUpDownDose;
        private Label drugNamelbl;
        private TextBox drugNameTextBox;
        private Label pescriptionComposelbl;
        private TextBox textBoxInstruction;
        private Label instructionslbl;
        private CheckBox checkBoxFilled;
        private Button buttonCancel;
        private Label Quantitylbl;
        private NumericUpDown numericUpDownQuantity;
    }
}