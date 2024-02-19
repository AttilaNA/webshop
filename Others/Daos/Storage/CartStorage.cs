using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models;

namespace WebShop.Others.Daos.Storage
{
    public class CartStorage : ICartDao
    {
        private List<Cart> Carts { get; set; }

        public CartStorage()
        {
            Carts = new List<Cart>();
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