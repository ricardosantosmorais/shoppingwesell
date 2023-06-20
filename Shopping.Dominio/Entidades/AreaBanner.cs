using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class AreaBanner
    {
        public int Id { get; set; }
        public Nullable<int> EstiloId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }

        public virtual Estilo Estilo { get; set; }
    }
}
