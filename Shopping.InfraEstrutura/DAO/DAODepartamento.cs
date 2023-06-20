using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAODepartamento
    {
        public IList<Departamento> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Departamento.Include("Categoria").ToList();
            }
        }

        public Departamento Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Departamento.Include("Categoria").Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Departamento Salvar(Departamento obj, IEnumerable<string> categoriaIds)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    if (categoriaIds != null)
                    {
                        var ids = categoriaIds.Select(int.Parse);
                        obj.Categoria = db.Categoria.Where(s => ids.Contains(s.Id)).ToList();
                    }
                    db.Departamento.Add(obj);
                }
                else
                {
                    var original = Selecionar(obj.Id);
                    db.Entry(original).State = System.Data.EntityState.Modified;
                    db.Entry(original).CurrentValues.SetValues(obj);
                    if (categoriaIds != null)
                    {
                        var ids = categoriaIds.Select(int.Parse);
                        original.Categoria = db.Categoria.Where(s => ids.Contains(s.Id)).ToList();
                    }
                    else
                        original.Categoria = null;
                }
                db.SaveChanges();
                return obj;
            }
        }
    }
}
