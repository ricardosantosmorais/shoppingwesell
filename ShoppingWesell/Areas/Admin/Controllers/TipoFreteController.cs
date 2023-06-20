using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Dominio.Entidades;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Admin.Controllers
{
    public class TipoFreteController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOTipoFrete();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOTipoFrete();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(TipoFrete model)
        {
            var obj = new DAOTipoFrete();
            obj.Salvar(model);
            return RedirectToAction("Index");
        }
    }
}
