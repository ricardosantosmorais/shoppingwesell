using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOCategoria
    {
        public IList<Categoria> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Categoria.Include("SubCategoria").ToList();
            }
        }

        public Categoria Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Categoria.Include("SubCategoria").Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Categoria Salvar(Categoria obj, IEnumerable<string> subCategoriaIds)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    if (subCategoriaIds != null)
                    {
                        var ids = subCategoriaIds.Select(int.Parse);
                        obj.SubCategoria = db.SubCategoria.Where(s => ids.Contains(s.Id)).ToList();
                    }
                    db.Categoria.Add(obj);
                }
                else
                {
                    var original = Selecionar(obj.Id);
                    db.Entry(original).State = System.Data.EntityState.Modified;
                    db.Entry(original).CurrentValues.SetValues(obj);
                    if (subCategoriaIds != null)
                    {
                        var ids = subCategoriaIds.Select(int.Parse);
                        original.SubCategoria = db.SubCategoria.Where(s => ids.Contains(s.Id)).ToList();
                    }
                    else
                        original.SubCategoria = null;
                }
                db.SaveChanges();
                return obj;
            }
        }
    }
}
