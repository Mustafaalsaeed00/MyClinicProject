using System.Data;
using System.Data.SqlClient;


namespace clsDataAccessLayer
{
    public class clsMedicalRecordDataAccess
    {
        public static bool Find(int MedicalRecordID , ref string Description , ref string Diagnosis , ref string Notes)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from MedicalRecords where MedicalRecordID =  @MedicalRecordID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("MedicalRecordID", MedicalRecordID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if(reader.Read())
                {
                    Description = (string)reader["Description"];
                    Diagnosis = (string)reader["Diagnosis"];
                    Notes = (string)reader["Notes"];
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

        public static DataTable GetMedicalRecordsListForPatient(int PatientID)
        {
            DataTable dtPatientMedicalRecords = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select MedicalRecordID , Description , Diagnosis , Notes from PatientsMedicalRecords where PatientID = @PatientID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("PatientID", PatientID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();


                if(reader.HasRows)
                {
                    dtPatientMedicalRecords.Load(reader);
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
            return dtPatientMedicalRecords;

        }

        public static DataTable GetMedicalRecordsList()
        {
            DataTable DTMedicalRecord = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from MedicalRecords";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    DTMedicalRecord.Load(reader);
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
            return DTMedicalRecord;

        }

        public static bool IsMedicalRecordExist(int MedicalRecordID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select A=1 from MedicalRecords where MedicalRecordID =  @MedicalRecordID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

        public static int AddNewMedicalRecord(string Description ,string diagnosis ,string Notes)
        {
            int ID = -1;
            

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"insert into MedicalRecords values (@Description , @Diagnosis , @Notes)
                                Select Scope_Identity()";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@diagnosis", diagnosis);
            Command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString() , out int InsertedID ))
                {
                    ID = InsertedID;
                }

                    
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return ID;

        }

        public static bool DeleteMedicalRecord(int MedicalRecordID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "Delete MedicalRecords where MedicalRecordID = @MedicalRecordID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

        public static bool UpdateMedicalRecord(int MedicalRecordID , string Description , string Diagnosis , string Notes)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"Update MedicalRecords set Description = @Description , Diagnosis = @Diagnosis , Notes = @Notes
                                    where MedicalRecordID = @MedicalRecordID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            Command.Parameters.AddWithValue("@Notes", Notes);


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
