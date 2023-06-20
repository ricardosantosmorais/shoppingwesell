using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOLojaUsuario
    {
        public LojaUsuario Selecionar(string LoginLoja, string Usuario, string Senha)
        {
            using (var db = new ShoppingEntities())
            {
                return db.LojaUsuario.Where(o => o.Loja.Login == LoginLoja && o.Usuario.Equals(Usuario) && o.Usuario.Senha.Equals(Senha)).FirstOrDefault();
            }
        }

        public LojaUsuario SelecionarPorId(string UsuarioId)
        {
            using (var db = new ShoppingEntities())
            {
                var Id = int.Parse(UsuarioId);
                return db.LojaUsuario.Where(o => o.Id.Equals(Id)).FirstOrDefault();
            }
        }

        public List<LojaUsuario> ListarPorLoja(int LojaId)
        {
            using (var db = new ShoppingEntities())
            {
                return db.LojaUsuario.Where(o => o.LojaId.Equals(LojaId)).ToList();
            }
        }

        public LojaUsuario SelecionarNoTipo(string Usuario, string roleName)
        {
            using (var db = new ShoppingEntities())
            {
                return db.LojaUsuario.Where(o => o.Id.Equals(int.Parse(Usuario)) && o.Usuario.TipoUsuario.Nome.Equals(roleName)).FirstOrDefault();
            }
        }

        public string[] SelecionarTiposUsuario(string Usuario)
        {
            using (var db = new ShoppingEntities())
            {
                var UsuarioId = int.Parse(Usuario);
                return db.LojaUsuario.Where(o => o.Usuario.Id.Equals(UsuarioId)).Select(u => u.Usuario.TipoUsuario.Nome).ToList().ToArray();
            }
        }

        public LojaUsuario Salvar(LojaUsuario obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.LojaUsuario.Add(obj);
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
