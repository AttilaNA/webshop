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
        return Suppliers.Select(supplier => supplier).First(supplier => supplier.Id == id);
    }

    public IEnumerable<Supplier> GetAll()
    {
        return Suppliers;
    }
}