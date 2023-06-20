using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOMarca
    {
        public IList<Marca> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Marca.ToList();
            }
        }

        public Marca Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Marca.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Marca Salvar(Marca marca)
        {
            using (var db = new ShoppingEntities())
            {
                if (marca.Id == 0)
                {
                    marca.DataDaInclusao = DateTime.Now;
                    db.Marca.Add(marca);
                }
                else
                {
                    marca.DataDaAlteracao = DateTime.Now;
                    db.Entry(marca).State = System.Data.EntityState.Modified;
                }
                db.SaveChanges();
                return marca;
            }
        }
    }
}
