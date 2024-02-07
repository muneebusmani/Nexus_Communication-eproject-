using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Entities;

namespace NexusCommunication.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(Admin credentials)
    {
        return View();
    }
}