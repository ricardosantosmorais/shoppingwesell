using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Shopping.Dominio.Entidades;

namespace Shopping.Admin.Models
{
    public class DepartamentoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<string> CategoriaSelecionadas { get; set; }
    }
}
