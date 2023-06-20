using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class SubCategoria : ICloneable
    {
        public SubCategoria()
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

        public override string ToString()
        {
            return this.Id.ToString();
        }

        public object Clone()
        {
            SubCategoria obj = new SubCategoria();
            obj.Ativo = this.Ativo;
            obj.Categoria = this.Categoria;
            obj.DataDaAlteracao = this.DataDaAlteracao;
            obj.DataDaInclusao = this.DataDaInclusao;
            obj.Descricao = this.Descricao;
            obj.Id = this.Id;
            obj.Nome = this.Nome;
            return obj;
        }
    }
}
