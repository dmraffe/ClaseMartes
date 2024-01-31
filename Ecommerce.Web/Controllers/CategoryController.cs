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
        public ActionResult Create(IFormCollection collection)
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

        // GET: CategoryController/Edit/5
        public async Task<ActionResult> Edit(GetByIdQuery Q)
        {
            var ret = await mediator.Send(Q);
            return View(ret);
        }

        // POST: CategoryController/Edit/5
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

        // GET: CategoryController/Delete/5
        public async Task<ActionResult> Delete(GetByIdQuery Q)
        {
            var ret = await mediator.Send(Q);
            return View(ret);
        }

        // POST: CategoryController/Delete/5
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
