using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class CalculadoraDeSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            if(funcionario.Cargo is Desenvolvedor)
            {
                return CincoOuSetePorcento(funcionario);
            }

            if(funcionario.Cargo is Gerente)
            {
                return DezOuQuinzePorcento(funcionario);
            }

            throw new Exception("Funcionário não encontrado");
        }

        private double DezOuQuinzePorcento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase < 5000)
                return funcionario.SalarioBase * 0.9;
            else
                return funcionario.SalarioBase * 0.85;
        }

        private double CincoOuSetePorcento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase < 2500)
                return funcionario.SalarioBase * 0.95;
            else
                return funcionario.SalarioBase * 0.93;
        }
    }
}
