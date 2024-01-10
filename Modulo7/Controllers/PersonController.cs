using Microsoft.AspNetCore.Mvc;
using Modulo7.Models;

namespace Modulo7.Controllers
{
    public class PersonController : Controller
    {

        [HttpGet]
        public IActionResult Formulario()
        {

            Person person = new Person();

            person.Name = "Test";
            person.LastName  = "Test";
            person.ContactMe = true;
            // TODO: Addlogichere
            return View(person);
        }



        [HttpPost]
        public IActionResult ShowDetails(Person person)
        {
            // TODO: Addlogichere
            if(ModelState.IsValid)
            return View(person);

           return View("Formulario", person);
        }


        [HttpGet]
        public IActionResult Index()
        {

            Person person = new Person();
            // TODO: Addlogichere
            return View(person);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Person person = new Person();
            // TODO: Addlogichere
            return View(person);
        }
        [HttpGet]
        public IActionResult Create()
        {
            // TODO: Addlogichere
            return View();
        } 
public IActionResult Create(Person person)
        {
            // TODO: Addlogichere
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Person person = new Person();
            // TODO: Addlogichere
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit(int id, Person person)
        {
            // TODO: Addlogichere
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Person person = new Person();
            // TODO: Addlogichere
            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Person person = new Person();
            // TODO: Addlogichere
            return RedirectToAction("Index");
        }

    }
}
