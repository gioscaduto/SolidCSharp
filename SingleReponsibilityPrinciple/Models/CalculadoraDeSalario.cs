using System;
using System.Collections.Generic;
using System.Text;

namespace SingleReponsibilityPrinciple.Models
{
    public class CalculadoraDeSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.CalculaSalario();
        }
    }
}
