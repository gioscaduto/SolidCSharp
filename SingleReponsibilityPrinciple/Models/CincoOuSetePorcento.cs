
namespace SingleReponsibilityPrinciple.Models
{
    public class CincoOuSetePorcento: IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase < 2500)
                return funcionario.SalarioBase * 0.95;
            else
                return funcionario.SalarioBase * 0.93;
        }
    }
}
