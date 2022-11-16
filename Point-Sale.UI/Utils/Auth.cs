using Point_Sale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Sale.UI.Utils
{
    public static class Auth
    {
        public static int Id { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string Token { get; set; }

        public static void setAuth(User user)
        {
            if (user == null) { return; }
            if (Id == 0 && string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password)) {
                Id = user.Id;
                UserName = user.UserName;
                Password = user.Password;
            }
        }

        public static void setNull()
        {
            Id = 0;
            UserName = null;
            Password = null;
        }

        public static bool IsLogged() { return Id != 0; }
    }
}
