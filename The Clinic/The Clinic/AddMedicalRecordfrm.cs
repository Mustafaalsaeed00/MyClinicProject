using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;


namespace The_Clinic
{
    public partial class AddMedicalRecordfrm : KryptonForm
    {
        int ID;
        bool MedicalRecordSaved = false;

        public AddMedicalRecordfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color of the MainInterface Form
        public AddMedicalRecordfrm(Color color)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pnlHeader.BackColor = color;
        }

        private void AddMedicalRecordfrm_Load(object sender, EventArgs e)
        {
            btnAddPrescription.Enabled = false;
            btnAddNewMedicalRecord.Visible = false;
            _SetControlsForeColor(lblHeader.BackColor);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtAddMedicalRecordDescription.StateActive.Content.Color1 = color;
            txtAddMedicalRecordDiagnosis.StateActive.Content.Color1 = color;
            txtAddMedicalRecordNotes.StateActive.Content.Color1 = color;
        }

        //this Function Created to Called from AddNewAppointment/UpdateAppointment Form To Show the MedicalRecordID if it saved Successfully
        public int GetMedicalRecordID()
        {
            if (MedicalRecordSaved)
                return ID;
            else
                return -1;
        }

        private bool _AddMedicalRecord()
        {
            clsMedicalRecord Medical = new clsMedicalRecord();

            Medical.Description = txtAddMedicalRecordDescription.Text;
            Medical.Diagnosis = txtAddMedicalRecordDiagnosis.Text;
            Medical.Notes = txtAddMedicalRecordNotes.Text;

            if(Medical.Save())
            {
                lblMedicalRecordID.Text = Medical.ID.ToString();
                ID = int.Parse(lblMedicalRecordID.Text);
                MedicalRecordSaved = true;
                return true;
            }
            return false;
        }

        private void btnAddMedicalRecord_Click(object sender, EventArgs e)
        {
            if (_AddMedicalRecord())
            {
                if (MessageBox.Show("Medical Record Added Susseccfully") == DialogResult.OK)
                {
                    btnAddMedicalRecord.Visible = false;
                    btnAddNewMedicalRecord.Visible = true;
                    btnAddPrescription.Enabled = true;
                    // this.Close();
                }
            }
            else
                MessageBox.Show("Medical Record Added Failed");
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            AddPrescriptionfrm frm = new AddPrescriptionfrm(lblHeader.BackColor, "Add Prescription", Properties.Resources.AddAppointment__1_, GetMedicalRecordID());
            frm.Show();
        }

        //this Used after adding a MedicalRecord if we want to Add a new one
        private void btnAddNewMedicalRecord_Click(object sender, EventArgs e)
        {
            lblMedicalRecordID.Text = "";
            txtAddMedicalRecordDescription.Text = "";
            txtAddMedicalRecordDiagnosis.Text = "";
            txtAddMedicalRecordNotes.Text = "";
            btnAddPrescription.Enabled = false;
            btnAddNewMedicalRecord.Visible = false;
        }

    }
    
}
