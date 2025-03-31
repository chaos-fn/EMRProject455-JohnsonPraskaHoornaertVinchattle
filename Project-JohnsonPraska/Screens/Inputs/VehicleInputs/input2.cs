using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_JohnsonPraska
{
    public partial class input2 : Form
    {
        public input2()
        {
            InitializeComponent();
        }
        private Vehicles mainForm = null;
        public input2(Form callingForm)
        {
            mainForm = callingForm as Vehicles;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to save the changes? Clicking 'No' will cancel", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                this.mainForm.MakeText = txtMake.Text;
                this.mainForm.ModelText = txtModel.Text;
                this.mainForm.YearText = txtYear.Text;
                this.mainForm.MilesText = txtMiles.Text;
                this.mainForm.EngineText = txtEngine.Text;
                this.Close();
            }
            else
            {
                this.Close();
            }
        }


        private void input2_Load(object sender, EventArgs e)
        {
            txtMake.Text = this.mainForm.MakeText;
            txtModel.Text = this.mainForm.ModelText;
            txtYear.Text = this.mainForm.YearText;
            txtMiles.Text = this.mainForm.MilesText;
            txtEngine.Text = this.mainForm.EngineText;
        }
    }
}
