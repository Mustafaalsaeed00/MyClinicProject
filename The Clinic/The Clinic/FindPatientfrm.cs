using System;
using System.Drawing;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class FindPatientfrm : KryptonForm
    {

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public FindPatientfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void FindPatientfrm_Load(object sender, EventArgs e)
        {
            _FillcbFindPatient();
            this.AcceptButton = btnFind;
            lblNotFound.Visible = false;
        }

        private void _FillcbFindPatient()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Patient ID");
                cbFind.Items.Add("Patient Name");
            }
        }

        private bool _FindPatient()
        {
            clsPatient Patient;
            if (cbFind.Text == "Patient ID")
            {

                int.TryParse(txtFind.Text, out int PatientID);
                Patient = clsPatient.Find(PatientID);
                if (Patient != null)
                {
                    lblNametxt.Text = "Name                  :";
                    lblPatientIDtxt.Text = "Patient ID";

                    lblID.Text = PatientID.ToString().ToUpper();
                    lblName.Text = Patient.Name;
                    lblGender.Text = Patient.Gender;
                    lblDateOfBirth.Text = Patient.DateOfBirth.ToString();
                    lblEmail.Text = Patient.Email;
                    lblPhone.Text = Patient.Phone;
                    lblAddress.Text = Patient.Address;
                    return true;
                }

            }
            else if (cbFind.Text == "Patient Name")
            {
                string patientName = txtFind.Text;
                Patient = clsPatient.Find(patientName);
                if (Patient != null)
                {
                    lblPatientIDtxt.Text = "Patient Name";
                    lblNametxt.Text = "Patient ID        :";

                    lblID.Text = Patient.Name.ToUpper();
                    lblName.Text = Patient.ID.ToString();
                    lblGender.Text = Patient.Gender;
                    lblDateOfBirth.Text = Patient.DateOfBirth.ToString();
                    lblEmail.Text = Patient.Email;
                    lblPhone.Text = Patient.Phone;
                    lblAddress.Text = Patient.Address;
                    return true;
                }

            }

            return false;
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            if (txtFind.Text == "Enter " + cbFind.Text)
            {
                txtFind.Text = "";
                txtFind.StateActive.Content.Color1 = Color.Black;
            }
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                txtFind.Text = "Enter " + cbFind.Text;
                txtFind.StateActive.Content.Color1 = Color.Gray;
            }
        }

        private void cbFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Text = "Enter " + cbFind.Text;
        }

        private void _ShowFindPatientControls(bool Visible)
        {
            lblPatientIDtxt.Visible = Visible;
            lblNametxt.Visible = Visible;
            lblDateOfBirthtxt.Visible = Visible;
            lblGendertxt.Visible = Visible;
            lblPhonetxt.Visible = Visible;
            lblEmailtxt.Visible = Visible;
            lblAddresstxt.Visible = Visible;


            lblID.Visible = Visible;
            lblName.Visible = Visible;
            lblDateOfBirth.Visible = Visible;
            lblGender.Visible = Visible;
            lblEmail.Visible = Visible;
            lblPhone.Visible = Visible;
            lblAddress.Visible = Visible;
            lblNotFound.Visible = !Visible;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_FindPatient())
                _ShowFindPatientControls(true);
            else
                _ShowFindPatientControls(false);
            txtFind.Text = "";
        }

    }
}
