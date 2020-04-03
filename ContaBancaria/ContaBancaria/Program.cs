using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Victor";
            cliente.Cpf = "123.456.789-09";
            cliente.Rg = "12.345.678-0";
            cliente.Endereco = "Rua de teste, 123, Centro";

            Conta conta = new Conta();
            conta.Numero = 1;
            conta.Titular = cliente;
            conta.Deposita(200.0);
            Console.WriteLine(conta.Saca(100.0) ? "Saque realizado com sucesso!" :
                "Saldo insuficiente!");

            Console.WriteLine($"Conta número: {conta.Numero}");
            Console.WriteLine($"Titular da conta: {conta.Titular.Nome}");
            Console.WriteLine($"Saldo R$: {conta.Saldo}");

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "João";

            Conta conta2 = new Conta();
            conta2.Numero = 2;
            conta2.Titular = cliente2;
            conta2.Deposita(400.0);

            conta.Transfere(100.0,conta2);
        }
    }
}
