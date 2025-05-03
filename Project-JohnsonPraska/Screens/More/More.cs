using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Project_JohnsonPraska.Global;

namespace Project_JohnsonPraska
{
    public partial class More : Form
    {
        private static string patientID;
        public More(string id = null)
        {
            More.patientID = id;
            InitializeComponent();
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

        private void lblVehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint vehicle = new Appoint();
            vehicle.Closed += (s, args) => this.Close();
            vehicle.Show();
        }

        private void lblDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prescriptions driver = new Prescriptions();
            driver.Closed += (s, args) => this.Close();
            driver.Show();
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

        private void More_Load(object sender, EventArgs e)
        {
            if (More.patientID != null)
            {
                DataTable dt = new DataTable();
                dt = ProfileService.GetDocNotes(More.patientID);

                FillGrid(dataPatient, dt);

                dt = ProfileService.GetPatient(More.patientID);
                FillLabels(dt);
            }
        }

        private void FillGrid(DataGridView grid, DataTable data)
        {
            grid.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int index = grid.Rows.Add(
                    row["Employee_ID"].ToString(),
                    ProfileService.GetDocName(row["Employee_ID"].ToString()),
                    row["Note"].ToString()
                );
            }

        }

        private void FillLabels(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                var dob = (DateTime)row["Date_Of_Birth"];
                lblFname.Text = row["Fname"].ToString();
                lblLname.Text = row["Lname"].ToString();
                lblDOB.Text = dob.ToString("MM-dd-yyyy");
                lblAddress.Text = row["Address"].ToString();
                lblRoom.Text = row["Room"].ToString();
                lblID.Text = More.patientID.ToString();
            }

        }
    }
}
