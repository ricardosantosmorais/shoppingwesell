using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class TipoFrete
    {
        public TipoFrete()
        {
            this.Loja = new HashSet<Loja>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Loja> Loja { get; set; }
    }
}
