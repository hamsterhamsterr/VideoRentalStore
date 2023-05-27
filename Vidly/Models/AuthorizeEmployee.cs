using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Controllers;
using System.Web.Routing;

namespace Vidly.Models
{
    public class AuthorizeEmployeeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext context)
        {
            context.Result = new RedirectToRouteResult(
                new RouteValueDictionary(new { controller = "Errors", action = "AccessDenied" }));
        }
    }
}