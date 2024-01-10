using Microsoft.AspNetCore.Mvc;
using Modulo7.Models;
using System.Diagnostics;

namespace Modulo7.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DetailsPhoto()
        {
            Photo photo = new();
            photo.Title = "Increible foto";
            photo.Description = "descrip foto";
            photo.Owner = "System";
            

            List<Photo> list = new List<Photo>();

            list.Add(photo);

            photo = new();
            photo.Title = "Increible foto";
            photo.Description = "descrip foto";
            photo.Owner = "System";
            list.Add(photo);

            photo = new();
            photo.Title = "Increible foto";
            photo.Description = "descrip foto";
            photo.Owner = "System";
            list.Add(photo);

            photo = new();
            photo.Title = "Increible foto";
            photo.Description = "descrip foto";
            photo.Owner = "System";
            list.Add(photo);
            return View(photo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}