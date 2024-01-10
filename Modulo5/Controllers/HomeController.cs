using Microsoft.AspNetCore.Mvc;
using Modulo5.Filter;
using Modulo5.Models;
using System.Diagnostics;

namespace Modulo5.Controllers
{
     
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Filtro]
        public IActionResult Index(int id)
        {
            string ids =(string)RouteData.Values["id"];

            SimpleModel model = new SimpleModel() { Value = id };
            return View(model);

        }


        [HttpGet("/Home/Some/{id}/{idsecundario}")]
        
        public IActionResult Index(string id,string idsecundario)
        {
            string ids = (string)RouteData.Values["id"];

            SimpleModel model = new SimpleModel() {  };
            return View(model);

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



         
        public ContentResult AnotherAction()
        {
            return Content("some text");
        }
        
        //public RedirectToRouteResult Index(int id)
        //{
        //    return RedirectToRoute(new
        //    {
        //        controller = "home",
        //        action = "AnotherAction"
        //    });
        //}
    }
}