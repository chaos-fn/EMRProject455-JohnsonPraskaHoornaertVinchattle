using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Project_JohnsonPraska.Screens.Login
{

    public partial class Login : Form
    {
        string connectionString = "server=localhost;user=appuser;password=password;database=emr;";
        public bool badge = true;
        public string username = "";
        public string password = "";
        public string pin = "";

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
            int enteredPIN = 0;
            try
            {
                enteredPIN = int.Parse(txtPIN.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ensure your PIN is correct. It should be an series integer", "PIN Error");
            }
     
            if (VerifyEmployeePIN(enteredPIN)){
                this.Hide();
                Main main = new Main();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else{
                MessageBox.Show("Invalid PIN. Try again", "Invalid PIN");
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
                    return reader.HasRows; // true = found, false = not found
                }
            }
        }

        public bool VerifyEmployeePIN(int pin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("VerifyEmployeePIN", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_PIN", pin);

                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows; // true = correct PIN, false = wrong PIN
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