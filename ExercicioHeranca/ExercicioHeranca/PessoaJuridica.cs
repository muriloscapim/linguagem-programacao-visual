using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca
{
    class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string InscEstadual { get; set; }
        public string InscMunicipal { get; set; }

        public PessoaJuridica(string nome, string cnpj, string inscEstadual)
            : base(nome)
        {
            this.Cnpj = cnpj;
            this.InscEstadual = inscEstadual;

        }
        public override double CalcImpostoDeRenda(double rendaBruta)
        {
            return rendaBruta * 0.10;
        }
    }
}
