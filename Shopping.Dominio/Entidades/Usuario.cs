using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
            this.UsuarioEndereco = new HashSet<UsuarioEndereco>();
            this.Loja = new HashSet<Loja>();
        }

        public int Id { get; set; }
        public int TipoUsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Apelido { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string DDDTelefone { get; set; }
        public string Telefone { get; set; }
        public string DDDCelular { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public int DiaNascimento { get; set; }
        public int MesNascimento { get; set; }
        public int AnoNascimento { get; set; }
        public bool ReceberOfertas { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<UsuarioEndereco> UsuarioEndereco { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual ICollection<Loja> Loja { get; set; }
    }
}
