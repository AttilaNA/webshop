using WebShop.Models;
using WebShop.Others.Storage;

namespace WebShop.Others.Daos.Storage;

public class ProductStorage : IProductDao
{
    private List<Product> Products { get; set; } = new List<Product>();

    public void Add(Product item)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetBy(Supplier supplier)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetBy(Category productCategory)
    {
        throw new NotImplementedException();
    }
}