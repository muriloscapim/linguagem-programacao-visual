using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class ContaPoupanca : Conta
    {
        public double Taxa { get; set; }

        public ContaPoupanca(Cliente titular, double saldo)
            : base(titular, saldo)
        {

        }

        public override bool Saca(double valor)
        {
            return base.Saca(valor + Taxa);
        }
    }
}
