using System.Diagnostics.Metrics;
using Project_JohnsonPraska.Screens.Vehicles;

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
            Map map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void lblMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }
       
    }
}
