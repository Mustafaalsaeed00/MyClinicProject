using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class Settingsfrm : KryptonForm
    {
        enum enPermissions { eAll = -1, ePatient = 1, eDoctor = 2, eAppointment = 4, ePayment = 8, eUser = 16 }

        clsUser _CurrentUser;

        KryptonForm MainForm;

        bool _LogedOut = false;

        //this Constructor Gets Header's Color,text,image and CurrentUser and The MainInterface to use it for logout
        public Settingsfrm(Color color, string text, Image image , clsUser User  , KryptonForm frm)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
            _CurrentUser = User;
            MainForm = frm;
        }

        private void Settingsfrm_Load(object sender, EventArgs e)
        {
            txtCurrentUserName.Text = _CurrentUser.UserName;
            if (_CurrentUser.Permissions == 0)
            {
                ckbAll.Checked = false;
                CheckAll();
            }
            else if (_CurrentUser.Permissions == -1)
            {
                ckbAll.Checked = true;
                CheckAll();
            }
            else
            {
                ckbPatient.Checked = CheckAccessPermissions(enPermissions.ePatient, _CurrentUser.Permissions);
                ckbDoctor.Checked = CheckAccessPermissions(enPermissions.eDoctor, _CurrentUser.Permissions);
                ckbAppointment.Checked = CheckAccessPermissions(enPermissions.eAppointment, _CurrentUser.Permissions);
                ckbPayment.Checked = CheckAccessPermissions(enPermissions.ePayment, _CurrentUser.Permissions);
                ckbUser.Checked = CheckAccessPermissions(enPermissions.eUser, _CurrentUser.Permissions);
            }

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

        private bool CheckAccessPermissions(enPermissions Permissions, int UserPermissions)
        {
            if (((int)Permissions & UserPermissions) == (int)Permissions)
            {
                return true;
            }

            return false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You Want To LogOut" , "LogOut" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _LogedOut = true;
                clsUserRegisteration register = new clsUserRegisteration();

                register.UserID = _CurrentUser.ID;
                register.dateTime = DateTime.Now;
                register.Description = "LogOut";

                if (register.Save())
                    MainForm.Close();
            }
        }
    }
}
