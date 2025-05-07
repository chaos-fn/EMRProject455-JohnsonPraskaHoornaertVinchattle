using Project_JohnsonPraska.Screens.Prescriptions;
using Project_JohnsonPraska.Screens.ReportBill;
using Project_JohnsonPraska.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_JohnsonPraska.Screens.Prescriptions.prescriptionService;

namespace Project_JohnsonPraska
{

    public partial class ReportBill : Form
    {


        private int _currentPatientId = -1;

        private readonly BillingInvoiceRepository _invRepo = new BillingInvoiceRepository();
        private readonly ReportBillService _rbService = new ReportBillService();
        private readonly prescriptionService _rxService = new prescriptionService();

        public ReportBill()
        {
            InitializeComponent();
            LoadInsuranceTab();
        }
        private void currentlbl_Click(object sender, EventArgs e)
        {

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
            RefreshFinancialGrid();
        }

        private void monthButton2_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            dateTimePickerFrom2.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerTo22.Value = today;
            RefreshFinancialGrid();
        }

        private void quarterButton2_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            int currentQuarter = (today.Month - 1) / 3 + 1;
            int startMonth = (currentQuarter - 1) * 3 + 1;

            dateTimePickerFrom2.Value = new DateTime(today.Year, startMonth, 1);
            dateTimePickerTo22.Value = today;
            RefreshFinancialGrid();
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


            dlg.SetItems(new[] {
                        "Appointments",
                        "Prescriptions",
                        "Notes",
                        "Medical Record"
                         });


            dlg.SetFileTypes(new[] { "CSV", "PDF" }, defaultType: "CSV");

            if (dlg.ShowDialog() != DialogResult.OK)
                return;


            var panelsToExport = dlg.SelectedItems;
            var fileType = dlg.SelectedFileType;

