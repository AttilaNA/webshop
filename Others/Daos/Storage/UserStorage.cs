using WebShop.Models;

namespace WebShop.Others.Daos.Storage
{
    public class UserStorage : IUserDao
    {
        private List<User> Users { get; set; }

        public UserStorage()
        {
            Users = new List<User>();
        }

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}