using Shopping.InfraEstrutura.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWesell.Areas.Portal.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult Header()
        {
            DAODepartamento daoDepartamento = new DAODepartamento();
            daoDepartamento.Listar();
            return PartialView("~/Views/Shared/MenuPortal.cshtml");
        }
    }
}
