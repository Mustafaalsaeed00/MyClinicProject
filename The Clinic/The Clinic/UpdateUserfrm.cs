using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class UpdateUserfrm : KryptonForm
    {
        enum enPermissions { eAll = -1, ePatient = 1, eDoctor = 2, eAppointment = 4, ePayment = 8, eUser = 16 }
        clsUser _User;
        bool _UserLoaded = false;

        //this Constructor Gets Header's Color,text,image from MainInterface Form
        public UpdateUserfrm(Color color, string text, Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void UpdateUserfrm_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            _FillcbFindUser();
            _SetControlsForeColor(lblHeader.BackColor);

            _User = clsUser.Find((int)dgAllUsers.CurrentRow.Cells[0].Value);
            _UserLoaded = true;
        }

        private void _SetControlsForeColor(Color color)
        {
            txtUpdateUserName.StateActive.Content.Color1 = color;
            txtUpdateUserPassword1.StateActive.Content.Color1 = color;
            txtUpdateUserPassword2.StateActive.Content.Color1 = color;
        }

        private void _FillcbFindUser()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("User ID");
                cbFind.Items.Add("User Name");
            }
        }

        public void _RefreshUsersList()
        {
            dgAllUsers.DataSource = clsUser.UsersList();
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
            if (txtFind.Text == "Enter User Name" || txtFind.Text == "Enter User ID")
                txtFind.Text = "";

            if (cbFind.Text == "User Name")
            {
                if (txtFind.Text != "")
                    dgAllUsers.DataSource = clsUser.FindUserByChar(txtFind.Text);
                else
                    dgAllUsers.DataSource = clsUser.UsersList();

            }
            else if (cbFind.Text == "User ID")
            {
                if (txtFind.Text != "")
                    dgAllUsers.DataSource = clsUser.FindUserByNum(txtFind.Text);
                else
                    dgAllUsers.DataSource = clsUser.UsersList();
            }
        }

        private void cbFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Text = "Enter " + cbFind.Text;
        }

        private int _GetUserPermissions()
        {
            int Permissions = 0;

            //if (ckbAll.Checked)
            //    return -1;

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

            if (Permissions == 31)
                return -1;
            else
                return Permissions;

        }

        private void _UpdateUser()
        {
            _User.UserName = txtUpdateUserName.Text;
            if (txtUpdateUserPassword1.Text == txtUpdateUserPassword2.Text)
            {
                string Password = txtUpdateUserPassword1.Text;
                _User.Password = clsEncryption.Encrypt(Password);
            }
            _User.Permissions = _GetUserPermissions();
        }

        private void _SetControlsEmpty()
        {
            txtUpdateUserName.Text = "";
            txtUpdateUserPassword1.Text = "";
            txtUpdateUserPassword1.Text = "";
        }

        private void btnUpdateUserbtn_Click(object sender, EventArgs e)
        {
            _User = clsUser.Find(int.Parse(dgAllUsers.CurrentRow.Cells[0].Value.ToString()));
            if (_User != null)
            {
                _UpdateUser();
                
                if (_User.Save())
                {
                    if (MessageBox.Show("User Updated Successfully", "Successful" , MessageBoxButtons.OK , MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ckbAll.Checked = false;
                        _SetControlsEmpty();
                        _RefreshUsersList();

                    }

                }
                else
                {
                    MessageBox.Show("User Updated Failed");
                }
            }


        }

        private bool CheckAccessPermissions(enPermissions Permissions , int UserPermissions)
        {
            if (((int)Permissions & UserPermissions) == (int)Permissions)
            {
                return true;
            }

            return false;
        }

        private void _CheckAllckbtn(bool Checked)
        {
            ckbPatient.Checked = Checked;
            ckbDoctor.Checked = Checked;
            ckbAppointment.Checked = Checked;
            ckbPayment.Checked = Checked;
            ckbUser.Checked = Checked;
        }

        private void CheckAll()
        {
            if (ckbAll.Checked)
                _CheckAllckbtn(true);
            else
                _CheckAllckbtn(false);
        }

        private void dgAllUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (_UserLoaded)
            {
                if (dgAllUsers.CurrentRow != null)
                {
                    txtUpdateUserName.Text = dgAllUsers.CurrentRow.Cells[1].Value.ToString();
                    txtUpdateUserPassword1.Text = clsEncryption.Decrypt(dgAllUsers.CurrentRow.Cells[2].Value.ToString());
                    txtUpdateUserPassword2.Text = clsEncryption.Decrypt(dgAllUsers.CurrentRow.Cells[2].Value.ToString());
                    try
                    {
                        if (int.Parse(dgAllUsers.CurrentRow.Cells[3].Value.ToString()) == 0)
                        {
                            ckbAll.Checked = false;
                            CheckAll();
                        }
                        else if (int.Parse(dgAllUsers.CurrentRow.Cells[3].Value.ToString()) == -1)
                        {
                            ckbAll.Checked = true;
                            CheckAll();
                        }
                        else
                        {
                            ckbAll.Checked = false;
                            ckbPatient.Checked = CheckAccessPermissions(enPermissions.ePatient, int.Parse(dgAllUsers.CurrentRow.Cells[3].Value.ToString()));
                            ckbDoctor.Checked = CheckAccessPermissions(enPermissions.eDoctor, int.Parse(dgAllUsers.CurrentRow.Cells[3].Value.ToString()));
                            ckbAppointment.Checked = CheckAccessPermissions(enPermissions.eAppointment, int.Parse(dgAllUsers.CurrentRow.Cells[3].Value.ToString()));
                            ckbPayment.Checked = CheckAccessPermissions(enPermissions.ePayment, int.Parse(dgAllUsers.CurrentRow.Cells[3].Value.ToString()));
                            ckbUser.Checked = CheckAccessPermissions(enPermissions.eUser, int.Parse(dgAllUsers.CurrentRow.Cells[3].Value.ToString()));
                        }
                    }
                    catch
                    {
                        txtUpdateUserName.AlwaysActive = true;
                    }
                }

            }
        }

        private void ckbAll_Click(object sender, EventArgs e)
        {
            CheckAll();
        }

    }
}
