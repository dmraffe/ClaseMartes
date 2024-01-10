using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.ADO.ADM;
using MVC.ADO.Models;

namespace MVC.ADO.Controllers
{
    public class ClientesController : Controller
    {
        // GET: ClientesController

        ADMClientes ADMClientes = new ADMClientes();
        public ActionResult Index()
        {
            return View(ADMClientes.TraerTodos());
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View(ADMClientes.TraerCliente(id));
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Clientes collection)
        {
            try
            {
                ADMClientes.Alta(collection);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ADMClientes.TraerCliente(id));
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Clientes collection)
        {
            try
            {
                ADMClientes.Modificar(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ADMClientes.TraerCliente(id));
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ADMClientes.Borrar(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
