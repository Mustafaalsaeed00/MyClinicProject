using System;
using System.Data.SqlClient;
using System.Data;


namespace clsDataAccessLayer
{
    public class clsPaymentDataAccess
    {
        public static bool Find(int PaymentID, ref DateTime Date , ref string Method, ref decimal AmountPaid , ref string Notes)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Payments where PaymentID =  @PaymentID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    Date = (DateTime)reader["Date"];
                    Method = (string)reader["Method"];
                    AmountPaid = (decimal)reader["AmountPaid"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";
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

        static public DataTable FindPaymentByNum(string PaymentID)
        {
            DataTable dtPayments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Payments where PaymentID like '' + @PaymentID + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPayments.Load(reader);

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
            return dtPayments;
        }

        static public DataTable FindPaymentByDate(string dateTime)
        {
            DataTable dtPayments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Payments where Date like '' + @dateTime + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@dateTime", dateTime);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPayments.Load(reader);

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
            return dtPayments;
        }

        static public DataTable FindPaymentByMethod(string Method)
        {
            DataTable dtPayments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Payments where Method like '' + @Method + '%'";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Method", Method);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPayments.Load(reader);

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
            return dtPayments;
        }

        static public DataTable GetPatientPayments(int PatientID)
        {
            DataTable dtPayments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select PaymentID , Date , Method , AmountPaid  , Notes from PatientsPayments where PatientID = @PatientID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPayments.Load(reader);

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
            return dtPayments;
        }

        public static DataTable GetPaymentsList()
        {
            DataTable DTPayments = new DataTable();
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select * from Payments";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    DTPayments.Load(reader);
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
            return DTPayments;

        }

        public static bool IsPaymentExist(int PaymentID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "select A=1 from Payments where PaymentID =  @PaymentID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static int AddNewPayment( DateTime Date, string Method, decimal AmountPaid, string Notes)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"insert into Payments values (@Date ,@Method , @AmountPaid, @Notes)
                                Select Scope_Identity()";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Date", Date);
            Command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            Command.Parameters.AddWithValue("@Method", Method);
            Command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
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

        public static bool DeletePayment(int PaymentID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = "Delete Payments where PaymentID = @PaymentID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static bool UpdatePayment(int PaymentID, DateTime Date, string Method, decimal AmountPaid, string Notes)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(ClinicDataAccessSettings.ConnectionString);

            string query = @"Update Payments set Date = @Date , AmountPaid = @AmountPaid ,Method =@Method , Notes = @Notes
                                    where PaymentID = @PaymentID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);
            Command.Parameters.AddWithValue("@Date", Date);
            Command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            Command.Parameters.AddWithValue("@Method", Method);
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
