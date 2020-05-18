using System;

namespace ContaBancaria
{
    class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public override bool Saca(double valor)
        {
            if (valor + 0.15 <= this.Saldo)
            {
                this.Saldo -= valor + 0.15;
                return true;
            }
            return false;
        }

        public double CalcularTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
