using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDSystem_DataAccessLayer_
{
    public class clsPeopleDataAccessLayer
    {

        public static bool GetPersonInfoByID(int PersonID , ref string NationalNo, ref string FirstName, ref string SecondName
                                             ,ref string ThirdName, ref string LastName,ref DateTime DateOfBirth,ref byte Gender
                                             ,ref string Address , ref string Phone ,ref string Email, ref int NationalityCountryID
                                             ,ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string Query = "select * from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    //Check ThirdName is Empty
                    ThirdName = (reader["ThirdName"] != DBNull.Value) ?(string)reader["ThirdName"]:string.Empty;
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    //Check Email is Empty
                    Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : string.Empty;
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    // Check ImagePath is Empty
                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : string.Empty;


                }

                reader.Close();
            }
            catch(Exception ex)
            {
                IsFound= false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName
                                        , ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender
                                        , ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID
                                        , ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string Query = "select * from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    //Check ThirdName is Empty
                    ThirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : string.Empty;
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    //Check Email is Empty
                    Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : string.Empty;
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    // Check ImagePath is Empty
                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : string.Empty;

                }

                reader.Close();

            }catch(Exception ex)
            {
                IsFound=false;
            }
            finally
            {
                connection.Close(); 
            }


            return IsFound;

        }

        public static int AddNewPerson(string NationalNo,string FirstName,string SecondName,string ThirdName,string LastName
                                      ,DateTime DateOfBirth,byte Gender,string Address,string Phone,string Email  
                                      ,int NationalityCountryID,string ImagePath )
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string Query = @"IF NOT EXISTS (SELECT 1 FROM People WHERE NationalNo = @NationalNo)
                             BEGIN
                             INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gender
                                                ,Address,Phone,Email,NationalityCountryID,ImagePath)
                                  VALUES
                                        (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address
                                        ,@Phone,@Email,@NationalityCountryID,@ImagePath)
                             		    select SCOPE_IDENTITY(); 
                              END";

            SqlCommand command =new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            // Nullable fields
            if (!string.IsNullOrEmpty(ThirdName))
                command.Parameters.AddWithValue("@ThirdName", ThirdName); 
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            if (!string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email",System.DBNull.Value);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath); 
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            // Nullable fields//

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int NewPersonID))
                {
                    PersonID = NewPersonID;
                }


            }
            catch (Exception ex) 
            {

            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID ,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName
                              , DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email
                              , int NationalityCountryID, string ImagePath)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string Query = @"UPDATE People
                                SET NationalNo = @NationalNo
                                   ,FirstName = @FirstName
                                   ,SecondName = @SecondName 
                                   ,ThirdName = @ThirdName
                                   ,LastName = @LastName
                                   ,DateOfBirth = @DateOfBirth
                                   ,Gender = @Gender
                                   ,Address = @Address
                                   ,Phone = @Phone
                                   ,Email = @Email
                                   ,NationalityCountryID = @NationalityCountryID
                                   ,ImagePath = @ImagePath
                              WHERE
                                    PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            // Nullable fields
            if (!string.IsNullOrEmpty(ThirdName))
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            if (!string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            // Nullable fields//

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


        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select Found = 1 from People where PersonID = @PersonID ";

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

        public static bool IsPersonExist(string NationalNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select Found = 1 from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);


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
        public static bool DeletePersonByPersonID(int PersonID)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "delete from People where  PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


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

        public static DataView GetAllPerson()
        {
            DataTable dtPerson = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @"SELECT People.PersonID, People.NationalNo,FullName = Concat(People.FirstName,' ', People.SecondName,' ', People.ThirdName,' ', People.LastName),
                             People.DateOfBirth, People.Gender, People.Address, 
                             People.Phone, People.Email, Countries.CountryName, 
                             People.ImagePath FROM People 
                             INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtPerson.Load(reader);
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
            return dtPerson.DefaultView;
        }

        public static DataView SearchPersonByPersonID(string PersonID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @"SELECT People.PersonID, People.NationalNo,FullName = Concat(People.FirstName,' ', People.SecondName,' ', People.ThirdName,' ', People.LastName), 
                             People.DateOfBirth, People.Gender, People.Address, People.Phone, 
                             People.Email, Countries.CountryName, 
                             People.ImagePath
                             FROM People INNER JOIN
                             Countries ON People.NationalityCountryID = Countries.CountryID
						     where People.PersonID like '%'+@PersonID+'%' ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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
