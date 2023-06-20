using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingWesell.Areas.Lojista.Models
{
    public class LoginViewModel
    {
        public string LoginLoja { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}