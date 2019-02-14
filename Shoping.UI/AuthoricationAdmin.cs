using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoping.UI
{
    public class AuthoricationAdmin : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["Role"].ToString()!="ADMIN")
            {
                HttpContext.Current.Session["ErrorMessage"] = "Bu Sayfaya Girmeye Yetkiniz Yok";
                filterContext.Result = new RedirectResult("/Login/Login");

            }
        }
    }
}