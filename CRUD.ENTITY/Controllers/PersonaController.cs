using CRUD.ENTITY.Models;
using CRUD.ENTITY.Servicio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.ENTITY.Controllers
{
    public class PersonaController : Controller
    {


        IServicePersonacs _servicioPersona;

        public PersonaController(IServicePersonacs servicioPersona)
        {
            _servicioPersona = servicioPersona;
        }


        // GET: PersonaController
        public async Task<ActionResult> Index()
        {

            var lista = await _servicioPersona.GetAllPersonaList();
            return View(lista);
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Persona collection)
        {
            try
            {
                collection.CityId = 1;
           await _servicioPersona.SavePersonaASync(collection);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                var t = ex;
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
