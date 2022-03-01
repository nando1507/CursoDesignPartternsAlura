using DesignPattners_Aula2.Interfaces;
using DesignPattners_Aula2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattners_Aula2
{
    public class Aula2
    {
        public void Inicio()
        {            Console.WriteLine($@"Informe o Valor do Orçamento");
            double orcado = double.Parse(Console.ReadLine());

            Orcamento orcamento = new Orcamento(orcado);
            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();

            orcamento.AdicionaItem(new Item("Caneta", new Random().Next(0,100)));
            orcamento.AdicionaItem(new Item("Lapis", new Random().Next(0, 100)));
            orcamento.AdicionaItem(new Item("Caderno", new Random().Next(0, 1000)));
            orcamento.AdicionaItem(new Item("Borracha", new Random().Next(0, 1000)));
            orcamento.AdicionaItem(new Item("Lapis", new Random().Next(0, 1000)));
            //orcamento.Valor = orcamento.Sum(s => s.Itens.Valor);

            double desconto = calculadora.Calcula(orcamento);
            Console.WriteLine($"Valor do desconto: {Math.Round(desconto,2)}");
            

            Console.ReadKey();
        }
    }
}
