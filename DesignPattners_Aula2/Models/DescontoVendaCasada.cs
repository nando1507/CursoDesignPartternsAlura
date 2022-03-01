using DesignPattners_Aula2.Interfaces;
using System.Collections.Generic;

namespace DesignPattners_Aula2.Models
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return orcamento.Valor * (Existe(orcamento) ? 0.05 : 0);
        }

        private bool Existe(Orcamento orcamento)
        {
            List<string> vs = new List<string>();
            vs.Add("Lapis");
            vs.Add("Caneta");

            foreach (var prod in vs)
            {
                foreach (Item item in orcamento.Itens)
                {
                    if (prod.Equals(item.Nome))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
