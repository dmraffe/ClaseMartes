using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebTests.Excepciones;
using WebTests.Models;

namespace WebTests.Controllers
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
            ParseNumero parseNumero = new ParseNumero();
            parseNumero.Parse("asdas");

            /*try
            {
                ParseNumero parseNumero = new ParseNumero();
                parseNumero.Parse("asdas");
            }
            catch (ParseExcepcion ex)
            {
                var h = ex;
            }
            catch (FormatException ex)
            {
                var h = ex;
            }     */
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