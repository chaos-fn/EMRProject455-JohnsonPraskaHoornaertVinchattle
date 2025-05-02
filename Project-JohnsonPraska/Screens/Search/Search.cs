using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_JohnsonPraska.Global;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_JohnsonPraska
{
    public partial class Search : Form
    {
        public Search()
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

        private void lblActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportBill activity = new ReportBill();
            activity.Closed += (s, args) => this.Close();
            activity.Show();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SearchService.SearchByName(txtSearch.Text.ToString());

            FillGrid(dataPatients, dt);
        }

        private void btnFilterName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SearchService.GetPatients("Fname");

            FillGrid(dataPatients, dt);
        }

        private void btnFilterAge_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SearchService.GetPatients("Date_Of_Birth");

            FillGrid(dataPatients, dt);
        }

        private void btnFilterRoom_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SearchService.GetPatients("Room");

            FillGrid(dataPatients, dt);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Patients reg = new Patients();
            reg.Show();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SearchService.GetPatients("Patient_ID");

            FillGrid(dataPatients, dt);
        }

        private void dataPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Code here to view selected patient profile
        }

        private void FillGrid(DataGridView grid, DataTable data)
        {
            grid.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                int index = grid.Rows.Add(
                    row["Patient_ID"].ToString(),
                    row["Fname"].ToString() + " " + row["Lname"].ToString(),
                    GetAge(row),
                    row["Room"].ToString()
                );
            }

        }

        private static Int32 GetAge(DataRow row)
        {
            DateTime today = DateTime.Today;
            DateTime birthdate = Convert.ToDateTime(row["Date_Of_Birth"]);
            Int32 age = today.Year - birthdate.Year;

            if (birthdate.Date > today.AddYears(-age))
            {
                return (age--);
            } else
            {
                return age;
            }
        }
    }
}