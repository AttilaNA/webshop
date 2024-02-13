using WebShop.Models;

namespace WebShop.Others.Daos.Storage;

public class CategoryStorage : ICategoryDao
{
    private List<Category> Categories { get; set; }

    public CategoryStorage()
    {
        Categories = new List<Category>();
    }

    public void Add(Category item)
    {
        Categories.Add(item);
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Category Get(int id)
    {
        return Categories.Select(category => category).First(category => category.Id == id);
    }

    public IEnumerable<Category> GetAll()
    {
        throw new NotImplementedException();
    }
}