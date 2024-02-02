using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers;
public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}