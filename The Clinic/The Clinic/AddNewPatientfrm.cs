using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AddNewPatientfrm : KryptonForm
    {
        public AddNewPatientfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AddNewPatientfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AddNewPatientfrm_Load(object sender, EventArgs e)
        {
            _RefreshPatientsList();
            _FillGenderCB();
            _SetControlsForeColor(lblHeader.BackColor);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtAddPatientName.StateActive.Content.Color1 = color;
            txtAddPatientDateOfBirth.StateActive.Content.Color1 = color;
            cbPatientGender.StateActive.ComboBox.Content.Color1 = color;
            txtAddPatientPhone.StateActive.Content.Color1 = color;
            txtAddPatientEmail.StateActive.Content.Color1 = color;
            txtAddPatientAddress.StateActive.Content.Color1 = color;
        }

        public void _RefreshPatientsList()
        {
            dgAllPatients.DataSource = clsPatient.PatientList();
        }

        private void _FillGenderCB()
        {
            if (cbPatientGender.Items.Count.Equals(0))
            {
                cbPatientGender.Items.Add("M");
                cbPatientGender.Items.Add("F");
            }
        }

        private bool _AddNewPatient()
        {
            clsPatient Patient = new clsPatient();

            Patient.Name = txtAddPatientName.Text;
            Patient.DateOfBirth = DateTime.Parse(txtAddPatientDateOfBirth.Text);
            Patient.Gender = cbPatientGender.Text;
            Patient.Phone = txtAddPatientPhone.Text;
            Patient.Email = txtAddPatientEmail.Text;
            Patient.Address = txtAddPatientAddress.Text;
            if (Patient.Save())
            {
                return true;
            }
            return false;

        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            if (clsPatient.IsExist(txtAddPatientName.Text.ToString()))
            {
                MessageBox.Show("Patient Name is already Exist");
            }
            else if (_AddNewPatient())
            {
                MessageBox.Show("Patient Added Successfully");
                _RefreshPatientsList();
                txtAddPatientName.Text = "";
                txtAddPatientDateOfBirth.Text = "";
                cbPatientGender.Text = "Select Gender";
                txtAddPatientPhone.Text = "";
                txtAddPatientEmail.Text = "";
                txtAddPatientAddress.Text = "";
            }
            else
                MessageBox.Show("Patient Added Failed");
        }

        private void txtAddPatientName_Enter(object sender, EventArgs e)
        {
            if (txtAddPatientAddress.Text == "Patient not found")
                txtAddPatientAddress.Text = "";
        }

        private void txtAddPatientName_Leave(object sender, EventArgs e)
        {
            string[] ValidateName = txtAddPatientName.Text.Split();
            if (string.IsNullOrEmpty(txtAddPatientName.Text))
            {
                errorProvider1.SetError(txtAddPatientName, "Patient Name required");
                return;
            }
            else if (ValidateName.Count() == 1)
            {
                errorProvider1.SetError(txtAddPatientName, "Patient Name Must be FirstName , LastName");
                return;
            }
            else if (ValidateName[1].Length < 2)
            {
                errorProvider1.SetError(txtAddPatientName, "Patient Name Must be FirstName , LastName");
                return;
            }
            else 
            {
                errorProvider1.SetError(txtAddPatientName, string.Empty);
            }

        }

    }
}
