using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class DepartamentoCategoria
    {
        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
