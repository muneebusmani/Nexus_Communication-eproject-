using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;
public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}