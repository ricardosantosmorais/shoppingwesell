using System.Web.Mvc;

namespace ShoppingWesell.Areas.Lojista
{
    public class LojistaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Lojista";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Lojista_default",
                "Lojista/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
