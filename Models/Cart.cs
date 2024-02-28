namespace WebShop.Models
{
    public class Cart
    {
        public List<Product> Products { get; set; }

        public User user { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }
    }
}