using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Banner
    {
        public int Id { get; set; }
        public int TipoBannerId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CaminhoArquivo { get; set; }
        public int Largura { get; set; }
        public int Altura { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public virtual TipoBanner TipoBanner { get; set; }
    }
}
