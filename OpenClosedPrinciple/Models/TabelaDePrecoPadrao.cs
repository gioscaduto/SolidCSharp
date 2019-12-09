namespace OpenClosedPrinciple.Models
{
    public class TabelaDePrecoPadrao: ITabelaDePreco
    {
        public double DescontoPara(double valor)
        {
            if (valor > 1000)
                return 0.05;

            if (valor > 550)
                return 0.07;

            return 0;
        }
    }
}
