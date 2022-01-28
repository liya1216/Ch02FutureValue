using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;
public class Homecontroller: Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.FV = 0;
        return View();
    }
    [HttpPost]
    public IActionResult Index(FutureValueModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.FV = model.CalculateFutureValue();
        }
        else
        {
            ViewBag.FV = 0;
        }
        return View(model);
    }
    } 