using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommerceUI.Models;

namespace EcommerceUI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var vm = new FeaturedProductsViewModel(new[] {
            new ProductViewModel("Chocolate", 34.95m),
            new ProductViewModel("Asparagus", 39.50m)
        });
        return View(vm);
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
