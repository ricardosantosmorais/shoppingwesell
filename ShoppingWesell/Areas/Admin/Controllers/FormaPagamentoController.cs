using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Dominio.Entidades;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Admin.Controllers
{
    public class FormaPagamentoController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOFormaPagamento();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOFormaPagamento();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(FormaPagamento model)
        {
            var obj = new DAOFormaPagamento();
            obj.Salvar(model);
            return RedirectToAction("Index");
        }
    }
}
