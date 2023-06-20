using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Loja
    {
        public Loja()
        {
            this.Cliente = new HashSet<Cliente>();
            this.FormaPagamento = new HashSet<FormaPagamento>();
            this.FormaEntrega = new HashSet<FormaEntrega>();
            this.TipoFrete = new HashSet<TipoFrete>();
            this.Segmento = new HashSet<Segmento>();
            this.Banner = new HashSet<Banner>();
            this.Pagina = new HashSet<Pagina>();
            this.Usuario = new HashSet<Usuario>();
        }

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

        public int Numero { get; set; }
        public string Complemento { get; set; }

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
        public Nullable<DateTime> DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public virtual Tema Tema { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Pagina> Pagina { get; set; }
        public virtual ICollection<FormaPagamento> FormaPagamento { get; set; }
        public virtual ICollection<FormaEntrega> FormaEntrega { get; set; }
        public virtual ICollection<TipoFrete> TipoFrete { get; set; }
        public virtual ICollection<Segmento> Segmento { get; set; }
        public virtual ICollection<Banner> Banner { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
