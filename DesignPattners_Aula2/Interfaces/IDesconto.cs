using DesignPattners_Aula2.Models;

namespace DesignPattners_Aula2.Interfaces
{
    public interface IDesconto
    {
        public double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
