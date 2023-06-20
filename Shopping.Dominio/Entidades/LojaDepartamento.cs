using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class LojaDepartamento
    {
        public int Id { get; set; }
        public int LojaId { get; set; }
        public int DepartamentoId { get; set; }
        public int BannerId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Banner Banner { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
