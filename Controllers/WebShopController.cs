using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShop.Others.Services;

namespace WebShop.Controllers;

public class WebShopController : Controller
{
    private readonly ILogger<WebShopController> _logger;

    private readonly IWebShopService _webShopService;

    private readonly ICartOfUserService _cartOfUserService;

    public WebShopController(ILogger<WebShopController> logger, IWebShopService webShopService, ICartOfUserService cartOfUserService)
    {
        _logger = logger;
        _webShopService = webShopService;
        _cartOfUserService = cartOfUserService;
    }
    
    public IActionResult Index(int? id, string filter)
    {
        SetUserInCookiesIfNecessary();
        
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

    private void SetUserInCookiesIfNecessary()
    {
        var cookies = Request.Cookies;
        var user = cookies["user"];
        if (user == null)
        {
            var newUser = _cartOfUserService.GetNewUser();
            Response.Cookies.Append("user", newUser.Id.ToString());
        }
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

    
    [HttpPost]
    public async Task<ActionResult> AddToCart(Product productFormWithId)
    {
        var product = _webShopService.GetProductById(productFormWithId.Id);
        _cartOfUserService.AddToCart(product, int.Parse(Request.Cookies["user"]));
        return RedirectToAction(nameof(Index));
    }   
}
