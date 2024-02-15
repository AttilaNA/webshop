using Microsoft.AspNetCore.Mvc;

namespace WebShop.Views.Shared.Components.NavBar;

public class NavBarViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}