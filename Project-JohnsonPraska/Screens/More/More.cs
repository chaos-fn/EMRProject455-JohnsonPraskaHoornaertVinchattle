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

namespace Project_JohnsonPraska
{
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
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
    }
}
