using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Models
{
    public class Fatura
    {
        public Fatura(double valorMensal, string cliente)
        {
            ValorMensal = valorMensal;
            Cliente = cliente;
        }

        public string Cliente { get; private set; }

        public double ValorMensal { get; private set; }
    }
}
