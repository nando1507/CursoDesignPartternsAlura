namespace DesignPattnersAluraCSharp2.Cap6.Interface
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();

        string Formata();
    }
}
