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
    public class PaginaController : Controller
    {
        public ActionResult Index()
        {
            var objPagina = new DAOPagina();
            var objLoja = new DAOLoja();
            var lojaUsuario = objLoja.SelecionarPorUsuarioId(int.Parse(HttpContext.User.Identity.Name));
            var model = objPagina.ListarPorLojaId(lojaUsuario.Id);
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOPagina();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(Pagina model)
        {
            var obj = new DAOPagina();
            var objLoja = new DAOLoja();
            var lojaUsuario = objLoja.SelecionarPorUsuarioId(int.Parse(HttpContext.User.Identity.Name));
            model.LojaId = lojaUsuario.Id;
            obj.Salvar(model);
            return RedirectToAction("Index");
        }
    }
}
