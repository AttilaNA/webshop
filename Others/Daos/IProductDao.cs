using WebShop.Models;

namespace WebShop.Others.Daos;

public interface IProductDao : IBaseDao<Product>
{
    IEnumerable<Product> GetBy(Supplier supplier);
    IEnumerable<Product> GetBy(Category category);
}