using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_JohnsonPraska.Screens.Vehicles;

namespace Project_JohnsonPraska
{
    public partial class Drivers : Form
    {
        public Drivers()
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
            Vehicles vehicle = new Vehicles();
            vehicle.Closed += (s, args) => this.Close();
            vehicle.Show();
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

        private void lblMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void picMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
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

        private void btnEditDriver_Click(object sender, EventArgs e)
        {
            input3 inp3 = new input3(this);
            inp3.Show();
        }

        private void btnAddDelDriver_Click(object sender, EventArgs e)
        {
            input5 inp5 = new input5();
            inp5.Show();
        }

        private void cmbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDrivers.SelectedIndex == 0)
            {
                lblName.Text = "Connor Praska";
                lblAge.Text = "20";
                lblDefaultVH.Text = "Connor's Car";
            }
            else if (cmbDrivers.SelectedIndex == 1)
            {
                lblName.Text = "Matthew Johnson";
                lblAge.Text = "20";
                lblDefaultVH.Text = "Matthew's Car";
            }
            else
            {
                lblName.Text = "Test Person";
                lblAge.Text = "34";
                lblDefaultVH.Text = "Test Car";
            }
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            DataManager.DriversUpdated += UpdateComboBox;
            UpdateComboBox();
            cmbDrivers.SelectedIndex = 0;
        }

        public string NameText
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string AgeText
        {
            get { return lblAge.Text; }
            set { lblAge.Text = value; }
        }
        public string DefaultVHText
        {
            get { return lblDefaultVH.Text; }
            set { lblDefaultVH.Text = value; }
        }
        public void UpdateComboBox()
        {
            cmbDrivers.DataSource = null;
            cmbDrivers.DataSource = DataManager.Drivers;
        }
    }
}
