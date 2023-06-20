using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Dominio.Entidades;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Admin.Controllers
{
    public class FabricanteController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOFabricante();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOFabricante();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(Fabricante model)
        {
            var obj = new DAOFabricante();
            obj.Salvar(model);
            return RedirectToAction("Index");
        }
    }
}
