using Dapper;
using Point_Sale.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Sale.DataAccess.Repository
{
    public class RepositoryBase <TEntity> where TEntity : class
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        protected bool create(string statement,TEntity entity)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                int data = connection.Execute(statement, entity);
                return data > 0;
            }
        }

        protected IList<TEntity> getAll(string statement)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                return connection.Query<TEntity>(statement).ToList();
            }
        }

        protected TEntity getById(string statement)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                return connection.Query<TEntity>(statement).FirstOrDefault();
            }
        }

        protected bool update(string statement, DynamicParameters parameters)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                int data = connection.Execute(statement, parameters);
                return data > 0;
            }
        }
    }
}
