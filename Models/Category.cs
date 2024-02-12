namespace WebShop.Models;

public class Category : BaseModel
{
    public List<Product> Products { get; set; }
    public string Department { get; set; }
}