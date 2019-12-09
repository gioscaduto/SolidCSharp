namespace SemOpenClosedPrinciple.Models
{
    public class Frete
    {
        public double Para(string uf)
        {
            if ("SP".Equals(uf.ToUpper()))
                return 10;

            return 22;
        }
    }
}
