using Microsoft.AspNetCore.Mvc;

namespace Project.Areas.Accounts.Controllers;

public class AccountsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}