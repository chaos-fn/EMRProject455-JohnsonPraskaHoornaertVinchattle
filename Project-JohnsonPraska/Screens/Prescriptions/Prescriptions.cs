using Project_JohnsonPraska.Screens.Prescriptions;
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
    public partial class Prescriptions : Form //COMMENT
    {
        public Prescriptions()
        {
            InitializeComponent();
            drugNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            drugNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            ValidateForm();

            //List of the items in the autocomplete
            //add database integration later
            var drugList = new[]
{
                    "Aspirin",
                    "Metformin",
                    "Lisinopril",
                    };

            drugNameTextBox.AutoCompleteCustomSource.AddRange(drugList);

            //Stuff for the route drop down, giving it the options
            comboBoxRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoute.Items.AddRange(new object[]
{
                                        "Oral (PO)",
                                        "Intravenous (IV)",
                                        "Intramuscular (IM)",
                                        "Subcutaneous (SC)",
                                        "Topical",
                                        "Inhalation"
                                        });

            numericUpDownDose.Minimum = 0;
            numericUpDownDose.Maximum = 10000;
            numericUpDownDose.DecimalPlaces = 1;
            numericUpDownDose.Increment = 0.5M;

            comboBoxDoseUnit.Items.AddRange(new object[]
{
                                             "mg",    // milligrams
                                             "mcg",   // micrograms
                                             "g",     // grams
                                             "mL",    // milliliters
                                             "units"  // e.g. insulin
                                              });
            comboBoxFrequency.Items.AddRange(new object[]
{
                                            "Once daily (QD)",
                                            "Twice daily (BID)",
                                            "Three times daily (TID)",
                                            "Four times daily (QID)",
                                            "Every 4 hours (Q4H)",
                                            "Every 6 hours (Q6H)",
                                            "Every 8 hours (Q8H)",
                                            "As needed (PRN)"
            });
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more = new More();
            more.Closed += (s, args) => this.Close();
            more.Show();
        }

        private void lblVehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoint vehicle = new Appoint();
            vehicle.Closed += (s, args) => this.Close();
            vehicle.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Session.EmployeeID, Session.FirstName, Session.LastName);
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void lblMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patients map = new Patients();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void lblActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportBill activity = new ReportBill();
            activity.Closed += (s, args) => this.Close();
            activity.Show();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search help = new Search();
            help.Closed += (s, args) => this.Close();
            help.Show();
        }

        private void Prescriptions_Load(object sender, EventArgs e)
        {
            listViewHistory.Items.Clear();

            /** 
             * code for adding medication from the patients history into the list view
            foreach (var med in patient.MedHistory)
            {
                var item = new ListViewItem(med.Date.ToShortDateString());
                item.SubItems.Add(med.DrugName);
                item.SubItems.Add($"{med.Dose}{med.Unit}");
                item.SubItems.Add(med.Status);
                listViewHistory.Items.Add(item);
            }
            */
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drugNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSendRx_Click(object sender, EventArgs e)
        {
            var summary = $"{numericUpDownDose.Value}{comboBoxDoseUnit.Text} × {comboBoxFrequency.Text}";
            var result = MessageBox.Show(
                $"Are you sure you want to send:\n{drugNameTextBox.Text} {summary}?",
                "Confirm Send",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Prescription sent successfully!", "Done",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            /**
             * Code for sending the selected item into the edit form
             * to be implemented later
            if (listViewHistory.SelectedItems.Count == 0) return;
            var sel = listViewHistory.SelectedItems[0];
            var med = /* map sel back to your Med object ;
            using (var dlg = new FormEditMed(med))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // copy dlg.EditedMed back and refresh the listViewHistory
                }
            }
            */

            using (var editForm = new FormEditMed())
            {
                editForm.ShowDialog();
                // later you can pull data back from editForm.EditedMed
            }
        }

        private void ValidateForm()
        {
            bool drugOk = !string.IsNullOrWhiteSpace(drugNameTextBox.Text);
            bool doseOk = numericUpDownDose.Value > 0;
            bool unitOk = comboBoxDoseUnit.SelectedIndex >= 0;
            bool routeOk = comboBoxRoute.SelectedIndex >= 0;
            bool freqOk = comboBoxFrequency.SelectedIndex >= 0;

            // enable/disable the button
            buttonSendRx.Enabled = drugOk && doseOk && unitOk && routeOk && freqOk;

            //Provides an error message for incorrect fields
            errorProvider1.SetError(drugNameTextBox, drugOk ? "" : "Enter or select a drug");
            errorProvider1.SetError(numericUpDownDose, doseOk ? "" : "Dose must be > 0");
            errorProvider1.SetError(comboBoxDoseUnit, unitOk ? "" : "Select a unit");
            errorProvider1.SetError(comboBoxRoute, routeOk ? "" : "Select a route");
            errorProvider1.SetError(comboBoxFrequency, freqOk ? "" : "Select how often");
        }

        private void numericUpDownDose_ValueChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void comboBoxDoseUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void comboBoxRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void comboBoxFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
    }
}