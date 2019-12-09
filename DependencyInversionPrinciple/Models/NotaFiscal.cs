
namespace DependencyInversionPrinciple.Models
{
    public class NotaFiscal
    {
            public NotaFiscal(double valorBruto, double imposto)
            {
                ValorBruto = valorBruto;
                Imposto = imposto;
            }

            public double ValorBruto { get; private set; }
            public double Imposto { get; private set; }
    }
}
