﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace MVC.Filter
{
    public class UserFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int? userId = context.HttpContext.Session.GetInt32("id");
            if (!userId.HasValue)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"action","Login" },
                    {"controller","Account" }
                });
            }
            base.OnActionExecuting(context);
        }
    }
}
