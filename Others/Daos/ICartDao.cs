using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models;

namespace WebShop.Others.Daos
{
    public interface ICartDao : IBaseDao<Cart>
    {
        Cart GetCartByUserId(int userId);
    }
}