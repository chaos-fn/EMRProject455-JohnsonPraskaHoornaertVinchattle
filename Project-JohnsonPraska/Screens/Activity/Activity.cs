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

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void picMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
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
            lblTime3.Text = "";
            lblTime4.Text = "";
            lblTime5.Text = "";
            lblTime6.Text = "";
            lblTime7.Text = "";
            lblTime8.Text = "";
            lblDesc3.Text = "";
            lblDesc4.Text = "";
            lblDesc5.Text = "";
            lblDesc6.Text = "";
            lblDesc7.Text = "";
            lblDesc8.Text = "";
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
            lblTime3.Text = "12/3/2024 8:54:13";
            lblTime4.Text = "12/3/2024 12:54:12";
            lblTime5.Text = "12/1/2024 9:54:53";
            lblTime6.Text = "11/29/2024 10:12:31";
            lblTime7.Text = "";
            lblTime8.Text = "";
            lblDesc3.Text = "Car doors locked successfully (Connor's Car)";
            lblDesc4.Text = "Alarm turned off successfully (Connor's Car)";
            lblDesc5.Text = "Sunroof closed successfully (Matthew's Car)";
            lblDesc6.Text = "Car started successfully (Matthew's Car)";
            lblDesc7.Text = "";
            lblDesc8.Text = "";
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
            lblTime3.Text = "12/3/2024 8:54:13";
            lblTime4.Text = "12/3/2024 12:54:12";
            lblTime5.Text = "12/1/2024 9:54:53";
            lblTime6.Text = "11/29/2024 10:12:31";
            lblTime7.Text = "11/18/2024 9:13:54";
            lblTime8.Text = "11/12/2024 12:32:35";
            lblDesc3.Text = "Car doors locked successfully (Connor's Car)";
            lblDesc4.Text = "Alarm turned off successfully (Connor's Car)";
            lblDesc5.Text = "Sunroof closed successfully (Matthew's Car)";
            lblDesc6.Text = "Car started successfully (Matthew's Car)";
            lblDesc7.Text = "Car started successfully (Connor's Car";
            lblDesc8.Text = "Car doors unlocked successfully (Matthew's Car)";
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
            lblTime3.Text = "12/3/2024 8:54:13";
            lblTime4.Text = "12/3/2024 12:54:12";
            lblTime5.Text = "12/1/2024 9:54:53";
            lblTime6.Text = "11/29/2024 10:12:31";
            lblTime7.Text = "11/18/2024 9:13:54";
            lblTime8.Text = "11/12/2024 12:32:35";
            lblDesc3.Text = "Car doors locked successfully (Connor's Car)";
            lblDesc4.Text = "Alarm turned off successfully (Connor's Car)";
            lblDesc5.Text = "Sunroof closed successfully (Matthew's Car)";
            lblDesc6.Text = "Car started successfully (Matthew's Car)";
            lblDesc7.Text = "Car started successfully (Connor's Car";
            lblDesc8.Text = "Car doors unlocked successfully (Matthew's Car)";
        }
    }
}
