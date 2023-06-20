using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOPagina
    {
        public IList<Pagina> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Pagina.ToList();
            }
        }

        public Pagina Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Pagina.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public List<Pagina> ListarPorLojaId(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Pagina.Where(o => o.Loja.Id == id).ToList();
            }
        }

        public Pagina Salvar(Pagina obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.Pagina.Add(obj);
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
