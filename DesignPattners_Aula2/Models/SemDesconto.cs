using DesignPattners_Aula2.Interfaces;

namespace DesignPattners_Aula2.Models
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return orcamento.Valor;
        }
    }
}
