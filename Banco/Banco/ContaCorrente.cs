using System;


namespace ContaBancaria
{
    class ContaCorrente : Conta
    {
        public override bool Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
