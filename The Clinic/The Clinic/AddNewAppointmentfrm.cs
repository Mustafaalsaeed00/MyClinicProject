using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class AddNewAppointmentfrm : KryptonForm
    {
        public AddNewAppointmentfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AddNewAppointmentfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void AddNewAppointmentfrm_Load(object sender, EventArgs e)
        {
            _RefreshAppointmentsList();
            _FillcbAppointmentStatus();
            _SetControlsForeColor(lblHeader.BackColor);

        }

        private void _SetControlsForeColor(Color color)
        {
            txtAddDoctorName.StateActive.Content.Color1 = color;
            txtAddPatientName.StateActive.Content.Color1 = color;
            txtAddSpecialization.StateActive.Content.Color1 = color;
            tpAddAppointmentDateTime.StateActive.Content.Color1 = color;
            cbAppointmentStatus.StateActive.ComboBox.Content.Color1 = color;
            lblMedicalRecordID.ForeColor = color;
            lblPaymentID.ForeColor = color;
        }

        private void _RefreshAppointmentsList()
        {
            dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
        }

        private void _FillcbAppointmentStatus()
        {
            if (cbAppointmentStatus.Items.Count.Equals(0))
            {
                cbAppointmentStatus.Items.Add("Pending");
                cbAppointmentStatus.Items.Add("Confirmed");
                cbAppointmentStatus.Items.Add("Completed");
                cbAppointmentStatus.Items.Add("Canceled");
                cbAppointmentStatus.Items.Add("Rescheduled");
                cbAppointmentStatus.Items.Add("No Show");
            }
        }

        private void txtAddAppointmentDoctorName_Enter(object sender, EventArgs e)
        {
            if (txtAddDoctorName.Text == "Doctor not found")
                txtAddDoctorName.Text = "";
            dgAllAppointments.DataSource = clsDoctor.DoctorList();
        }

        private void txtAddAppointmentDoctorName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddDoctorName.Text))
            {
                errorProvider1.SetError(txtAddDoctorName, "DoctorName required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAddDoctorName, string.Empty);
            }

            clsDoctor Doctor = clsDoctor.Find(txtAddDoctorName.Text);
            if (Doctor != null)
                txtAddSpecialization.Text = Doctor.Specialization;
            else
            {
                txtAddDoctorName.Text = "Doctor not found";
                errorProvider1.SetError(txtAddDoctorName, "DoctorName required");
            }
            dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
        }

        private void txtAddAppointmentPatientName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddPatientName.Text))
            {
                errorProvider2.SetError(txtAddPatientName, "PatientName required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtAddPatientName, string.Empty);
            }

            clsPatient Patient = clsPatient.Find(txtAddPatientName.Text);
            if (Patient == null)
            {
                txtAddPatientName.Text = "Patient not found";
                errorProvider2.SetError(txtAddPatientName, "PatientName required");
            }

            dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
        }

        private void txtAddAppointmentPatientName_Enter(object sender, EventArgs e)
        {
            if (txtAddPatientName.Text == "Patient not found")
                txtAddPatientName.Text = "";
            dgAllAppointments.DataSource = clsPatient.PatientList();
        }

        private bool _AddNewAppointment()
        {
            clsAppointment Appointment = new clsAppointment();
            clsPatient Patient = clsPatient.Find(txtAddPatientName.Text);
            clsDoctor Doctor = clsDoctor.Find(txtAddDoctorName.Text);
            if (Patient != null)
                Appointment.PatientID = Patient.ID;

            if (Doctor != null)
                Appointment.DoctorID = Doctor.ID;

            Appointment.Date_Time = DateTime.Parse(tpAddAppointmentDateTime.Text);
            if (cbAppointmentStatus.Text == "Select Status")
            {
                cbAppointmentStatus.SelectedIndex = 0;
            }
            Appointment.Status = cbAppointmentStatus.Text;

            if (lblMedicalRecordID.Text != "")
                Appointment.MedicalRecordID = int.Parse(lblMedicalRecordID.Text);
            

            if (lblPaymentID.Text != "")
                Appointment.PaymentID = int.Parse(lblPaymentID.Text);
            

            if (Appointment.Save())
            {
                return true;
            }

            return false;

        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            if (_AddNewAppointment())
            {
                if(MessageBox.Show("Appointment Added Susseccfully") == DialogResult.OK)
                {
                    
                    txtAddPatientName.Text = "";
                    txtAddDoctorName.Text = "";
                    tpAddAppointmentDateTime.CalendarTodayText = "";
                    txtAddSpecialization.Text = "";
                    cbAppointmentStatus.Text = "Select Status";
                    lblPaymentID.Text = "";
                    _RefreshAppointmentsList();
                    int count = dgAllAppointments.RowCount;
                    dgAllAppointments.Rows[count - 2].Selected = true;
                    
                }
            }
            else
                MessageBox.Show("Appointment Added Failed");

            
        }

        private void btnAddMedicalRecord_Click(object sender, EventArgs e)
        {
            AddMedicalRecordfrm frm = new AddMedicalRecordfrm(lblHeader.BackColor);
            frm.ShowDialog();
            label26.Text = "Medical Record ID : ";
            int MedicalRecordID = frm.GetMedicalRecordID();
            lblMedicalRecordID.Text = MedicalRecordID.ToString();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddPaymentfrm frm = new AddPaymentfrm(lblHeader.BackColor);
            frm.ShowDialog();
            label31.Text = "Payment ID : ";
            int PaymentID = frm.GetPaymentID();
            lblPaymentID.Text = PaymentID.ToString();
        }

        private void cbUpdateAppointmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAppointmentStatus.SelectedIndex == 2)
            {
                btnAddMedicalRecord.Enabled = true;
            }
            else
            {
                btnAddMedicalRecord.Enabled = false;
            }
        }

    }
}
