using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Shopping.Autenticacao
{
    public class FiltroDeAutenticacao : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            string controller = filterContext.RequestContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RequestContext.RouteData.Values["action"].ToString();
            string currentArea = filterContext.RequestContext.RouteData.DataTokens["area"] as string;

            if (filterContext.Result is HttpUnauthorizedResult)
                filterContext.HttpContext.Response.Redirect(String.Format("~/{0}/{1}", currentArea, "/Home/Login"));
        }
    }
}
