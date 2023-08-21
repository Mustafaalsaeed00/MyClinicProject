using System;
using System.Drawing;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class UserRegisterationfrm : KryptonForm
    {

        //this Constructor to Gets the Header's Color,Text,image from the AllUsers Form
        public UserRegisterationfrm(Color color, string text, Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void UserRegisterationfrm_Load(object sender, EventArgs e)
        {
            _FillcbFindUser();
            _RefreshRegistersList();
        }

        private void _FillcbFindUser()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("User ID");
                cbFind.Items.Add("User Name");
            }
        }

        public void _RefreshRegistersList()
        {
            dgAllRegisters.DataSource = clsUserRegisteration.GetRegisterList();
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
                    dgAllRegisters.DataSource = clsUserRegisteration.FindRegisterbyChar(txtFind.Text);
                else
                    dgAllRegisters.DataSource = clsUserRegisteration.GetRegisterList();

            }
            else if (cbFind.Text == "User ID")
            {
                if (txtFind.Text != "")
                    dgAllRegisters.DataSource = clsUserRegisteration.FindRegisterbyNum(txtFind.Text);
                else
                    dgAllRegisters.DataSource = clsUserRegisteration.GetRegisterList();
            }

        }

        private void cbFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Text = "Enter " + cbFind.Text;
        }
    }
}
