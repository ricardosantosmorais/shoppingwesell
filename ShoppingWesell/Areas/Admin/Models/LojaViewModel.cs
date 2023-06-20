using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Shopping.Dominio.Entidades;

namespace Shopping.Admin.Models
{
    public class LojaViewModel
    {
        public int Id { get; set; }
        public Nullable<int> TemaId { get; set; }

        [Required(ErrorMessage = "Por favor, digite a Razão Social!")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Por favor, digite o Nome Fantasia!")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Por favor, digite o Nome Comercial!")]
        public string NomeComercial { get; set; }

        [Required(ErrorMessage = "Por favor, digite o CNPJ!")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Por favor, digite a Inscrição Estadual!")]
        public string IE { get; set; }

        [Required(ErrorMessage = "Por favor, digite o Endereço!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Por favor, digite o Login!")]
        [RegularExpression(@"^[a-zA-Z0-9_]*$", ErrorMessage = "Por favor, Seu Login deve conter apenas letras e números!")]
        public string Login { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }

        [RegularExpression(@"^[0-9 ]{1,10}$", ErrorMessage = "Por favor, digite seu CEP corretamente!")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Por favor, digite a Cidade!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Por favor, digite o Estado!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor, digite o País!")]
        public string Pais { get; set; }
        public string Site { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public string TemaSelecionado { get; set; }
        public IEnumerable<string> FormaPagamentoSelecionadas { get; set; }
        public IEnumerable<string> FormaEntregaSelecionadas { get; set; }
        public IEnumerable<string> TipoFreteSelecionadas { get; set; }
        public IEnumerable<string> SegmentoSelecionadas { get; set; }
    }
}
