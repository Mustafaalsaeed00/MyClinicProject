using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AllAppointmentsfrm : KryptonForm
    {

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AllAppointmentsfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AllAppointmentsfrm_Load(object sender, EventArgs e)
        {
            _RefreshAppointmentsList();
            _FillcbFindAppointment();
        }

        public void _RefreshAppointmentsList()
        {
            dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
        }

        private void _FillcbFindAppointment()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Appointment ID");
                cbFind.Items.Add("Patient Name");
                cbFind.Items.Add("Doctor Name");
                cbFind.Items.Add("Appointment Status");
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
            if (txtFind.Text == "Enter Patient Name" || txtFind.Text == "Enter Appointment ID" || 
                txtFind.Text == "Enter Appointment Status" || txtFind.Text == "Enter Doctor Name")
                txtFind.Text = "";

            if (cbFind.Text == "Patient Name")
            {
                if (txtFind.Text != "")
                    dgAllAppointments.DataSource = clsAppointment.FindAppointmentByPatientChar(txtFind.Text);
                else
                    dgAllAppointments.DataSource = clsAppointment.AppointmentsList();

            }
            else if (cbFind.Text == "Appointment ID")
            {
                if (txtFind.Text != "")
                    dgAllAppointments.DataSource = clsAppointment.FindAppointmentByNum(txtFind.Text);
                else
                    dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
            }
            else if (cbFind.Text == "Appointment Status")
            {
                if (txtFind.Text != "")
                    dgAllAppointments.DataSource = clsAppointment.FindAppointmentByStatus(txtFind.Text);
                else
                    dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
            }
            else if (cbFind.Text == "Doctor Name")
            {
                if (txtFind.Text != "")
                    dgAllAppointments.DataSource = clsAppointment.FindAppointmentByDoctorChar(txtFind.Text);
                else
                    dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
            }

        }

        private void cbFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Text = "Enter " + cbFind.Text;
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgAllAppointments.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsAppointment.Delete((int)dgAllAppointments.CurrentRow.Cells[0].Value);
                    _RefreshAppointmentsList();
                }
            }
            else if (dgAllAppointments.SelectedRows.Count > 1)
            {
                if(MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach(DataGridViewRow Row in dgAllAppointments.SelectedRows)
                    {
                        clsAppointment.Delete((int)Row.Cells[0].Value);
                    }
                    _RefreshAppointmentsList();
                }
            }
        }
    }
}
