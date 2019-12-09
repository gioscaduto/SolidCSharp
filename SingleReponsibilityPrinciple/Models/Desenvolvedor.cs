using System;
using System.Collections.Generic;
using System.Text;

namespace SingleReponsibilityPrinciple.Models
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraDeCalculo regra) : base(regra)
        {
        }

    }
}
