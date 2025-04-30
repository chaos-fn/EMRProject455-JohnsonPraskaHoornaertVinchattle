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
            //Code here to search for patient's by name
        }

        private void btnFilterName_Click(object sender, EventArgs e)
        {
            //Code here to filter by Name
        }

        private void btnFilterAge_Click(object sender, EventArgs e)
        {
            //Code here to filter by Name
        }

        private void btnFilterRoom_Click(object sender, EventArgs e)
        {
            //Code here to filter by Name
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            //Code here to filter by Name
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Patients reg = new Patients();
            reg.Show();
        }
    }
}