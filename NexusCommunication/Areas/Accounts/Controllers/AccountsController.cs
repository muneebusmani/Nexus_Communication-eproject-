using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Data;
using NexusCommunication.Models;

namespace NexusCommunication.Areas.Accounts.Controllers;

[Area("Accounts")]
public class AccountsController(ApplicationDbContext context) : Controller
{
    private ApplicationDbContext Context { get; } = context;

    // GET
    public IActionResult CreateBill()
    {
        return View();
    }

    public IActionResult EditBill()
    {
        return View();
    }

    public IActionResult DeleteBill()
    {
        return View();
    }

    public IActionResult ListBills()
    {
        return View();
    }

    public IActionResult ViewBill()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateBill(Billing Bill)
    {
        if (ModelState.IsValid)
        {
            Context.Billing.Add(Bill);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpPost]
    public IActionResult EditBill(Billing Bill)
    {
        if (ModelState.IsValid)
        {
            Context.Billing.Update(Bill);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpPost]
    public IActionResult DeleteBill(Billing Bill)
    {
        if (ModelState.IsValid)
        {
            Context.Billing.Remove(Bill);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }
}