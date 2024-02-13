namespace WebShop.Others.Daos;

public interface IBaseDao<T>
{
    void Add(T item);
    void Remove(int id);
    T Get(int id);
    IEnumerable<T> GetAll();
}