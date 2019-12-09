namespace SemOpenClosedPrinciple.Models
{
    public class CalculadoraDePrecos
    {
        public double Calcular(Compra compra)
        {
            /* Para uma Nova Tabela de Precos é necessario alterar o codigo
             * EXEMPLO: 
             * TabelaDePrecoEletronicos tabela = new TabelaDePrecoEletronicos();
             */
            TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();

            /* Para um nova Forma de Entrega é necessario alterar o codigo
             * EXEMPLO: 
             * FreteTransportadora freteTransportadora = new FreteTransportadora();
             */
            Frete freteCorreios = new Frete();
            
            double desconto = tabela.DescontoPara(compra.Valor);
            double frete = freteCorreios.Para(compra.Uf);

            return compra.Valor * (1 - desconto) + frete;
        }
    }
}
