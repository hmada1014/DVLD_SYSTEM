using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDSystem_DataAccessLayer_
{
    public class clsDriverDataAccessLayer
    {
        public static bool GetDriverInfoByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from Drivers where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];


                }
                else
                {
                    IsFound = false;

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = $"insert into Drivers (PersonID,CreatedByUserID,CreatedDate)" +
            $"Values(@PersonID,@CreatedByUserID,@CreatedDate) select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertID))
                {
                    DriverId = InsertID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return DriverId;
        }
        public static bool UpdateDriverByDriverID(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"update Drivers 
                             set
                             PersonID = @PersonID,
                             CreatedByUserID = @CreatedByUserID,
                             CreatedDate = @CreatedDate
                             where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return (AffectedRows > 0);
        }
        public static bool DeleteDriverByDriverID(int DriverID)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "delete from Drivers where  DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return (AffectedRows > 0);
        }
        public static DataView GetAllDriver()
        {
            DataTable dtDriver = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = " select DriverID,PersonID,CreatedByUserID,CreatedDate from Drivers ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtDriver.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return dtDriver.DefaultView;
        }
        public static int GetTotalDrivers()
        {
            int Total = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select count(*) from Drivers";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int total))
                {
                    Total = total;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
            return Total;
        }
        public static bool IsDriverExist(int DriverID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select Found = 1 from Drivers where DriverID = @DriverID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static DataView SearchDriverByDriverID(int DriverID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Enter your query";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return dataTable.DefaultView;
        }
    }
}
