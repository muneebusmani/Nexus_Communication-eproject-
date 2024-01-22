using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class RetailController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}