using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class Funcionario
    {
        public Funcionario(Cargo cargo, double salarioBase)
        {
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public  Cargo Cargo { get; private set; }
        public double SalarioBase { get; private set; }
    }
}
