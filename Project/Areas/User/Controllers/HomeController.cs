using Microsoft.AspNetCore.Mvc;

namespace Project.Areas.User.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}