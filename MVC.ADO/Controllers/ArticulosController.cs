using Microsoft.AspNetCore.Mvc;
using MVC.ADO.ADM;
using MVC.ADO.Models;

namespace MVC.ADO.Controllers
{
    public class ArticulosController : Controller
    {

        ADMArticulos ADMArticulos = new ADMArticulos();
        public IActionResult Index()
        {
            return View(ADMArticulos.TraerTodos());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Articulo articulo)
        {
            ADMArticulos.Alta(articulo);
            return RedirectToAction("index");
        }

        public IActionResult Details(int id)
        {
            var articulo = ADMArticulos.TraerArticulo(id);
            return View(articulo);
        }

        public IActionResult Edit(int id)
        {
            var articulo = ADMArticulos.TraerArticulo(id);
            return View(articulo);
        }

        [HttpPost]
        public IActionResult Edit(int id, Articulo articulo)
        {
             ADMArticulos.Modificar(articulo);
            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            var articulo = ADMArticulos.TraerArticulo(id);
            return View(articulo);
        }


        [HttpPost]
        public IActionResult Delete(int id, Articulo articulo)
        {
            ADMArticulos.Borrar(id);
            return RedirectToAction("index");
        }




    }
}
