using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente victor = new Cliente();
            victor.nome = "Victor";

            Conta c = new Conta();
            c.numero = 1;
            /* o atributo titular guarda uma referência
             * para uma instância da classe Cliente
             */
            c.titular = victor;
            c.Deposita(100.0);
            bool deuCerto = c.Saca(10.0);

            Console.WriteLine(deuCerto ? "Saque realizado com sucesso!"
                : "Saldo insuficiente!");

            Console.WriteLine($"Conta número: {c.numero}, Titular: {c.titular.nome}");

            Cliente joao = new Cliente();
            joao.nome = "João";

            Conta c1 = new Conta();
            c1.numero = 2;
            c1.titular = joao;
            c1.Deposita(200.0);
            c1.Saca(100.0);

            c.Transfere(100.0, c1);

            Console.WriteLine(c.saldo);
            Console.WriteLine(c1.saldo);
        }
    }
}
