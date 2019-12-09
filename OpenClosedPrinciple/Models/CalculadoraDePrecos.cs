namespace OpenClosedPrinciple.Models
{
    public class CalculadoraDePrecos
    {
        private IServicoDeEntrega entrega;
        private ITabelaDePreco tabela; 

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            this.tabela = tabela;
            this.entrega = entrega;
        }

        public double Calcular(Compra compra)
        {
            double desconto = this.tabela.DescontoPara(compra.Valor);
            double frete = this.entrega.Para(compra.Uf);

            return compra.Valor * (1 - desconto) + frete;
        }
    }
}
