using Point_Sale.Data.Models;
using Point_Sale.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale.DataAccess.Service
{
    public class UserService
    {
        private readonly  UserRepository _userRepository = null;
        public UserService() {
          _userRepository = new UserRepository();
        }

        public bool create(User user) {
            return _userRepository.create(user);
        }

        public User getByName(string userName) {
           return _userRepository.getByName(userName);
        }

        public List<User> getAll() {
            return _userRepository.getAll();
        }

        public bool update(User user) {
            return _userRepository.update(user);
        }

        public bool delete(int Id) {
            return _userRepository.delete(Id);
        }
    }
}
