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
    public class DepartamentoController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAODepartamento();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            if (id != 0)
            {
                var obj = new DAODepartamento().Selecionar(id);
                var model = AutoMapper.Mapper.Map<Departamento, DepartamentoViewModel>(obj);
                model.CategoriaSelecionadas = obj.Categoria.Select(x => x.Id.ToString());
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(DepartamentoViewModel model)
        {
            var obj = new DAODepartamento();
            var departamento = AutoMapper.Mapper.Map<DepartamentoViewModel, Departamento>(model);
            obj.Salvar(departamento, model.CategoriaSelecionadas);
            return RedirectToAction("Index");
        }
    }
}
