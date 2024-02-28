using Ecommerce.Application.Features.Carrito.Commands.ManagerCarrito;
using Ecommerce.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IMediator mediator;

        public HomeController(IMediator mediator, ILogger<HomeController> logger)
        {
            this.mediator = mediator;
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

        public IActionResult ViewProduct(int id)
        {


            return View();

        }

        public async Task<IActionResult> addCarrito(int id)
        {

            id = 2;
            ManagerCarritoCommand managerCarritoCommand = new ManagerCarritoCommand();

            var carrito = Request.Cookies["carritoID"];

            if(!string.IsNullOrEmpty(carrito) )
            {
                managerCarritoCommand.idCarrito = int.Parse(carrito);
            }

            managerCarritoCommand.articulo = id;


         var carritodto =   await  this.mediator.Send(managerCarritoCommand);

            Response.Cookies.Append("carritoID",string.Format("{0}", carritodto.Id));

            return View(carritodto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}