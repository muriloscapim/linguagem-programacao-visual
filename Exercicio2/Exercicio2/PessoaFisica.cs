using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica(){
        }

        public PessoaFisica(string nome, double rendaAnual, 
            double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalculoDeImposto()
        {
            if (RendaAnual < 20000.0)
            {
                return RendaAnual * 0.15 - GastosComSaude * 0.5;
            }
            else {
                return RendaAnual * 0.25 - GastosComSaude * 0.50;
            } 
        }
    }
}
