using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOSegmento
    {
        public IList<Segmento> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Segmento.ToList();
            }
        }

        public Segmento Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Segmento.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Segmento Salvar(Segmento obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.Segmento.Add(obj);
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
