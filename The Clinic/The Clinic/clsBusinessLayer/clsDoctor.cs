using clsDataAccessLayer;
using System;
using System.Data;


namespace ClinicBusinessLayer
{
    public class clsDoctor
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.Update;

        public int ID { set; get; }
        public string Name { set; get; }
        public string Specialization { set; get; }
        public string Gender { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }


        public clsDoctor()
        {
            ID = -1;
            Name = "";
            Specialization = "";
            Gender = "";
            DateOfBirth = DateTime.Now;
            Email = "";
            Phone = "";
            Address = "";
            _Mode = enMode.AddNew;
        }

        clsDoctor(int ID, string Name, string Specialization, string Gender, DateTime DateOfBirth, string Email, string Phone, string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Specialization = Specialization;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            _Mode = enMode.Update;
        }


        static public DataTable DoctorList()
        {
            return clsDoctorDataAccess.GetDoctorsList();
        }

        static public clsDoctor Find(int DoctorID)
        {
            string Name = "", Email = "", Phone = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "" , Specialization = "";
            if (clsDoctorDataAccess.FindDoctor(DoctorID, ref Name,ref Specialization, ref Gender, ref DateOfBirth, ref Email, ref Phone, ref Address))
                return new clsDoctor(DoctorID, Name,Specialization ,Gender, DateOfBirth, Email, Phone, Address);
            else
                return null;

        }

        static public clsDoctor Find(string Name)
        {
            string Email = "", Phone = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "", Specialization = "";
            int DoctorID = -1;
            if (clsDoctorDataAccess.FindDoctor(ref DoctorID, Name, ref Specialization, ref Gender, ref DateOfBirth, ref Email, ref Phone, ref Address))
                return new clsDoctor(DoctorID, Name, Specialization, Gender, DateOfBirth, Email, Phone, Address);
            else
                return null;

        }

        static public DataTable FindByChar(string DoctorName)
        {
            return clsDoctorDataAccess.FindDoctorNameByChar(DoctorName);
        }

        static public DataTable FindByNum(string DoctorName)
        {
            return clsDoctorDataAccess.FindDoctorNameByNum(DoctorName);
        }

        static public bool Delete(int DoctorID)
        {
            return (clsDoctorDataAccess.DeleteDoctor(DoctorID));
        }

        bool _UpdateDoctor()
        {
            return clsDoctorDataAccess.UpdateDoctor(this.ID, this.Name,this.Specialization, this.Gender, this.DateOfBirth, this.Email, this.Phone, this.Address);
        }

        bool _AddNewDoctor()
        {
            this.ID = clsDoctorDataAccess.AddNewDoctor(this.Name,this.Specialization ,this.Gender, this.DateOfBirth, this.Email, this.Phone, this.Address);
            return (this.ID != -1);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    if (_UpdateDoctor())
                        return true;
                    else
                        return false;

            }
            return false;
        }
    }
}
