using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Pagina
    {
        public int Id { get; set; }
        public int LojaId { get; set; }
        public string Titulo { get; set; }
        public string TituloCurto { get; set; }
        public string Chamada { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public virtual Loja Loja { get; set; }
    }
}
