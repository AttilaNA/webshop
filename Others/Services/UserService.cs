using WebShop.Models;

namespace WebShop.Others.Services
{
    public class UserService : IUserService
    {
        
        private List<User> Users { get; set; }

        public UserService()
        {
            Users = new List<User>();
        }

        public void CrateUser()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser()
        {
            throw new NotImplementedException();
        }
    }
}