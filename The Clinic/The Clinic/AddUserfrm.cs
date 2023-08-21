using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AddUserfrm : KryptonForm
    {
        enum enPermissions { eAll = -1, ePatient = 1, eDoctor = 2, eAppointment = 4, ePayment = 8 , eUser = 16}
        public AddUserfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AddUserfrm(Color color, string text, Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AddUserfrm_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            _SetControlsForeColor(lblHeader.BackColor);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtAddUserName.StateActive.Content.Color1 = color;
            txtAddUserPassword1.StateActive.Content.Color1 = color;
            txtAddUserPassword2.StateActive.Content.Color1 = color;
        }

        private void _RefreshUsersList()
        {
            dgAllUsers.DataSource = clsUser.UsersList();
        }

        private void _CheckAllckbtn(bool Checked)
        {
            ckbPatient.Checked = Checked;
            ckbDoctor.Checked = Checked;
            ckbAppointment.Checked = Checked;
            ckbPayment.Checked = Checked;
            ckbUser.Checked = Checked;
        }

        private void ckbAll_Click(object sender, EventArgs e)
        {
            if(ckbAll.Checked)
                _CheckAllckbtn(true);
            else
                _CheckAllckbtn(false);
        }

        private int _GetUserPermissions()
        {
            int Permissions = 0;

            if (ckbAll.Checked)
                return -1;

            if (ckbPatient.Checked)
                Permissions += (int)enPermissions.ePatient;

            if (ckbDoctor.Checked)
                Permissions += (int)enPermissions.eDoctor;

            if (ckbAppointment.Checked)
                Permissions += (int)enPermissions.eAppointment;

            if (ckbPayment.Checked)
                Permissions += (int)enPermissions.ePayment;

            if (ckbUser.Checked)
                Permissions += (int)enPermissions.eUser;


            return Permissions;

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            clsUser User = new clsUser();

            if (clsUser.IsExist(txtAddUserName.Text))
            {
                MessageBox.Show("UserName is already exist" , "Failed" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                return;
            }

            User.UserName = txtAddUserName.Text;
            if (txtAddUserPassword1.Text == txtAddUserPassword2.Text)
            {
                string Password = txtAddUserPassword1.Text;
                User.Password = clsEncryption.Encrypt(Password);
            }
            else
            {
                errorProvider1.SetError(txtAddUserPassword2, "Passwords not Same");
            }

            User.Permissions = _GetUserPermissions();


            if(User.Save())
            {
                MessageBox.Show("User Added Successfully" , "Successful" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                _RefreshUsersList();
            }
            else
            {
                MessageBox.Show("User Adding Faild");
            }


        }

        private void txtAddUserPassword2_Leave(object sender, EventArgs e)
        {
            if(txtAddUserPassword1.Text != txtAddUserPassword2.Text)
            {
                errorProvider1.SetError(txtAddUserPassword2, "Passwords not Same");
            }
            else
            {
                errorProvider1.SetError(txtAddUserPassword2, string.Empty);
            }
        }
    }
}
