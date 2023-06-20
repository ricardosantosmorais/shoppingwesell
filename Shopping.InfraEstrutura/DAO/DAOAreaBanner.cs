using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOAreaBanner
    {
        public IList<AreaBanner> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.AreaBanner.Include("Estilo").ToList();
            }
        }

        public AreaBanner Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.AreaBanner.Include("Estilo").Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public AreaBanner Salvar(AreaBanner obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.AreaBanner.Add(obj);
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
