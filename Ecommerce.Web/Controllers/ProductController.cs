using Ecommerce.Application.Features.Category.Querys.GetAllCategory;
using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using Ecommerce.Application.Features.Product.Commands.DeleteProduct;
using Ecommerce.Application.Features.Product.Commands.UpdateProduct;
using Ecommerce.Application.Features.Product.Querys.GetAllProduct;
using Ecommerce.Application.Features.Product.Querys.GetProductById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Ecommerce.Web.Controllers
{
    public class ProductController : Controller
    {

        private IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: ProductController
        public async Task<ActionResult> Index()
        {

            var liesta = await this.mediator.Send(new GetAllProductQuery());
            return View(liesta);
        }

        // GET: ProductController/Details/5
        public async Task<ActionResult> Details(GetProductByIdQuery idQuery)
        {
            var liesta = await this.mediator.Send(idQuery);
            return View(liesta);
        }

        // GET: ProductController/Create
        public ActionResult Create(int id)
        {

            ViewBag.CategoryId = id;
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateProductCommand command)
        {
            try
            {
                var ret = await mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public async Task<ActionResult>  Edit(GetProductByIdQuery idQuery)
        {
            var liesta = await this.mediator.Send(idQuery);
            return View(liesta);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, UpdateProductCommand updateProductCommand)
        {
            try
            {
               
                await this.mediator.Send(updateProductCommand);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public async Task<ActionResult> Delete(GetProductByIdQuery idQuery)
        {
            var liesta = await this.mediator.Send(idQuery);
            return View(liesta);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, DeleteProductCommand updateProductCommand)
        {
            try
            {
                updateProductCommand.Id = id;
                await this.mediator.Send(updateProductCommand);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
