using DesignPattners_Aula5.Interfaces;
using DesignPattners_Aula5.Models;

namespace DesignPattners_Aula5
{
    public class Aula5
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


            orcamento.AplicaDescontoExtra();

            Console.WriteLine(orcamento.Valor);
            orcamento.Aprova();
            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);
            orcamento.Finaliza();


            Console.ReadKey();
        }
    }
}