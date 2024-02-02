using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers;

public class CustomerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}