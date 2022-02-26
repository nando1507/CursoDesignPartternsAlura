using DesignPattners_Aula1.Interfaces;
using DesignPattners_Aula1_Investimentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattners_Aula1
{
    public class Aula1_Investimentos
    {
        public void Inicio()
        {
            IInvestimento _arrojado = new Arrojado();
            IInvestimento _conservador = new Conservador();
            IInvestimento _moderado = new Moderado();

            Console.WriteLine($@"Informe o Valor do Orçamento");
            double orcado = double.Parse(Console.ReadLine());

            Conta orcamento = new Conta(orcado);
            IDictionary<string, double> dictionary = new Dictionary<string, double>();
            dictionary.Add(typeof(Arrojado).Name, _arrojado.Calcula(orcamento));
            dictionary.Add(typeof(Conservador).Name, _conservador.Calcula(orcamento));
            dictionary.Add(typeof(Moderado).Name, _moderado.Calcula(orcamento));


            foreach (var item in dictionary)
            {
                Console.WriteLine($@"{item.Key}: {item.Value}");
            }

            Console.WriteLine($@"Total: {orcado + dictionary.Values.Sum()}");

            Console.ReadKey();
        }
    }
}
