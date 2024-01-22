using Microsoft.AspNetCore.Mvc;

namespace NexusCommunication.Controllers;

public class AccountsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}