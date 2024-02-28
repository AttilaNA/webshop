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
            Users.Add(item);
        }

        public User Get(int id)
        {
            return Users.Find(user => user.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return Users;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

    }
}