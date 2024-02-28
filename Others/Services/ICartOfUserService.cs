using WebShop.Models;
using WebShop.Others.Daos;

namespace WebShop.Others.Services
{
    public interface ICartOfUserService
    {
        
        void CrateUser();
        void RemoveUser();
        User GetNewUser();
        User GetUserById(int id);
        void AddToCart(Product product, int userId);
        IEnumerable<Cart> GetAllCarts();
        IEnumerable<User> GetAllUsers();
    }
}