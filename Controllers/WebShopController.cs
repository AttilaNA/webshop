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
        var user = Request.Cookies["user"];
        
        if (user == null)
        {
            var newUser = _cartOfUserService.GetNewUser();
            Response.Cookies.Append("user", newUser.Id.ToString());
        }

        // Solve data persistence issue.
        // User and its cart is created with the first GET request if there is no user key in cookies.
        // If app is restarted and user key remains in cookies neider user nor cart will be instantiated.
        // This caused null reference exeption error.
        // Issue is fixed for development purpose until in-memory-database is in use.
        var carts = _cartOfUserService.GetAllCarts();

        if (carts.Count() == 0)
        {
            Response.Cookies.Delete("user");
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

    public async Task<ActionResult> AddToCart(int id)
    {
        var product = _webShopService.GetProductById(id);
        _cartOfUserService.AddToCart(product, int.Parse(Request.Cookies["user"]));
        return RedirectToAction(nameof(Index));
    }

    public IActionResult CheckOutCart()
    {
        var userId = Request.Cookies["user"];

        // Only allow the normal flow further if userId in not null
        // Otherwise 'ArgumentNullException: Parameter value cannot be null' exeption occure
        if (userId == null)
        {
            return RedirectToAction(nameof(Index));
        }

        var userCart = _cartOfUserService.GetCartByUserId(int.Parse(userId));
        return View(userCart);
    }

    public IActionResult IncrementProduct(int id)
    {
        var product = _webShopService.GetProductById(id);
        var userId = int.Parse(Request.Cookies["user"]);
        _cartOfUserService.AddToCart(product, userId);
        var userCart = _cartOfUserService.GetCartByUserId(userId);
        return View("CheckOutCart", userCart);
    }

    public IActionResult DecrementProduct(int id)
    {
        var product = _webShopService.GetProductById(id);
        var userId = int.Parse(Request.Cookies["user"]);
        _cartOfUserService.RemoveFromCart(product, userId);
        var userCart = _cartOfUserService.GetCartByUserId(userId);
        return View("CheckOutCart", userCart);
    }

    public IActionResult RemoveProductFromCart(int id)
    {
        var product = _webShopService.GetProductById(id);
        var userId = int.Parse(Request.Cookies["user"]);
        _cartOfUserService.RemoveAllProductsFromCart(product, userId);
        var userCart = _cartOfUserService.GetCartByUserId(userId);
        return View("CheckOutCart", userCart);
    }
}
