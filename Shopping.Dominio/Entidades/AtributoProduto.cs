using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class AtributoProduto
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string Atributo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
