namespace OpenClosedPrinciple.Models
{
    public class Frete: IServicoDeEntrega
    {
        public double Para(string uf)
        {
            if ("SP".Equals(uf.ToUpper()))
                return 10;

            return 22;
        }
    }
}
