using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOCliente
    {
        public IList<Cliente> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Cliente.Include("Loja").ToList();
            }
        }

        public Cliente Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Cliente.Include("Loja").Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Cliente Salvar(Cliente obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.Cliente.Add(obj);
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
