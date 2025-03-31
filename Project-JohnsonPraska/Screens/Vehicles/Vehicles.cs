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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
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

        private void lblHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help();
            help.Closed += (s, args) => this.Close();
            help.Show();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            DataManager.VehiclesUpdated += UpdateComboBox;
            UpdateComboBox();
            cmbVehicles.SelectedIndex = 0;
        }

        private void cmbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicles.SelectedIndex == 0)
            {
                lblMake.Text = "Chevrolet";
                lblModel.Text = "Equinox";
                lblYear.Text = "2019";
                lblMiles.Text = "25,280";
                lblEngine.Text = "Gas";
            }
            else if (cmbVehicles.SelectedIndex == 1)
            {
                lblMake.Text = "Tesla";
                lblModel.Text = "Model X";
                lblYear.Text = "2024";
                lblMiles.Text = "12,561";
                lblEngine.Text = "Electric";
            }
            else
            {
                lblMake.Text = "Toyota";
                lblModel.Text = "Prius";
                lblYear.Text = "2023";
                lblMiles.Text = "12,375";
                lblEngine.Text = "Hybrid";
            }
        }

        private void btnEditVH_Click(object sender, EventArgs e)
        {
            input2 inp2 = new input2(this);
            inp2.Show();
        }

        private void btnAddDelVH_Click(object sender, EventArgs e)
        {
            input4 inp4 = new input4();
            inp4.Show();
        }

        public string MakeText
        {
            get { return lblMake.Text; }
            set { lblMake.Text = value; }
        }
        public string ModelText
        {
            get { return lblModel.Text; }
            set { lblModel.Text = value; }
        }
        public string YearText
        {
            get { return lblYear.Text; }
            set { lblYear.Text = value; }
        }
        public string MilesText
        {
            get { return lblMiles.Text; }
            set { lblMiles.Text = value; }
        }
        public string EngineText
        {
            get { return lblEngine.Text; }
            set { lblEngine.Text = value; }
        }
        public void UpdateComboBox()
        {
            cmbVehicles.DataSource = null;
            cmbVehicles.DataSource = DataManager.Vehicles;
        }
    }
}
