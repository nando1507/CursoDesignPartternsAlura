using CursoDesignPatterns1.Interface;
using CursoDesignPatterns1.Model.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1.Model
{
    public class CalculadorDeDescontos
    {
      

        public double calcula(Orcamento orcamento)
        {
            //double desconto = new DescontoPorCintoItens().Desconta(orcamento);
            //if(desconto == 0)
            //{
            //    desconto = new DescontoPorMaisDeQuinhentosReais().Desconta(orcamento);
            //}
            //return desconto;

            IDesconto d1 = new DescontoPorCintoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
