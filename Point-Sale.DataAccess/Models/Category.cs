using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Sale.DataAccess.Models
{
    public class Category: ModelBase
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
