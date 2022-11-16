using Dapper;
using Point_Sale.Data.Models;
using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace Point_Sale.DataAccess.Repository
{
    public class UserRepository
    {
        private const string SELECT = @"SELECT Id, UserName, Password, CreateAt, IsActive FROM User ";
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public UserRepository() { }

        public bool create(User user)
        {
            bool result = false;
            try
            {
                using (IDbConnection connection = new SQLiteConnection(connectionString))
                {
                    int data = connection.Execute(@"INSERT INTO User (UserName, Password, CreateAt) VALUES (@UserName, @Password, @CreateAt)", user);
                    result = data > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool update(User user)
        {
            bool result = false;
            try
            {
                using (IDbConnection connection = new SQLiteConnection(connectionString))
                {
                    var dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@Id", user.Id);
                    dynamicParameters.Add("@UserName", user.UserName);
                    dynamicParameters.Add("@Password", user.Password);

                    int data = connection.Execute(@"UPDATE User SET UserName = @UserName, Password = @Password WHERE Id = @Id ", dynamicParameters);
                    result = data > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool delete(int Id)
        {
            bool result = false;
            try
            {
                using (IDbConnection connection = new SQLiteConnection(connectionString))
                {
                    int data = connection.Execute(@"UPDATE User SET IsActive = 0 WHERE Id = @Id ", new { @Id = Id });
                    result = data > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public User getByName(string name)
        {
            User result = null;
            try
            {
                using (IDbConnection connection = new SQLiteConnection(connectionString))
                {
                    result = connection.Query<User>(SELECT + " WHERE UserName = @UserName", new { @UserName = name }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public User getById(int Id)
        {
            User result = null;
            try
            {
                using (IDbConnection connection = new SQLiteConnection(connectionString))
                {
                    result = connection.Query<User>(SELECT + " WHERE Id = @Id", new { @Id = Id }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<User> getAll()
        {
            List<User> result = null;
            try
            {
                using (IDbConnection connection = new SQLiteConnection(connectionString))
                {
                    result = connection.Query<User>(SELECT + " ORDER BY UserName ASC").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
