using System;

namespace ExHeranca
{
    class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        /*
         * base chama o construtor da classe pai que tem
         * os mesmos tipos de argumentos
         */
        public PessoaFisica(string nome, string cpf,
            string rg) : base(nome)
        {
            this.Cpf = cpf;
            this.Rg = rg;
        }

        public override double CalcImpostoDeRenda(double rendaBruta)
        {
            double imposto = 0.0;
            if (rendaBruta > 1000.01 && rendaBruta <= 2500.00)
            {
                imposto = base.CalcImpostoDeRenda(rendaBruta);
            }
            else if (rendaBruta > 2500.01 && rendaBruta <= 4000.00)
            {
                imposto = rendaBruta * 0.15;
            }
            return imposto;
        }
    }
}
