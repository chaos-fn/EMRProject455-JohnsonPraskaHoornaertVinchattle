using System;
using System.Windows.Forms;

namespace Project_JohnsonPraska.Screens.Login
{
    public partial class Login : Form
    {
        public bool badge = true;
        public string username = "";
        public string password = "";
        public string PIN = "";

        public Login()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e) { }
        private void lblPIN_Click(object sender, EventArgs e) { }

        private void lblBadge_Click(object sender, EventArgs e)
        {
            lblBadge.Visible = false;

            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            btnLogin.Visible = true;
            lblMessage.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();

            if (enteredUsername == username && enteredPassword == password)
            {
                lblUsername.Visible = false;
                txtUsername.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;

                lblPIN.Visible = true;
                txtPIN.Visible = true;
                btnEnter.Visible = true;
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Username or password incorrect.";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string enteredPIN = txtPIN.Text.Trim();

            if (enteredPIN == PIN)
            {
                this.Hide();
                Main main = new Main();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Invalid PIN. Try again.";
            }
        }
    }
}