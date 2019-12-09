using System;
using System.Collections.Generic;
using System.Text;

namespace SingleReponsibilityPrinciple.Models
{
    public class Gerente : Cargo
    {
        public Gerente(IRegraDeCalculo regra) : base(regra)
        {
        }
    }
}
