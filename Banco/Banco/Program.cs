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

            /* Classe Conta é abstrata
             * Não poderá mais ser instânciada
            Conta conta = new Conta(cliente, 100.0);
            conta.Numero = 1;
            conta.Deposita(200.0);
            */

            // Apenas as classes filhas de Conta podem ser instânciadas
            ContaPoupanca c = new ContaPoupanca(cliente, 100.0);
            c.Taxa = 0.10;
            c.Numero = 1;
            c.Deposita(100.0);
            c.Saca(50.0);

            Console.WriteLine(c.Saca(100.0) ? "Saque realizado com sucesso!" :
                "Saldo insuficiente!");

            Console.WriteLine($"Conta número: {c.Numero}");
            Console.WriteLine($"Titular da conta: {c.Titular.Nome}");
            Console.WriteLine($"Saldo R$: {c.Saldo}");

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "João";

            // Polimorfismo
            Conta conta = new ContaCorrente();
            conta.Numero = 2;
            conta.Titular = cliente2;
            conta.Deposita(400.0);

            conta.Transfere(100.0,c);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c);
            t.Soma(conta);

            Console.WriteLine($"Valor total das contas {t.ValorTotal}");
        }
    }
}
