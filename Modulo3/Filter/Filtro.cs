using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.Diagnostics;
using System.Security.Policy;

namespace Modulo3.Filter
{
    public class Filtro : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("This Event Fired: OnActionExecuting");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("This Event Fired: OnActionExecuted");
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("This Event Fired: OnResultExecuting");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("This Event Fired: OnResultExecuted");
        }

    }
}
