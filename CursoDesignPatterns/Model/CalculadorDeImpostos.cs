using CursoDesignPatterns1.Interface;
using System;

namespace CursoDesignPatterns1.Model
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double calc = imposto.Calcula(orcamento);
            Console.WriteLine(calc);
        }
    }
}
