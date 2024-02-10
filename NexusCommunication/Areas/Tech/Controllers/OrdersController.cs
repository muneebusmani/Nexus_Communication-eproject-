using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Data;
using NexusCommunication.Models;

namespace NexusCommunication.Areas.Tech.Controllers;

[Area("Tech")]
public class OrdersController(ApplicationDbContext context) : Controller
{
    private ApplicationDbContext Context { get; } = context;

    // GET
    public IActionResult ListOrders()
    {
        return View();
    }

    public IActionResult UpdateOrder()
    {
        return View();
    }

    [HttpPost]
    public IActionResult UpdateOrder(Orders orders)
    {
        if (ModelState.IsValid)
        {
            Context.Orders.Update(orders);
            Context.SaveChanges();
            return RedirectToAction("ListOrders");
        }

        return View();
    }
}