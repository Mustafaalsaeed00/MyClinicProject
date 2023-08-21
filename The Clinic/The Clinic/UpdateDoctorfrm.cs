using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class UpdateDoctorfrm : KryptonForm
    {
        clsDoctor _Doctor;

        //this Constructor Gets Header's Color,text,image from MainInterface Form
        public UpdateDoctorfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void UpdateDoctorfrm_Load(object sender, EventArgs e)
        {
            _RefreshDoctors();
            _FillcbFindDoctor();
            _FillGenderCB();
            _SetControlsForeColor(lblHeader.BackColor);
            _Doctor = clsDoctor.Find((int)dgAllDoctors.CurrentRow.Cells[0].Value);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtUpdateDoctorName.StateActive.Content.Color1 = color;
            txtUpdateDoctorDateOfBirth.StateActive.Content.Color1 = color;
            cbDoctorGender.StateActive.ComboBox.Content.Color1 = color;
            txtUpdateDoctorSpecialization.StateActive.Content.Color1 = color;
            txtUpdateDoctorPhone.StateActive.Content.Color1 = color;
            txtUpdateDoctorEmail.StateActive.Content.Color1 = color;
            txtUpdateDoctorAddress.StateActive.Content.Color1 = color;
        }

        private void _FillGenderCB()
        {
            if (cbDoctorGender.Items.Count.Equals(0))
            {
                cbDoctorGender.Items.Add("M");
                cbDoctorGender.Items.Add("F");
            }
        }

        private void _FillcbFindDoctor()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Doctor ID");
                cbFind.Items.Add("Doctor Name");
            }
        }

        private void _RefreshDoctors()
        {
            dgAllDoctors.DataSource = clsDoctor.DoctorList();
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

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "Enter Doctor Name" || txtFind.Text == "Enter Doctor ID")
                txtFind.Text = "";

            if (cbFind.Text == "Doctor Name")
            {
                if (txtFind.Text != "")
                    dgAllDoctors.DataSource = clsDoctor.FindByChar(txtFind.Text);
                else
                    dgAllDoctors.DataSource = clsDoctor.DoctorList();

            }
            else if (cbFind.Text == "Doctor ID")
            {
                if (txtFind.Text != "")
                    dgAllDoctors.DataSource = clsDoctor.FindByNum(txtFind.Text);
                else
                    dgAllDoctors.DataSource = clsDoctor.DoctorList();
            }

        }

        private void cbFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Text = "Enter " + cbFind.Text;
        }

        private void _UpdateDoctor()
        {
            _Doctor.Name = txtUpdateDoctorName.Text;
            _Doctor.DateOfBirth = DateTime.Parse(txtUpdateDoctorDateOfBirth.Text);
            _Doctor.Gender = cbDoctorGender.Text;
            _Doctor.Phone = txtUpdateDoctorPhone.Text;
            _Doctor.Email = txtUpdateDoctorEmail.Text;
            _Doctor.Address = txtUpdateDoctorAddress.Text;
            _Doctor.Specialization = txtUpdateDoctorSpecialization.Text;
        }

        private void _SetControlsEmpty()
        {
            txtUpdateDoctorName.Text = "";
            txtUpdateDoctorDateOfBirth.Text = "";
            cbDoctorGender.Text = "Select Gender";
            txtUpdateDoctorSpecialization.Text = "";
            txtUpdateDoctorPhone.Text = "";
            txtUpdateDoctorEmail.Text = "";
            txtUpdateDoctorAddress.Text = "";
        }

        private void btnUpdateDoctortbtn_Click(object sender, EventArgs e)
        {
            _Doctor = clsDoctor.Find(int.Parse(dgAllDoctors.CurrentRow.Cells[0].Value.ToString()));

            if (_Doctor != null)
            {
                _UpdateDoctor();

                if (_Doctor.Save())
                {
                    if (MessageBox.Show("Doctor Updated Successfully", "Successful" , MessageBoxButtons.OK ,MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        _SetControlsEmpty();
                        _RefreshDoctors();
                    }
                }
                else
                {
                    MessageBox.Show("Doctor Updated Failed");
                }
            }
        }

        private void dgAllDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAllDoctors.CurrentRow != null)
            {
                txtUpdateDoctorName.Text = dgAllDoctors.CurrentRow.Cells[1].Value.ToString();
                txtUpdateDoctorSpecialization.Text = dgAllDoctors.CurrentRow.Cells[2].Value.ToString();
                txtUpdateDoctorDateOfBirth.Text = dgAllDoctors.CurrentRow.Cells[3].Value.ToString();
                cbDoctorGender.Text = dgAllDoctors.CurrentRow.Cells[4].Value.ToString();
                txtUpdateDoctorEmail.Text = dgAllDoctors.CurrentRow.Cells[5].Value.ToString();
                txtUpdateDoctorPhone.Text = dgAllDoctors.CurrentRow.Cells[6].Value.ToString();
                txtUpdateDoctorAddress.Text = dgAllDoctors.CurrentRow.Cells[7].Value.ToString();
            }

        }

    }
}
