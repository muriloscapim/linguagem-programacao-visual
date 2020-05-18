using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, string rg)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
        }
    }
}
