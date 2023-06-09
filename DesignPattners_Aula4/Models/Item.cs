using System;

namespace DesignPattners_Aula4.Models
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(string _nome, double _valor)
        {
            Nome = _nome;
            Valor = _valor;
        }
    }
}
