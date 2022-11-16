using Dapper;
using Point_Sale.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Sale.DataAccess.Repository
{
    public class CategoryService : RepositoryBase<Category>
    {
        private const string SELECT = @"SELECT * FROM Category ";
        public CategoryService() { }

        public bool create(Category category)
        {
            try
            {
                const string sql = @"INSERT INTO Category (CategoryName, Description, CreateAt) VALUES (@CategoryName, @Description, @CreateAt)";
                
                return create(sql, category);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Category> getAll()
        {
            try
            {
                return getAll(SELECT + " ORDER BY CategoryName ASC").ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool update(Category category)
        {
            try
            {
                const string sql = @"UPDATE Category SET CategoryName = @CategoryName, Description = @Description WHERE Id = @Id";

                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Id", category.Id);
                dynamicParameters.Add("@CategoryName", category.CategoryName);
                dynamicParameters.Add("@Description", category.Description);

                return update(sql, dynamicParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool delete(int Id)
        {
            try
            {
                const string sql = @"UPDATE Category SET IsActive = 0 WHERE Id = @Id";
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Id", Id);

                return update(sql, dynamicParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
