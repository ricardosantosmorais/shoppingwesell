using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOTipoBanner
    {
        public IList<TipoBanner> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.TipoBanner.ToList();
            }
        }

        public TipoBanner Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.TipoBanner.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public TipoBanner Salvar(TipoBanner obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.TipoBanner.Add(obj);
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
