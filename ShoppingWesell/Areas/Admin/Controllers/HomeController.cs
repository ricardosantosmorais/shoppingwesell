using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Shopping.Autenticacao;
using Shopping.InfraEstrutura.DAO;
using ShoppingWesell.Areas.Admin.Models;

namespace ShoppingWesell.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/
        [FiltroDeAutenticacao(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            var usuario = new DAOUsuario().SelecionarAdmin(login.Email, login.Senha);
            //if (System.Web.HttpContext.Current.User.Identity.
            if (usuario != null)
            {
                FormsAuthentication.SetAuthCookie(usuario.Id.ToString(), false);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index");
        }

    }
}
