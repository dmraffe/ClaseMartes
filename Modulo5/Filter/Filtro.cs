using Microsoft.AspNetCore.Mvc.Filters;
 
using System.Diagnostics;
using System.Security.Policy;

namespace Modulo5.Filter
{
    public class Filtro : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("This Event Fired: OnActionExecuting");
        }
        public override void OnActionExecuted(ActionExecutedContext   filterContext)
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
