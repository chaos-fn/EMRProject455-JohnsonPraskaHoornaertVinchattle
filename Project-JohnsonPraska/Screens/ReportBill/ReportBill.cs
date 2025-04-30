using Project_JohnsonPraska.Screens.ReportBill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_JohnsonPraska.Global;

namespace Project_JohnsonPraska
{
    public partial class ReportBill : Form
    {
        private DateTimePicker dateTimePickerTo2;

        public ReportBill()
        {
            InitializeComponent();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void lblVehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint vehicles = new Appoint();
            vehicles.Closed += (s, args) => this.Close();
            vehicles.Show();
        }

        private void lblDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prescriptions drivers = new Prescriptions();
            drivers.Closed += (s, args) => this.Close();
            drivers.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Session.EmployeeID, Session.FirstName, Session.LastName);
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void lblMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patients map = new Patients();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search help = new Search();
            help.Closed += (s, args) => this.Close();
            help.Show();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {


        }

        private void btnWeek_Click(object sender, EventArgs e)
        {


        }

        private void btnMonth_Click(object sender, EventArgs e)
        {


        }

        private void btnAll_Click(object sender, EventArgs e)
        {


        }

        private void ReportBill_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void daysButton_Click(object sender, EventArgs e)
        {
            dateTimePickerTo.Value = DateTime.Today;
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            dateTimePickerFrom.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerTo.Value = today;
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            int currentQuarter = (today.Month - 1) / 3 + 1;
            int startMonth = (currentQuarter - 1) * 3 + 1;

            dateTimePickerFrom.Value = new DateTime(today.Year, startMonth, 1);
            dateTimePickerTo.Value = today;
        }

        private void daysButton2_Click(object sender, EventArgs e)
        {
            dateTimePickerTo22.Value = DateTime.Today;
            dateTimePickerFrom2.Value = DateTime.Today.AddDays(-7);
        }

        private void monthButton2_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            dateTimePickerFrom2.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerTo22.Value = today;
        }

        private void quarterButton2_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            int currentQuarter = (today.Month - 1) / 3 + 1;
            int startMonth = (currentQuarter - 1) * 3 + 1;

            dateTimePickerFrom2.Value = new DateTime(today.Year, startMonth, 1);
            dateTimePickerTo22.Value = today;
        }

        private void daysButton3_Click(object sender, EventArgs e)
        {
            dateTimePickerTo3.Value = DateTime.Today;
            dateTimePickerFrom3.Value = DateTime.Today.AddDays(-7);
        }

        //Month Button on insruance tab
        private void button5_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            dateTimePickerFrom3.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerTo3.Value = today;
        }

        private void quarterButton3_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            int currentQuarter = (today.Month - 1) / 3 + 1;
            int startMonth = (currentQuarter - 1) * 3 + 1;

            dateTimePickerFrom3.Value = new DateTime(today.Year, startMonth, 1);
            dateTimePickerTo3.Value = today;
        }


        //Colors the datagrid cells into a color depending on the status
        private void dataGridViewClinical_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewClinical.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                var status = e.Value.ToString();
                switch (status)
                {
                    case "Paid":
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Pending":
                        e.CellStyle.BackColor = Color.LightYellow;
                        break;
                    case "Denied":
                        e.CellStyle.BackColor = Color.LightCoral;
                        break;
                }
                e.CellStyle.ForeColor = Color.Black;
                e.FormattingApplied = true;
            }
        }

        private void dataGridViewFinancial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewFinancial.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                var status = e.Value.ToString();
                switch (status)
                {
                    case "Paid":
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Pending":
                        e.CellStyle.BackColor = Color.LightYellow;
                        break;
                    case "Denied":
                        e.CellStyle.BackColor = Color.LightCoral;
                        break;
                }
                e.CellStyle.ForeColor = Color.Black;
                e.FormattingApplied = true;
            }
        }

        private void dataGridViewInsurance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewInsurance.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                var status = e.Value.ToString();
                switch (status)
                {
                    case "Paid":
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Pending":
                        e.CellStyle.BackColor = Color.LightYellow;
                        break;
                    case "Denied":
                        e.CellStyle.BackColor = Color.LightCoral;
                        break;
                }
                e.CellStyle.ForeColor = Color.Black;
                e.FormattingApplied = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void exportPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExportOptionsDialog("PDF");
        }

        private void exportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExportOptionsDialog("CSV");

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        private void ShowExportOptionsDialog(string defaultType)
        {


        }

        private void tsddExport_Click(object sender, EventArgs e)
        {

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using var dlg = new FormExportOptions();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            var exportType = dlg.ExportType;        // "CSV" or "PDF"
            var selectedCols = dlg.SelectedColumns;   // e.g. ["Date","ClaimID","Status"]

            //Choose which data grid to export based on the active tab
            DataGridView dgv;
            if (tabControl1.SelectedTab == tabPage1) dgv = dataGridViewClinical;
            else if (tabControl1.SelectedTab == tabPage2) dgv = dataGridViewFinancial;
            else dgv = dataGridViewInsurance;

            DoExport(dgv, selectedCols, exportType);
        }

        private void DoExport(DataGridView dgv, List<string> cols, string type)
        {
            using var sfd = new SaveFileDialog();
            if (type == "CSV")
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                    ExportToCsv(dgv, cols, sfd.FileName);
            }
            else
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                    ExportToPdf(dgv, cols, sfd.FileName);
            }
        }

        private void ExportToCsv(DataGridView dgv, List<string> cols, string path)
        {
            var sb = new StringBuilder();
            // Header
            sb.AppendLine(string.Join(",", cols));
            // Rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                var values = cols
                    .Select(c => row.Cells[c].Value?.ToString()?.Replace(",", " ") ?? "")
                    .ToArray();
                sb.AppendLine(string.Join(",", values));
            }
            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
            MessageBox.Show("CSV export complete!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToPdf(DataGridView dgv, List<string> cols, string path)
        {

            MessageBox.Show("PDF export not implemented yet.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewClinical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewClinical_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClinical.CurrentRow == null) return;
            int claimId = Convert.ToInt32(
                dataGridViewClinical.CurrentRow.Cells["ClaimID"].Value);

            using var dlg = new FormClaimDetails(claimId);
            dlg.ShowDialog();  // modal
        }

        private void dataGridViewFinancial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFinancial.CurrentRow == null) return;
            int claimId = Convert.ToInt32(
                dataGridViewFinancial.CurrentRow.Cells["ClaimID"].Value);

            using var dlg = new FormClaimDetails(claimId);
            dlg.ShowDialog();  // modal
        }

        private void dataGridViewInsurance_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInsurance.CurrentRow == null) return;
            int claimId = Convert.ToInt32(
                dataGridViewInsurance.CurrentRow.Cells["ClaimID"].Value);

            using var dlg = new FormClaimDetails(claimId);
            dlg.ShowDialog();  // modal
        }
    }
}