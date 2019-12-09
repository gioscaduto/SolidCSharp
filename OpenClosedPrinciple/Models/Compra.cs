namespace OpenClosedPrinciple.Models
{
    public class Compra
    {
        public Compra(double valor, string uf)
        {
            Valor = valor;
            Uf = uf;
        }

        public double Valor { get; private set; }
        public string Uf { get; private set; }
    }
}
