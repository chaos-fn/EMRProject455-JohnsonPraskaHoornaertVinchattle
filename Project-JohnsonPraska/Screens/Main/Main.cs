using System.Diagnostics.Metrics;

namespace Project_JohnsonPraska
{

    public partial class Main : Form
    {
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
    }
}
