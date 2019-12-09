
namespace LiskovSubstitutivePrinciple.Models
{
    public class ContaEstudante
    {
        private ManipuladorDeSaldo manipulador;

        public int Milhas { get; private set; }

        public ContaEstudante()
        {
            manipulador = new ManipuladorDeSaldo();
        }

        public void Deposita(double valor)
        {
            manipulador.Deposita(valor);
            Milhas += (int)valor;
        }
    }
}
