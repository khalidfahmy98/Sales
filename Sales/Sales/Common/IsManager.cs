using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sales.Common
{
    public class IsManager : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if ( Convert.ToInt32(filterContext.HttpContext.Session["Rule"]) ==  1 || Convert.ToInt32(filterContext.HttpContext.Session["Rule"]) == 2)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "RuleError", controller = "Home" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}