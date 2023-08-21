using System;
using System.Data.SqlClient;
using System.Data;


namespace clsDataAccessLayer
{
    public class clsDoctorDataAccess
    {
        static public bool FindDoctor(int ID, ref string Name, ref string Specialization, ref string Gender, ref DateTime DateOfBirth,
            ref string Email, ref string Phone, ref string Address)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from DoctorDetails where DoctorID = @DoctorID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DoctorID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["Name"];
                    Gender = (string)reader["Gender"];
                    if (reader["Specialization"] != DBNull.Value)
                        Specialization = (string)reader["Specialization"];
                    else
                        Specialization = "";
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

        static public bool FindDoctor(ref int ID, string Name, ref string Specialization, ref string Gender, ref DateTime DateOfBirth,
            ref string Email, ref string Phone, ref string Address)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from DoctorDetails where Name = @Name";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["DoctorID"];
                    Gender = (string)reader["Gender"];
                    if (reader["Specialization"] != DBNull.Value)
                        Specialization = (string)reader["Specialization"];
                    else
                        Specialization = "";
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

        static public DataTable FindDoctorNameByChar(string DoctorName)
        {
            DataTable dtDoctorNames = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select DoctorID , Name , Specialization , DateOfBirth , Gender , Email , Phone , Address from DoctorDetails where Name like '' + @DoctorName + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DoctorName", DoctorName);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtDoctorNames.Load(reader);

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
            return dtDoctorNames;
        }

        static public DataTable FindDoctorNameByNum(string DoctorID)
        {
            DataTable dtDoctors = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select DoctorID , Name , Specialization , DateOfBirth , Gender , Email , Phone , Address from DoctorDetails where DoctorID like '' + @DoctorID + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DoctorID", DoctorID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtDoctors.Load(reader);

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
            return dtDoctors;
        }

        static public DataTable GetDoctorsList()
        {
            DataTable DoctorsList = new DataTable();

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select DoctorID , Name , Specialization , DateOfBirth , Gender , Email , Phone , Address from DoctorDetails";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    DoctorsList.Load(reader);

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
            return DoctorsList;

        }

        static public int AddNewDoctor(string Name, string Specialization, string Gender, DateTime DateOfBirth, string Email, string Phone, string Address)
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

                if (resulte != null && int.TryParse(resulte.ToString(), out int PersonInsertedID))
                {
                    query = @"insert into Doctors values (@PersonID , @Specialization);
                                select Scope_Identity()";
                    Command = new SqlCommand(query, Connection);
                    Command.Parameters.AddWithValue("@PersonID", PersonInsertedID);
                    if (Specialization != "")
                        Command.Parameters.AddWithValue("@Specialization", Specialization);
                    else
                        Command.Parameters.AddWithValue("@Specialization", DBNull.Value);
                    resulte = Command.ExecuteScalar();
                    if (resulte != null && int.TryParse(resulte.ToString(), out int InsertedID))
                    {
                        ID = InsertedID;
                    }
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

        static public bool UpdateDoctor(int ID, string Name, string Specialization, string Gender, DateTime DateOfBirth, string Email, string Phone, string Address)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"select PersonID from DoctorDetails where DoctorID = @DoctorID
                             Update Doctors set Specialization = @Specialization  where DoctorID = @DoctorID";


            SqlCommand Command = new SqlCommand(query, Connection);



            Command.Parameters.AddWithValue("@DoctorID", ID);
            if (Specialization != "")
                Command.Parameters.AddWithValue("@Specialization", Specialization);
            else
                Command.Parameters.AddWithValue("@Specialization", DBNull.Value);


            try
            {
                Connection.Open();

                object resulte = Command.ExecuteScalar();

                if(resulte != null && int.TryParse(resulte.ToString() , out int UpdatedPersonID))
                {
                    query = @"Update Persons set Name = @Name ,  DateOfBirth = @DateOfBirth ,Gender = @Gender ,
                             Email = @Email , Phone = @Phone , Address = @Address
                                where PersonID = @PersonID;";

                    Command = new SqlCommand(query, Connection);

                    Command.Parameters.AddWithValue("@PersonID", UpdatedPersonID);
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

                    int AffectedRows = Command.ExecuteNonQuery();

                    if (AffectedRows > 0)
                    {
                        IsUpdated = true;
                    }
                }
                else
                {
                    return false;
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

        static public bool DeleteDoctor(int ID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"select PersonID from DoctorDetails where DoctorID = @DoctorID;
                             delete from Doctors where DoctorID = @DoctorID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DoctorID", ID);

            clsAppointmentDataAccess.DeleteAppointmentByDoctorID(ID);

            try
            {
                Connection.Open();

                object resulte = Command.ExecuteScalar();

                if (resulte != null && int.TryParse(resulte.ToString(), out int DeletedPersonID))
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
