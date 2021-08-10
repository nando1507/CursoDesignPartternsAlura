using CursoDesignPatterns1;
using CursoDesignPatterns1.Interface;
using CursoDesignPatterns1.Model;
using System;
using System.Linq;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iccc);

            CalculadorDeDescontos descontos = new CalculadorDeDescontos();
            Orcamento orcamento1 = new Orcamento(500.0);
            orcamento1.adicionaItem(new Item("Caneta", 250.0));
            orcamento1.adicionaItem(new Item("Lapis", 250.0));
            orcamento1.adicionaItem(new Item("Fogão", 250.0));
            orcamento1.adicionaItem(new Item("Geladeira", 250.0));
            orcamento1.adicionaItem(new Item("Xbox", 250.0));
            orcamento1.adicionaItem(new Item("Notebook", 250.0));
            orcamento1.adicionaItem(new Item("PS5", 250.0));
            orcamento1.adicionaItem(new Item("Moedor de Carne", 250.0));
            //var valor = orcamento.Itens.Sum(s => s.Valor);
            //orcamento1.Valor = valor;
            double desconto = descontos.calcula(orcamento1);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
