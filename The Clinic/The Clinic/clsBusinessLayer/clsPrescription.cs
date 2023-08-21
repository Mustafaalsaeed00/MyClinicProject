using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsPrescription
    {

        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        int ID { set; get; }
        public int MedicalRecordID { set; get; }
        public string MedicationName { set; get; }
        public string Dosage { set; get; }
        public short Frequency { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string SpecialInstructions { set; get; }

        public clsPrescription()
        {
            ID = -1;
            MedicalRecordID = -1;
            MedicationName = "";
            Dosage = "";
            Frequency = -1;
            StartDate = DateTime.Now;
            EndDate = DateTime.MaxValue;
            SpecialInstructions = "";
            _Mode = enMode.AddNew;
        }

        clsPrescription(int MedicalRecordID, string MedicationName, string Dosage, short Frequency
            , DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            this.MedicalRecordID = MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
            _Mode = enMode.Update;
        }

        public static clsPrescription Find(int PrescriptionID)
        {
            int MedicalRecordID = -1;
            string MedicationName = "", Dosage = "", SpecialInstructions = "";
            short Frequency = -1;
            DateTime StartDate = DateTime.Now, EndDate = DateTime.MaxValue;

            if (clsPrescriptionDataAccess.Find(PrescriptionID, ref MedicalRecordID, ref MedicationName, ref Dosage, ref Frequency
            , ref StartDate, ref EndDate, ref SpecialInstructions))
                return new clsPrescription(MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
            else
                return null;
        }

        public static DataTable PatientPrescriptionsList(int PatientID)
        {
            return clsPrescriptionDataAccess.GetPatientPrescriptions(PatientID);
        }

        public static DataTable PrescriptionsList()
        {
            return clsPrescriptionDataAccess.GetPrescriptionsList();
        }

        public static bool IsExist(int PrescriptionID)
        {
            return clsPrescriptionDataAccess.IsPrescriptionExist(PrescriptionID);
        }

        bool _AddNewPrescription()
        {
            this.ID = clsPrescriptionDataAccess.AddNewPrescription(this.MedicalRecordID, this.MedicationName, this.Dosage, this.Frequency , 
                this.StartDate , this.EndDate , this.SpecialInstructions);
            return (this.ID != -1);
        }

        static public bool Delete(int PrescriptionID)
        {
            return (clsPrescriptionDataAccess.DeletePrescription(PrescriptionID));
        }

        bool _UpdatePrescription()
        {
            return clsPrescriptionDataAccess.UpdatePrescription(this.ID, this.MedicalRecordID, this.MedicationName, this.Dosage, this.Frequency,
                this.StartDate, this.EndDate, this.SpecialInstructions);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPrescription())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdatePrescription())
                        return true;
                    else
                        return false;

            }
            return false;
        }
    }
}
