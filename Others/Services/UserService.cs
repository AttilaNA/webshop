using Microsoft.Extensions.WebEncoders.Testing;
using WebShop.Models;
using WebShop.Others.Daos;

namespace WebShop.Others.Services
{
    public class UserService : IUserService
    {
        
        private IUserDao _userStorage;

        public UserService(IUserDao userStorage)
        {
            _userStorage = userStorage;
        }

        public void CrateUser()
        {
            var users = _userStorage.GetAll();
            User? lastUser = null;
            if (users.Count() != 0)
            {
                lastUser = users.OrderByDescending(x => x.Id).First();
            }
            
            var newUser = new User
            {
                Cart = new Cart(),
                Id = lastUser == null ? 1 : lastUser.Id + 1
            };
            _userStorage.Add(newUser);
        }

        private int getUniqId()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser()
        {
            throw new NotImplementedException();
        }

        public User GetNewUser()
        {
            CrateUser();
            return _userStorage.GetAll().OrderByDescending(x => x.Id).First();
        }
    }
}