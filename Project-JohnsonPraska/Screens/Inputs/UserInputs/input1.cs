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
    public partial class input1 : Form
    {
        public input1()
        {
            InitializeComponent();
        }
        private More mainForm = null;
        public input1(Form callingForm)
        {
            mainForm = callingForm as More;
            InitializeComponent();
        }

        private void input1_Load(object sender, EventArgs e)
        {
            txtName.Text = this.mainForm.NameText;
            txtEmail.Text = this.mainForm.EmailText;
            txtPhone.Text = this.mainForm.PhoneText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to save? Clicking 'No' will cancel", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.mainForm.NameText = txtName.Text;
                this.mainForm.EmailText = txtEmail.Text;
                this.mainForm.PhoneText = txtPhone.Text;

                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
