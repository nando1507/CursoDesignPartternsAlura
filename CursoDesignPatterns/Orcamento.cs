using CursoDesignPatterns1.Model;
using System.Collections.Generic;

namespace CursoDesignPatterns1
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void adicionaItem(Item item)
        {
            Itens.Add(item);
        }

    }
}