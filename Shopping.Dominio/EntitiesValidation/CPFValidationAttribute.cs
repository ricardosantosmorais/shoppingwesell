using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Shopping.Dominio.EntitiesValidation
{
    public class CPFValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            return Common.Util.CPF.Validar(value.ToString());
        }
    }
}
