using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsAppointment
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        public int ID { set; get; }
        public int PatientID { set; get; }
        public string PatientName { set; get; }
        public int DoctorID { set; get; }
        public string DoctorName { set; get; }
        public DateTime Date_Time { set; get; }
        public string Status { set; get; }
        public int MedicalRecordID { set; get; }
        public int PaymentID { set; get; }
        public string Specialization { set; get; }

        public clsAppointment()
        {
            ID = -1;
            PatientID = -1;
            PatientName = "";
            DoctorID = -1;
            DoctorName = "";
            Specialization = "";
            Date_Time = DateTime.Now;
            Status = "";
            MedicalRecordID = -1;
            PaymentID = -1;
            _Mode = enMode.AddNew;
        }

        clsAppointment(int ID, int PatientID , string PatientName,int DoctorID , string DoctorName,
            string Specialization, DateTime Date_Time, string Status,int MedicalRecordID, int PaymentID)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            this.PatientName = PatientName;
            this.DoctorID = DoctorID;
            this.DoctorName = DoctorName;
            this.Specialization = Specialization;
            this.Date_Time = Date_Time;
            this.Status = Status;
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;
            _Mode = enMode.Update;
        }

        public static clsAppointment FindAppointment(int ID)
        {
            int PatientID = -1 , DoctorID = -1 , MedicalRecordID = -1, PaymentID = -1;
            string Status = "" , PatientName = "" , DoctorName = "" , Specialization = "";
            DateTime Date_Time = DateTime.Now;
            if (clsAppointmentDataAccess.FindAppointment(ID,ref PatientID , ref PatientName,ref DoctorID, ref DoctorName, ref Specialization,  ref Date_Time, ref Status, ref MedicalRecordID, ref PaymentID))
                return new clsAppointment(ID, PatientID,PatientName,DoctorID, DoctorName, Specialization, Date_Time, Status, MedicalRecordID, PaymentID);
            else
                return null;
        }

        public static clsAppointment FindAppointment(string PatientName)
        {
            int PatientID = -1, DoctorID = -1, MedicalRecordID = -1, PaymentID = -1, AppointmentID = -1;
            string Status = "", DoctorName = "", Specialization = "";
            DateTime Date_Time = DateTime.Now;
            if (clsAppointmentDataAccess.FindAppointment(ref AppointmentID, ref PatientID, PatientName, ref DoctorID, ref DoctorName, ref Specialization, ref Date_Time, ref Status, ref MedicalRecordID, ref PaymentID))
                return new clsAppointment(AppointmentID, PatientID, PatientName, DoctorID, DoctorName, Specialization, Date_Time, Status, MedicalRecordID, PaymentID);
            else
                return null;
        }

        public static DataTable FindAppointmentByNum(string AppointmentID)
        {
            return clsAppointmentDataAccess.FindAppointmentByNum(AppointmentID);
        }

        public static DataTable FindAppointmentByPatientChar(string PatientName)
        {
            return clsAppointmentDataAccess.FindAppointmentByPatientChar(PatientName);
        }

        public static DataTable FindAppointmentByDoctorChar(string DoctorName)
        {
            return clsAppointmentDataAccess.FindAppointmentByDoctorChar(DoctorName);
        }

        public static DataTable FindAppointmentByStatus(string Status)
        {
            return clsAppointmentDataAccess.FindAppointmentByStatus(Status);
        }

        public static DataTable AppointmentsList()
        {
            return clsAppointmentDataAccess.GetAppointmentsList();
        }

        bool _MakeNewAppointment()
        {
            this.ID = (clsAppointmentDataAccess.MakeNewAppointment(this.PatientID, this.DoctorID, this.Date_Time, this.Status, this.MedicalRecordID, this.PaymentID));
            return (this.ID != -1);
        }

        static public bool Delete(int ID)
        {
            return (clsAppointmentDataAccess.DeleteAppointment(ID));
        }

        bool _UpdateAppointment()
        {
            return clsAppointmentDataAccess.UpdateAppointment(ID, PatientID, DoctorID, Date_Time,  Status,  MedicalRecordID,  PaymentID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_MakeNewAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                   
                case enMode.Update:
                    if (_UpdateAppointment())
                    {
                        return true;
                    }
                    else
                        return false;


            }
            return false;


        }

    }
}
