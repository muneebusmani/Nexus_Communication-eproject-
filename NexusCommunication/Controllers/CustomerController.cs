using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class CustomerController : Controller
{
    // GET
    public IActionResult SignUp()
    {
        return View();
    }
}