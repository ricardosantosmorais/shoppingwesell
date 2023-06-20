using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class ProdutoFoto
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string Caminho { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
