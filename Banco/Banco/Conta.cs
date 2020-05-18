using System;

namespace ContaBancaria
{
    abstract class Conta
    {
        // Auto-implemented Properties
        public int Numero { get; set; }
        /* get e set do saldo são públicos 
         * Saldo pode ser acessado por qualquer classe
         * set definido como privado, só pode ser acessado na classe Conta
         */
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public Conta()
        { 
        }

        public Conta(Cliente titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public abstract bool Saca(double valor);

        /* Assinatura do método
         * não devolve nenhum valor e recebe um double como argumento */
        public abstract void Deposita(double valor);
        
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
