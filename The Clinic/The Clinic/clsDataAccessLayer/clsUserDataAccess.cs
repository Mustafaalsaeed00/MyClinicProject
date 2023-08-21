using System;
using System.Data.SqlClient;
using System.Data;


namespace clsDataAccessLayer
{
    public class clsUserDataAccess
    {

        public static bool Find(int UserID, ref string UserName, ref string Password, ref int Permissions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Users where UserID =  @UserID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;

        }

        public static bool Find(ref int UserID, string UserName, ref string Password, ref int Permissions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Users where UserName =  @UserName";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;

        }

        public static DataTable FindUserByChar(string UserName)
        {
            DataTable DTUsers = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Users where UserName like '' + @UserName + '%' ";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("UserName", UserName);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.HasRows)
                {
                    DTUsers.Load(reader);
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
            return DTUsers;

        }

        public static DataTable FindUserByNum(string UserID)
        {
            DataTable DTUsers = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Users where UserID like '' + @UserID + '%' ";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.HasRows)
                {
                    DTUsers.Load(reader);
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
            return DTUsers;

        }

        public static DataTable GetUsersList()
        {
            DataTable DTUsers = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Users";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    DTUsers.Load(reader);
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
            return DTUsers;

        }

        public static bool IsUserExist(int UserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select A=1 from Users where UserID =  @UserID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                object resulte = Command.ExecuteScalar();
                if (resulte != null)
                    IsFound = true;
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select A=1 from Users where UserName =  @UserName";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                object resulte = Command.ExecuteScalar();
                if (resulte != null)
                    IsFound = true;
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewUser(string UserName, string Password, int Permissions)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"insert into Users values (@UserName ,@Password , @Permissions)
                                Select Scope_Identity()";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);


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

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "Delete Users where UserID = @UserID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                int rowsAffected = Command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    IsDeleted = true;
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return IsDeleted;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, int Permissions)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"Update Users set UserName = @UserName , Password = @Password ,Permissions =@Permissions
                                    where UserID = @UserID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                Connection.Open();
                int rowsAffected = Command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    IsUpdated = true;
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return IsUpdated;
        }
    }
}
