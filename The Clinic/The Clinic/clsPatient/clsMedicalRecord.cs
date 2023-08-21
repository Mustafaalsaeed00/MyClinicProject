using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsMedicalRecord
    {
        enum enMode { AddNew=0 , Update=1}
        enMode _Mode = enMode.Update;

        public int ID { set; get; }
        public string Description { set; get; }
        public string Diagnosis { set; get; }
        public string Notes { set; get; }


        public clsMedicalRecord()
        {
            ID = -1;
            Description = "";
            Diagnosis = "";
            Notes = "";
            _Mode = enMode.AddNew;
        }

        clsMedicalRecord(int ID , string Description , string Diagnosis , string Notes)
        {
            this.ID = ID;
            this.Description = Description;
            this.Diagnosis = Diagnosis;
            this.Notes = Notes;
            _Mode = enMode.Update;
        }

        public static clsMedicalRecord Find(int MedicalRecordID)
        {
            string Description = "", Diagnosis = "", Notes = "";
            clsMedicalRecordDataAccess.Find(MedicalRecordID, ref Description, ref Diagnosis, ref Notes);
            if (clsMedicalRecordDataAccess.Find(MedicalRecordID, ref Description, ref Diagnosis, ref Notes))
                return new clsMedicalRecord(MedicalRecordID, Description, Diagnosis, Notes);
            else
                return null;
        }

        public static DataTable FindMedicalRecordsListForPatient(int PatientID)
        {
            return clsMedicalRecordDataAccess.GetMedicalRecordsListForPatient(PatientID);
        }

        public static DataTable MedicalRecordList()
        {
            return clsMedicalRecordDataAccess.GetMedicalRecordsList();
        }

        public static bool IsExist(int MedicalRecordID)
        {
            return clsMedicalRecordDataAccess.IsMedicalRecordExist(MedicalRecordID);
        }

        bool _AddNewMedicalRecord()
        {
            this.ID = clsMedicalRecordDataAccess.AddNewMedicalRecord( this.Description , this.Diagnosis , this.Notes);
            return (this.ID != -1);
        }

        static public bool Delete(int MedicalRecordID)
        {
            return (clsMedicalRecordDataAccess.DeleteMedicalRecord(MedicalRecordID));
        }

        bool _UpdateMedicalRecord()
        {
            return clsMedicalRecordDataAccess.UpdateMedicalRecord(this.ID, this.Description, this.Diagnosis, this.Notes);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMedicalRecord())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateMedicalRecord())
                        return true;
                    else
                        return false;
                    
            }
            return false;
        }

    }
}
