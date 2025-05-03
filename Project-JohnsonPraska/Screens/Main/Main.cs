using System;
using System.Data;
using System.Windows.Forms;
using Project_JohnsonPraska.Global;
using Project_JohnsonPraska.Screens.Login;
using MainSvc = Project_JohnsonPraska.Screens.Main.MainService;

namespace Project_JohnsonPraska
{
    public partial class Main : Form
    {
        private readonly int _employeeID;

        public Main(int employeeID, string firstName, string lastName)
        {
            InitializeComponent();

            _employeeID = employeeID;
            lblCurrentID.Text = $"Role: {MapRole(_employeeID)}";
            lblCurrentFName.Text = $"First Name: {firstName}";
            lblCurrentLName.Text = $"Last Name: {lastName}";

            quickConfirmBtn.Click -= quickConfirmBtn_Click;
            quickCancelBtn.Click -= quickCancelBtn_Click;
            quickConfirmBtn.Click += quickConfirmBtn_Click;
            quickCancelBtn.Click += quickCancelBtn_Click;

            this.Load += Main_Load;
            MainDataView.SelectedIndexChanged += MainDataView_SelectedIndexChanged;
        }
        private string MapRole(int id) => id switch
        {
            1 => "Physician",
            2 => "Nurse",
            3 => "Office",
            4 => "Office",
            5 => "Office",
            _ => "Unknown"
        };


        public Main()
        {
            InitializeComponent();

            quickConfirmBtn.Click += quickConfirmBtn_Click;
            quickCancelBtn.Click += quickCancelBtn_Click;

            this.Load += Main_Load;
            MainDataView.SelectedIndexChanged += MainDataView_SelectedIndexChanged;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateGridForSelectedTab();
        }

        private void MainDataView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridForSelectedTab();
        }

        private void UpdateGridForSelectedTab()
        {
            DateTime start = DateTime.Today;
            DateTime end;
            DataGridView grid;

            if (MainDataView.SelectedTab == todayTab)
            {
                end = start.AddDays(1);
                grid = todayDataGridView3;
            }
            else if (MainDataView.SelectedTab == weekTab)
            {
                end = start.AddDays(7);
                grid = weekDataGridView1;
            }
            else if (MainDataView.SelectedTab == monthTab)
            {
                end = start.AddMonths(1);
                grid = monthDataGridView2;
            }
            else return;

            var dt = MainSvc.GetAppointmentsForEmployee(_employeeID, start, end);
            FillGrid(grid, dt);
        }

        private DataGridView GetActiveGrid()
        {
            if (MainDataView.SelectedTab == todayTab) return todayDataGridView3;
            if (MainDataView.SelectedTab == weekTab) return weekDataGridView1;
            if (MainDataView.SelectedTab == monthTab) return monthDataGridView2;
            return null;
        }

        private DataGridViewRow GetSelectedRow()
        {
            var grid = GetActiveGrid();
            if (grid == null) return null;
            if (grid.SelectedRows.Count > 0) return grid.SelectedRows[0];
            return grid.CurrentRow;
        }

        private void quickConfirmBtn_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("Please select a row first.", "No Selection");
                return;
            }
            if (!(row.Tag is int appointmentId))
            {
                MessageBox.Show("Unable to determine the appointment ID.", "Error");
                return;
            }

            var status = row.Cells[8]?.Value?.ToString() ?? "";
            if (status == "Confirmed")
            {
                MessageBox.Show("Appointment is already confirmed.", "No Action");
                return;
            }

            bool success = MainSvc.UpdateAppointmentStatus(appointmentId, 1);
            MessageBox.Show(
                success ? "Appointment status set to Confirmed." : "Failed to update appointment status.",
                "Status Update"
            );
            if (success) UpdateGridForSelectedTab();
        }

        private void quickCancelBtn_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("Please select a row first.", "No Selection");
                return;
            }
            if (!(row.Tag is int appointmentId))
            {
                MessageBox.Show("Unable to determine the appointment ID.", "Error");
                return;
            }

            var status = row.Cells[8]?.Value?.ToString() ?? "";
            if (status == "Cancelled")
            {
                MessageBox.Show("Appointment is already cancelled.", "No Action");
                return;
            }

            bool success = MainSvc.UpdateAppointmentStatus(appointmentId, 3);
            MessageBox.Show(
                success ? "Appointment status set to Cancelled." : "Failed to update appointment status.",
                "Status Update"
            );
            if (success) UpdateGridForSelectedTab();
        }

        private void FillGrid(DataGridView grid, DataTable dt)
        {
            grid.Rows.Clear();
            foreach (DataRow r in dt.Rows)
            {
                int idx = grid.Rows.Add(
                    Convert.ToDateTime(r["Date"]).ToString("MM/dd/yyyy HH:mm"),
                    r["PatientFirst"].ToString(),
                    r["PatientLast"].ToString(),
                    r["Age"].ToString(),
                    r["Prescription"].ToString(),
                    r["Invoice"].ToString(),
                    r["Reason"].ToString(),
                    r["EmployeeName"].ToString(),
                    MapStatusIDToText(Convert.ToInt32(r["Status_ID"]))
                );
                grid.Rows[idx].Tag = (int)r["Appointment_ID"];

                var color = MapStatusIDToText(Convert.ToInt32(r["Status_ID"]));
                grid.Rows[idx].DefaultCellStyle.BackColor = color switch
                {
                    "Confirmed" => System.Drawing.Color.LightGreen,
                    "Pending" => System.Drawing.Color.LightYellow,
                    "Cancelled" => System.Drawing.Color.LightSalmon,
                    _ => System.Drawing.Color.White,
                };
            }
        }

        private string MapStatusIDToText(int statusID) => statusID switch
        {
            1 => "Confirmed",
            2 => "Pending",
            3 => "Cancelled",
            _ => "Unknown",
        };

        private void lblMap_Click(object sender, EventArgs e)
        {
            Hide();
            var patients = new Patients();
            patients.Closed += (s, args) => Close();
            patients.Show();
        }

        private void lblMore_Click(object sender, EventArgs e)
        {
            Hide();
            var more = new More();
            more.Closed += (s, args) => Close();
            more.Show();
        }

        private void lblHome_Click(object sender, EventArgs e) { /* no-op */ }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new Login();
            login.Closed += (s, args) => Close();
            login.Show();
        }

        private void searchButtonbtn_Click(object sender, EventArgs e)
        {
            Hide();
            var help = new Search();
            help.Closed += (s, args) => Close();
            help.Show();
        }

        private void newPresciptionBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var driver = new Prescriptions();
            driver.Closed += (s, args) => Close();
            driver.Show();
        }

        private void newAppointBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var vehicle = new Appoint();
            vehicle.Closed += (s, args) => Close();
            vehicle.Show();
        }

        private void reportBillBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var activity = new ReportBill();
            activity.Closed += (s, args) => Close();
            activity.Show();
        }
    }
}
