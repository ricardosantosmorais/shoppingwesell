using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOLoja
    {
        public IList<Loja> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Loja.Include("Cliente").ToList();
            }
        }

        public Loja Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Loja.Include("Cliente").Include("FormaPagamento").Include("FormaEntrega").Include("TipoFrete").Include("Segmento").Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Loja SelecionarPorLogin(string login)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Loja.Include("Cliente").Include("FormaPagamento").Include("FormaEntrega").Include("TipoFrete").Include("Segmento").Where(o => o.Login == login).FirstOrDefault();
            }
        }

        public Loja SelecionarPorUsuarioId(int UsuarioId)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Loja.Include("Usuario").Where(o => o.Usuario.Any(u => u.Id == UsuarioId)).FirstOrDefault();
            }
        }

        public Loja Salvar(Loja obj, IEnumerable<string> FormaPagamentoSelecionadasIds, IEnumerable<string> FormaEntregaSelecionadasIds,
            IEnumerable<string> TipoFreteSelecionadasIds, IEnumerable<string> SegmentosSelecionadasIds)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    if (FormaPagamentoSelecionadasIds != null)
                    {
                        var idsPagamento = FormaPagamentoSelecionadasIds != null ? FormaPagamentoSelecionadasIds.Select(int.Parse) : null;
                        obj.FormaPagamento = idsPagamento != null ? db.FormaPagamento.Where(s => idsPagamento.Contains(s.Id)).ToList() : null;

                        var idsEntrega = FormaEntregaSelecionadasIds != null ? FormaEntregaSelecionadasIds.Select(int.Parse) : null;
                        obj.FormaEntrega = idsEntrega != null ? db.FormaEntrega.Where(s => idsEntrega.Contains(s.Id)).ToList() : null;

                        var idsFrete = TipoFreteSelecionadasIds != null ? TipoFreteSelecionadasIds.Select(int.Parse) : null;
                        obj.TipoFrete = idsFrete != null ? db.TipoFrete.Where(s => idsFrete.Contains(s.Id)).ToList() : null;

                        var idsSegmento = SegmentosSelecionadasIds != null ? SegmentosSelecionadasIds.Select(int.Parse) : null;
                        obj.Segmento = idsSegmento != null ? db.Segmento.Where(s => idsSegmento.Contains(s.Id)).ToList() : null;

                    }
                    db.Loja.Add(obj);
                }
                else
                {
                    var original = Selecionar(obj.Id);
                    db.Entry(original).State = System.Data.EntityState.Modified;
                    db.Entry(original).CurrentValues.SetValues(obj);
                    if (FormaPagamentoSelecionadasIds != null)
                    {
                        var idsPagamento = FormaPagamentoSelecionadasIds != null ? FormaPagamentoSelecionadasIds.Select(int.Parse) : null;
                        original.FormaPagamento = idsPagamento != null ? db.FormaPagamento.Where(s => idsPagamento.Contains(s.Id)).ToList() : null;

                        var idsEntrega = FormaEntregaSelecionadasIds != null ? FormaEntregaSelecionadasIds.Select(int.Parse) : null ;
                        original.FormaEntrega = idsEntrega != null ? db.FormaEntrega.Where(s => idsEntrega.Contains(s.Id)).ToList() : null ;

                        var idsFrete = TipoFreteSelecionadasIds != null ? TipoFreteSelecionadasIds.Select(int.Parse) : null;
                        original.TipoFrete = idsFrete != null ? db.TipoFrete.Where(s => idsFrete.Contains(s.Id)).ToList() : null;

                        var idsSegmento = SegmentosSelecionadasIds != null ? SegmentosSelecionadasIds.Select(int.Parse) : null;
                        original.Segmento = idsSegmento != null ? db.Segmento.Where(s => idsSegmento.Contains(s.Id)).ToList() : null;

                    }
                    else
                    {
                        original.FormaPagamento = null;
                        original.FormaEntrega = null;
                    }
                }
                db.SaveChanges();
                return obj;
            }
        }
    }
}
