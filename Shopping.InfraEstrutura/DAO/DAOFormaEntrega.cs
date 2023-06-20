using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOFormaEntrega
    {
        public IList<FormaEntrega> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.FormaEntrega.ToList();
            }
        }

        public FormaEntrega Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.FormaEntrega.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public FormaEntrega Salvar(FormaEntrega obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.FormaEntrega.Add(obj);
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
