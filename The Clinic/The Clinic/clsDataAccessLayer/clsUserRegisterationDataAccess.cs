using System;
using System.Data.SqlClient;
using System.Data;

namespace clsDataAccessLayer
{
    public class clsUserRegisterationDataAccess
    {
        public static DataTable FindRegisterByChar(string UserName)
        {
            DataTable DTRegisteration = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from UserRegisterationDetails where UserName like '' + @UserName + '%' ";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("UserName", UserName);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.HasRows)
                {
                    DTRegisteration.Load(reader);
                }
                reader.Close();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return DTRegisteration;

        }

        public static DataTable FindRegisterByNum(string UserID)
        {
            DataTable DTRegisteration = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from UserRegisterationDetails where UserID like '' + @UserID + '%' ";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.HasRows)
                {
                    DTRegisteration.Load(reader);
                }
                reader.Close();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return DTRegisteration;

        }

        public static DataTable GetUserRegisterationList()
        {
            DataTable DTRegisteration = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from UserRegisterationDetails";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    DTRegisteration.Load(reader);
                }

                //reader.Close();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return DTRegisteration;

        }

        public static int AddNewRegister(int UserID, DateTime dateTime, string Description)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"insert into UserRegisteration values (@UserID ,@DateTime,@Description)
                                Select Scope_Identity()";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@DateTime", dateTime);
            Command.Parameters.AddWithValue("@Description", Description);


            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return ID;

        }
    }
}
