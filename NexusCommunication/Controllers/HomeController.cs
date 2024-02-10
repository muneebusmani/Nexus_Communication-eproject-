using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}