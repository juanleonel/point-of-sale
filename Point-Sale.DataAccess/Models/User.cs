using Point_Sale.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Sale.Data.Models
{
    public class User: ModelBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
         
    }
}
