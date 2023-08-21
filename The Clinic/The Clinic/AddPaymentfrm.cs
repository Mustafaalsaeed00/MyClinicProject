using System;
using System.Drawing;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ComponentFactory.Krypton.Toolkit;


namespace The_Clinic
{
    public partial class AddPaymentfrm : KryptonForm
    {
        int ID;
        bool PaymentSaved = false;
        public AddPaymentfrm()
        {
            InitializeComponent();
        }

        //this Constructor to Gets the Header's Color of the ِAddNewAppointment Form
        public AddPaymentfrm(Color color)
        {
            InitializeComponent();
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
            lblHeader.Text = "Add Payment";
            pbHeader.Image = Properties.Resources.Find_Payment__1_;

        }

        private void AddPaymentfrm_Load(object sender, EventArgs e)
        {
            _FillMethodCB();
            _SetControlsForeColor(lblHeader.BackColor);
        }

        private void _SetControlsForeColor(Color color)
        {
            txtAddPaymentAmountPaid.StateActive.Content.Color1 = color;
            txtAddPaymentNotes.StateActive.Content.Color1 = color;
            cbMethod.StateActive.ComboBox.Content.Color1 = color;
        }

        //this Function Created to Called from AddNewAppointment/UpdateAppointment Form To Show the PaymentID if it saved Successfully
        public int GetPaymentID()
        {
            if (PaymentSaved)
                return ID;
            else
                return -1;
        }

        private void _FillMethodCB()
        {
            if (cbMethod.Items.Count.Equals(0))
            {
                cbMethod.Items.Add("Cash");
                cbMethod.Items.Add("Visa");
            }
        }

        private bool _AddPayment()
        {
            clsPayment Payment = new clsPayment();

            Payment.Date = DateTime.Now;
            Payment.Method = cbMethod.Text;
            double.TryParse(txtAddPaymentAmountPaid.Text , out double Amount);
            Payment.AmountPaid = Amount;
            Payment.Notes = txtAddPaymentNotes.Text;

            if(Payment.Save())
            {
                lblDate.Text = Payment.Date.ToString();
                lblPaymentID.Text = Payment.ID.ToString();
                ID = int.Parse(lblPaymentID.Text);
                PaymentSaved = true;
                return true;
            }
            return false;
        }

        private void btnAddMedicalRecord_Click(object sender, EventArgs e)
        {
            if (_AddPayment())
            {
                if (MessageBox.Show("Payment Added Susseccfully") == DialogResult.OK)
                    this.Close();
            }
            else
                MessageBox.Show("Payment Added Failed");
        }
    }
}
