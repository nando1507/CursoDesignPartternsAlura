using DesignPattners_Aula7.Models;
using DesignPattners_Aula7.Services;

namespace DesignPattners_Aula7
{
    public class Aula7
    {
        public void Inicio()
        {
            //IList<ItemDaNota> itens = new List<ItemDaNota>();
            //double valorTotal = 0;
            //foreach (ItemDaNota item in itens)
            //{
            //    valorTotal += item.Valor;
            //}

            //double impostos = valorTotal * 0.05;

            //NotaFiscal nf = new NotaFiscal("Razao", "CNPJ", DateTime.Now, valorTotal, impostos, itens, "etc");

            CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            criador.ParaEmpresa("Caelum")
                .ComCNPJ("12.345.678/0001-90")
                .ComItem(new ItemDaNota("item 1", 500))
                .ComItem(new ItemDaNota("item 2", 200))
                .ComItem(new ItemDaNota("item 3", 100))
                .ComObservacoes("etc")
                .NaDataAtual();

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new EnviadorDeSMS());
            criador.AdicionaAcao(new NotaFiscalDao());


            Console.ReadKey();
        }

    }
}