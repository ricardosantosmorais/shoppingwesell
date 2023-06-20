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
    public class AreaBannerController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOAreaBanner();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            SetViewData();

            if (id != 0)
            {
                var obj = new DAOAreaBanner();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(AreaBanner model)
        {
            var obj = new DAOAreaBanner();
            obj.Salvar(model);
            return RedirectToAction("Index");
        }

        protected void SetViewData()
        {
            var estilos = new DAOEstilo().ListarAtivos();
            estilos.Insert(0, new Estilo() { Nome = "Selecione" });
            ViewData["Estilos"] = estilos.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Nome
            });
        }

    }
}
