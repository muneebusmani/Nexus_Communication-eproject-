using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class Admin : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}