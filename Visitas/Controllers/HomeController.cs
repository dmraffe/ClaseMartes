using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Visitas.Models;

namespace Visitas.Controllers
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

        public IActionResult formulariovisitas()
        { 
        
            return View();
        }


        public IActionResult GuardarVisitas()
        { 
            string Nombre = Request.Form["Nombre"].ToString();
            string Comentario = Request.Form["Comentario"].ToString();
            LibrioVisitasAdm librioVisitasAdm = new();

            librioVisitasAdm.GuardarVisitas(Nombre, Comentario);
            return RedirectToAction("listavisitas");   
        }

        public IActionResult listavisitas() {
            LibrioVisitasAdm librioVisitasAdm = new();
            ViewData["libros"] = librioVisitasAdm.LeerVisitas();
            return View();
        }



    }
}