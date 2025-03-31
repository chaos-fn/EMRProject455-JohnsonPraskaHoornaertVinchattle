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
    public partial class input5 : Form
    {
        public input5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Driver has been added.");
            DataManager.Drivers.Add(txtInput.Text);
            DataManager.NotifyForms();
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string driverName = txtInput.Text;

            if (DataManager.Drivers.Contains(driverName))
            {
                var result = MessageBox.Show("Are you sure you want to delete the driver?", "Delete Driver", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    DataManager.Drivers.Remove(driverName);
                    DataManager.NotifyForms();
                    MessageBox.Show("Driver deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sorry, no driver exists with that name. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



    }
}
