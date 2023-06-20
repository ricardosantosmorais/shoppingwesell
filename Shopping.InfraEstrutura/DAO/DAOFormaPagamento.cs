using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOFormaPagamento
    {
        public IList<FormaPagamento> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.FormaPagamento.ToList();
            }
        }

        public FormaPagamento Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.FormaPagamento.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public FormaPagamento Salvar(FormaPagamento obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.FormaPagamento.Add(obj);
                }
                else
                {
                    db.Entry(obj).State = System.Data.EntityState.Modified;
                }
                db.SaveChanges();
                return obj;
            }
        }
    }
}
