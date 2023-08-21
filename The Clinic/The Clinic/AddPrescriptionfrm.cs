using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;


namespace The_Clinic
{
    public partial class AddPrescriptionfrm : KryptonForm
    {
        int _MedicalRecordID;
        public AddPrescriptionfrm()
        {
            InitializeComponent();
        }
        //this Constructor to Gets the Header's Color,Text,image from the AddMediaclRecord Form and the MedicalRecordID after Saving to use it in Prescription data
        public AddPrescriptionfrm(Color color, string text, Image image , int MedicalRecordId)
        {
            InitializeComponent();
            _MedicalRecordID = MedicalRecordId;
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AddPrescriptionfrm_Load(object sender, EventArgs e)
        {
            _RefreshPrescriptionList();
            _SetControlsForeColor(lblHeader.BackColor);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtAddMedicationName.StateActive.Content.Color1 = color;
            txtAddFrequency.StateActive.Content.Color1 = color;
            txtAddDosage.StateActive.Content.Color1 = color;
            txtAddSpecialInstructions.StateActive.Content.Color1 = color;
            tpAddEndDate.StateActive.Content.Color1 = color;
            tpAddStartDate.StateActive.Content.Color1 = color;
        }

        private void _RefreshPrescriptionList()
        {
            dgAllPrescriptions.DataSource = clsMedicalRecord.MedicalRecordList();
        }

        private bool _AddNewPrescription()
        {
            clsPrescription Prescription = new clsPrescription();
            Prescription.MedicalRecordID = _MedicalRecordID;
            Prescription.MedicationName = txtAddMedicationName.Text;
            Prescription.Dosage = txtAddDosage.Text;
            Prescription.Frequency = short.Parse(txtAddFrequency.Text);
            Prescription.SpecialInstructions = txtAddSpecialInstructions.Text;
            Prescription.StartDate = DateTime.Parse(tpAddStartDate.Text);
            Prescription.EndDate = DateTime.Parse(tpAddEndDate.Text);

            if (Prescription.Save())
            {
                return true;
                
            }

            return false;

        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            if (_AddNewPrescription())
            {
                if (MessageBox.Show("Prescription Added Susseccfully") == DialogResult.OK)
                {

                    txtAddMedicationName.Text = "";
                    txtAddDosage.Text = "";
                    txtAddFrequency.Text = "";
                    txtAddSpecialInstructions.Text = "";
                    tpAddStartDate.CalendarTodayText = "";
                    tpAddEndDate.CalendarTodayText = "";
                    _RefreshPrescriptionList();
                    int count = dgAllPrescriptions.RowCount;
                    dgAllPrescriptions.Rows[count - 2].Selected = true;
                    dgAllPrescriptions.DataSource = clsPrescription.PrescriptionsList();

                }
            }
            else
                MessageBox.Show("Prescription Added Failed");
        }

    }
}
