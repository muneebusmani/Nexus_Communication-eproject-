using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class CustomersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}