using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOTipoFrete
    {
        public IList<TipoFrete> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.TipoFrete.ToList();
            }
        }

        public TipoFrete Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.TipoFrete.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public TipoFrete Salvar(TipoFrete obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.TipoFrete.Add(obj);
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
