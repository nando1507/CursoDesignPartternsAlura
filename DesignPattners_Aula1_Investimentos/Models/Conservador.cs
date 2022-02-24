using DesignPattners_Aula1;
using DesignPattners_Aula1.Interfaces;

namespace DesignPattners_Aula1_Investimentos.Models
{
    public class Conservador : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            return conta.ValorInvestido * 0.008;
        }
    }
}
