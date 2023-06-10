using DesignPattners_Aula7.Interfaces;
using DesignPattners_Aula7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattners_Aula7.Services
{
    public class EnviadorDeSMS : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia SMS");
        }
    }
}
