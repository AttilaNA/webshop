using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

namespace WebShop.Controllers;

public class WebShopController : Controller
{
    private readonly ILogger<WebShopController> _logger;

    public WebShopController(ILogger<WebShopController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
