using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AllUsersfrm : KryptonForm
    {

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AllUsersfrm(Color color, string text, Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AllUsersfrm_Load(object sender, EventArgs e)
        {
            _FillcbFindUser();
            _RefreshUsersList();
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
            txtFind.StateActive.Content.Color1 = Color.Gray;
            if (txtFind.Text == "")
            {
                txtFind.Text = "Enter " + cbFind.Text;

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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgAllUsers.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsUser.Delete((int)dgAllUsers.CurrentRow.Cells[0].Value);
                    _RefreshUsersList();
                }
            }
            else if (dgAllUsers.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow Row in dgAllUsers.SelectedRows)
                    {
                        clsUser.Delete((int)Row.Cells[0].Value);
                    }
                    _RefreshUsersList();
                }
            }
        }

        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            UserRegisterationfrm frm = new UserRegisterationfrm(lblHeader.BackColor, "User register", pbHeader.Image);
            frm.Show();
        }

        //to decrypt password and show it
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(int.Parse(dgAllUsers.CurrentRow.Cells[0].Value.ToString()));

            dgAllUsers.CurrentRow.Cells[2].Value = User.Password;
        }
    }
}
