using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Interfaces;

namespace NexusCommunication.Controllers;

public class CustomerController(IUnitOfWork unitOfWork) : Controller
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    // GET
    public IActionResult SignUp()
    {
        return View();
    }
}