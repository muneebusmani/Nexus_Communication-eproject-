using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers;

public class EmployeeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}