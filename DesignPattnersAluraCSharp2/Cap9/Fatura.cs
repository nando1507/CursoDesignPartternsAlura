namespace DesignPattnersAluraCSharp2.Cap9
{
    public class Fatura
    {
        private object cliente;
        private object valor;

        public Fatura(object cliente, object valor)
        {
            this.cliente = cliente;
            this.valor = valor;
        }
    }
}