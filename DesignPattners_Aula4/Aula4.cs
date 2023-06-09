using DesignPattners_Aula4.Interfaces;
using DesignPattners_Aula4.Models;

namespace DesignPattners_Aula4
{
    public class Aula4
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

            Imposto iss = new ISS(new ICMS());
            var valor = iss.Calcula(orcamento);
            Console.WriteLine( valor);




            Console.ReadKey();
        }
    }
}