﻿using DesignPattners_Aula3.Models;

namespace DesignPattners_Aula3
{
    public class Aula3
    {
        public void Inicio()
        {
            Console.WriteLine($@"Informe o Valor do Orçamento");
            double orcado = double.Parse(Console.ReadLine());

            Orcamento orcamento = new Orcamento(orcado);
            //CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();

            orcamento.AdicionaItem(new Item("Caneta", new Random().Next(0, 100)));
            orcamento.AdicionaItem(new Item("Lapis", new Random().Next(0, 100)));
            orcamento.AdicionaItem(new Item("Caderno", new Random().Next(0, 1000)));
            orcamento.AdicionaItem(new Item("Borracha", new Random().Next(0, 1000)));
            orcamento.AdicionaItem(new Item("Lapis", new Random().Next(0, 1000)));
            //orcamento.Valor = orcamento.Sum(s => s.Itens.Valor);

            double ickv = new IKCV().Calcula(orcamento);
            double icpp = new ICPP().Calcula(orcamento);
            Console.WriteLine(ickv);
            Console.WriteLine(icpp);

            Console.ReadKey();
        }
    }
}