using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class LojaBanner
    {
        public int Id { get; set; }
        public int LojaId { get; set; }
        public int BannerId { get; set; }
        public int AreaBannerId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public Banner Banner { get; set; }
        public AreaBanner AreaBanner { get; set; }
        public Loja Loja { get; set; }
    }
}
