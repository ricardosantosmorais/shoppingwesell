using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOTema
    {
        public IList<Tema> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Tema.ToList();
            }
        }

        public Tema Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Tema.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Tema Salvar(Tema obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.Tema.Add(obj);
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
