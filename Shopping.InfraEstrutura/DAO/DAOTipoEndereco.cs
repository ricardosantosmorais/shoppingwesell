using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOTipoEndereco
    {
        public IList<TipoEndereco> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.TipoEndereco.ToList();
            }
        }

        public TipoEndereco Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.TipoEndereco.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public TipoEndereco Salvar(TipoEndereco obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.TipoEndereco.Add(obj);
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
