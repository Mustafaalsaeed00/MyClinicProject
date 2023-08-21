using System;
using System.Data;
using System.Data.SqlClient;


namespace clsDataAccessLayer
{
    public class clsAppointmentDataAccess
    {
        static public bool FindAppointment(int AppointmentID ,ref int PatientID, ref string PatientName ,ref int DoctorID,
            ref string DoctorName ,ref string Specialization , ref DateTime Date_Time , ref string Status ,ref int MedicalRecordID ,  ref int PaymentID )
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from AppointmentDetails where AppointmentID = @AppointmentID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if(reader.Read())
                {
                    PatientID = (int)reader["PatientID"];
                    PatientName = (string)reader["PatientName"];
                    DoctorID = (int)reader["DoctorID"];
                    DoctorName = (string)reader["DoctorName"];
                    Specialization = (string)reader["Specialization"];
                    Date_Time = (DateTime)reader["DateTime"];
                    Status = (string)reader["Status"];
                    if(reader["MedicalRecordID"] != DBNull.Value)
                        MedicalRecordID = (int)reader["MedicalRecordID"];
                    else
                        MedicalRecordID = -1;
                    if (reader["PaymentID"] != DBNull.Value)
                        PaymentID = (int)reader["PaymentID"];
                    else
                        PaymentID = -1;
                    IsFound = true;

                }

                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        static public bool FindAppointment(ref int AppointmentID, ref int PatientID, string PatientName, ref int DoctorID,
            ref string DoctorName, ref string Specialization, ref DateTime Date_Time, ref string Status,ref int MedicalRecordID, ref int PaymentID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from AppointmentDetails where PatientName = @PatientName";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientName", PatientName);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    AppointmentID = (int)reader["AppointmentID"];
                    PatientName = (string)reader["PatientName"];
                    DoctorID = (int)reader["DoctorID"];
                    DoctorName = (string)reader["DoctorName"];
                    Specialization = (string)reader["Specialization"];
                    Date_Time = (DateTime)reader["DateTime"];
                    Status = (string)reader["Status"];
                    if (reader["MedicalRecordID"] != DBNull.Value)
                        MedicalRecordID = (int)reader["MedicalRecordID"];
                    else
                        MedicalRecordID = -1;
                    if (reader["PaymentID"] != DBNull.Value)
                        PaymentID = (int)reader["PaymentID"];
                    else
                        PatientID = -1;
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

        static public DataTable FindAppointmentByPatientChar(string PatientName)
        {
            DataTable dtPatients = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from AppointmentDetailsWithoutID where PatientName like '' + @PatientName + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientName", PatientName);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPatients.Load(reader);

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
            return dtPatients;
        }

        static public DataTable FindAppointmentByNum(string AppointmentID)
        {
            DataTable dtAppointments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from AppointmentDetailsWithoutID where AppointmentID like '' + @AppointmentID + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        static public DataTable FindAppointmentByDoctorChar(string DoctorName)
        {
            DataTable dtPatients = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from AppointmentDetailsWithoutID where DoctorName like '' + @DoctorName + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DoctorName", DoctorName);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPatients.Load(reader);

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
            return dtPatients;
        }

        static public DataTable FindAppointmentByStatus(string Status)
        {
            DataTable dtStatus = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from AppointmentDetailsWithoutID where Status like '' + @Status + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Status", Status);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtStatus.Load(reader);

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
            return dtStatus;
        }

        static public DataTable GetAppointmentsList()
        {
            DataTable AppointmentsList = new DataTable();

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from AppointmentDetailsWithoutID";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    AppointmentsList.Load(reader);

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
            return AppointmentsList;

        }

        static public int MakeNewAppointment(int PatientID,int DoctorID,  DateTime Date_Time, string Status,
           int MedicalRecordID,  int PaymentID)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"insert Into Appointments
                                Values(@PatientID , @DoctorID , @Date_Time ,@Status , @MedicalRecordID ,@PaymentID);
                                select Scope_Identity();";


            SqlCommand Command = new SqlCommand(query, Connection);



            Command.Parameters.AddWithValue("@PatientID", PatientID);
            Command.Parameters.AddWithValue("@DoctorID", DoctorID);
            Command.Parameters.AddWithValue("@Date_Time", Date_Time);
            Command.Parameters.AddWithValue("@Status", Status);
            if (MedicalRecordID != -1)
                Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
                Command.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);

            if (PaymentID != -1)
                Command.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                Command.Parameters.AddWithValue("@PaymentID", DBNull.Value);


            try
            {
                Connection.Open();
                object resulte = Command.ExecuteScalar();

                if (resulte != null && int.TryParse(resulte.ToString(), out int InsertedAppointmentID))
                {
                    ID = InsertedAppointmentID;
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

        static public bool UpdateAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime Date_Time, string Status,
           int MedicalRecordID, int PaymentID)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"Update Appointments set PatientID = @PatientID ,  DoctorID = @DoctorID ,DateTime = @DateTime ,
                            Status = @Status , MedicalRecordID = @MedicalRecordID , PaymentID = @PaymentID
                                where AppointmentID = @AppointmentID";


            SqlCommand Command = new SqlCommand(query, Connection);


            Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            Command.Parameters.AddWithValue("@PatientID", PatientID);
            Command.Parameters.AddWithValue("@DoctorID", DoctorID);
            Command.Parameters.AddWithValue("@DateTime", Date_Time);
            Command.Parameters.AddWithValue("@Status", Status);

            if (MedicalRecordID != -1)
                Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
                Command.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);

            if (PaymentID != -1)
                Command.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                Command.Parameters.AddWithValue("@PaymentID", DBNull.Value);


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

        static public bool DeleteAppointment(int AppointmentID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @" delete from Appointments where AppointmentID = @AppointmentID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            try
            {
                Connection.Open();

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

        static public bool DeleteAppointmentByPatientID(int PatientID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @" delete from Appointments where PatientID = @PatientID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                Connection.Open();

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

        static public bool DeleteAppointmentByDoctorID(int DoctorID)
        {
            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @" delete from Appointments where DoctorID = @DoctorID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DoctorID", DoctorID);

            try
            {
                Connection.Open();

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
