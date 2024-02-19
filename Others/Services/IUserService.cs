using WebShop.Models;

namespace WebShop.Others.Services
{
    public interface IUserService
    {
        
        void CrateUser();
        void RemoveUser();
        User GetNewUser();
    }
}