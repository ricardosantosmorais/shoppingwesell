using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class ProdutoSemelhante
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int ProdutoSemelhanteId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
