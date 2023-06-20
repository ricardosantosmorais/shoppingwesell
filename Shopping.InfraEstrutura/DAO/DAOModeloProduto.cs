using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOModeloProduto
    {
        public IList<ModeloProduto> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.ModeloProduto.ToList();
            }
        }

        public ModeloProduto Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.ModeloProduto.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public ModeloProduto Salvar(ModeloProduto obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.ModeloProduto.Add(obj);
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
