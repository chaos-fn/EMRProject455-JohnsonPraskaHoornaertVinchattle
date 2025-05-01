
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
        private readonly BillingInvoiceRepository _svc = new BillingInvoiceRepository();

        public FormClaimDetails(int invoiceId)
        {
            InitializeComponent();
            var inv = _svc.GetInvoiceById(invoiceId);
            if (inv == null)
            {
                MessageBox.Show("Invoice not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtInvoiceId.Text = inv.InvoiceID.ToString();
            txtAppointmentId.Text = inv.AppointmentID.ToString();
            txtPatientId.Text = inv.PatientID.ToString();
            txtDate.Text = inv.Date.ToString("yyyy-MM-dd HH:mm");
            txtDescription.Text = inv.Description;
            txtPrice.Text = inv.Price.ToString("C");
            txtStatus.Text = inv.Status;
        }

        private void FormClaimDetails_Load_1(object sender, EventArgs e)
        {

        }
    }
}