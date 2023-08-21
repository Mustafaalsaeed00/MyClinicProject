using System;
using System.Drawing;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class FindAppointmentfrm : KryptonForm
    {
     

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public FindAppointmentfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void FindAppointmentfrm_Load(object sender, EventArgs e)
        {
            _FillcbFindAppointment();
            this.AcceptButton = btnFind;
            lblNotFound.Visible = false;

        }

        private void _FillcbFindAppointment()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Appointment ID");
                cbFind.Items.Add("Patient Name");
            }
        }

        private void _FillLabelsByAppointmentData(clsAppointment Appointment)
        {
            lblID.Text = Appointment.ID.ToString().ToUpper();
            lblPatientName.Text = Appointment.PatientName;
            lblDoctorName.Text = Appointment.DoctorName;
            lblDateTime.Text = Appointment.Date_Time.ToString();
            lblMedicalRecordID.Text = Appointment.Status;
            lblStatus.Text = Appointment.MedicalRecordID.ToString();
            lblPaymentID.Text = Appointment.PaymentID.ToString();
            lblSpecialization.Text = Appointment.Specialization;
        }

        private bool _FindAppointment()
        {

            clsAppointment Appointment;
            if (cbFind.Text == "Appointment ID")
            {

                int.TryParse(txtFind.Text, out int AppointmentID);
                Appointment = clsAppointment.FindAppointment(AppointmentID);
                if (Appointment != null)
                {
                    _FillLabelsByAppointmentData(Appointment);
                    return true;
                }

            }
            else if (cbFind.Text == "Patient Name")
            {
                string PatientName = txtFind.Text;
                Appointment = clsAppointment.FindAppointment(PatientName);
                if (Appointment != null)
                {
                    _FillLabelsByAppointmentData(Appointment);
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_FindAppointment())
            {
                lblAppointmentIDtxt.Visible = true;
                lblPatientNametxt.Visible = true;
                lblDoctorNametxt.Visible = true;
                lblDateTimetxt.Visible = true;
                lblSpecializationtxt.Visible = true;
                lblStatustxt.Visible = true;
                lblMedicalRecordIDtxt.Visible = true;
                lblPaymentIDtxt.Visible = true;

                lblID.Visible = true;
                lblPatientName.Visible = true;
                lblDateTime.Visible = true;
                lblDoctorName.Visible = true;
                lblMedicalRecordID.Visible = true;
                lblStatus.Visible = true;
                lblPaymentID.Visible = true;
                lblNotFound.Visible = false;
            }
            else
            {
                lblAppointmentIDtxt.Visible = false;
                lblPatientNametxt.Visible = false;
                lblDoctorNametxt.Visible = false;
                lblDateTimetxt.Visible = false;
                lblSpecializationtxt.Visible = false;
                lblStatustxt.Visible = false;
                lblMedicalRecordIDtxt.Visible = false;
                lblPaymentIDtxt.Visible = false;

                lblID.Visible = false;
                lblPatientName.Visible = false;
                lblDateTime.Visible = false;
                lblDoctorName.Visible = false;
                lblMedicalRecordID.Visible = false;
                lblStatus.Visible = false;
                lblPaymentID.Visible = false;
                lblNotFound.Visible = true;
                lblSpecialization.Visible = false;
            }
            txtFind.Text = "";
        }
    }
}
