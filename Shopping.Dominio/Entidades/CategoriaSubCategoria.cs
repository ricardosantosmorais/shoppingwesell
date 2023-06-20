using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.Entidades
{
    public class CategoriaSubCategoria
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public int SubCategoriaId { get; set; }
        public DateTime DataDaInclusao { get; set; }
        public bool Ativo { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
    }
}
