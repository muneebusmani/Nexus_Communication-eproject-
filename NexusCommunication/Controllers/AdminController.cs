using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Plans()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }
}