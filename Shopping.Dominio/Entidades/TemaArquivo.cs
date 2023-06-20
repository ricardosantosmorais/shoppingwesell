using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class TemaArquivo
    {
        public int Id { get; set; }
        public int TemaId { get; set; }
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public virtual Tema Tema { get; set; }
    }
}