            foreach (var panel in panelsToExport)
            {
                switch (panel)
                {
                    case "Appointments":
                        DoExport(
                            dgvAppointments,
                            null,             // null = export all columns
                            fileType,
                            "Appointments");
                        break;

                    case "Prescriptions":
                        DoExport(
                            dgvPrescriptions,
                            null,
                            fileType,
                            "Prescriptions");
                        break;

                    case "Notes":
                        DoExport(
                            dgvNotes,
                            null,
                            fileType,
                            "Notes");
                        break;

                    case "Medical Record":
                        ExportMedicalRecord(fileType);
                        break;
                }
            }
        }

        private void DoExport(
                    DataGridView dgv,
                    List<string>? cols,
                    string type,
                    string fileSuffix)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = type == "CSV"
                ? "CSV files (*.csv)|*.csv"
                : "PDF files (*.pdf)|*.pdf";
            sfd.FileName = $"{lblCurrentPatient.Text}_{fileSuffix}.{type.ToLower()}";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            if (type == "CSV")
                ExportToCsv(dgv, cols, sfd.FileName);
            else
                ExportToPdf(dgv, cols, sfd.FileName);
        }

        private void ExportMedicalRecord(string type)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = type == "CSV"
                ? "CSV files (*.csv)|*.csv"
                : "PDF files (*.pdf)|*.pdf";
            sfd.FileName = $"{lblCurrentPatient.Text}_MedicalRecord.{type.ToLower()}";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            if (type == "CSV")
            {
                var lines = new[]
                {
            $"MedicalHistory,\"{lblHistory.Text.Replace("\"","\"\"")}\"",
            $"Allergies,\"{lblAllergies.Text.Replace("\"","\"\"")}\""
        };
                File.WriteAllLines(sfd.FileName, lines);
                MessageBox.Show("CSV export complete!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // stub PDF export
                MessageBox.Show("PDF export not implemented yet.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToCsv(DataGridView dgv, List<string>? cols, string filePath)
        {
            // Determine which columns to export
            var columnNames = cols
                ?? dgv.Columns
                      .Cast<DataGridViewColumn>()
                      .Select(c => c.Name)
                      .ToList();

            var sb = new StringBuilder();

            // 1) Header row
            sb.AppendLine(string.Join(",", columnNames));

            // 2) Data rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                var values = columnNames.Select(colName =>
                {
                    var cell = row.Cells[colName]?.Value;
                    var text = cell?.ToString() ?? "";

                    // Escape quotes by doubling them
                    text = text.Replace("\"", "\"\"");

                    // If text contains comma, quote, or newline, wrap in quotes
                    if (text.IndexOfAny(new[] { ',', '"', '\n' }) >= 0)
                        text = $"\"{text}\"";

                    return text;
                });

                sb.AppendLine(string.Join(",", values));
            }

            // 3) Write file
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

            MessageBox.Show("CSV export complete!", "Export",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToPdf(DataGridView dgv, List<string> cols, string path)
        {

            MessageBox.Show("PDF export not implemented yet.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewClinical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewFinancial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFinancial.CurrentRow == null) return;
            int claimId = Convert.ToInt32(
                dataGridViewFinancial.CurrentRow.Cells["InvoiceID"].Value);

            using var dlg = new FormClaimDetails(claimId);
            dlg.ShowDialog();
        }

        private void dataGridViewInsurance_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInsurance.CurrentRow == null) return;
            int claimId = Convert.ToInt32(
                dataGridViewInsurance.CurrentRow.Cells["ClaimID"].Value);

            using var dlg = new FormClaimDetails(claimId);
            dlg.ShowDialog();  // modal
        }

        private void lblCurrentPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPatient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPatientId.Text.Trim(), out var id))
            {
                MessageBox.Show("Enter a valid numeric Patient ID.", "Invalid ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = _rxService.GetPatientById(id);
            if (patient == null)
            {
                MessageBox.Show($"No patient found with ID {id}.", "Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCurrentPatient.Text = "No patient selected";
                _currentPatientId = -1;
                dataGridViewFinancial.DataSource = null;
            }
            else
            {
                _currentPatientId = patient.PatientID;
                lblCurrentPatient.Text = $"{patient.Fname} {patient.Lname} (ID: {_currentPatientId})";
                RefreshFinancialGrid();
                RefreshClinicalTab();
                //RefreshInsuranceGrid();
            }
        }
        private void RefreshFinancialGrid()
        {
            if (_currentPatientId < 0) return;

            // 1. Read the date range from your controls
            var start = dateTimePickerFrom2.Value.Date;
            var end = dateTimePickerTo22.Value.Date.AddDays(1).AddSeconds(-1);

            // 2. Load filtered invoices
            var list = _invRepo.GetInvoicesByPatient(_currentPatientId, start, end);
            dataGridViewFinancial.DataSource = list;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshClinicalTab()
        {
            if (_currentPatientId < 0) return;

            var start = dateTimePickerFrom.Value.Date;
            var end = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1);

            
            dgvAppointments.DataSource =
                _rbService.GetRecentAppointments(_currentPatientId, start, end);
            
            var prescs = _rbService.GetRecentPrescriptions(_currentPatientId);
            dgvPrescriptions.DataSource = prescs;

            
            var notes = _rbService.GetRecentNotes(_currentPatientId);
            dgvNotes.DataSource = notes;

            
            var mr = _rbService.GetRecord(_currentPatientId);
            lblHistorytxt.Text = mr?.MedicalHistory ?? "(none)";
            lblAllergiestxt.Text = mr?.Allergies ?? "(none)";

            
            dgvAppointments.Columns["Date"].HeaderText = "Date";
            dgvAppointments.Columns["Type"].HeaderText = "Visit Type";
            dgvAppointments.Columns["Physician"].HeaderText = "Doctor";
            dgvAppointments.Columns["Status"].HeaderText = "Status";

            dgvPrescriptions.Columns["DrugName"].HeaderText = "Drug";
            dgvPrescriptions.Columns["Dosage"].HeaderText = "Dosage";
            dgvPrescriptions.Columns["Route"].HeaderText = "Route";
            dgvPrescriptions.Columns["Frequency"].HeaderText = "Frequency";
            dgvPrescriptions.Columns["Filled"].HeaderText = "Filled";

            if (dgvNotes.Columns.Contains("Date"))
                dgvNotes.Columns.Remove("Date");
            dgvNotes.Columns["Snippet"].HeaderText = "Note Snippet";
            dgvNotes.Columns["Author"].HeaderText = "Author";
            
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshClinicalTab();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            RefreshClinicalTab();
        }

        private void btnExportFinancial_Click(object sender, EventArgs e)
        {
            ExportFinancial();
        }

        private void ExportFinancial()
        {
            using var dlg = new FormExportOptions();

            // Offer the billing-invoice fields for export
            dlg.SetItems(new[]
                            {
                        "Date",
                        "Description",
                        "Price",
                        "Status"
                    });

            // Offer CSV/PDF
            dlg.SetFileTypes(new[] { "CSV", "PDF" }, defaultType: "CSV");

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            var cols = dlg.SelectedItems;     // e.g. ["Date","Price"]
            var fileType = dlg.SelectedFileType;  // "CSV" or "PDF"

            DoExport(
                dataGridViewFinancial,
                cols,
                fileType,
                "Financial");
        }

        private void exportButton2_Click(object sender, EventArgs e)
        {
            ExportFinancial();
        }

        private void dateTimePickerFrom2_ValueChanged(object sender, EventArgs e)
        {
            RefreshFinancialGrid();
        }

        private void dateTimePickerTo22_ValueChanged(object sender, EventArgs e)
        {
            RefreshFinancialGrid();
        }

        private void LoadInsuranceTab()
        {
            var companies = _rbService.GetAllInsuranceCompanies();
            dataGridViewInsurance.DataSource = companies;
        }

        private void exportButton3_Click(object sender, EventArgs e)
        {
            var companies = _rbService.GetAllInsuranceCompanies();

            using var sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "InsuranceCompanies.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportInsuranceToCsv(companies, sfd.FileName);
                MessageBox.Show("Export successful.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExportInsuranceToCsv(List<InsuranceCompany> companies, string filePath)
        {
            using var writer = new StreamWriter(filePath);
            writer.WriteLine("Name,Address,Phone Number");

            foreach (var company in companies)
            {
                writer.WriteLine($"\"{company.Name}\",\"{company.Address}\",\"{company.PhoneNumber}\"");
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Rectangle screen = Screen.FromControl(this).WorkingArea;
            float scaleX = (float)screen.Width / Width;
            float scaleY = (float)screen.Height / Height;
            float scale = Math.Min(scaleX, scaleY);
            Scale(new SizeF(scale, scale));
            Location = new Point(
                screen.Left + (screen.Width - Width) / 2,
                screen.Top + (screen.Height - Height) / 2
            );
        }

        private void dgvNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}