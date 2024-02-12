using WebShop.Models;
using WebShop.Others.Storage;

namespace WebShop.Others.Daos.Storage;

public class SupplierStorage : ISupplierDao
{
    private List<Supplier> Suppliers { get; set; } = new List<Supplier>();

    public void Add(Supplier item)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Supplier Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Supplier> GetAll()
    {
        throw new NotImplementedException();
    }
}