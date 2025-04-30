using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Project_JohnsonPraska.Global;

namespace Project_JohnsonPraska
{
    public partial class Appoint : Form
    {
        //private static readonly string connectionString = "server=localhost;port=3306;userid=appuser;password=password;database=emr;";
        public Appoint()
        {
            InitializeComponent();
        }
        /*
        private void TestConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        */

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

        private void lblAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void lblDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prescriptions drivers = new Prescriptions();
            drivers.Closed += (s, args) => this.Close();
            drivers.Show();
        }

        private void lblActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportBill activity = new ReportBill();
            activity.Closed += (s, args) => this.Close();
            activity.Show();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search help = new Search();
            help.Closed += (s, args) => this.Close();
            help.Show();
        }

        private void Appoint_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            todayDataGridView.CellEndEdit += todayDataGridView_CellEndEdit;
            weekDataGridView.CellEndEdit += weekDataGridView_CellEndEdit;
            monthDataGridView.CellEndEdit += monthDataGridView_CellEndEdit;
        }

        private void LoadAppointments()
        {
            DateTime todayStart = DateTime.Today;
            DateTime todayEnd = todayStart.AddDays(1).AddSeconds(-1);
            DateTime weekEnd = DateTime.Today.AddDays(7);
            DateTime monthEnd = DateTime.Today.AddMonths(1);

            FillGrid(todayDataGridView, AppointService.GetAppointments(todayStart, todayEnd));
            FillGrid(weekDataGridView, AppointService.GetAppointments(todayStart, weekEnd));
            FillGrid(monthDataGridView, AppointService.GetAppointments(todayStart, monthEnd));
        }

        private void FillGrid(DataGridView grid, DataTable data)
        {
            grid.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int index = grid.Rows.Add(
                    Convert.ToDateTime(row["Date"]).ToString("MM/dd/yyyy HH:mm"),
                    row["Patient_ID"].ToString(),
                    row["PatientName"].ToString(),
                    row["Physician_ID"].ToString(),
                    "Physician ID " + row["Physician_ID"].ToString(),
                    row["Reason"].ToString(),
                    row["Employee_ID"].ToString(),
                    row["EmployeeName"].ToString(),
                    MapStatusIDToText(Convert.ToInt32(row["Status_ID"]))
                );

                grid.Rows[index].Tag = row["Appointment_ID"];

                grid.Rows[index].Cells[2].ReadOnly = true;
                grid.Rows[index].Cells[4].ReadOnly = true;
                grid.Rows[index].Cells[7].ReadOnly = true;
                grid.Rows[index].Cells[8].ReadOnly = true;

                string status = MapStatusIDToText(Convert.ToInt32(row["Status_ID"]));
                switch (status)
                {
                    case "Confirmed":
                        grid.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        break;
                    case "Pending":
                        grid.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                        break;
                    case "Cancelled":
                        grid.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                        break;
                    default:
                        grid.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        break;
                }
            }
        }


        private void todayDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AutoFillNames(todayDataGridView, e.RowIndex, e.ColumnIndex);
        }

        private void weekDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AutoFillNames(weekDataGridView, e.RowIndex, e.ColumnIndex);
        }

        private void monthDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AutoFillNames(monthDataGridView, e.RowIndex, e.ColumnIndex);
        }

        private void AutoFillNames(DataGridView grid, int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || rowIndex >= grid.Rows.Count)
                return;

            var row = grid.Rows[rowIndex];

            if (columnIndex == 1) 
            {
                if (int.TryParse(row.Cells[1].Value?.ToString(), out int patientID))
                    row.Cells[2].Value = AppointService.GetPatientNameByID(patientID);
            }
            else if (columnIndex == 3) 
            {
                if (int.TryParse(row.Cells[3].Value?.ToString(), out int physicianID))
                    row.Cells[4].Value = AppointService.GetEmployeeNameByID(physicianID);
     
            }
            else if (columnIndex == 6) 
            {
                if (int.TryParse(row.Cells[6].Value?.ToString(), out int employeeID))
                    row.Cells[7].Value = AppointService.GetEmployeeNameByID(employeeID);
            }
        }


        private string MapStatusIDToText(int statusID)
        {
            switch (statusID)
            {
                case 1: return "Confirmed";
                case 2: return "Pending";
                case 3: return "Cancelled";
                default: return "Unknown";
            }
        }

        private DataGridView GetActiveGrid()
        {
            if (Appointments.SelectedTab == todayTab)
                return todayDataGridView;
            else if (Appointments.SelectedTab == weekTab)
                return weekDataGridView;
            else if (Appointments.SelectedTab == monthTab)
                return monthDataGridView;
            else
                return null;
        }

        private DataGridViewRow GetSelectedRow()
        {
            DataGridView grid = GetActiveGrid();
            if (grid != null && grid.SelectedRows.Count > 0)
                return grid.SelectedRows[0];
            return null;
        }

        private void deleteAppointbtn_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            int id = Convert.ToInt32(row.Tag);

            bool deleted = AppointService.DeleteAppointment(id); 

            if (deleted)
            {
                MessageBox.Show("Appointment deleted successfully!");
                LoadAppointments();
            }
            else
            {
                
            }
        }

        private void confrmButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ActiveControl = null;

            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(row.Cells[0]?.Value?.ToString()) ||  
                    string.IsNullOrWhiteSpace(row.Cells[1]?.Value?.ToString()) ||  
                    string.IsNullOrWhiteSpace(row.Cells[3]?.Value?.ToString()) ||  
                    string.IsNullOrWhiteSpace(row.Cells[5]?.Value?.ToString()) || 
                    string.IsNullOrWhiteSpace(row.Cells[6]?.Value?.ToString()))    
                {
                    MessageBox.Show("Date, PatientID, PhysicianID, Reason, and EmployeeID must be filled.");
                    return;
                }

                if (!int.TryParse(row.Cells[1].Value.ToString(), out int patientID) ||
                    !int.TryParse(row.Cells[3].Value.ToString(), out int physicianID) ||
                    !int.TryParse(row.Cells[6].Value.ToString(), out int employeeID))
                {
                    MessageBox.Show("Patient ID, Physician ID, and Employee ID must be valid numbers.");
                    return;
                }

                string type = row.Cells[5].Value.ToString();

                if (!DateTime.TryParseExact(row.Cells[0].Value.ToString(), "MM/dd/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    MessageBox.Show("Date must be in the format MM/dd/yyyy HH:mm.");
                    return;
                }

                if (!AppointService.DoesPatientExist(patientID))
                {
                    MessageBox.Show($"Patient ID {patientID} does not exist.");
                    return;
                }
                if (!AppointService.DoesEmployeeExist(employeeID))
                {
                    MessageBox.Show($"Employee ID {employeeID} does not exist.");
                    return;
                }
                if (!AppointService.DoesPhysicianExist(physicianID))
                {
                    MessageBox.Show($"Physician ID {physicianID} does not exist.");
                    return;
                }
                if (row.Tag == null || string.IsNullOrWhiteSpace(row.Tag.ToString()))
                {
                    AppointService.InsertAppointment(patientID, physicianID, type, employeeID, date);
                    MessageBox.Show("New appointment added successfully!");
                }
                else
                {
                    int appointmentID = Convert.ToInt32(row.Tag);

                    AppointService.ConfirmAppointment(appointmentID, patientID, employeeID, physicianID, type, date);
                    MessageBox.Show("Appointment confirmed and updated!");
                }
                
                LoadAppointments(); // Refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void rescheduleButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ActiveControl = null;

            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            if (row.Tag == null || string.IsNullOrWhiteSpace(row.Tag.ToString()))
            {
                MessageBox.Show("This appointment has no ID. Cannot reschedule.");
                return;
            }

            if (!DateTime.TryParseExact(row.Cells[0].Value.ToString(), "MM/dd/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime newDate))
            {
                MessageBox.Show("Invalid Date format. Please use MM/dd/yyyy HH:mm.");
                return;
            }

            int appointmentID = Convert.ToInt32(row.Tag);

            AppointService.RescheduleAppointment(appointmentID, newDate);

            MessageBox.Show("Appointment rescheduled successfully!");

            LoadAppointments();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            int id = Convert.ToInt32(row.Tag);
            AppointService.CancelAppointment(id);
            MessageBox.Show("Appointment cancelled!");
            LoadAppointments();
        }

        private bool AreRequiredFieldsFilled(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private void InsertNewAppointment(DataGridViewRow row)
        {
            int patientID = int.Parse(row.Cells[1].Value.ToString());
            int physicianID = int.Parse(row.Cells[3].Value.ToString());
            string type = row.Cells[5].Value.ToString();
            int employeeID = int.Parse(row.Cells[6].Value.ToString());
            DateTime date = DateTime.ParseExact(row.Cells[0].Value.ToString(), "MM/dd/yyyy HH:mm", null);

            AppointService.InsertAppointment(patientID, physicianID, type, employeeID, date);

            MessageBox.Show("New appointment added!");
            LoadAppointments();
        }

        private void UpdateExistingAppointment(DataGridViewRow row)
        {
            int appointmentID = Convert.ToInt32(row.Tag);
            int patientID = int.Parse(row.Cells[1].Value.ToString());
            int physicianID = int.Parse(row.Cells[3].Value.ToString());
            string type = row.Cells[5].Value.ToString();
            int employeeID = int.Parse(row.Cells[6].Value.ToString());
            DateTime date = DateTime.ParseExact(row.Cells[0].Value.ToString(), "MM/dd/yyyy HH:mm", null);

            AppointService.ConfirmAppointment(appointmentID, patientID, employeeID, physicianID, type, date);

            MessageBox.Show("Appointment confirmed!");
            LoadAppointments();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
