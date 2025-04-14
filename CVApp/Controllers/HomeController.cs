using Microsoft.AspNetCore.Mvc;
using CVApp.Models;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(CVModel model)
    {
        if (ModelState.IsValid)
        {
            return View("Preview", model);
        }

        return View(model);
    }
}
