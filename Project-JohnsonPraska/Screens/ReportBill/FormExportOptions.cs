using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project_JohnsonPraska.Screens.ReportBill
{


    public partial class FormExportOptions : Form
    {

        public string ExportType => comboBoxFileType.SelectedItem?.ToString() ?? "CSV";

        public FormExportOptions()
        {
            InitializeComponent();
        }

        private void lblLeftMain_Click(object sender, EventArgs e)
        {

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<string> SelectedColumns
        {
            get
            {
                var cols = new List<string>();
                if (checkBoxDate.Checked) cols.Add("Date");
                if (checkBoxClaimID.Checked) cols.Add("ClaimID");
                if (checkBoxAmount.Checked) cols.Add("Amount");
                if (checkBoxStatus.Checked) cols.Add("Status");
                return cols;
            }
        }
    }


}