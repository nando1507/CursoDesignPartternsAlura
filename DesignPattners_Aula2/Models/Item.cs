using System;

namespace DesignPattners_Aula2.Models
{
    public class Item
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(String _nome, double _valor)
        {
            this.Nome = _nome;
            this.Valor = _valor;
        }     
    }
}
