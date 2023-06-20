using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Departamento
    {
        public Departamento()
        {
            this.Categoria = new HashSet<Categoria>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Categoria> Categoria { get; set; }

        public object Clone()
        {
            Departamento obj = new Departamento();
            obj.Ativo = this.Ativo;
            obj.DataDaAlteracao = this.DataDaAlteracao;
            obj.DataDaInclusao = this.DataDaInclusao;
            obj.Descricao = this.Descricao;
            obj.Id = this.Id;
            obj.Nome = this.Nome;
            obj.Categoria = this.Categoria;
            return obj;
        }
    }
}
