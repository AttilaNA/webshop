using Microsoft.AspNetCore.Mvc;
using WebShop.Others.Daos;
using WebShop.Others.Daos.Storage;

namespace WebShop.Views.Shared.Components.NavBar;

public class NavBarViewComponent : ViewComponent
{
    private readonly ICategoryDao _categoryStorage;

    public NavBarViewComponent(ICategoryDao categoryStorage)
    {
        _categoryStorage = categoryStorage;
    }
    
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = _categoryStorage.GetAll();
        return View(categories.ToList());
    }
}