using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class LojaSegmento
    {
        public int Id { get; set; }
        public int LojaId { get; set; }
        public int SegmentoId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Segmento Segmento { get; set; }
    }
}
