using ClinicBusinessLayer;
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
    public class clsUser
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        public int ID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int Permissions { set; get; }


        public clsUser()
        {
            ID = -1;
            UserName = "";
            Password = "";
            
            _Mode = enMode.AddNew;
        }

        clsUser(int UserID, string UserName, string Password, int Permissions)
        {
            this.ID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;
            _Mode = enMode.Update;
        }

        public static clsUser Find(string UserName)
        {
            string  Password = "";
            int Permissions = -1 , UserID = -1;

            if (clsUserDataAccess.Find(ref UserID, UserName, ref Password, ref Permissions))
                return new clsUser(UserID, UserName, Password, Permissions);
            else
                return null;
        }

        public static clsUser Find(int UserID)
        {
            string UserName = "", Password = "";
            int Permissions = -1;

            if (clsUserDataAccess.Find(UserID, ref UserName, ref Password, ref Permissions))
                return new clsUser(UserID, UserName, clsEncryption.Decrypt(Password), Permissions);
            else
                return null;
        }

        public static DataTable FindUserByChar(string UserName)
        {
            return clsUserDataAccess.FindUserByChar(UserName);
        }

        public static DataTable FindUserByNum(string UserID)
        {
            return clsUserDataAccess.FindUserByNum(UserID);
        }

        public static DataTable UsersList()
        {
            return clsUserDataAccess.GetUsersList();
        }

        public static bool IsExist(int UserID)
        {
            return clsUserDataAccess.IsUserExist(UserID);
        }

        public static bool IsExist(string UserName)
        {
            return clsUserDataAccess.IsUserExist(UserName);
        }

        bool _AddNewUser()
        {
            this.ID = clsUserDataAccess.AddNewUser(this.UserName, this.Password, this.Permissions);
            return (this.ID != -1);
        }

        static public bool Delete(int UserID)
        {
            return (clsUserDataAccess.DeleteUser(UserID));
        }

        bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.ID, this.UserName, this.Password, this.Permissions);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateUser())
                        return true;
                    else
                        return false;

            }
            return false;
        }

    }
}
