using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.Admin.Models;
using Shopping.Dominio.Entidades;
using Shopping.InfraEstrutura.DAO;

namespace ShoppingWesell.Areas.Admin.Controllers
{
    public class LojaController : Controller
    {
        public ActionResult Index()
        {
            var obj = new DAOLoja();
            var model = obj.Listar();
            return View(model);
        }

        public ActionResult Form(int id)
        {
            SetViewData();

            if (id != 0)
            {
                var obj = new DAOLoja().Selecionar(id);
                var model = AutoMapper.Mapper.Map<Loja, LojaViewModel>(obj);
                model.FormaPagamentoSelecionadas = obj.FormaPagamento.Select(x => x.Id.ToString());
                model.FormaEntregaSelecionadas = obj.FormaEntrega.Select(x => x.Id.ToString());
                model.TipoFreteSelecionadas = obj.TipoFrete.Select(x => x.Id.ToString());
                model.SegmentoSelecionadas = obj.Segmento.Select(x => x.Id.ToString());
                return View(model);
            }
            return View();
        }

        public ActionResult Salvar(LojaViewModel model)
        {
            var obj = new DAOLoja();

            var existe = obj.SelecionarPorLogin(model.Login);

            if ( model.Id == 0 && existe != null)
            {
                SetViewData();
                ModelState.AddModelError("Error", "Login existente. Por favor, escolha outra opção.");
                return View("Form", model);
            }

            var loja = AutoMapper.Mapper.Map<LojaViewModel, Loja>(model);
            obj.Salvar(loja, model.FormaPagamentoSelecionadas, model.FormaEntregaSelecionadas, model.TipoFreteSelecionadas, model.SegmentoSelecionadas);
            return RedirectToAction("Index");
        }

        protected void SetViewData()
        {
            ViewData["Estado"] = new SelectList(new[] {
                new SelectListItem { Text="Selecione o Estado", Value="" },
                new SelectListItem { Text="Acre", Value="AC" },
                new SelectListItem { Text="Alagoas", Value="AL" },
                new SelectListItem { Text="Amapá", Value="AP" },
                new SelectListItem { Text="Amazonas", Value="AM" },
                new SelectListItem { Text="Bahia", Value="BA" },
                new SelectListItem { Text="Ceará", Value="CE" },
                new SelectListItem { Text="Distrito Federal", Value="DF" },
                new SelectListItem { Text="Espírito Santo", Value="ES" },
                new SelectListItem { Text="Goiás", Value="GO" },
                new SelectListItem { Text="Maranhão", Value="MA" },
                new SelectListItem { Text="Mato Grosso", Value="MT" },
                new SelectListItem { Text="Mato Grosso do Sul", Value="MS" },
                new SelectListItem { Text="Minas Gerais", Value="MG" },
                new SelectListItem { Text="Paraná", Value="PR" },
                new SelectListItem { Text="Paraíba", Value="PB" },
                new SelectListItem { Text="Pará", Value="PA" },
                new SelectListItem { Text="Pernambuco", Value="PE" },
                new SelectListItem { Text="Piauí", Value="PI" },
                new SelectListItem { Text="Rio de Janeiro", Value="RJ" },
                new SelectListItem { Text="Rio Grande do Norte", Value="RN" },
                new SelectListItem { Text="Rio Grande do Sul", Value="RS" },
                new SelectListItem { Text="Rondonia", Value="RO" },
                new SelectListItem { Text="Roraima", Value="RR" },
                new SelectListItem { Text="Santa Catarina", Value="SC" },
                new SelectListItem { Text="Sergipe", Value="SE" },
                new SelectListItem { Text="São Paulo", Value="SP" },
                new SelectListItem { Text="Tocantins", Value="TO" }
            }, "Value", "Text");

            ViewData["Pais"] = new SelectList(new[] {
                new SelectListItem { Text="Brasil", Value="BR" }
            }, "Value", "Text");
        }

    }
}
