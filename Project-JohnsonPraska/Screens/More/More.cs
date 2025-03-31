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
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
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

        private void lblVehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicles vehicle = new Vehicles();
            vehicle.Closed += (s, args) => this.Close();
            vehicle.Show();
        }

        private void btnTZ_Click(object sender, EventArgs e)
        {
            lblTZ.Text = "PST/GMT-8";
            lblLeftMain.Text = "  Wed. 8:12";
        }

        private void lblDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drivers driver = new Drivers();
            driver.Closed += (s, args) => this.Close();
            driver.Show();
        }

        private void lblActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            Activity activity = new Activity();
            activity.Closed += (s, args) => this.Close();
            activity.Show();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help();
            help.Closed += (s, args) => this.Close();
            help.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            input1 inp1 = new input1(this);
            inp1.Show();
        }

        public string NameText
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string EmailText
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }
        public string PhoneText
        {
            get { return lblNumber.Text; }
            set { lblNumber.Text = value; }
        }
    }
}
