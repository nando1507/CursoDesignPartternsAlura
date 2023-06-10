//using System;
//using DesignPattners_Aula1;
//using DesignPattners_Aula2;
//using DesignPattners_Aula3;
//using DesignPattners_Aula4;
//using DesignPattners_Aula5;
using DesignPattners_Aula6;
using DesignPattners_Aula7;

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
            //Aula2 aula2 = new Aula2();
            //aula2.Inicio();

            //Template Method
            //Aula3 aula3 = new Aula3();
            //aula3.Inicio();

            //Template Decorator
            //Aula4 aula4 = new Aula4();
            //aula4.Inicio();

            //State
            //Aula5 aula5 = new Aula5();
            //aula5.Inicio();

            //builder/Fluente interface
            Aula6 aula6 = new Aula6();
            aula6.Inicio();



            //Observer
            Aula7 aula7 = new Aula7();
            aula7.Inicio();
        }
    }
}
