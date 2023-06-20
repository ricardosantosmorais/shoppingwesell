using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class AvaliacaoProduto
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int UsuarioId { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public int Nota { get; set; }
        public bool Anonimo { get; set; }
        public bool Recomenda { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }
    }
}
