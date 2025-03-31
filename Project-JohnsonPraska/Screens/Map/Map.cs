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
    public partial class Map : Form
    {
        public Map()
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

        private void lblMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void picMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            DataManager.VehiclesUpdated += UpdateComboBox;
            UpdateComboBox();
            cmbVehicles.SelectedIndex = 0;

            ResetGeoButtons();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            picMap.Image = Project_JohnsonPraska.Properties.Resources.Map2;

            EnableGeoButtons();
        }

        private void btnShowGeo_Click(object sender, EventArgs e)
        {
            picMap.Image = Project_JohnsonPraska.Properties.Resources.Geofence;
        }

        private void btnHideGeo_Click(object sender, EventArgs e)
        {
            picMap.Image = Project_JohnsonPraska.Properties.Resources.Map2;
        }

        private void ResetGeoButtons()
        {
            btnShowGeo.Enabled = false;
            btnHideGeo.Enabled = false;
            ApplyGrayOverlay(btnShowGeo);
            btnHideGeo.BackColor = Color.Red;
            ApplyGrayOverlay(btnHideGeo);
        }

        private void EnableGeoButtons()
        {
            btnShowGeo.Enabled = true;
            btnHideGeo.Enabled = true;
            RemoveGrayOverlay(btnShowGeo);
            RemoveGrayOverlay(btnHideGeo);
            btnHideGeo.BackColor = Control.DefaultBackColor;
            btnHideGeo.BackColor = Color.FromArgb(139, 0, 0);
        }

        private void ApplyGrayOverlay(Button btn)
        {
            if (btn != null)
            {
                btn.BackColor = Color.Gray;
                btn.Enabled = false;
            }
        }

        private void RemoveGrayOverlay(Button btn)
        {
            if (btn != null)
            {
                btn.BackColor = Control.DefaultBackColor;
                btn.Enabled = true;
            }
        }

        public void UpdateComboBox()
        {
            cmbVehicles.DataSource = null;
            cmbVehicles.DataSource = DataManager.Vehicles;
        }
    }
}
