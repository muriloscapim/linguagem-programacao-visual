using System;

namespace ContaBancaria
{
    class ContaPoupanca : Conta, ITributavel
    {
        public double Taxa { get; set; }

        public ContaPoupanca(Cliente titular, double saldo)
            : base(titular, saldo)
        {
        }

        public override bool Saca(double valor)
        {
            if (valor + this.Taxa <= this.Saldo)
            {
                this.Saldo -= valor + this.Taxa;
                return true;
            }
            return false;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        /*
         * Toda classe que assina uma interface é obrigada a
         * implementar os seus métodos
         */
        public double CalcularTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
