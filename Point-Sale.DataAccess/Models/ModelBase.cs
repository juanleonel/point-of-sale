using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Sale.DataAccess.Models
{
    public abstract class ModelBase
    {
        public int Id { get; set; }
        public string CreateAt { get; set; }

        private string _IsActive;
        public string IsActive
        {
            get
            {
                if (!string.IsNullOrEmpty(_IsActive) && int.Parse(_IsActive) == 1)
                {
                    return "SI";
                }
                return "NO";
            }
            set { _IsActive = value; }
        }
    }
}
