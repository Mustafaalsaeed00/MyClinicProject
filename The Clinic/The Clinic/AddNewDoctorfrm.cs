using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AddNewDoctorfrm : KryptonForm
    {
        public AddNewDoctorfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AddNewDoctorfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AddNewDoctorfrm_Load(object sender, EventArgs e)
        {
            _RefreshDoctorsList();
            _FillGenderCB();
            _SetControlsForeColor(lblHeader.BackColor);

        }

        private void _SetControlsForeColor(Color color)
        {
            txtAddDoctorName.StateActive.Content.Color1 = color;
            txtAddDoctorDateOfBirth.StateActive.Content.Color1 = color;
            cbDoctorGender.StateActive.ComboBox.Content.Color1 = color;
            txtAddDoctorSpecialization.StateActive.Content.Color1 = color;
            txtAddDoctorPhone.StateActive.Content.Color1 = color;
            txtAddDoctorEmail.StateActive.Content.Color1 = color;
            txtAddDoctorAddress.StateActive.Content.Color1 = color;
        }

        public void _RefreshDoctorsList()
        {
            dgAllDoctors.DataSource = clsDoctor.DoctorList();
        }

        private void _FillGenderCB()
        {
            if (cbDoctorGender.Items.Count.Equals(0))
            {
                cbDoctorGender.Items.Add("M");
                cbDoctorGender.Items.Add("F");
            }
        }

        private bool _AddNewDoctor()
        {
            clsDoctor Doctor = new clsDoctor();

            Doctor.Name = txtAddDoctorName.Text;
            Doctor.DateOfBirth = DateTime.Parse(txtAddDoctorDateOfBirth.Text);
            Doctor.Gender = cbDoctorGender.Text;
            Doctor.Specialization = txtAddDoctorSpecialization.Text;
            Doctor.Phone = txtAddDoctorPhone.Text;
            Doctor.Email = txtAddDoctorEmail.Text;
            Doctor.Address = txtAddDoctorAddress.Text;

            if (Doctor.Save())
            {
                return true;
            }

            return false;

        }

        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            if (clsPatient.IsExist(txtAddDoctorName.Text.ToString()))
            {
                MessageBox.Show("Doctor Name is already Exist");
            }
            else if (_AddNewDoctor())
            {
                MessageBox.Show("Doctor Added Successfully");
                _RefreshDoctorsList();
                txtAddDoctorName.Text = "";
                txtAddDoctorDateOfBirth.Text = "";
                cbDoctorGender.Text = "Select Gender";
                txtAddDoctorSpecialization.Text = "";
                txtAddDoctorPhone.Text = "";
                txtAddDoctorEmail.Text = "";
                txtAddDoctorAddress.Text = "";

            }
            else
                MessageBox.Show("Doctor Added Failed");
        }

        private void txtAddDoctorName_Enter(object sender, EventArgs e)
        {
            if (txtAddDoctorAddress.Text == "Doctor not found")
                txtAddDoctorAddress.Text = "";
        }

        private void txtAddDoctorName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddDoctorName.Text))
            {
                errorProvider1.SetError(txtAddDoctorName, "Doctor Name required");
                return;
            }
            else if (txtAddDoctorName.Text.Split().Length < 2)
            {
                errorProvider1.SetError(txtAddDoctorName, "Doctor Name Must be FirstName , LastName");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAddDoctorName, string.Empty);
            }

        }
    }
}
