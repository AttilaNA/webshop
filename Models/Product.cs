namespace WebShop.Models;

public class Product : BaseModel
{
    public string Currency { get; set; }
    public decimal DefaultPrice { get; set; }
    public Category Category { get; set; }
    public Supplier Supplier { get; set; }
}