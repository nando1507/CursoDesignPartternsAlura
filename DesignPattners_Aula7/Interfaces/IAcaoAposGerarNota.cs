﻿using DesignPattners_Aula7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattners_Aula7.Interfaces
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}
