using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_JohnsonPraska.Global;

namespace Project_JohnsonPraska
{
    public partial class Patients : Form
    {
        string connectionString = "server=localhost;user=appuser;password=password;database=emr;";
        public Patients()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Session.EmployeeID, Session.FirstName, Session.LastName);
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

        private void btnCompleteRegistration_Click(object sender, EventArgs e)
        {
            // Get data from form fields
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string room = txtRoom.Text;
            DateTime dob = datePickerDOB.Value;
            string address = txtAddress.Text;

            // Call the register method
            RegisterPatient(fname, lname, room, dob, address);
        }

        public void RegisterPatient(string fname, string lname, string room, DateTime dob, string address)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand("RegisterPatient", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@p_Room", room);
                        cmd.Parameters.AddWithValue("@p_DateOfBirth", dob);
                        cmd.Parameters.AddWithValue("@p_Address", address);
                        cmd.Parameters.AddWithValue("@p_Fname", fname);
                        cmd.Parameters.AddWithValue("@p_Lname", lname);
                       
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient registered successfully!");
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtRoom.Text = "";
                        datePickerDOB.Value = DateTime.Now;
                        txtAddress.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering patient: " + ex.Message);
            }
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
