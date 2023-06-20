using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Autenticacao;
using Shopping.Dominio.Entidades;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Admin.Controllers
{
    [FiltroDeAutenticacao(Roles = "Admin")]
    public class TemaController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOTema();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOTema();
                var model = obj.Selecionar(id);
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(Estilo model)
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase arquivo = Request.Files[i];

            }

            var file = Request.Files[0];

            var result = Common.Util.ImageUtility.SaveImage("/Upload/Css/", 1000000, "css", file, HttpContext.Server);

            if (!result.Success)
            {
                if (String.IsNullOrEmpty(model.Caminho))
                {
                    ModelState.AddModelError("Error", "Você deve selecionar um arquivo de estilo (CSS)");
                    return View("Form", model);
                }
                else
                {
                    result.FileName = model.Caminho;
                }
            }

            model.Caminho = result.FileName;
            var obj = new DAOEstilo();
            obj.Salvar(model);
            return RedirectToAction("Index");
        }
    }
}
