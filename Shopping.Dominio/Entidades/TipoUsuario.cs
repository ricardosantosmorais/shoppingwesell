using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
