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
    public partial class input4 : Form
    {
        public input4()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vehicle has been added.");
            DataManager.Vehicles.Add(txtInput.Text);
            DataManager.NotifyForms();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string vehicleName = txtInput.Text;

            if (DataManager.Vehicles.Contains(vehicleName))
            {
                var result = MessageBox.Show("Are you sure you want to delete the vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    DataManager.Vehicles.Remove(vehicleName);
                    DataManager.NotifyForms();
                    MessageBox.Show("Vehicle deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sorry, no vehicle exists with that name. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

    }
}
