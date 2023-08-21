using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class SignInfrm : KryptonForm
    {

        public SignInfrm()
        {
            InitializeComponent();
        }

        private void SignInfrm_Load(object sender, EventArgs e)
        {
            AcceptButton = btnSignIn;
        }

        private void txtuserName_Enter(object sender, EventArgs e)
        {
            if (txtuserName.Text == "User Name")
            {
                txtuserName.Text = "";
                txtuserName.StateActive.Content.Color1 = Color.Black;
            }
             
        }

        private void txtuserName_Leave(object sender, EventArgs e)
        {
            if (txtuserName.Text == "")
            {
                txtuserName.Text = "User Name";
                txtuserName.StateActive.Content.Color1 = Color.Gray;
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.StateActive.Content.Color1 = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.StateActive.Content.Color1 = Color.Gray;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(txtuserName.Text);
            if (User != null && User.Password == clsEncryption.Encrypt(txtPassword.Text))
            {
                MainUserInterface mainUserInterface = new MainUserInterface(User);
                clsUserRegisteration register = new clsUserRegisteration();

                register.UserID = User.ID;
                register.dateTime = DateTime.Now;
                register.Description = "LogIn";

                if(register.Save())
                {
                    mainUserInterface.ShowDialog();
                }
            }
            else
            MessageBox.Show("UserName or Password is Wrong try Again" , "Login Failed" , MessageBoxButtons.OK , MessageBoxIcon.Error);
        }

    }
}
