using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Project_JohnsonPraska.Global;

namespace Project_JohnsonPraska.Screens.Login
{

    public partial class Login : Form
    {
        string connectionString = "server=localhost;user=appuser;password=password;database=emr;";
        public bool badge = false;

        public Login()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e) { }
        private void lblPIN_Click(object sender, EventArgs e) { }

        private void lblBadge_Click(object sender, EventArgs e)
        {
            if (badge) {
                BadgeToPIN();
            }
            else
            {
                BadgeToLogin();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int enteredUsername = 0;
            try
            {
                enteredUsername = int.Parse(txtUsername.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ensure your username is correct. It should be your employee ID", "Username Error");
            }
            
            string enteredPassword = txtPassword.Text.Trim();
            if (VerifyEmployeeLogin(enteredUsername, enteredPassword))
            {
                LoginToPIN();
            }
            else
            {
                MessageBox.Show("Invalid Login. Try again", "Invalid Login");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int enteredPIN;
            if (!int.TryParse(txtPIN.Text.Trim(), out enteredPIN))
            {
                MessageBox.Show("PIN must be a number.", "Invalid PIN");
                return;
            }

            if (VerifyEmployeePIN(Session.EmployeeID, enteredPIN))
            {
                this.Hide();
                Main main = new Main(Session.EmployeeID, Session.FirstName, Session.LastName);
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid PIN for this user. Try again.", "Invalid PIN");
            }
        }


        public bool VerifyEmployeeLogin(int employeeId, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("VerifyEmployeeLogin", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_Employee_ID", employeeId);
                cmd.Parameters.AddWithValue("@p_Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // read one matching record
                    {
                        Session.EmployeeID = reader.GetInt32("Employee_ID"); // careful: match column names
                        Session.FirstName = reader.GetString("Fname");
                        Session.LastName = reader.GetString("Lname");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool VerifyEmployeePIN(int employeeID, int pin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("VerifyEmployeePIN", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_Employee_ID", employeeID);
                cmd.Parameters.AddWithValue("@p_PIN", pin);

                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows; // only returns true if employeeID and PIN match
                }
            }
        }


        private void BadgeToPIN()
        {
            lblBadge.Visible = false;
            lblMessage.Visible = false;

            lblPIN.Visible = true;
            txtPIN.Visible = true;
            btnEnter.Visible = true;
        }

        private void BadgeToLogin()
        {
            lblBadge.Visible = false;

            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            btnLogin.Visible = true;
            lblMessage.Visible = true;
        }

        private void LoginToPIN()
        {
            lblUsername.Visible = false;
            txtUsername.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            btnLogin.Visible = false;
            lblMessage.Visible = false;

            lblPIN.Visible = true;
            txtPIN.Visible = true;
            btnEnter.Visible = true;
        }
    }
}