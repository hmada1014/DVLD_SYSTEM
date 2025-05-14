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
            string query = @"SELECT dbo.Drivers.DriverID, dbo.Drivers.PersonID, dbo.People.NationalNo,
                             dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS FullName,
                             dbo.Drivers.CreatedDate,
                             (SELECT       COUNT(LicenseID) AS NumberOfActiveLicenses
                             FROM dbo.Licenses
                             WHERE         (IsActive = 1) AND (DriverID = dbo.Drivers.DriverID)) AS NumberOfActiveLicenses
                             FROM dbo.Drivers INNER JOIN 
                             dbo.People ON dbo.Drivers.PersonID = dbo.People.PersonID";

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
                connection.Close();
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

        public static bool IsDriverByPersonIDExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select Found = 1 from Drivers where  Drivers.PersonID  = @PersonID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


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
        public static int GetDriverIDByPersonID(int PersonID)
        {
            int DriverId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select Drivers.DriverID from Drivers where  Drivers.PersonID  = @PersonID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int ID))
                {
                    DriverId = ID;
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
        public static DataView SearchDriverByDriverID(string DriverID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @"SELECT       dbo.Drivers.DriverID, dbo.Drivers.PersonID, dbo.People.NationalNo, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS FullName, dbo.Drivers.CreatedDate,
                             (SELECT       COUNT(LicenseID) AS NumberOfActiveLicenses
                             FROM             dbo.Licenses
                             WHERE         (IsActive = 1) AND (DriverID = dbo.Drivers.DriverID)) AS NumberOfActiveLicenses
                             FROM            dbo.Drivers INNER JOIN
                             dbo.People ON dbo.Drivers.PersonID = dbo.People.PersonID
						     where Drivers.DriverID like '%'+@DriverID+'%'";
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

        public static DataView SearchDriverByNationalNo(string NationalNo)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @" SELECT       dbo.Drivers.DriverID, dbo.Drivers.PersonID, dbo.People.NationalNo, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS FullName, dbo.Drivers.CreatedDate,
                             (SELECT       COUNT(LicenseID) AS NumberOfActiveLicenses
                               FROM             dbo.Licenses
                               WHERE         (IsActive = 1) AND (DriverID = dbo.Drivers.DriverID)) AS NumberOfActiveLicenses
                             FROM            dbo.Drivers INNER JOIN
                             dbo.People ON dbo.Drivers.PersonID = dbo.People.PersonID
						     where People.NationalNo  like '%'+@NationalNo+'%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
        public static DataView SearchDriverByFullName(string FullName)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @" select * from(
						      SELECT       dbo.Drivers.DriverID, dbo.Drivers.PersonID, dbo.People.NationalNo, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS FullName, dbo.Drivers.CreatedDate,
                                  (SELECT       COUNT(LicenseID) AS NumberOfActiveLicenses
                                    FROM             dbo.Licenses
                                    WHERE         (IsActive = 1) AND (DriverID = dbo.Drivers.DriverID)) AS NumberOfActiveLicenses
                              FROM            dbo.Drivers INNER JOIN
                              dbo.People ON dbo.Drivers.PersonID = dbo.People.PersonID)R1
						      where R1.FullName like '%'+@FullName+'%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FullName", FullName);

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
