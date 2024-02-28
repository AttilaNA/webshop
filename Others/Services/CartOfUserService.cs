using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.WebEncoders.Testing;
using WebShop.Models;
using WebShop.Others.Daos;

namespace WebShop.Others.Services
{
    public class CartOfUserService : ICartOfUserService
    {
        
        private IUserDao _userStorage;

        private ICartDao _cartStorage;

        public CartOfUserService(IUserDao userStorage, ICartDao cartStorage)
        {
            _userStorage = userStorage;
            _cartStorage = cartStorage;
        }

        public void CrateUser()
        {
            // Get all users
            var users = _userStorage.GetAll();

            // Find the user with the highest id if any
            User? lastUser = null;
            if (users.Count() != 0)
            {
                lastUser = users.OrderByDescending(x => x.Id).First();
            }
            
            // Create a new user and set its properties
            var newUser = new User
            {
                Id = lastUser == null ? 1 : lastUser.Id + 1,
                Cart = new Cart()
            };

            // Cart has a user, which must be the same as the user who own the cart
            newUser.Cart.user = newUser;

            _cartStorage.Add(newUser.Cart);
            _userStorage.Add(newUser);
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

        public void AddProduct(Product product, User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            return _userStorage.Get(id);
        }

        public void AddToCart(Product product, int userId)
        {
            var cart = _cartStorage.GetCartByUserId(userId);
            cart.Products.Add(product);
        }

        public IEnumerable<Cart> GetAllCarts()
        {
            return _cartStorage.GetAll();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userStorage.GetAll();
        }
    }
}