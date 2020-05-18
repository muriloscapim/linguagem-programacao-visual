using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca
{
    class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        public PessoaFisica()
        {

        }
        /* base chama o construtor da classe pai
         * que tem os mesmos tipos de argumentos
         */
        public PessoaFisica(string nome, string cpf, string rg)
            : base(nome)
        {
            this.Cpf = cpf;
            this.Rg = rg;
        }
    }
}
