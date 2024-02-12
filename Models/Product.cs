namespace WebShop.Models;

public class Product : BaseModel
{
    public string Currency { get; set; }
    public decimal DefaultPrice { get; set; }
    public Category ProductCategory { get; set; }
    public Supplier Supplier { get; set; }

    public void SetProductCategory(Category productCategory)
    {
        ProductCategory = productCategory;
        ProductCategory.Products.Add(this);
    }
}