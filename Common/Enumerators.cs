using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Common
{
    public class Enumerators
    {
        public enum Sexo : byte
        {
            [Description("Masculino")]
            M = 1,
            [Description("Feminino")]
            F = 2
        }

    }
}
