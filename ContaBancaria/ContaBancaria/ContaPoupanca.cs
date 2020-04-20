using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class ContaPoupanca : Conta
    {
        public double Taxa { get; set; }

        public override bool Saca(double valor)
        {
            if (this.Saldo >= (valor + Taxa))
            {
                this.Saldo -= (valor + Taxa);
                return true;
            }
            return false;
        }
    }
}
