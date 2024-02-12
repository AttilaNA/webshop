using WebShop.Models;

namespace WebShop.Others.Storage;

public interface IProductDao : IBaseDao<Product>
{
    IEnumerable<Product> GetBy(Supplier supplier);
    IEnumerable<Product> GetBy(Category productCategory);
}