using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public int FabricanteId { get; set; }
        public int ModeloId { get; set; }
        public int DepartamentoId { get; set; }
        public int CategoriaId { get; set; }
        public int SubCategoriaId { get; set; }
        public int LojaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodigoFabricante { get; set; }
        public string Ean { get; set; }
        public string Isbn { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorDesconto { get; set; }
        public string ManualProduto { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public Marca Marca { get; set; }
        public ModeloProduto ModeloProduto { get; set; }
        public Fabricante Fabricante { get; set; }
        public Departamento Departamento { get; set; }
        public Categoria Categoria { get; set; }
        public SubCategoria SubCategoria { get; set; }
        public Loja Loja { get; set; }
        public virtual List<AtributoProduto> AtributoProduto { get; set; }
        public virtual List<ProdutoFoto> ProdutoFoto { get; set; }
        public virtual List<ProdutoSemelhante> ProdutoSemelhante { get; set; }
        public virtual List<AvaliacaoProduto> AvaliacaoProduto { get; set; }
    }
}
