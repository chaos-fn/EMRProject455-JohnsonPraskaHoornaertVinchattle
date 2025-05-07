using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JohnsonPraska.Screens.More
{
    public partial class EditPatient : Form
    {
        private static string patientID;
        public EditPatient(string patientID)
        {
            EditPatient.patientID = patientID;
            InitializeComponent();
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            if (EditPatient.patientID != null)
            {
                DataTable dt = new DataTable();

                dt = ProfileService.GetPatient(EditPatient.patientID);
                FillLabels(dt);
            }
        }

        private void FillLabels(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                var dob = (DateTime)row["Date_Of_Birth"];
                txtFirstName.Text = row["Fname"].ToString();
                txtLastName.Text = row["Lname"].ToString();
                datePickerDOB.Value = dob;
                txtAddress.Text = row["Address"].ToString();
                txtRoom.Text = row["Room"].ToString();
            }

        }

        private void btnConfirmPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EditPatient.patientID) || string.IsNullOrEmpty(txtFirstName.Text) || 
                string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAddress.Text) || datePickerDOB.Value == null)
            {
                MessageBox.Show("Please enter all required fields.");
            }
            else if (int.TryParse(EditPatient.patientID, out int id))
            {
                if (string.IsNullOrEmpty(txtRoom.Text.ToString()))
                {
                    ProfileService.ConfirmPatient(id, "", datePickerDOB.Value, 
                        txtAddress.Text, txtFirstName.Text, txtLastName.Text);
                }
                else
                {
                    ProfileService.ConfirmPatient(id, txtRoom.Text, datePickerDOB.Value, 
                        txtAddress.Text, txtFirstName.Text, txtLastName.Text);
                }

                MessageBox.Show("Patient updated successfully!");
                this.Close();
            }
        }
    }
}
