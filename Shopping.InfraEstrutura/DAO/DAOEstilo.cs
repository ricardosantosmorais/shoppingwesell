using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOEstilo
    {
        public IList<Estilo> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Estilo.ToList();
            }
        }

        public IList<Estilo> ListarAtivos()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Estilo.Where(p => p.Ativo).ToList();
            }
        }

        public Estilo Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Estilo.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Estilo Salvar(Estilo obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.Estilo.Add(obj);
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
