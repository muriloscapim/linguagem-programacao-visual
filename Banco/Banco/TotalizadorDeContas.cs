using System;

namespace ContaBancaria
{
    class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }

        // Polimorfismo
        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
    }
}
