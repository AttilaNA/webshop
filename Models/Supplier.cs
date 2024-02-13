namespace WebShop.Models;

public class Supplier : BaseModel
{
    public List<Product> Products { get; set; }

    public Supplier()
    {
        Products = new List<Product>();
    }
}