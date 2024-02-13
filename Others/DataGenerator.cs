using WebShop.Models;
using WebShop.Others.Daos;

namespace WebShop.Others;

public class DataGenerator
{
    private readonly IProductDao _productStorage;

    private readonly ICategoryDao _categoryStorage;

    private readonly ISupplierDao _supplierStorage;
    
    public DataGenerator(IProductDao productStorage, ICategoryDao categoryStorage, ISupplierDao supplierStorage)
    {
        _productStorage = productStorage;
        _categoryStorage = categoryStorage;
        _supplierStorage = supplierStorage;
    }
    public void Populate()
    {
        Supplier amazon = new Supplier{Id = 1, Name = "Amazon", Description = "Digital content and services"};
        Supplier lenovo = new Supplier{Id = 2, Name = "Lenovo", Description = "Computers"};
        Category tablet = new Category {Id = 1, Name = "Tablet", Department = "Hardware", Description = "A tablet computer, commonly shortened to tablet, is a thin, flat mobile computer with a touchscreen display." };
        Product amazonFire = new Product {Id = 1, Name = "Amazon Fire", DefaultPrice = 49.9m, Currency = "USD", Description = "Fantastic price. Large content ecosystem. Good parental controls. Helpful technical support.", Category = tablet, Supplier = amazon };
        Product lenovoIdeaPad = new Product() {Id = 2, Name = "Lenovo IdeaPad Miix 700", DefaultPrice = 479.0m, Currency = "USD", Description = "Keyboard cover is included. Fanless Core m5 processor. Full-size USB ports. Adjustable kickstand.", Category = tablet, Supplier = lenovo };
        Product amazonFireHd = new Product(){Id = 3, Name = "Amazon Fire HD 8", DefaultPrice = 89.0m, Currency = "USD", Description = "Amazon's latest Fire HD 8 tablet is a great value for media consumption.", Category = tablet, Supplier = amazon };
        amazon.Products.Add(amazonFire);
        amazon.Products.Add(amazonFireHd);
        lenovo.Products.Add(lenovoIdeaPad);
        tablet.Products.Add(amazonFire);
        tablet.Products.Add(lenovoIdeaPad);
        tablet.Products.Add(amazonFireHd);
        _productStorage.Add(amazonFire);
        _productStorage.Add(lenovoIdeaPad);
        _productStorage.Add(amazonFireHd);
        _categoryStorage.Add(tablet);
        _supplierStorage.Add(amazon);
        _supplierStorage.Add(lenovo);
    }
}