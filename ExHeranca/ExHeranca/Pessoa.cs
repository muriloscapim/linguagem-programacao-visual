using System;
using System.Collections.Generic;
using System.Text;

namespace ExHeranca
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public virtual double CalcImpostoDeRenda(double rendaBruta)
        {
            return rendaBruta * 0.10;
        }
    }
}
