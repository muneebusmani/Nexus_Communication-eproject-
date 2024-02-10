using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Data;
using NexusCommunication.Models;

namespace NexusCommunication.Areas.Admin.Controllers;

[Area("Admin")]
public class Admin(ApplicationDbContext context) : Controller
{
    private ApplicationDbContext Context { get; } = context;

    public IActionResult CreatePlan()
    {
        return View();
    }

    public IActionResult EditPlan()
    {
        return View();
    }

    public IActionResult DeletePlan()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreatePlan(Plans plan)
    {
        if (ModelState.IsValid)
        {
            Context.Plans.Add(plan);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpPost]
    public IActionResult EditPlan(Plans plan)
    {
        if (ModelState.IsValid)
        {
            Context.Plans.Update(plan);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpPost]
    public IActionResult DeletePlan(Plans plan)
    {
        if (ModelState.IsValid)
        {
            Context.Plans.Remove(plan);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }

    public IActionResult ListPlans()
    {
        return View();
    }

    public IActionResult ViewPlan()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }
}