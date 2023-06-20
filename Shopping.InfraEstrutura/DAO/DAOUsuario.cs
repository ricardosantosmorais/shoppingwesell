using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura.DAO
{
    public class DAOUsuario
    {
        public IList<Usuario> Listar()
        {
            using (var db = new ShoppingEntities())
            {
                return db.Usuario.ToList();
            }
        }

        public Usuario Selecionar(int id)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Usuario.Where(o => o.Id == id).FirstOrDefault();
            }
        }

        public Usuario Selecionar(string LojaLogin, string EmailUsuario, string SenhaUsuario)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Usuario.Where(o => o.Loja.FirstOrDefault().Login.Equals(LojaLogin) && o.Email.Equals(EmailUsuario) && o.Senha.Equals(SenhaUsuario)).FirstOrDefault();
            }
        }

        public Usuario SelecionarAdmin(string EmailUsuario, string SenhaUsuario)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Usuario.Where(o => o.Email.Equals(EmailUsuario) && o.Senha.Equals(SenhaUsuario)).FirstOrDefault();
            }
        }

        public List<Usuario> ListarPorLojaId(int LojaId)
        {
            using (var db = new ShoppingEntities())
            {
                return db.Usuario.Where(o => o.Loja.FirstOrDefault().Id.Equals(LojaId)).ToList();
            }
        }

        public string[] SelecionarTiposUsuario(string Usuario)
        {
            using (var db = new ShoppingEntities())
            {
                var UsuarioId = int.Parse(Usuario);
                return db.Usuario.Where(o => o.Id.Equals(UsuarioId)).Select(u => u.TipoUsuario.Nome).ToList().ToArray();
            }
        }

        public Usuario Salvar(Usuario obj)
        {
            using (var db = new ShoppingEntities())
            {
                if (obj.Id == 0)
                {
                    obj.DataDaInclusao = DateTime.Now;
                    db.Usuario.Add(obj);
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
