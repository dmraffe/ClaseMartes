using Microsoft.AspNetCore.Mvc;

namespace Modulo6.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult<IViewComponentResult>(View("header"));
        }
    }
}
