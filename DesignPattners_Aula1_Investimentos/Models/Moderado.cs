using DesignPattners_Aula1;
using DesignPattners_Aula1.Interfaces;
using System;

namespace DesignPattners_Aula1_Investimentos.Models
{
    public class Moderado : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            bool escolhido = new Random().Next(101) > 50;
            return conta.ValorInvestido * (escolhido ? 0.025 : 0.007);
        }
    }
}
