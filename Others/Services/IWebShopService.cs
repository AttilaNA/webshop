using WebShop.Models;

namespace WebShop.Others.Services;

public interface IWebShopService
{
    public Category GetProductCategory(int categoryId);

    public IEnumerable<Product> GetProductsForCategory(int categoryId);
}