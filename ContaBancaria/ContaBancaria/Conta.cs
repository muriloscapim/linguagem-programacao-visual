using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        // declaração dos atributos
        public int numero;
        public Cliente titular;
        public double saldo;

        public bool Saca(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }
        /* não devolve nenhum valor e 
        recebe um double como argumento */
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        /* dentro do método this possui o valor da
         * referência em que o método foi invocado */
        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }
    }
}
