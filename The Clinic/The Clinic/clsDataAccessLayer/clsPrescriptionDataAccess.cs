using System;
using System.Data.SqlClient;
using System.Data;


namespace clsDataAccessLayer
{
    public class clsPrescriptionDataAccess
    {

        public static bool Find(int PrescriptionID, ref int MedicalRecordID , ref string MedicationName , ref string Dosage ,ref short Frequency
            , ref DateTime StartDate , ref DateTime EndDate ,ref string SpecialInstructions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Prescriptions where PrescriptionID =  @PrescriptionID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    MedicalRecordID = (int)reader["MedicalRecordID"];
                    MedicationName = (string)reader["MedicationName"];
                    Dosage = (string)reader["Dosage"];
                    Frequency = (short)reader["Frequency"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    if (reader["SpecialInstructions"] != DBNull.Value)
                        SpecialInstructions = (string)reader["SpecialInstructions"];
                    else
                        SpecialInstructions = "";
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

        public static DataTable GetPrescriptionsList()
        {
            DataTable DTPrescriptions = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Prescriptions";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    DTPrescriptions.Load(reader);
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
            return DTPrescriptions;

        }

        static public DataTable GetPatientPrescriptions(int PatientID)
        {
            DataTable dtPrescriptions = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"select PrescriptionID , MedicalRecordID ,MedicationName , Dosage , Frequency , StartDate , EndDate , 
                                    SpecialInstructions from PatientsPrescriptions where PatientID = @PatientID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPrescriptions.Load(reader);

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
            return dtPrescriptions;
        }

        public static bool IsPrescriptionExist(int PrescriptionID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select A=1 from Prescriptions where PrescriptionID =  @PrescriptionID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

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

        public static int AddNewPrescription(int MedicalRecordID, string MedicationName,  string Dosage, short Frequency
            , DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"insert into Prescriptions values (@MedicalRecordID ,@MedicationName , @Dosage, @Frequency , @StartDate , @EndDate , @SpecialInstructions)
                                Select Scope_Identity()";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            Command.Parameters.AddWithValue("@MedicationName", MedicationName);
            Command.Parameters.AddWithValue("@Dosage", Dosage);
            Command.Parameters.AddWithValue("@Frequency", Frequency);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);
            if(SpecialInstructions != "")
                Command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            else
                Command.Parameters.AddWithValue("@SpecialInstructions", DBNull.Value);


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

        public static bool DeletePrescription(int PrescriptionID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "Delete Prescriptions where PrescriptionID = @PrescriptionID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

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

        public static bool UpdatePrescription(int PrescriptionID,int MedicalRecordID, string MedicationName, string Dosage, short Frequency
            , DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"Update Prescriptions set MedicalRecordID = @MedicalRecordID , MedicationName = @MedicationName ,Dosage =@Dosage , Frequency = @Frequency ,
                            StartDate = @StartDate ,EndDate = @EndDate , SpecialInstructions = @SpecialInstructions
                                    where PrescriptionID = @PrescriptionID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            Command.Parameters.AddWithValue("@MedicationName", MedicationName);
            Command.Parameters.AddWithValue("@Dosage", Dosage);
            Command.Parameters.AddWithValue("@Frequency", Frequency);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);
            Command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);

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
