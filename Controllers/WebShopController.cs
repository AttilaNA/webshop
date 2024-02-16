using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShop.Others.Services;

namespace WebShop.Controllers;

public class WebShopController : Controller
{
    private readonly ILogger<WebShopController> _logger;

    private readonly IWebShopService _webShopService;

    public WebShopController(ILogger<WebShopController> logger, IWebShopService webShopService)
    {
        _logger = logger;
        _webShopService = webShopService;
    }
    
    public IActionResult Index(int? id, string filter)
    {
        if (id == null)
        {
            var products = _webShopService.GetProducts();
            return View(products.ToList());
        }

        if (filter == "supplier")
        {
            var productsBySupplier = _webShopService.GetProductsForSupplier((int)id);
            return View(productsBySupplier.ToList());
        }

        var productsByCategory = _webShopService.GetProductsForCategory((int)id);
        return View(productsByCategory.ToList());
    }
    
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Error { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
