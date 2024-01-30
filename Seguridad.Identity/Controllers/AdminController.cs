using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Seguridad.Identity.Controllers
{
    [Authorize(Policy = "RequireEmail")]

    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
