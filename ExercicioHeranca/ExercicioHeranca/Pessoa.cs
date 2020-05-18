using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public virtual double CalcImpostoDeRenda(double rendaBruta)
        {
            double imposto = 0.0;
            if(rendaBruta > 0.0 && rendaBruta <= 1000.00)
            {
                imposto = 0.0;
            } else if (rendaBruta > 1001.00 && rendaBruta <= 2500.00)
            {
                imposto = rendaBruta * 0.10;
            } else if (rendaBruta > 2500.01 && rendaBruta <= 4000.00)
            {
                imposto = rendaBruta * 0.15;
            } else
            {
                imposto = rendaBruta * 0.20;
            }
            return imposto;
        }
    }
}
