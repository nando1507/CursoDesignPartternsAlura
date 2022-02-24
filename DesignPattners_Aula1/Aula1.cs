using DesignPattners_Aula1.Interfaces;
using DesignPattners_Aula1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattners_Aula1
{
    public class Aula1
    {
        public void Inicio()
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Console.WriteLine($@"Informe o Valor do Orçamento");
            double orcado = double.Parse(Console.ReadLine());

            Orcamento orcamento = new Orcamento(orcado);
            IDictionary<string, double> dictionary = new Dictionary<string, double>();
            dictionary.Add(typeof(ISS).Name, iss.Calcula(orcamento));
            dictionary.Add(typeof(ICMS).Name, icms.Calcula(orcamento));
            dictionary.Add(typeof(ICCC).Name, iccc.Calcula(orcamento));


            foreach (var item in dictionary)
            {
                Console.WriteLine($@"{item.Key}: {item.Value}");
            }

            Console.WriteLine($@"Total: {orcado - dictionary.Values.Sum()}");

            Console.ReadKey();
        }
    }
}
