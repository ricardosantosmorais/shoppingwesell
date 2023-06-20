using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Autenticacao;
using Shopping.Dominio.Entidades;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Lojista.Controllers
{
    [FiltroDeAutenticacao(Roles = "Lojista")]
    public class SubCategoriaController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOSubCategoria();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOSubCategoria();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(SubCategoria model)
        {
            var obj = new DAOSubCategoria();
            obj.Salvar(model);
            return RedirectToAction("Index");
        }
    }
}
