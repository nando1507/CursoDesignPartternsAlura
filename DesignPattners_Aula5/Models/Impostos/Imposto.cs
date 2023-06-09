﻿using DesignPattners_Aula5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattners_Aula5.Models.Impostos
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public Imposto(Imposto _outroImposto)
        {
            OutroImposto = _outroImposto;
        }
        public Imposto()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
                return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}
