using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class UsuarioEndereco
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int TipoEnderecoId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public virtual TipoEndereco TipoEndereco { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
