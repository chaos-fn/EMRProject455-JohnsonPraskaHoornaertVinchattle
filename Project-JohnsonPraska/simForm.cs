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
    public partial class simForm : Form
    {
        public simForm()
        {
            InitializeComponent();
        }

        private void btnActivateAnom_Click(object sender, EventArgs e)
        {
            DataManager.SimulateAnomaly("Your vehicle has been broken into!");
        }
    }
}
