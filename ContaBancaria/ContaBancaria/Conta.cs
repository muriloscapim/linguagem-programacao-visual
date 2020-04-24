using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        // Auto-implemented Properties
        public int Numero { get; set; }
        // get do saldo é público pode ser acessado por qualquer classe
        // set do saldo é privado, só pode ser acessado na classe Conta
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta()
        { 
        }

        public Conta(Cliente titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public virtual bool Saca(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
        /* não devolve nenhum valor e 
        recebe um double como argumento */
        public void Deposita(double valor)
        {
            this.Saldo += valor;
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
