using WebShop.Models;

namespace WebShop.Others.Daos.Storage;

public class SupplierStorage : ISupplierDao
{
    private List<Supplier> Suppliers { get; set; }

    public SupplierStorage()
    {
        Suppliers = new List<Supplier>();
    }

    public void Add(Supplier item)
    {
        Suppliers.Add(item);
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