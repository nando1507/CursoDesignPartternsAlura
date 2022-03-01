using System;
using DesignPattners_Aula1;
using DesignPattners_Aula2;

namespace DesignPattnersAluraCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Design Strategy
            //Aula1 aula1 = new Aula1();
            //aula1.Inicio();
            //Design Strategy
            //Aula1_Investimentos aula1 = new Aula1_Investimentos();
            //aula1.Inicio();

            //Design Chain of Responsability
            Aula2 aula2 = new Aula2();
            aula2.Inicio();

        }
    }
}
