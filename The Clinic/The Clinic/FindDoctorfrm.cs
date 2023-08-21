using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class FindDoctorfrm : KryptonForm
    {

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public FindDoctorfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void FindDoctorfrm_Load(object sender, EventArgs e)
        {
            _FillcbFindDoctor();
            this.AcceptButton = btnFind;
            lblNotFound.Visible = false;
        }

        private void _FillcbFindDoctor()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Doctor ID");
                cbFind.Items.Add("Doctor Name");
            }
        }

        private void _FillLabelsByDoctorData(clsDoctor Doctor)
        {
            lblGender.Text = Doctor.Gender;
            lblDateOfBirth.Text = Doctor.DateOfBirth.ToString();
            lblEmail.Text = Doctor.Email;
            lblPhone.Text = Doctor.Phone;
            lblAddress.Text = Doctor.Address;
            lblSpecialization.Text = Doctor.Specialization;
        }

        private bool _FindDoctor()
        {

            clsDoctor Doctor;
            if (cbFind.Text == "Doctor ID")
            {
                lblID.Location = new Point(803, 291);
                int.TryParse(txtFind.Text, out int DoctorID);
                Doctor = clsDoctor.Find(DoctorID);
                if (Doctor != null)
                {
                    lblNametxt.Text = "Name                  :";
                    lblDoctorIDtxt.Text = "Doctor ID";

                    lblID.Text = Doctor.ID.ToString().ToUpper();
                    lblName.Text = Doctor.Name;
                    _FillLabelsByDoctorData(Doctor);
                    return true;
                }

            }
            else if (cbFind.Text == "Doctor Name")
            {
                string DoctorName = txtFind.Text;
                Doctor = clsDoctor.Find(DoctorName);
                if (Doctor != null)
                {
                    lblDoctorIDtxt.Text = "Doctor Name";
                    lblNametxt.Text = "Doctor ID        :";

                    lblID.Text = Doctor.Name.ToUpper();
                    lblName.Text = Doctor.ID.ToString();
                    _FillLabelsByDoctorData(Doctor);

                    string[] Name = lblID.Text.Split();
                    if (Name.Count() > 1)
                        lblID.Location = new Point(768, 291);
                    else
                        lblID.Location = new Point(803, 291);
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

        private void _ShowFindDoctorControls(bool Visible)
        {
            lblDoctorIDtxt.Visible = Visible;
            lblNametxt.Visible = Visible;
            lblDateOfBirthtxt.Visible = Visible;
            lblGendertxt.Visible = Visible;
            lblPhonetxt.Visible = Visible;
            lblEmailtxt.Visible = Visible;
            lblAddresstxt.Visible = Visible;
            lblSpecializationtxt.Visible = Visible;



            lblID.Visible = Visible;
            lblName.Visible = Visible;
            lblDateOfBirth.Visible = Visible;
            lblGender.Visible = Visible;
            lblEmail.Visible = Visible;
            lblPhone.Visible = Visible;
            lblAddress.Visible = Visible;
            lblSpecialization.Visible = Visible;
            lblNotFound.Visible = !Visible;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_FindDoctor())
                _ShowFindDoctorControls(true);
            else
                _ShowFindDoctorControls(false);
            txtFind.Text = "";
        }

    }
}
