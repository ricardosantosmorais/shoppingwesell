using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class Estilo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, digite o nome do Arquivo!")]
        public string Nome { get; set; }

        public string Caminho { get; set; }

        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
