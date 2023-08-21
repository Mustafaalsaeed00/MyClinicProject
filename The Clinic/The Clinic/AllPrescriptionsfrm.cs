using System;
using System.Drawing;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AllPrescriptionsfrm : KryptonForm
    {
        int _PatientID = -1;
 
        //this Constructor to Gets the Header's Color,Text,image from the AllPatients Form and PatientID To get the patient's prescriptions
        public AllPrescriptionsfrm(Color color, string text, Image image, int PatientID)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
            _PatientID = PatientID;
        }

        private void AllPrescriptionsfrm_Load(object sender, EventArgs e)
        {
            _RefreshPrescriptionsList();
        }

        private void _RefreshPrescriptionsList()
        {
                dgAllPrescriptions.DataSource = clsPrescription.PatientPrescriptionsList(_PatientID);
        }

        private void btnAllPrescriptions_Click(object sender, EventArgs e)
        {
            dgAllPrescriptions.DataSource = clsPrescription.PrescriptionsList();
            lblHeader.Text = "All Prescriptions";
        }
    }
}
