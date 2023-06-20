using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Categoria : ICloneable
    {
        public Categoria()
        {
            this.SubCategoria = new HashSet<SubCategoria>();
            this.Departamento = new HashSet<Departamento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<SubCategoria> SubCategoria { get; set; }
        public virtual ICollection<Departamento> Departamento { get; set; }

        public object Clone()
        {
            Categoria obj = new Categoria();
            obj.Ativo = this.Ativo;
            obj.DataDaAlteracao = this.DataDaAlteracao;
            obj.DataDaInclusao = this.DataDaInclusao;
            obj.Descricao = this.Descricao;
            obj.Id = this.Id;
            obj.Nome = this.Nome;
            obj.SubCategoria = this.SubCategoria;
            obj.Departamento = this.Departamento;
            return obj;
        }
    }
}
