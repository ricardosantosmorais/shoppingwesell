using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Autenticacao;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Lojista.Controllers
{
    [FiltroDeAutenticacao(Roles="Lojista")]
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            var objUsuario = new DAOUsuario();
            var objLoja = new DAOLoja();
            var lojaUsuario = objLoja.SelecionarPorUsuarioId(int.Parse(HttpContext.User.Identity.Name));
            var model = objUsuario.ListarPorLojaId(lojaUsuario.Id);
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOUsuario();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();

        }
    }
}
