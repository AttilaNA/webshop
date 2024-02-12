namespace WebShop.Others.Storage;

public interface IBaseDao<T>
{
    void Add(T item);
    void Remove(int id);
    T Get(int id);
    IEnumerable<T> GetAll();
}