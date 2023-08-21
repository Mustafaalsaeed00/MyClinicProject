using clsDataAccessLayer;
using System;
using System.Data;


namespace ClinicBusinessLayer
{
   
    public class clsPatient
    {
        enum enMode { AddNew = 0 , Update = 1};
        enMode _Mode = enMode.Update;

        public int ID { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }


        public clsPatient()
        {
            ID = -1;
            Name = "";
            Gender = "";
            DateOfBirth = DateTime.Now;
            Email = "";
            Phone = "";
            Address = "";
            _Mode = enMode.AddNew;
        }

        clsPatient(int ID , string Name ,string Gender , DateTime DateOfBirth , string Email , string Phone , string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            _Mode = enMode.Update;
        }


        static public DataTable PatientList()
        {
            return clsPatientDataAccess.GetPatientsList();
        }

        static public clsPatient Find(int PatientID)
        {
            string Name = "", Email = "", Phone = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "";
            if (clsPatientDataAccess.FindPatient(PatientID, ref Name, ref Gender, ref DateOfBirth, ref Email, ref Phone, ref Address))
                return new clsPatient(PatientID, Name, Gender, DateOfBirth, Email, Phone, Address);
            else
                return null;

        }

        static public clsPatient Find(string PatientName)
        {
            string Email = "", Phone = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "";
            int PatientID = -1;
            if (clsPatientDataAccess.FindPatient(ref PatientID, PatientName, ref Gender, ref DateOfBirth, ref Email, ref Phone, ref Address))
                return new clsPatient(PatientID, PatientName, Gender, DateOfBirth, Email, Phone, Address);
            else
                return null;

        }

        static public DataTable FindByChar(string DoctorName)
        {
            return clsPatientDataAccess.FindPatientByChar(DoctorName);
        }

        static public DataTable FindByNum(string DoctorName)
        {
            return clsPatientDataAccess.FindPatientByNum(DoctorName);
        }

        static public bool IsExist(int PatientID)
        {
            return (clsPatientDataAccess.IsExist(PatientID));
        }

        static public bool IsExist(string PatientName)
        {
            return (clsPatientDataAccess.IsExist(PatientName));
        }

        static public bool Delete(int PatientID)
        {
            return (clsPatientDataAccess.DeletePatient(PatientID));
        }

        bool _UpdatePatient()
        {
            return clsPatientDataAccess.UpdatePatient(this.ID, this.Name, this.Gender, this.DateOfBirth, this.Email, this.Phone, this.Address);
        }

        bool _AddNewPatient()
        {
            this.ID = clsPatientDataAccess.AddNewPatient(this.Name, this.Gender, this.DateOfBirth, this.Email, this.Phone, this.Address);
            return (this.ID != -1);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    if (_UpdatePatient())
                        return true;
                    else
                        return false;

            }
            return false;
        }

    }
}
