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

        public void SetItems(IEnumerable<string> items, bool checkAll = true)
        {
            checkedListBoxItems.Items.Clear();
            checkedListBoxItems.Items.AddRange(items.ToArray());
            if (checkAll)
                for (int i = 0; i < checkedListBoxItems.Items.Count; i++)
                    checkedListBoxItems.SetItemChecked(i, true);
        }


        public void SetFileTypes(IEnumerable<string> types, string defaultType = null)
        {
            comboBoxFileType.Items.Clear();
            comboBoxFileType.Items.AddRange(types.ToArray());
            comboBoxFileType.SelectedItem = defaultType ?? types.FirstOrDefault();
        }

        public List<string> SelectedItems
    => checkedListBoxItems.CheckedItems.Cast<string>().ToList();

        public string SelectedFileType
            => comboBoxFileType.SelectedItem?.ToString() ?? "CSV";

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

                return cols;
            }
        }

    }


}