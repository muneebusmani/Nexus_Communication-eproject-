using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class EmployeeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}