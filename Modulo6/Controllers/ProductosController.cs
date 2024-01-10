using Microsoft.AspNetCore.Mvc;

namespace Modulo6.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Createdos(int id)
        {
            return Content("Second Controller");
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

         


    }
}
