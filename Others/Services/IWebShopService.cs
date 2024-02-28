using WebShop.Models;

namespace WebShop.Others.Services;

public interface IWebShopService
{
    public Category GetProductCategory(int categoryId);

    public IEnumerable<Product> GetProductsForCategory(int categoryId);

    public IEnumerable<Product> GetProductsForSupplier(int supplierId);
    
    public IEnumerable<Product> GetProducts();

    public Product GetProductById(int id);
}