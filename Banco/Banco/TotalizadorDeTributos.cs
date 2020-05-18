using System;

namespace ContaBancaria
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        /* Polimorfismo com interfaces
         * Método Acumula soma os impostos de produtos tributáveis do banco
         * */
        public void Acumula(ITributavel t)
        {
            Total += t.CalcularTributo();
        }
    }
}
