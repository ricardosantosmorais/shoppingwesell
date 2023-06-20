using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class LojaFormaPagamento
    {
        public int Id { get; set; }
        public int FormaPagamentoId { get; set; }
        public int LojaId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
