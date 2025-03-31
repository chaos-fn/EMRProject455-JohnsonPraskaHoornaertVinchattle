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
    public partial class input3 : Form
    {
        public input3()
        {
            InitializeComponent();
        }
        private Drivers mainForm = null;
        public input3(Form callingForm)
        {
            mainForm = callingForm as Drivers;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to save? Clicking 'No' will cancel", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.mainForm.NameText = txtName.Text;
                this.mainForm.AgeText = txtAge.Text;
                this.mainForm.DefaultVHText = txtDefaultVH.Text;

                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        private void input3_Load(object sender, EventArgs e)
        {
            txtName.Text = this.mainForm.NameText;
            txtAge.Text = this.mainForm.AgeText;
            txtDefaultVH.Text = this.mainForm.DefaultVHText;
        }
    }
}
