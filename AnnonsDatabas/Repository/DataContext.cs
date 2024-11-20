using AnnonsDatabas.Repository.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace AnnonsDatabas.Repository
{
    public class DataContext
    {
        private readonly string _connString;
        private SqlConnection _conn;
        public DataContext()
        {
            _connString = ConfigurationManager.ConnectionStrings["AdvertisementDatabaseConn"].ConnectionString;
            _conn = new SqlConnection(_connString);
        }
        //Metoden för att öppna
        public void OpenConnection()
        {
            if (_conn.State == System.Data.ConnectionState.Closed)
            {
                _conn.Open();
            }
        }
        //Metoden för att stänga 
        public void CloseConnection()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }
        }
        //SELECT metoder
        public List<Advertisement> GetAdvertisements()
        {
            string query = "SELECT * FROM Advertisements";
            List<Advertisement> advertisements = new List<Advertisement>();

            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var advertisement = new Advertisement
                        {
                            AdvertisementID = (int)reader["AdvertisementID"],
                            AdvertisementTitle = reader["AdvertisementTitle"].ToString(),
                            AdvertisementDescription = reader["AdvertisementDescription"].ToString(),
                            Price = (decimal)reader["Price"],
                            PublishedTime = (DateTime)reader["PublishedTime"],
                            CategoryID = (int)reader["CategoryID"],
                            UserID = (int)reader["UserID"]
                        };
                        advertisements.Add(advertisement);
                    }
                }
            }
            CloseConnection();
            return advertisements;
        }
        public List<Category> GetCategories()
        {
            string query = "SELECT * FROM Categories";
            List<Category> categories = new List<Category>();
            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new Category
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = reader["CategoryName"].ToString()
                        };
                        categories.Add(category);
                    }
                }
            }
            CloseConnection();
            return categories;
        }
        //public List<Category> GetCategoryById(int id)
        //{
        //    string query = "SELECT CategoryName FROM Categories Where CategoryID = @id";
        //    List<Category> categories = new List<Category>();
        //    OpenConnection();
        //    using (SqlCommand cmd = new SqlCommand(query, _conn))
        //    {
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var category = new Category
        //                {
        //                    CategoryID = (int)reader["CategoryID"],
        //                    CategoryName = reader["CategoryName"].ToString()
        //                };
        //                categories.Add(category);
        //            }
        //        }
        //    }
        //    CloseConnection();
        //    return categories;
        //}
        public List<AppUser> GetAppUser()
        {
            string query = "SELECT * FROM AppUsers";
            List<AppUser> appUsers = new List<AppUser>();
            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var appUser = new AppUser
                        {
                            UserID = (int)reader["UserID"],
                            Login = reader["Login"].ToString(),
                            Password = reader["Password"].ToString()
                        };
                        appUsers.Add(appUser);
                    }
                }
            }
            CloseConnection();
            return appUsers;
        }

        public void CreateNewUser(string login, string password)
        {
            string query = "INSERT INTO Appusers (login, password) VALUES (@login, @password)";
            List<AppUser> appUsers = new List<AppUser>();
            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();
            }
            CloseConnection();
        }

        //INSERT metoden
        public void InsertAdvertisements(string advertisementTitle, string advertisementDescription, decimal price,
                                         DateTime publishedTime, int categoryID, int userID)
        {
            string query = "INSERT INTO Advertisements (AdvertisementTitle, AdvertisementDescription, Price," +
                           " PublishedTime, CategoryID, UserID) " +
                           "VALUES (@Title, @Description, @Price, @PublishedTime, @CategoryID, @UserID)";
            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@Title",advertisementTitle);
                cmd.Parameters.AddWithValue("@Description", advertisementDescription);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@PublishedTime", publishedTime);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@UserID", userID);

                cmd.ExecuteNonQuery();
            }
            CloseConnection();
        }

        // Update metoden
        public void UpdateAdvertisement(int advertisementID,string advertisementTitle, string advertisementDescription, decimal price,
                                         DateTime publishedTime, int categoryID)
        {
            string query = "UPDATE Advertisements SET AdvertisementTitle = @Title, AdvertisementDescription = @Description, " +
                           "Price = @Price, PublishedTime = @PublishedTime, CategoryID = @CategoryID WHERE AdvertisementID = @AdvertisementID";
                OpenConnection();

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@Title", advertisementTitle);
                cmd.Parameters.AddWithValue("@Description", advertisementDescription);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@PublishedTime", publishedTime);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@AdvertisementID", advertisementID);

                cmd.ExecuteNonQuery();
            }
            
            CloseConnection();
        }

        // Delete metoden
        public void DeleteAdvertisement(int advertisementID)
        {
            string query = "DELETE FROM Advertisements WHERE AdvertisementID = @AdvertisementID";
            OpenConnection();

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@AdvertisementID", advertisementID);

                cmd.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}

//App.Config
//<? xml version = "1.0" encoding = "utf-8" ?>
//< configuration >
//  < connectionStrings >
//    < add name = "DefaultConnection"
//         connectionString = "Server=localhost;Database=MyDatabase;Integrated Security=True;"
//         providerName = "System.Data.SqlClient" />
//  </ connectionStrings >
//</ configuration >

