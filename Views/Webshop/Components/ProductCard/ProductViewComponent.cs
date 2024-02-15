using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

namespace WebShop.Views.Shared.Components.NavBar;

public class ProductCardViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(Product product)
    {
        return View(product);
    }
}