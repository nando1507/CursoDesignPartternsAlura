using DesignPattners_Aula2.Interfaces;
using DesignPattners_Aula2.Models;

namespace DesignPattners_Aula2
{
    public class CalculadoraDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhetosReais();
            IDesconto d3 = new DescontoVendaCasada();
            IDesconto d4 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}
