using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AllDoctorsfrm : KryptonForm
    {
        public AllDoctorsfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AllDoctorsfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AllDoctorsfrm_Load(object sender, EventArgs e)
        {
            _RefreshDoctorsList();
            _FillcbFindDoctor();
        }

        public void _RefreshDoctorsList()
        {
            dgAllDoctors.DataSource = clsDoctor.DoctorList();
        }

        private void _FillcbFindDoctor()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Doctor ID");
                cbFind.Items.Add("Doctor Name");
            }
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

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dgAllDoctors.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsDoctor.Delete((int)dgAllDoctors.CurrentRow.Cells[0].Value);
                    _RefreshDoctorsList();
                }
            }
            else if (dgAllDoctors.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow Row in dgAllDoctors.SelectedRows)
                    {
                        clsDoctor.Delete((int)Row.Cells[0].Value);
                    }
                    _RefreshDoctorsList();
                }
            }


        }
    }
}
