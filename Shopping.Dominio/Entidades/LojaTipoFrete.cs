using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class LojaTipoFrete
    {
        public int Id { get; set; }
        public int TipoFreteId { get; set; }
        public int LojaId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
