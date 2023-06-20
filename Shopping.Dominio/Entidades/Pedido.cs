using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int LojaId { get; set; }
        public int UsuarioEnderecoId { get; set; }
        public int FormaPagamentoId { get; set; }
        public int FormaEntregaId { get; set; }
        public int TipoFreteId { get; set; }
        public int StatusPedidoId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDoCancelamento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalFrete { get; set; }
        public decimal TotalServicos { get; set; }
        public decimal TotalDesconto { get; set; }
        public int QuantidadeParcelas { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Ativo { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Loja Loja { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public FormaEntrega FormaEntrega { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public virtual List<Produto> Produto { get; set; }
    }
}
