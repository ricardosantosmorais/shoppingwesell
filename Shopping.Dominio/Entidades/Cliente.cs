using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Shopping.Dominio.EntitiesValidation;

namespace Shopping.Dominio.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            this.Loja = new HashSet<Loja>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu Nome Completo!")]
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu Cpf!")]
        [CPFValidation(ErrorMessage = "Por faovor, o Cpf informado não é válido.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu E-mail!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Por favor, digite seu E-mail corretamente!")]
        public string Email { get; set; }
        public string Sexo { get; set; }

        public Common.Enumerators.Sexo SexoEnum { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu DDD!")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Por favor, digite o DDD corretamente!")]
        public string DDDTelefone { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu Telefone!")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Por favor, digite o Telefone corretamente!")]
        public string Telefone { get; set; }

        public string DDDCelular { get; set; }
        public string Celular { get; set; }

        [Required(ErrorMessage = "Por favor, digite sua senha!")]
        [StringLength(18, ErrorMessage = "Atenção, sua senha deve ter 18 caracteres!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu Cep!")]
        [RegularExpression(@"^[0-9 ]{1,10}$", ErrorMessage = "Por favor, digite seu CEP corretamente!")]
        public string Cep { get; set; }

        public Nullable<int> DiaNascimento { get; set; }
        public Nullable<int> MesNascimento { get; set; }
        public Nullable<int> AnoNascimento { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu Endereço!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu Número!")]
        public int Numero { get; set; }

        public string Complemento { get; set; }
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Por favor, digite sua Cidade!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Por favor, selecione seu Estado!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor, selecione seu País!")]
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Loja> Loja { get; set; }

    }
}
