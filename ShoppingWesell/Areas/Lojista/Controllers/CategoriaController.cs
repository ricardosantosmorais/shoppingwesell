using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Admin.Models;
using Shopping.Autenticacao;
using Shopping.Dominio.Entidades;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Lojista.Controllers
{
    [FiltroDeAutenticacao(Roles = "Lojista")]
    public class CategoriaController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOCategoria();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAOCategoria().Selecionar(id);
                var model = AutoMapper.Mapper.Map<Categoria, CategoriaViewModel>(obj);
                model.SubCategoriaSelecionadas = obj.SubCategoria.Select(x => x.Id.ToString());
                return View(model);
            }

            return View();
        }

        public ActionResult Salvar(CategoriaViewModel model)
        {
            var obj = new DAOCategoria();
            var categoria = AutoMapper.Mapper.Map<CategoriaViewModel, Categoria>(model);
            obj.Salvar(categoria, model.SubCategoriaSelecionadas);
            return RedirectToAction("Index");
        }

        protected List<CategoriaViewModel> ConverterParaViewModel(IList<Categoria> objs)
        {
            var viewModel = new List<CategoriaViewModel>();

            foreach (var item in objs)
            {
                var model = new CategoriaViewModel();
                model.Id = item.Id;
                model.Nome = item.Nome;
                model.Descricao = item.Descricao;
                model.DataDaInclusao = item.DataDaInclusao;
                viewModel.Add(model);
            }

            return viewModel;
        }

        protected void SetViewData(CategoriaViewModel model)
        {
            ViewData["SubCategorias"] = new DAOSubCategoria().Listar()
                                                                .OrderBy(item => item.Nome)
                                                                .Select(item => new SelectListItem
                                                                {
                                                                    Text = item.Nome,
                                                                    Value = item.Id.ToString()
                                                                });
        }

    }
}
