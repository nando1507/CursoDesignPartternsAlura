using DesignPattnersAluraCSharp2.Cap1;
using DesignPattnersAluraCSharp2.Cap2;
using DesignPattnersAluraCSharp2.Cap2.Interface;
using DesignPattnersAluraCSharp2.Cap2.Model;
using DesignPattnersAluraCSharp2.Cap3;
using DesignPattnersAluraCSharp2.Cap4;
using DesignPattnersAluraCSharp2.Cap5;
using DesignPattnersAluraCSharp2.Cap6;
using DesignPattnersAluraCSharp2.Cap6.Interface;
using DesignPattnersAluraCSharp2.Cap6.Model;
using DesignPattnersAluraCSharp2.Cap7.Models;
using DesignPattnersAluraCSharp2.Cap8;
using DesignPattnersAluraCSharp2.Cap9;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace DesignPattnersAluraCSharp2
{
    public class Home
    {
        private Cliente cliente;

        public void inicio()
        {
            //cap1
            #region Cap1
            IDbConnection connection = new ConnectionFactory().GetConnection();

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "Select * from tabela";
            #endregion
            //cap2
            #region Cap2
            //NotasMusicais notas = new NotasMusicais();
            //IList<INota> musica = new List<INota>() {
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa")
            //};

            //IList<INota> doReMiFa = new List<INota>() {
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),

            //    notas.Pega("do"),
            //    notas.Pega("sol"),
            //    notas.Pega("fa"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa")
            //};

            //Piano piano = new Piano();
            //piano.Toca(musica);
            //piano.Toca(doReMiFa);
            #endregion
            //cap3
            #region Cap3
            //    Historico historico = new Historico();

            //    Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            //    historico.Adiciona(contrato.SalvaEstado());

            //    contrato.Avanca();
            //    historico.Adiciona(contrato.SalvaEstado());

            //    contrato.Avanca();
            //    historico.Adiciona(contrato.SalvaEstado());

            //    contrato.Avanca();
            //    historico.Adiciona(contrato.SalvaEstado());
            #endregion
            //Cap4e5
            #region Cap4e5
            //IExpressao conta = new Soma(new Numero(10), new Numero(20));
            //IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            //IExpressao direita = new Soma(new Numero(2), new Numero(10));

            //IExpressao conta = new Soma(esquerda, direita);

            //int resultado = conta.Avalia();
            //Console.WriteLine(resultado);


            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(20)); // 10 + 20
            //Expression subtracao = Expression.Subtract(Expression.Constant(10), Expression.Constant(20)); // 10 + 20
            //Func<int> interpreter = Expression.Lambda<Func<int>>(soma).Compile();
            //Func<int> interpreter2 = Expression.Lambda<Func<int>>(subtracao).Compile();
            //int resultado2 = interpreter();
            //int resultado3 = interpreter2();
            //Console.WriteLine( resultado2);
            //Console.WriteLine(resultado3);


            //Impressora impressora = new Impressora();
            //conta.Aceita(impressora);
            #endregion
            //cap6
            #region Cap6
            //// Envia uma mensagem por e-mail para o victor
            //IMensagem email = new MensagemPorEmail("victor");
            //email.Envia();

            //// Envia uma mensagem por SMS para o mauricio
            //IMensagem sms = new MensagemPorSMS("mauricio");
            //sms.Envia();

            //IEnviador enviador = new EnviaPorEmail();
            //IMensagem mensagem = new MensagemAdministrativa("victor");
            //mensagem.Enviador = enviador;

            //mensagem.Envia();

            //IEnviador enviador2 = new EnviaPorSMS();
            //IMensagem mensagem2 = new MensagemCliente("mauricio");
            //mensagem2.Enviador = enviador2;

            //mensagem.Envia();

            #endregion
            //Cap7
            #region Cap7
            //Pedido pedido1 = new Pedido("Mauricio", 150.0);
            //Pedido pedido2 = new Pedido("Marcelo", 250.0);

            //FilaDeTrabalho fila = new FilaDeTrabalho();

            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));
            //fila.Adiciona(new FinalizaPedido(pedido1));

            //fila.Processa();
            #endregion
            //Cap8
            #region Cap8

            //Cliente cliente = new Cliente();
            //cliente.Nome = "victor";
            //cliente.Endereco = "Rua Vergueiro";
            //cliente.DataDeNascimento = DateTime.Now;


            //GeradorDeXml gerador = new GeradorDeXml();
            //String xml = gerador.GeraXml(cliente);
            //Console.WriteLine(xml);
            #endregion
            //Cap9
            #region Cap9
            EmpresaFacade fachada = new EmpresaFacadeSingleton().Instancia;
            string cpf = "118.256.441-01";/// pega cpf
            double valor = 500;
            Cliente cliente = fachada.BuscaCliente(cpf);

            Fatura fatura = fachada.CriaFatura(cliente, valor);

            Cobranca cobranca = fachada.GeraCobranca(fatura);
            cobranca.Emite();

            ContatoCliente contato = fachada.FazContato(cliente, cobranca);
            contato.Dispara();

            #endregion
            Console.ReadKey();

        }
    }
}