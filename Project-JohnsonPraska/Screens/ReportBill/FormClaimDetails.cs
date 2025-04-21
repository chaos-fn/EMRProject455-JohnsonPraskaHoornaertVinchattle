
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JohnsonPraska.Screens.ReportBill
{


    public partial class FormClaimDetails : Form
    {
        private readonly int _claimId;

        public FormClaimDetails(int claimID)
        {
            InitializeComponent();
            _claimId = claimID;
        }

        private async void FormClaimDetails_Load(object sender, EventArgs e)
        {
            // TODO: replace this with actual code

        }
    }
}
