using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class LojaUsuario
    {
        public int Id { get; set; }
        public int LojaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }

        public virtual Loja Loja { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
