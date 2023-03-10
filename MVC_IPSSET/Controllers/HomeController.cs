using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using MVC_IPSSET.Models;
using System.Diagnostics;



namespace MVC_IPSSET.Controllers
{
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


        public IActionResult Inicio()
        {
            return View();
        }


        public ActionResult Autenticacion(String?nombre, String?password)
        {



            return RedirectToAction("Inicio","Home");
        }


        public ActionResult Eliminar_Persona(int?Id)
        {



            return RedirectToAction("Inicio", "Home");
        }


        public ActionResult Editar_Persona()
        {



            return View();
        }

        public IActionResult Agregar_Persona()
        {



            return View();
        }

        public IActionResult Ver_Persona()
        {



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}