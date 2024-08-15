using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP6__JJOO__Blaser_Smucler.Models;

namespace TP6__JJOO__Blaser_Smucler.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
