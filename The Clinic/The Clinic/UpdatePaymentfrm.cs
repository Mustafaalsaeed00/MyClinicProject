using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace The_Clinic
{
    public partial class UpdatePaymentfrm : KryptonForm
    {
        clsPayment _Payment;

        //this Constructor Gets Header's Color,text,image from MainInterface Form
        public UpdatePaymentfrm(Color color, string text, Image image)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            pnlHeader.BackColor = color;
            lblHeader.Text = text;
            pbHeader.Image = image;
        }

        private void UpdatePaymentfrm_Load(object sender, EventArgs e)
        {
            _FillMethodCB();
            _RefreshPaymentList();
            _FillcbFindPayment();
            _SetControlsForeColor(lblHeader.BackColor);

            _Payment = clsPayment.Find((int)dgAllPayments.CurrentRow.Cells[0].Value);
        }

        private void _SetControlsForeColor(Color color)
        {
            lblDate.ForeColor = color;
            cbMethod.StateActive.ComboBox.Content.Color1 = color;
            txtUpdatePaymentAmountPaid.StateActive.Content.Color1 = color;
            txtUpdatePaymentNotes.StateActive.Content.Color1 = color;
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

        private void _RefreshPaymentList()
        {
            dgAllPayments.DataSource = clsPayment.PaymentsList();
        }

        private void _FillMethodCB()
        {
            if (cbMethod.Items.Count.Equals(0))
            {
                cbMethod.Items.Add("Cash");
                cbMethod.Items.Add("Visa");
            }
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            txtFind.StateActive.Content.Color1 = Color.Black ;

            if (txtFind.Text == "Enter " + cbFind.Text || txtFind.Text == "YYYY-MM-DD")
            {
                txtFind.Text = "";
            }

        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            txtFind.StateActive.Content.Color1 = Color.Gray;

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

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

        private void _UpdatePayment()
        {
            _Payment.Date = DateTime.Now;
            _Payment.Method = cbMethod.Text;
            _Payment.AmountPaid = double.Parse(txtUpdatePaymentAmountPaid.Text);
            _Payment.Notes = txtUpdatePaymentNotes.Text;
        }

        private void _SetControlsEmpty()
        {
            lblDate.Text = "";
            cbMethod.Text = "Select Method";
            txtUpdatePaymentAmountPaid.Text = "";
            txtUpdatePaymentNotes.Text = "";
        }

        private void btnUpdatePaymenttbtn_Click(object sender, EventArgs e)
        {
            _Payment = clsPayment.Find(int.Parse(dgAllPayments.CurrentRow.Cells[0].Value.ToString()));
            if (_Payment != null)
            {
                _UpdatePayment();

                if (_Payment.Save())
                {
                    if (MessageBox.Show("Payment Updated Successfully", "Successful" , MessageBoxButtons.OK , MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        _SetControlsEmpty();
                        _RefreshPaymentList();
                    }
                }
                else
                {
                    MessageBox.Show("Payment Updated Failed");
                }
            }
        }

        private void dgAllPayments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAllPayments.CurrentRow != null)
            {
                lblDate.Text = dgAllPayments.CurrentRow.Cells[1].Value.ToString();
                cbMethod.Text = dgAllPayments.CurrentRow.Cells[2].Value.ToString();
                txtUpdatePaymentAmountPaid.Text = dgAllPayments.CurrentRow.Cells[3].Value.ToString();
                txtUpdatePaymentNotes.Text = dgAllPayments.CurrentRow.Cells[4].Value.ToString();
                
            }
        }

    }
}
