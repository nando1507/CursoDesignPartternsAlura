using DesignPattners_Aula6.Models;

namespace DesignPattners_Aula6
{
    public class Aula6
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



            Console.ReadKey();
        }
    }
}
