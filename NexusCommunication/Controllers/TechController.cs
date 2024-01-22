using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class TechController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}