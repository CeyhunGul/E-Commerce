using NTier.ECommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.ECommerce.UI.Areas.Admin.Filters
{
    public class AuthenticationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["login"] == null)
            {
                filterContext.Result = new RedirectResult("~/AppUser/Login");
            }
            else
            {
                var UserValue = filterContext.HttpContext.Session["login"] as AppUser;
                if (UserValue.Role == Role.admin)
                {
                    filterContext.Result = new RedirectResult("~/Area/Admin/Views/Home/Index");
                }
                else
                {
                    filterContext.Result=new RedirectResult("~/Home/Index");
                }
            }
        }
    }
}