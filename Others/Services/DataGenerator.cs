using WebShop.Models;
using WebShop.Others.Daos;
using WebShop.Others.Daos.Storage;

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
        // Adding new suppliers
        Supplier amazon = new Supplier{Id = 1, Name = "Amazon", Description = "Digital content and services"};
        Supplier lenovo = new Supplier{Id = 2, Name = "Lenovo", Description = "Computers"};
        
        // Adding new category
        Category tablet = new Category {Id = 1, Name = "Tablet", Department = "Hardware", Description = "A tablet computer, commonly shortened to tablet, is a thin, flat mobile computer with a touchscreen display." };
        
        // Adding new products
        Product amazonFire = new Product {Id = 1, Name = "Amazon Fire", DefaultPrice = 49.9m, Currency = "USD", Description = "Fantastic price. Large content ecosystem. Good parental controls. Helpful technical support.", Category = tablet, Supplier = amazon };
        Product lenovoIdeaPad = new Product() {Id = 2, Name = "Lenovo IdeaPad Miix 700", DefaultPrice = 479.0m, Currency = "USD", Description = "Keyboard cover is included. Fanless Core m5 processor. Full-size USB ports. Adjustable kickstand.", Category = tablet, Supplier = lenovo };
        Product amazonFireHd = new Product(){Id = 3, Name = "Amazon Fire HD 8", DefaultPrice = 89.0m, Currency = "USD", Description = "Amazon's latest Fire HD 8 tablet is a great value for media consumption.", Category = tablet, Supplier = amazon };
        
        // Adding relationships between suppliers and products
        amazon.Products.Add(amazonFire);
        amazon.Products.Add(amazonFireHd);
        lenovo.Products.Add(lenovoIdeaPad);
        
        // Adding relationships between category and products
        tablet.Products.Add(amazonFire);
        tablet.Products.Add(lenovoIdeaPad);
        tablet.Products.Add(amazonFireHd);
        
        // Adding new entities to the storage
        _productStorage.Add(amazonFire);
        _productStorage.Add(lenovoIdeaPad);
        _productStorage.Add(amazonFireHd);
        _categoryStorage.Add(tablet);
        _supplierStorage.Add(amazon);
        _supplierStorage.Add(lenovo);
        
        // Adding new suppliers
        Supplier apple = new Supplier { Id = 3, Name = "Apple", Description = "Electronics" };
        Supplier samsung = new Supplier { Id = 4, Name = "Samsung", Description = "Electronics" };
        
        // Adding new category
        Category smartphone = new Category { Id = 2, Name = "Smartphone", Department = "Hardware", Description = "A mobile phone that performs many of the functions of a computer, typically having a touchscreen interface, Internet access, and an operating system capable of running downloaded apps." };
        
        // Adding new products
        Product appleIPad = new Product() { Id = 4, Name = "Apple iPad", DefaultPrice = 329.0m, Currency = "USD", Description = "Powerful. Easy to use. Versatile. The iPad combines the power and capability of a computer with the ease of use and versatility you’d never expect from one.", Category = smartphone, Supplier = apple };
        Product appleIPhone12 = new Product() { Id = 5, Name = "Apple iPhone 12", DefaultPrice = 799.0m, Currency = "USD", Description = "Blast past fast. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display. Ceramic Shield with four times better drop performance. And Night mode on every camera.", Category = smartphone, Supplier = apple };
        Product appleIPhoneSE = new Product() { Id = 6, Name = "Apple iPhone SE", DefaultPrice = 399.0m, Currency = "USD", Description = "Lots to love. Less to spend. iPhone SE packs our most powerful chip into our most popular size at our most affordable price. It’s just what you’ve been waiting for.", Category = smartphone, Supplier = apple };
        Product samsungGalaxyTab = new Product() { Id = 7, Name = "Samsung Galaxy Tab S7", DefaultPrice = 649.99m, Currency = "USD", Description = "PC performance. Tablet portability. Get more done with DeX. Transform your tablet into a PC experience with DeX mode and the optional keyboard¹ with expanded trackpad.", Category = smartphone, Supplier = samsung};
        Product samsungGalaxyS21 = new Product() { Id = 8, Name = "Samsung Galaxy S21", DefaultPrice = 799.99m, Currency = "USD", Description = "Meet Galaxy S21 5G and S21+ 5G. Designed to revolutionize video and photography, with beyond cinematic 8K resolution so you can snap epic photos right out of video. It has it all in two sizes: 64MP, our fastest chip, and a massive all-day battery.", Category = smartphone, Supplier = samsung };
        Product samsungGalaxyNote20 = new Product() { Id = 9, Name = "Samsung Galaxy Note20", DefaultPrice = 999.99m, Currency = "USD", Description = "Power to work and play. Like a computer, a gaming console, a film studio, and an intelligent pen, all in one device. A massive leap forward in power and speed, with an intelligent battery, a pro-grade camera, and expandable storage.", Category = smartphone, Supplier = samsung };
        
        // Adding relationships between suppliers and products
        apple.Products.Add(appleIPad);
        apple.Products.Add(appleIPhone12);
        apple.Products.Add(appleIPhoneSE);
        samsung.Products.Add(samsungGalaxyTab);
        samsung.Products.Add(samsungGalaxyS21);
        samsung.Products.Add(samsungGalaxyNote20);

        // Adding relationships between category and products
        smartphone.Products.Add(appleIPad);
        smartphone.Products.Add(appleIPhone12);
        smartphone.Products.Add(appleIPhoneSE);
        smartphone.Products.Add(samsungGalaxyTab);
        smartphone.Products.Add(samsungGalaxyS21);
        smartphone.Products.Add(samsungGalaxyNote20);

        // Adding new entities to the storage
        _productStorage.Add(appleIPad);
        _productStorage.Add(appleIPhone12);
        _productStorage.Add(appleIPhoneSE);
        _productStorage.Add(samsungGalaxyTab);
        _productStorage.Add(samsungGalaxyS21);
        _productStorage.Add(samsungGalaxyNote20);
        _categoryStorage.Add(smartphone);
        _supplierStorage.Add(apple);
        _supplierStorage.Add(samsung);
        
        // Adding new suppliers
        Supplier dell = new Supplier { Id = 5, Name = "Dell", Description = "Computers and related products" };
        Supplier hp = new Supplier { Id = 6, Name = "HP", Description = "Technology company specializing in computer hardware" };
        
        // Adding new category
        Category laptop = new Category { Id = 3, Name = "Laptop", Department = "Hardware", Description = "A portable, personal computer often designed to fit on your lap while still offering the same functionality as a desktop computer." };
        
        // Adding new products
        Product dellXPS13 = new Product() { Id = 10, Name = "Dell XPS 13", DefaultPrice = 999.99m, Currency = "USD", Description = "Experience the ultimate power of a compact, 13-inch laptop with an optional touchscreen and beautiful display in a design that's thin and light.", Category = laptop, Supplier = dell };
        Product hpSpectreX360 = new Product() { Id = 11, Name = "HP Spectre x360", DefaultPrice = 1299.99m, Currency = "USD", Description = "Pushing the limits of performance in a breathtaking design, the HP Spectre x360 Convertible Laptop is built for the way you work and play.", Category = laptop, Supplier = hp };
        
        // Adding relationships between suppliers and products
        dell.Products.Add(dellXPS13);
        hp.Products.Add(hpSpectreX360);
        
        // Adding relationships between category and products
        laptop.Products.Add(dellXPS13);
        laptop.Products.Add(hpSpectreX360);
        
        // Adding new entities to the storage
        _productStorage.Add(dellXPS13);
        _productStorage.Add(hpSpectreX360);
        _categoryStorage.Add(laptop);
        _supplierStorage.Add(dell);
        _supplierStorage.Add(hp);
    }
}