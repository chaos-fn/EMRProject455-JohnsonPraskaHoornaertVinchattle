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

        private readonly prescriptionService _rxService = new prescriptionService();
        private int _currentPatientId = -1;
        private int _selectedRxId = -1;

        public Prescriptions()
        {

            InitializeComponent();
            drugNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            drugNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            ValidateForm();


            listViewHistory.Clear();


            listViewHistory.View = View.Details;
            listViewHistory.FullRowSelect = true;


            listViewHistory.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Drug Name", 150, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Dose", 100, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Quantity", 80, HorizontalAlignment.Right);
            listViewHistory.Columns.Add("Filled", 60, HorizontalAlignment.Center);
            listViewHistory.Columns.Add("Route", 120, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Frequency", 120, HorizontalAlignment.Left);
            listViewHistory.Columns.Add("Instruction", 200, HorizontalAlignment.Left);

            //List of the items in the autocomplete

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
            buttonAddRx.Enabled = false;
            lblCurrentPatient.Text = "No patient selected";
            buttonAddRx.Enabled = false;
            listViewHistory.Items.Clear();
            drugNameTextBox.Text = "";
            numericUpDownDose.Value = numericUpDownDose.Minimum;
            comboBoxDoseUnit.SelectedIndex = -1;
            comboBoxRoute.SelectedIndex = -1;
            comboBoxFrequency.SelectedIndex = -1;
            textBoxInstruction.Text = "";

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
            bool isDoctor = UserService.GetCurrentUserRole() == 1;
            groupBox1.Visible = isDoctor;
            buttonDeleteRx.Visible = isDoctor;
            patientLoadBox.Visible = true;



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
            if (_currentPatientId < 0)
            {
                MessageBox.Show("Load a patient first.", "No Patient",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rx = new Prescription
            {
                PatientID = _currentPatientId,
                DrugName = drugNameTextBox.Text,
                Quantity = (int)numericUpDownQuantity.Value,
                Dosage = $"{numericUpDownDose.Value} {comboBoxDoseUnit.Text}",
                Instruction = textBoxInstruction.Text,
                Route = comboBoxRoute.Text,
                Frequency = comboBoxFrequency.Text,
                Filled = false
            };

            var summary = $"{numericUpDownDose.Value}{comboBoxDoseUnit.Text} × {comboBoxFrequency.Text}";
            if (MessageBox.Show(
                    $"Are you sure you want to send:\n{rx.DrugName} {summary}?",
                    "Confirm Send",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                != DialogResult.Yes)
                return;

            _rxService.AddPrescription(rx);
            RefreshPrescriptionList(_currentPatientId);
            MessageBox.Show("Prescription sent successfully!", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteRx.Enabled = listViewHistory.SelectedItems.Count > 0;
        }

        private void listViewHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bool isDoctor = UserService.GetCurrentUserRole() == 1;
            if (!isDoctor) return;
            if (listViewHistory.SelectedItems.Count == 0) return;
            var rx = (Prescription)listViewHistory.SelectedItems[0].Tag;

            using var editForm = new FormEditMed(rx);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // apply the changes
                _rxService.UpdatePrescription(editForm.EditedRx);
                RefreshPrescriptionList(_currentPatientId);
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
            buttonAddRx.Enabled = drugOk && doseOk && unitOk && routeOk && freqOk;

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

        private void RefreshPrescriptionList(int patientId)
        {
            listViewHistory.Items.Clear();
            var list = _rxService.GetPrescriptions(patientId);
            foreach (var rx in list)
            {
                var item = new ListViewItem(rx.PrescriptionID.ToString()); // ID
                item.SubItems.Add(rx.DrugName);                            // Drug Name
                item.SubItems.Add(rx.Dosage);                              // Dose
                item.SubItems.Add(rx.Quantity.ToString());                 // Quantity
                item.SubItems.Add(rx.Filled ? "Yes" : "No");               // Filled
                item.SubItems.Add(rx.Route);                               // Route
                item.SubItems.Add(rx.Frequency);                           // Frequency
                item.SubItems.Add(rx.Instruction);                         // Instructions

                item.Tag = rx;
                listViewHistory.Items.Add(item);
            }
        }

        private void btnLoadPatient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPatientId.Text.Trim(), out var id))
            {
                MessageBox.Show("Enter a valid numeric Patient ID.", "Invalid ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = _rxService.GetPatientById(id);
            if (patient == null)
            {
                MessageBox.Show($"No patient found with ID {id}.", "Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCurrentPatient.Text = "No patient selected";
                _currentPatientId = -1;
                listViewHistory.Items.Clear();
            }
            else
            {
                _currentPatientId = patient.PatientID;
                lblCurrentPatient.Text = $"{patient.Fname} {patient.Lname} (ID: {_currentPatientId})";
                RefreshPrescriptionList(_currentPatientId);
            }
        }

        private void textBoxInstruction_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructionslbl_Click(object sender, EventArgs e)
        {

        }

        private void frequencylbl_Click(object sender, EventArgs e)
        {

        }

        private void routelbl_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteRx_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedItems.Count == 0)
                return;

            var rx = (Prescription)listViewHistory.SelectedItems[0].Tag;

            var result = MessageBox.Show(
                $"Are you sure you want to delete prescription #{rx.PrescriptionID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            _rxService.DeletePrescription(rx.PrescriptionID);

            RefreshPrescriptionList(_currentPatientId);
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
    }
}