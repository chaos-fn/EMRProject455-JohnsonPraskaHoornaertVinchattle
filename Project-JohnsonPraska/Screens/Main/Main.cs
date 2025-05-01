using Project_JohnsonPraska.Screens.Login;
using System.Diagnostics.Metrics;

namespace Project_JohnsonPraska
{

    public partial class Main : Form
    {
        public Main(int employeeID, string firstName, string lastName)
        {
            InitializeComponent();

            lblCurrentID.Text = "Employee ID: " + employeeID.ToString();
            lblCurrentFName.Text = "First Name: " + firstName;
            lblCurrentLName.Text = "Last Name: " + lastName;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Rectangle screen = Screen.FromControl(this).WorkingArea;
            float scaleX = (float)screen.Width / Width;
            float scaleY = (float)screen.Height / Height;
            float scale = Math.Min(scaleX, scaleY);
            Scale(new SizeF(scale, scale));
            Location = new Point(
                screen.Left + (screen.Width - Width) / 2,
                screen.Top + (screen.Height - Height) / 2
            );
        }

        public Main()
        {
            InitializeComponent();
        }

        private void lblMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patients patients = new Patients();
            patients.Closed += (s, args) => this.Close();
            patients.Show();
        }

        private void lblMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentFName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
