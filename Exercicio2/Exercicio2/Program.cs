using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contribuinte pf = new PessoaFisica("Ana",150000.0,1000.0);
            pf.CalculoDeImposto();

            Contribuinte pj = new PessoaJuridica("Empresa 1",5000000,10);
            pj.CalculoDeImposto();
        }
    }
}
