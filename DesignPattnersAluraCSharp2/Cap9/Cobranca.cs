namespace DesignPattnersAluraCSharp2.Cap9
{
    public class Cobranca
    {
        public Cobranca(EnumCobranca boleto, Fatura fatura)
        {
            Boleto = boleto;
            Fatura = fatura;
        }

        public EnumCobranca Boleto { get; }
        public Fatura Fatura { get; }

        internal void Emite()
        {
            Console.WriteLine("Emite");
        }
    }
}