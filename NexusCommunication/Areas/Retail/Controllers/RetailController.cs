using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Areas.Retail.Models;
using NexusCommunication.Data;

namespace NexusCommunication.Areas.Retail.Controllers;

[Area("Retail")]
public class RetailController(ApplicationDbContext context) : Controller
{
    private ApplicationDbContext Context { get; } = context;

    public IActionResult Orders()
    {
        List<Order> result = Context.Orders
            .Join(Context.Customers,
                t1 => t1.CustomerId,
                t2 => t2.CustomerId,
                (t1, t2) => new Order
                {
                    OrderId = t1.OrderId,
                    CustomerId = t1.CustomerId,
                    AccountId = t2.AccountId,
                    Status = t1.Status,
                    Email = t2.Email
                }).ToList();
        return View(result);
    }
}