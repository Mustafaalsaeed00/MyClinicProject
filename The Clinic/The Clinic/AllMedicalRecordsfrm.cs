using System;
using System.Drawing;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AllMedicalRecordsfrm : KryptonForm
    {
        int _PatientID = -1;
        public AllMedicalRecordsfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color,Text,image from the AllPatients Form and PatientID To get the patient's MedicalRecords
        public AllMedicalRecordsfrm(Color color, string text, Image image , int PatientID)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
            _PatientID = PatientID;
        }

        private void AllMedicalRecordsfrm_Load(object sender, EventArgs e)
        {
            if(_PatientID != -1)
            dgAllMedicalRecords.DataSource = clsMedicalRecord.FindMedicalRecordsListForPatient(_PatientID);
        }

        private void btnAllMedicalRecords_Click(object sender, EventArgs e)
        {
            dgAllMedicalRecords.DataSource = clsMedicalRecord.MedicalRecordList();
            lblHeader.Text = "All Medical Records";
            pbHeader.Image = Properties.Resources.All_MedicalRecords;
        }
    }
}
