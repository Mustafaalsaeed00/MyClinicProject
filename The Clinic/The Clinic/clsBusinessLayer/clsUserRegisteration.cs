using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsUserRegisteration
    {
        enum enMode { AddNew = 0}
        enMode _Mode = enMode.AddNew;

        int ID { set; get; }
        public int UserID { set; get; }
        public DateTime dateTime { set; get; }
        public string Description { set; get; }


        public clsUserRegisteration()
        {
            ID = -1;
            UserID = -1;
            dateTime = DateTime.Now;
            Description = "";
            _Mode = enMode.AddNew;
        }

        static public DataTable FindRegisterbyChar(string UserName)
        {
            return clsUserRegisterationDataAccess.FindRegisterByChar(UserName);
        }

        static public DataTable FindRegisterbyNum(string UserID)
        {
            return clsUserRegisterationDataAccess.FindRegisterByNum(UserID);
        }

        static public DataTable GetRegisterList()
        {
            return clsUserRegisterationDataAccess.GetUserRegisterationList();
        }

        bool _AddNewRegister()
        {
            this.ID = clsUserRegisterationDataAccess.AddNewRegister(this.UserID, this.dateTime, this.Description);
            return (this.ID != -1);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRegister())
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