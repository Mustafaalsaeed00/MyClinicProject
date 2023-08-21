using System;
using System.Data;
using System.Data.SqlClient;


namespace clsDataAccessLayer
{
    public class clsPatientDataAccess
    {
        static public bool FindPatient(int ID , ref string Name , ref string Gender , ref DateTime DateOfBirth,
            ref string Email , ref string Phone , ref  string Address)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from PatientDetails where PatientID = @PatientID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if(reader.Read())
                {
                    Name = (string)reader["Name"];
                    Gender = (string)reader["Gender"];
                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                    else
                        DateOfBirth = DateTime.Now;
                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";
                    if (reader["Phone"] != DBNull.Value)
                        Phone = (string)reader["Phone"];
                    else
                        Phone = "";
                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = "";
                    IsFound = true;

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

            return IsFound;

        }

        static public bool FindPatient(ref int ID, string Name, ref string Gender, ref DateTime DateOfBirth,
            ref string Email, ref string Phone, ref string Address)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from PatientDetails where Name = @PatientName";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientName", Name);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["PatientID"];
                    Gender = (string)reader["Gender"];
                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                    else
                        DateOfBirth = DateTime.Now;
                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";
                    if (reader["Phone"] != DBNull.Value)
                        Phone = (string)reader["Phone"];
                    else
                        Phone = "";
                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = "";
                    IsFound = true;

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

            return IsFound;

        }

        static public DataTable FindPatientByNum(string PatientID)
        {
            DataTable dtAppointments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select PatientID , Name , DateOfBirth , Gender , Email ,Phone ,Address from PatientDetails where PatientID like '' + @PatientID + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtAppointments.Load(reader);

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
            return dtAppointments;
        }

        static public DataTable FindPatientByChar(string PatientName)
        {
            DataTable dtAppointments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select PatientID , Name , DateOfBirth , Gender , Email ,Phone ,Address from PatientDetails where Name like '' + @PatientName + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientName", PatientName);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtAppointments.Load(reader);

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
            return dtAppointments;
        }

        static public DataTable GetPatientsList()
        {
            DataTable PatientsList = new DataTable();

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select PatientID , Name , DateOfBirth , Gender , Email ,Phone ,Address from PatientDetails";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    PatientsList.Load(reader);

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
            return PatientsList;

        }

        static public bool IsExist(int ID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select A=1 from PatientDetails where PatientID = @PatientID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientID", ID);


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

        static public bool IsExist(string PatientName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select A=1 from PatientDetails where Name = @PatientName";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientName", PatientName);


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

        static public int AddNewPatient(string Name , string Gender , DateTime DateOfBirth , string Email , string Phone , string Address)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"insert Into Persons
                                Values(@Name , @DateOfBirth , @Gender ,@Email , @Phone ,@Address);
                                select Scope_Identity();";
                

            SqlCommand Command = new SqlCommand(query, Connection);



            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            if (Email != "")
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            if (Phone != "")
                Command.Parameters.AddWithValue("@Phone", Phone);
            else
                Command.Parameters.AddWithValue("@Phone", DBNull.Value);
            if (Address != "")
                Command.Parameters.AddWithValue("@Address", Address);
            else
                Command.Parameters.AddWithValue("@Address", DBNull.Value);


            try
            {
                Connection.Open();
                object resulte = Command.ExecuteScalar();

                if(resulte != null && int.TryParse(resulte.ToString(),out int PersonInsertedID))
                {
                    query = @"insert into Patients values (@PersonID);
                                select Scope_Identity()";
                    Command = new SqlCommand(query, Connection);
                    Command.Parameters.AddWithValue("@PersonID", PersonInsertedID);
                    resulte = Command.ExecuteScalar();
                    if (resulte != null && int.TryParse(resulte.ToString(), out int InsertedID))
                    {
                        ID = InsertedID;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return ID;
        }

        static public bool UpdatePatient(int ID , string Name , string Gender , DateTime DateOfBirth , string Email , string Phone , string Address)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"Update PatientDetails set Name = @Name ,  DateOfBirth = @DateOfBirth ,Gender = @Gender ,
                            Email = @Email , Phone = @Phone , Address = @Address
                                where PatientID = @PatientID";


            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("@PatientID", ID);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            if (Email != "")
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            if (Phone != "")
                Command.Parameters.AddWithValue("@Phone", Phone);
            else
                Command.Parameters.AddWithValue("@Phone", DBNull.Value);
            if (Address != "")
                Command.Parameters.AddWithValue("@Address", Address);
            else
                Command.Parameters.AddWithValue("@Address", DBNull.Value);


            try
            {
                Connection.Open();
                int AffectedRows = Command.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    IsUpdated = true;
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
            return IsUpdated;
            
        }

        static public bool DeletePatient(int ID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"select PersonID from PatientDetails where PatientID = @PatientID;
                             delete from Patients where PatientID = @PatientID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientID", ID);

            clsAppointmentDataAccess.DeleteAppointmentByPatientID(ID);

            try
            {
                Connection.Open();

                object resulte = Command.ExecuteScalar();

                if (resulte != null && int.TryParse(resulte.ToString() , out int DeletedPersonID))
                {
                    query = "delete from Persons where PersonID = @PersonID";
                    Command = new SqlCommand(query, Connection);
                    Command.Parameters.AddWithValue("@PersonID", DeletedPersonID);

                }

                int AffectedRows = Command.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    IsDeleted = true;
                }



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
    }
      
}
