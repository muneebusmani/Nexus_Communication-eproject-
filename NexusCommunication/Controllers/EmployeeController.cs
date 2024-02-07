using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Interfaces;

namespace NexusCommunication.Controllers;

public class EmployeeController(IUnitOfWork unitOfWork) : Controller
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public IActionResult SignUp()
    {
        return View();
    }
}