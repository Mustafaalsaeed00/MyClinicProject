using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;


namespace The_Clinic
{
    public partial class UpdatePatientfrm : KryptonForm
    {
        clsPatient _Patient;


        //this Constructor Gets Header's Color,text,image from MainInterface Form
        public UpdatePatientfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void UpdatePatientfrm_Load(object sender, EventArgs e)
        {
            _RefreshPatients();
            _FillcbFindPatient();
            _FillGenderCB();
            _SetControlsForeColor(lblHeader.BackColor);

            _Patient = clsPatient.Find((int)dgAllPatients.CurrentRow.Cells[0].Value);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtUpdatePatientName.StateActive.Content.Color1 = color;
            txtUpdatePatientDateOfBirth.StateActive.Content.Color1 = color;
            txtUpdatePatientPhone.StateActive.Content.Color1 = color;
            cbPatientGender.StateActive.ComboBox.Content.Color1 = color;
            txtUpdatePatientEmail.StateActive.Content.Color1 = color;
            txtUpdatePatientAddress.StateActive.Content.Color1 = color;
        }

        private void _FillGenderCB()
        {
            if (cbPatientGender.Items.Count.Equals(0))
            {
                cbPatientGender.Items.Add("M");
                cbPatientGender.Items.Add("F");
            }
        }

        private void _FillcbFindPatient()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Patient ID");
                cbFind.Items.Add("Patient Name");
            }
        }

        private void _RefreshPatients()
        {
            dgAllPatients.DataSource = clsPatient.PatientList();
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            txtFind.StateActive.Content.Color1 = Color.Black;
            if (txtFind.Text == "Enter " + cbFind.Text)
            {
                txtFind.Text = "";
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

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "Enter Patient Name" || txtFind.Text == "Enter Patient ID")
                txtFind.Text = "";

            if (cbFind.Text == "Patient Name")
            {
                if (txtFind.Text != "")
                    dgAllPatients.DataSource = clsPatient.FindByChar(txtFind.Text);
                else
                    dgAllPatients.DataSource = clsPatient.PatientList();

            }
            else if (cbFind.Text == "Patient ID")
            {
                if (txtFind.Text != "")
                    dgAllPatients.DataSource = clsPatient.FindByNum(txtFind.Text);
                else
                    dgAllPatients.DataSource = clsPatient.PatientList();
            }

        }

        private void cbFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Text = "Enter " + cbFind.Text;
        }

        private void _UpdatePatient()
        {
            _Patient.Name = txtUpdatePatientName.Text;
            _Patient.DateOfBirth = DateTime.Parse(txtUpdatePatientDateOfBirth.Text);
            _Patient.Gender = cbPatientGender.Text;
            _Patient.Phone = txtUpdatePatientPhone.Text;
            _Patient.Email = txtUpdatePatientEmail.Text;
            _Patient.Address = txtUpdatePatientAddress.Text;
        }

        private void _SetControlsEmpty()
        {
            txtUpdatePatientName.Text = "";
            txtUpdatePatientDateOfBirth.Text = "";
            cbPatientGender.Text = "Select Gender";
            txtUpdatePatientPhone.Text = "";
            txtUpdatePatientEmail.Text = "";
            txtUpdatePatientAddress.Text = "";
        }

        private void btnUpdatePatientbtn_Click(object sender, EventArgs e)
        {
            _Patient = clsPatient.Find(int.Parse(dgAllPatients.CurrentRow.Cells[0].Value.ToString()));
            if (_Patient != null)
            {
                _UpdatePatient();

                if (_Patient.Save())
                {
                    if (MessageBox.Show("Patient Updated Successfully", "Successful" , MessageBoxButtons.OK , MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        _SetControlsEmpty();
                        _RefreshPatients();
                        
                    }

                }
                else
                {
                    MessageBox.Show("Patient Updated Failed");
                }
            }


        }

        private void dgAllPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAllPatients.CurrentRow != null)
            {
                txtUpdatePatientName.Text = dgAllPatients.CurrentRow.Cells[1].Value.ToString();
                txtUpdatePatientDateOfBirth.Text = dgAllPatients.CurrentRow.Cells[2].Value.ToString();
                cbPatientGender.Text = dgAllPatients.CurrentRow.Cells[3].Value.ToString();
                txtUpdatePatientEmail.Text = dgAllPatients.CurrentRow.Cells[4].Value.ToString();
                txtUpdatePatientPhone.Text = dgAllPatients.CurrentRow.Cells[5].Value.ToString();
                txtUpdatePatientAddress.Text = dgAllPatients.CurrentRow.Cells[6].Value.ToString();
            }
            
        }

    }
}
