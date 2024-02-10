using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Data;
using NexusCommunication.Models;

namespace NexusCommunication.Areas.Tech.Controllers;

[Area("Tech")]
public class ConnectionsController(ApplicationDbContext context) : Controller
{
    private ApplicationDbContext Context { get; } = context;

    public IActionResult CreateConnection()
    {
        return View();
    }

    public IActionResult EditConnection()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateConnection(Connections connections)
    {
        if (ModelState.IsValid)
        {
            Context.Connections.Add(connections);
            Context.SaveChanges();
            return RedirectToAction("ListConnections");
        }

        return View();
    }

    [HttpPost]
    public IActionResult EditConnection(Connections connections)
    {
        if (ModelState.IsValid)
        {
            Context.Connections.Update(connections);
            Context.SaveChanges();
            return RedirectToAction("ListConnections");
        }

        return View();
    }

    public IActionResult ListConnections()
    {
        return View();
    }

    public IActionResult ViewConnection()
    {
        return View();
    }
}