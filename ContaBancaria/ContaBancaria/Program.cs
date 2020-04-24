using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Victor","123.456.789-09","12.345.678-0");
            cliente.Endereco = "Rua de teste, 123, Centro";
            cliente.DataNascimento = new DateTime(1995, 6, 12);

            Conta conta = new Conta(cliente, 100.0);
            conta.Numero = 1;
            conta.Deposita(200.0);
         
            Console.WriteLine(conta.Saca(100.0) ? "Saque realizado com sucesso!" :
                "Saldo insuficiente!");

            Console.WriteLine($"Conta número: {conta.Numero}");
            Console.WriteLine($"Titular da conta: {conta.Titular.Nome}");
            Console.WriteLine($"Saldo R$: {conta.Saldo}");

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "João";

            Conta conta2 = new Conta(cliente2, 100.0);
            conta2.Numero = 2;
            conta2.Titular = cliente2;
            conta2.Deposita(400.0);

            conta.Transfere(100.0,conta2);

            ContaPoupanca c = new ContaPoupanca(cliente2,100.0);
            c.Taxa = 0.10;
            c.Numero = 1;
            c.Deposita(100.0);
            c.Saca(50.0);
        }
    }
}
