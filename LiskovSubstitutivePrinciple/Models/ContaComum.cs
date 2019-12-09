
namespace LiskovSubstitutivePrinciple.Models
{
    public class ContaComum
    {
        private ManipuladorDeSaldo manipulador;

        public ContaComum()
        {
            manipulador = new ManipuladorDeSaldo();
        }

        public void SomaInvestimento()
        {
            manipulador.SomaInvestimento(1.02);
        }

        public void Saca(double valor)
        {
            manipulador.Saca(valor);
        }

        public void Deposita(double valor)
        {
            manipulador.Deposita(valor);
        }

        public double GetSaldo()
        {
            return manipulador.Saldo;
        }
    }
}
;