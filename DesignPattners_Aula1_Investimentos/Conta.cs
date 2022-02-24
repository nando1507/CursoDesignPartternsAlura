using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattners_Aula1
{
    public class Conta
    {
        public double ValorInvestido { get; private set; }
        public Conta(double valorInvestido)
        {
            this.ValorInvestido = valorInvestido;
        }
    }
}
