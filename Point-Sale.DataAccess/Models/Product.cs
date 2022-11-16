using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Sale.DataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Folio { get; set; }
        public decimal Max { get; set; }
        public decimal Min { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public decimal WhoSalePrice { get; set; }
        public int CategoyId { get; set; }
        public string Category { get; set; }
        public int UserCreated { get; set; }
        public string CreateAt { get; set; }
    }
}
