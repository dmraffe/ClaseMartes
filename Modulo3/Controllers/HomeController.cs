using Microsoft.AspNetCore.Mvc;
using Modulo3.Models;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Mime;

namespace Modulo3.Controllers
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


            //return Content("<html><body><h1> ACME S.R.L.</h1><p> Una organización a su servicio, para resolver cualquier problema </p></body></html>",  "text/html");
            return View();
            
        }

        public IActionResult Equipo()
        {
            //return Content("<html><body><h1> Nosotros </h1><p> Juan Gomez<br> Pedro Martinez<br> Carla Perez </p></body></html>",  "text/html");

            return View();
        }


        /* public IActionResult Privacy()
         {
             return View();
         }

         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
         public IActionResult Error()
         {
             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }  */
    }
}