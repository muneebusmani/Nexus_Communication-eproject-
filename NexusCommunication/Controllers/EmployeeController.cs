using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class EmployeeController : Controller
{
    public IActionResult SignUp()
    {
        return View();
    }
}