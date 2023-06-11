﻿using DesignPattnersAluraCSharp2.Cap3;
using DesignPattnersAluraCSharp2.Cap8;

namespace DesignPattnersAluraCSharp2.Cap9
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(String cpf)
        {
            return new ClienteDao().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente,
                                 double valor)
        {
            Fatura fatura = new Fatura(cliente, valor);
            return fatura;
        }

        public Cobranca GeraCobranca(Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(EnumCobranca.Boleto, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}