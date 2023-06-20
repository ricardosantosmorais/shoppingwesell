using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Tema
    {
        public Tema()
        {
            this.TemaArquivo = new HashSet<TemaArquivo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public ICollection<TemaArquivo> TemaArquivo { get; set; }
    }
}
