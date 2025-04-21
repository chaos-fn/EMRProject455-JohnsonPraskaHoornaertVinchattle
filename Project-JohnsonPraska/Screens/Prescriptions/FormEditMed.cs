using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JohnsonPraska.Screens.Prescriptions
{
    public partial class FormEditMed : Form
    {
        public FormEditMed()
        {
            InitializeComponent();

            drugNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            drugNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEditMed_Load(object sender, EventArgs e)
        {

        }
    }
}