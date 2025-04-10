using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JohnsonPraska
{
    public partial class Activity : Form
    {
        public Activity()
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

        private void lblHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help();
            help.Closed += (s, args) => this.Close();
            help.Show();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            btnDay.BackColor = Color.White;
            btnDay.ForeColor = Color.Black;
            btnWeek.BackColor = Color.FromArgb(64, 64, 64);
            btnWeek.ForeColor = Color.White;
            btnMonth.BackColor = Color.FromArgb(64, 64, 64);
            btnMonth.ForeColor = Color.White;
            btnAll.BackColor = Color.FromArgb(64, 64, 64);
            btnAll.ForeColor = Color.White;

        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            btnDay.BackColor = Color.FromArgb(64, 64, 64);
            btnDay.ForeColor = Color.White;
            btnWeek.BackColor = Color.White;
            btnWeek.ForeColor = Color.Black;
            btnMonth.BackColor = Color.FromArgb(64, 64, 64);
            btnMonth.ForeColor = Color.White;
            btnAll.BackColor = Color.FromArgb(64, 64, 64);
            btnAll.ForeColor = Color.White;

        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            btnDay.BackColor = Color.FromArgb(64, 64, 64);
            btnDay.ForeColor = Color.White;
            btnWeek.BackColor = Color.FromArgb(64, 64, 64);
            btnWeek.ForeColor = Color.White;
            btnMonth.BackColor = Color.White;
            btnMonth.ForeColor = Color.Black;
            btnAll.BackColor = Color.FromArgb(64, 64, 64);
            btnAll.ForeColor = Color.White;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnDay.BackColor = Color.FromArgb(64, 64, 64);
            btnDay.ForeColor = Color.White;
            btnWeek.BackColor = Color.FromArgb(64, 64, 64);
            btnWeek.ForeColor = Color.White;
            btnMonth.BackColor = Color.FromArgb(64, 64, 64);
            btnMonth.ForeColor = Color.White;
            btnAll.BackColor = Color.White;
            btnAll.ForeColor = Color.Black;

        }
    }
}
