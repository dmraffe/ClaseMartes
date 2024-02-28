using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Commands.CreateCategory;
using Ecommerce.Application.Features.Category.Commands.DeleteCategory;
using Ecommerce.Application.Features.Category.Commands.UpdateCategory;
using Ecommerce.Application.Features.Category.Querys.GetAllCategory;
using Ecommerce.Application.Features.Category.Querys.GetByIdCategory;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        private IMediator mediator;

        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        // GET: CategoryController
        public async Task<ActionResult> Index()
        {

            var ret = await mediator.Send(new GetAllCategoryQuery());

            return View(ret);
        }

        // GET: CategoryController/Details/5
        public async Task<ActionResult> Details(GetByIdQuery Q)
        {
            var ret = await mediator.Send(Q);
            return View(ret);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateCategoryCommand Q)
        {
            try
            {
                var ret = await mediator.Send(Q);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                var e = ex;
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public async Task<ActionResult> Edit(GetByIdQuery Q)
        {
            var ret = await mediator.Send(Q);
            return View(ret);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, UpdateCategoryCommand q)
        {
            try
            {
                var ret = await mediator.Send(q);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public async Task<ActionResult> Delete(GetByIdQuery Q)
        {
            var ret = await mediator.Send(Q);
            return View(ret);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, DeleteCategoryCommand q)
        {
            try
            {
                var ret = await mediator.Send(q);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
