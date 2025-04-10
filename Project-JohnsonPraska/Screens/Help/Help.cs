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

namespace Project_JohnsonPraska
{
    public partial class Help : Form
    {
        public Help()
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
            Vehicles vehicles = new Vehicles();
            vehicles.Closed += (s, args) => this.Close();
            vehicles.Show();
        }

        private void lblDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drivers drivers = new Drivers();
            drivers.Closed += (s, args) => this.Close();
            drivers.Show();
        }

        private void lblActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            Activity activity = new Activity();
            activity.Closed += (s, args) => this.Close();
            activity.Show();
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
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

    }
}
