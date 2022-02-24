using DesignPattners_Aula1;
using DesignPattners_Aula1.Interfaces;
using System;

namespace DesignPattners_Aula1_Investimentos.Models
{
    public class Arrojado : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            Random random = new Random();
            double rnd = random.Next(101);
            if (rnd < 20)
            {
                return conta.ValorInvestido * 0.05;
            }
            else if (rnd >= 20 && rnd < 50)
            {
                return conta.ValorInvestido * 0.03;
            }
            else if (rnd >= 50)
            {
                return conta.ValorInvestido * 0.006;
            }
            else
            {
                return 0;
            }
        }
    }
}
