using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsPayment
    {

        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        public int ID { set; get; }
        public DateTime Date { set; get; }
        public string Method { set; get; }
        public double AmountPaid { set; get; }
        public string Notes { set; get; }


        public clsPayment()
        {
            ID = -1;
            Date = DateTime.Now;
            AmountPaid = -1;
            Method = "";
            Notes = "";
            _Mode = enMode.AddNew;
        }

        clsPayment(int ID, DateTime Date, string Method, double AmountPaid , string Notes)
        {
            this.ID = ID;
            this.Date = Date;
            this.AmountPaid = AmountPaid;
            this.Method = Method;
            this.Notes = Notes;
            _Mode = enMode.Update;
        }

        public static clsPayment Find(int PaymentID)
        {
            DateTime Date = DateTime.Now;
            decimal AmountPaid = -1;
            string Method = "", Notes = "";
            
            if (clsPaymentDataAccess.Find(PaymentID, ref Date, ref Method, ref AmountPaid, ref Notes))
                return new clsPayment(PaymentID, Date, Method, Convert.ToInt32(AmountPaid), Notes);
            else
                return null;
        }

        public static DataTable FindByNum(string PaymentID)
        {
            return clsPaymentDataAccess.FindPaymentByNum(PaymentID);
        }

        public static DataTable PatientPaymentsList(int PatientID)
        {
            return clsPaymentDataAccess.GetPatientPayments(PatientID);
        }

        public static DataTable FindByDate(string dateTime)
        {
            return clsPaymentDataAccess.FindPaymentByDate(dateTime);
        }

        public static DataTable FindByMethod(string Method)
        {
            return clsPaymentDataAccess.FindPaymentByMethod(Method);
        }

        public static DataTable PaymentsList()
        {
            return clsPaymentDataAccess.GetPaymentsList();
        }

        public static bool IsExist(int PaymentID)
        {
            return clsPaymentDataAccess.IsPaymentExist(PaymentID);
        }

        bool _AddNewPayment()
        {
            this.ID = clsPaymentDataAccess.AddNewPayment(this.Date, this.Method,Convert.ToInt32(this.AmountPaid) , this.Notes);
            return (this.ID != -1);
        }

        static public bool Delete(int PaymentID)
        {
            return (clsPaymentDataAccess.DeletePayment(PaymentID));
        }

        bool _UpdatePayment()
        {
            return clsPaymentDataAccess.UpdatePayment(this.ID, this.Date, this.Method, Convert.ToInt32(this.AmountPaid), this.Notes);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdatePayment())
                        return true;
                    else
                        return false;

            }
            return false;
        }
    }
}
