using System;

namespace ExHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoa = new PessoaFisica("Ana","123.456.789-00","12.345.678-9");
            pessoa.CalcImpostoDeRenda(4000.00);
        }
    }
}
