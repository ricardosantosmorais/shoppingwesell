using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOSubCategoria
    {
        public IList<SubCategoria> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.SubCategoria.Include("Categoria").ToList();
            }
        }

        public SubCategoria Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.SubCategoria.Include("Categoria").Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public SubCategoria Salvar(SubCategoria obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.SubCategoria.Add(obj);
                }
                else
                {
                    obj.DataDaAlteracao = DateTime.Now;
                    db.Entry(obj).State = System.Data.EntityState.Modified;
                }
                db.SaveChanges();
                return obj;
            }
        }
    }
}
