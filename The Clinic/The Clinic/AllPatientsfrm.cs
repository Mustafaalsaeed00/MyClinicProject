using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AllPatientsfrm : KryptonForm
    {
        public AllPatientsfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AllPatientsfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        public void AllPatientsfrm_Load(object sender, EventArgs e)
        {
            _FillcbFindPatient();
            _RefreshPatientsList();
        }

        private void _FillcbFindPatient()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Patient ID");
                cbFind.Items.Add("Patient Name");
            }
        }

        public void _RefreshPatientsList()
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
            txtFind.StateActive.Content.Color1 = Color.Gray;
            if (txtFind.Text == "")
            {
                txtFind.Text = "Enter " + cbFind.Text;
                
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

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (dgAllPatients.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsPatient.Delete((int)dgAllPatients.CurrentRow.Cells[0].Value);
                    _RefreshPatientsList();
                }
            }
            else if (dgAllPatients.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow Row in dgAllPatients.SelectedRows)
                    {
                        clsPatient.Delete((int)Row.Cells[0].Value);
                    }
                    _RefreshPatientsList();
                }
            }

        }

        //show patient's MedicalRecords
        private void medicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMedicalRecordsfrm frm = new AllMedicalRecordsfrm(lblHeader.BackColor, dgAllPatients.CurrentRow.Cells[1].Value.ToString() + "'s Medical Records",
                Properties.Resources.medical_record , (int)dgAllPatients.CurrentRow.Cells[0].Value );
            frm.Show();
        }

        //show patient's Payments
        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllPaymentsfrm frm = new AllPaymentsfrm(lblHeader.BackColor, dgAllPatients.CurrentRow.Cells[1].Value.ToString() + "'s Payments",
                Properties.Resources.All_Payments__3_, (int)dgAllPatients.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        //show patient's Prescriptions
        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllPrescriptionsfrm frm = new AllPrescriptionsfrm(lblHeader.BackColor, dgAllPatients.CurrentRow.Cells[1].Value.ToString() + "'s Prescriptions",
                Properties.Resources.All_Prescriptions, (int)dgAllPatients.CurrentRow.Cells[0].Value);
            frm.Show();
        }
    }
}
