using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOCategoriaSubCategoria
    {
        public IList<CategoriaSubCategoria> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.CategoriaSubCategoria.ToList();
            }
        }

        public CategoriaSubCategoria Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.CategoriaSubCategoria.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public CategoriaSubCategoria Salvar(CategoriaSubCategoria obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.CategoriaSubCategoria.Add(obj);
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
