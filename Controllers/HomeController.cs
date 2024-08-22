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

    [HttpPost]
    public IActionResult GuardarDeportista(Deportista dep)
    {
        BD.AgregarDeportista(dep);
        return View("Index");
    }

    public IActionResult EliminarDeportista(int idCandidato)
    {
        //ACÁ SE PUEDE HACER Q SI NO PUEDE BORRAR, VUELVA A LA PAG. DE BORRAR DEPORTISTA CON UN MSG ERROR
        int pudo = BD.EliminarDeportista(idCandidato);
        return View("Index");
    }

    public IActionResult Creditos()
    {
        return View();
    }
}