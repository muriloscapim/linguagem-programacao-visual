using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercicio2
{
    class PessoaJuridica : Contribuinte
    {   
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(){
        }

        public PessoaJuridica(string nome, double rendaAnual,
            int nroDeFuncionarios) : base(nome,rendaAnual)
        {
            NumeroDeFuncionarios = nroDeFuncionarios;

        }

        public override double CalculoDeImposto()
        {
            if (NumeroDeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else {
                return RendaAnual * 0.16;
            }
        }
    }
}
