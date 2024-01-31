using Microsoft.AspNetCore.Mvc;

namespace Project.Areas.User.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}