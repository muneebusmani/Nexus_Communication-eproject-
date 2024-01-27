using Microsoft.AspNetCore.Mvc;

namespace Project.Areas.Retail.Controllers;

[Area("Retail")]
public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}