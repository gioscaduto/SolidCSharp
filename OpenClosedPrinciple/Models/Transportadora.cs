namespace OpenClosedPrinciple.Models
{
    public class Transportadora : IServicoDeEntrega
    {
        public double Para(string uf)
        {
            if ("SP".Equals(uf.ToUpper()))
                return 5;

            return 12;
        }
    }
}
