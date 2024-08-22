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

    public IActionResult Deportes()
    {
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View();
    }

    public IActionResult Paises()
    {
        ViewBag.ListaPaises = BD.ListarPaises();
        return View();
    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        ViewBag.Deporte = BD.VerInfoDeporte(idDeporte);
        ViewBag.Deportistas = BD.ListarDeportistasPorDeporte(idDeporte);
        return View("DetalleDeporte");
    }

    public IActionResult VerDetallePais(int idPais)
    {
        ViewBag.Pais = BD.VerInfoPais(idPais);
        ViewBag.Deportistas = BD.ListarDeportistasPorPais(idPais);
        return View("DetallePais");
    }

    public IActionResult VerDetalleDeportista(int idDeportista)
    {
        ViewBag.Deportista = BD.VerInfoDeportista(idDeportista);
        return View("DetalleDeportista");
    }

    public IActionResult AgregarDeportista()
    {
        ViewBag.Paises = BD.ListarPaises();
        ViewBag.Deportes = BD.ListarDeportes();
        return View();
    }
}
