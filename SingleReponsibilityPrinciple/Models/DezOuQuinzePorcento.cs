using System;
using System.Collections.Generic;
using System.Text;

namespace SingleReponsibilityPrinciple.Models
{
    public class DezOuQuinzePorcento: IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase < 5000)
                return funcionario.SalarioBase * 0.9;
            else
                return funcionario.SalarioBase * 0.85;
        }
    }
}
