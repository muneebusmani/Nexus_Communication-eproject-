using Microsoft.AspNetCore.Mvc;

namespace Project.Areas.Accounts.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}