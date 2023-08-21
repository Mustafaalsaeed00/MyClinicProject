using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    public partial class UpdateAppointmentfrm : KryptonForm
    {
        clsAppointment _Appointment;

        //this Constructor Gets Header's Color,text,image from MainInterface Form
        public UpdateAppointmentfrm(Color color , string text , Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void UpdateAppointmentfrm_Load(object sender, EventArgs e)
        {
            _RefreshAppointmentsList();
            _FillcbFindAppointment();
            _FillcbAppointmentStatus();
            _SetControlsForeColor(lblHeader.BackColor);
            
            _Appointment = clsAppointment.FindAppointment((int)dgAllAppointments.CurrentRow.Cells[0].Value);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtUpdateAppointmentDoctorName.StateActive.Content.Color1 = color;
            txtUpdateAppointmentPatientName.StateActive.Content.Color1 = color;
            txtUpdateAppointmentSpecialization.StateActive.Content.Color1 = color;
            tpUpdateAppointmentDateTime.StateActive.Content.Color1 = color;
            cbUpdateAppointmentStatus.StateActive.ComboBox.Content.Color1 = color;
            lblUpdateAppointmentMedicaRecordID.ForeColor = color;
            lblUpdateAppointmentPaymentID.ForeColor = color;
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

        private void _FillcbAppointmentStatus()
        {
            if (cbUpdateAppointmentStatus.Items.Count.Equals(0))
            {   
                cbUpdateAppointmentStatus.Items.Add("Pending");
                cbUpdateAppointmentStatus.Items.Add("Confirmed");
                cbUpdateAppointmentStatus.Items.Add("Completed");
                cbUpdateAppointmentStatus.Items.Add("Canceled");
                cbUpdateAppointmentStatus.Items.Add("Rescheduled");
                cbUpdateAppointmentStatus.Items.Add("No Show");
            }
        }

        private void txtAddAppointmentDoctorName_Enter(object sender, EventArgs e)
        {
            if (txtUpdateAppointmentDoctorName.Text == "Doctor not found")
                txtUpdateAppointmentDoctorName.Text = "";
        }

        private void txtUpdateAppointmentDoctorName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateAppointmentDoctorName.Text))
            {
                errorProvider1.SetError(txtUpdateAppointmentDoctorName, "DoctorName required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUpdateAppointmentDoctorName, string.Empty);
            }

            clsDoctor Doctor = clsDoctor.Find(txtUpdateAppointmentDoctorName.Text);
            if (Doctor != null)
                txtUpdateAppointmentSpecialization.Text = Doctor.Specialization;
            else
            {
                txtUpdateAppointmentDoctorName.Text = "Doctor not found";
                errorProvider1.SetError(txtUpdateAppointmentDoctorName, "DoctorName required");
            }

        }

        private void txtAddAppointmentPatientName_Enter(object sender, EventArgs e)
        {
            if (txtUpdateAppointmentPatientName.Text == "Patient not found")
                txtUpdateAppointmentPatientName.Text = "";
        }

        private void txtUpdateAppointmentPatientName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateAppointmentPatientName.Text))
            {
                errorProvider2.SetError(txtUpdateAppointmentPatientName, "PatientName required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtUpdateAppointmentPatientName, string.Empty);
            }

            clsPatient Patient = clsPatient.Find(txtUpdateAppointmentPatientName.Text);
            if (Patient == null)
            {
                txtUpdateAppointmentPatientName.Text = "Patient not found";
                errorProvider2.SetError(txtUpdateAppointmentPatientName, "PatientName required");
            }

        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            if (txtFind.Text == "Enter " + cbFind.Text)
            {
                txtFind.Text = "";
                txtFind.StateActive.Content.Color1 = Color.Black;
            }

            if (cbFind.Text == "Patient Name")
            {
                if (txtFind.Text != "")

                    dgAllAppointments.DataSource = clsAppointment.FindAppointmentByPatientChar(txtFind.Text);
                else
                    dgAllAppointments.DataSource = clsAppointment.AppointmentsList();
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
            if (txtFind.Text == "Enter Patient Name" || txtFind.Text == "Enter Appointment ID")
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

        private void _UpdateAppointment()
        {
            clsPatient Patient = clsPatient.Find(txtUpdateAppointmentPatientName.Text);
            clsDoctor Doctor = clsDoctor.Find(txtUpdateAppointmentDoctorName.Text);

            _Appointment.PatientID = Patient.ID;
            _Appointment.PatientName = txtUpdateAppointmentPatientName.Text;
            _Appointment.DoctorID = Doctor.ID;
            _Appointment.DoctorName = txtUpdateAppointmentDoctorName.Text;
            _Appointment.Date_Time = DateTime.Parse(tpUpdateAppointmentDateTime.Text);
            _Appointment.Status = cbUpdateAppointmentStatus.Text;
            _Appointment.Specialization = txtUpdateAppointmentSpecialization.Text;

            if (lblUpdateAppointmentMedicaRecordID.Text == "No Medical Records" || lblUpdateAppointmentMedicaRecordID.Text == "")
                _Appointment.MedicalRecordID = -1;
            else
                _Appointment.MedicalRecordID = int.Parse(lblUpdateAppointmentMedicaRecordID.Text);


            if (lblUpdateAppointmentPaymentID.Text == "No Payments" || lblUpdateAppointmentPaymentID.Text == "")
                _Appointment.PaymentID = -1;
            else
                _Appointment.PaymentID = int.Parse(lblUpdateAppointmentPaymentID.Text);

        }

        private void _SetControlsEmpty()
        {
            txtUpdateAppointmentPatientName.Text = "";
            txtUpdateAppointmentDoctorName.Text = "";
            tpUpdateAppointmentDateTime.Text = "";
            cbUpdateAppointmentStatus.Text = "";
            lblUpdateAppointmentMedicaRecordID.Text = "";
            lblUpdateAppointmentPaymentID.Text = "";
            txtUpdateAppointmentSpecialization.Text = "";
        }

        private void btnUpdateAppointmentbtn_Click(object sender, EventArgs e)
        {
            _Appointment = clsAppointment.FindAppointment(int.Parse(dgAllAppointments.CurrentRow.Cells[0].Value.ToString()));

            if (_Appointment != null)
            {
                _UpdateAppointment();

                if (_Appointment.Save())
                {
                    if (MessageBox.Show("Appointment Updated Susseccfully" , "Successful" , MessageBoxButtons.OK , MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        _SetControlsEmpty();
                        _RefreshAppointmentsList();
                    }

                }
                else
                {
                    MessageBox.Show("Appointment Updated Failed");
                }
            }



        }

        private void btnAddMedicalRecord_Click(object sender, EventArgs e)
        {
            AddMedicalRecordfrm frm = new AddMedicalRecordfrm();
            frm.ShowDialog();
            int MedicalRecordID = frm.GetMedicalRecordID();
            lblUpdateAppointmentMedicaRecordID.Text = MedicalRecordID.ToString();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddPaymentfrm frm = new AddPaymentfrm();
            frm.ShowDialog();
            int PaymentID = frm.GetPaymentID();
            lblUpdateAppointmentPaymentID.Text = PaymentID.ToString();
        }

        private void dgAllAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAllAppointments.CurrentRow != null)
            {
                try
                {
                    _Appointment = clsAppointment.FindAppointment((int)dgAllAppointments.CurrentRow.Cells[0].Value);
                    txtUpdateAppointmentPatientName.Text = dgAllAppointments.CurrentRow.Cells[1].Value.ToString();
                    txtUpdateAppointmentDoctorName.Text = dgAllAppointments.CurrentRow.Cells[2].Value.ToString();
                    tpUpdateAppointmentDateTime.CalendarTodayText = dgAllAppointments.CurrentRow.Cells[3].Value.ToString();
                    cbUpdateAppointmentStatus.Text = dgAllAppointments.CurrentRow.Cells[4].Value.ToString();
                    lblUpdateAppointmentMedicaRecordID.Text = dgAllAppointments.CurrentRow.Cells[5].Value.ToString();
                    lblUpdateAppointmentPaymentID.Text = dgAllAppointments.CurrentRow.Cells[6].Value.ToString();
                    txtUpdateAppointmentSpecialization.Text = dgAllAppointments.CurrentRow.Cells[7].Value.ToString();
                }
                catch
                {
                    txtUpdateAppointmentPatientName.AlwaysActive = true;
                }
            }

        }

        private void cbUpdateAppointmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbUpdateAppointmentStatus.SelectedIndex == 2)
                btnAddMedicalRecord.Enabled = true;
            else
                btnAddMedicalRecord.Enabled = false;
        }
    }
}
