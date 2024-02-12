using WebShop.Models;
using WebShop.Others.Storage;

namespace WebShop.Others.Daos.Storage;

public class CategoryStorage : ICategoryDao
{
    private List<Category> Categories { get; set; } = new List<Category>();

    public void Add(Category item)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Category Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Category> GetAll()
    {
        throw new NotImplementedException();
    }
}