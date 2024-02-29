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

        public void Add(Cart item)
        {
            Carts.Add(item);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Cart Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetAll()
        {
            return Carts;
        }

        public Cart GetCartByUserId(int userId)
        {
            var cart = Carts.Find( cart => cart.User.Id == userId);
            return cart;
        }
    }
}