using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace The_Clinic
{
    
    public partial class AllPaymentsfrm : KryptonForm
    {
        int _PatientID = -1;
        bool _PatientPayments = false;

        //this Constructor to Gets the Header's Color,Text,image from the MainInterface Form
        public AllPaymentsfrm(Color color, string text, Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
            _PatientPayments = false;
        }

        //this Constructor to Gets the Header's Color,Text,image from the AllPatients Form and PatientID To get the patient's payments
        public AllPaymentsfrm(Color color, string text, Image image , int PatientID )
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
            _PatientID = PatientID;
            _PatientPayments = true;
            cbFind.Visible = false;
            txtFind.Visible = false;
        }

        private void AllPayments_Load(object sender, EventArgs e)
        {
            _RefreshPaymentList();
            _FillcbFindPayment();
        }

        private void _RefreshPaymentList()
        {
            if (_PatientPayments)
                dgAllPayments.DataSource = clsPayment.PatientPaymentsList(_PatientID);
            else
                dgAllPayments.DataSource = clsPayment.PaymentsList();
        }

        private void _FillcbFindPayment()
        {
            if (cbFind.Items.Count.Equals(0))
            {
                cbFind.Items.Add("Payment ID");
                cbFind.Items.Add("Payment Date");
                cbFind.Items.Add("Payment Method");
            }
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            txtFind.StateActive.Content.Color1 = Color.Black;

            if (txtFind.Text == "Enter " + cbFind.Text || txtFind.Text == "YYYY-MM-DD")
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
            if (txtFind.Text == "Enter Payment ID" || txtFind.Text == "Enter Payment Date" || txtFind.Text == "Enter Payment Method")
                txtFind.Text = "";

            if (cbFind.Text == "Payment ID")
            {
                if (txtFind.Text != "")
                    dgAllPayments.DataSource = clsPayment.FindByNum(txtFind.Text);
                else
                    dgAllPayments.DataSource = clsPayment.PaymentsList();

            }
            else if (cbFind.Text == "Payment Date")
            {
                if (txtFind.Text != "")
                    dgAllPayments.DataSource = clsPayment.FindByDate(txtFind.Text);
                else
                    dgAllPayments.DataSource = clsPayment.PaymentsList();
            }
            else if (cbFind.Text == "Payment Method")
            {
                if (txtFind.Text != "")
                    dgAllPayments.DataSource = clsPayment.FindByMethod(txtFind.Text);
                else
                    dgAllPayments.DataSource = clsPayment.PaymentsList();
            }


        }

        private void cbFind_TextChanged(object sender, EventArgs e)
        {
            if (cbFind.Text == "Payment Date")
            {
                txtFind.Text = "YYYY-MM-DD";
            }
            else
            {
                txtFind.Text = "Enter " + cbFind.Text;
            }
            dgAllPayments.DataSource = clsPayment.PaymentsList();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgAllPayments.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (clsPayment.Delete((int)dgAllPayments.CurrentRow.Cells[0].Value))
                        _RefreshPaymentList();
                    else
                        MessageBox.Show("This Payment is linked to an existing Appointment ", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            else if (dgAllPayments.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dgAllPayments.SelectedRows.Count != dgAllPayments.RowCount)
                    {
                        foreach (DataGridViewRow Row in dgAllPayments.SelectedRows)
                        {
                            if (!clsPayment.Delete((int)Row.Cells[0].Value))
                            {
                                MessageBox.Show("Payments are linked to an existing Appointment Can't Deleted ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                        _RefreshPaymentList();
                    }
                    else
                        MessageBox.Show("No Payments Selected ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
