using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Victor";
            c.saldo = 100.0;
            bool deuCerto = c.Saca(10.0);

            Console.WriteLine(deuCerto ? "Saque realizado com sucesso!"
                : "Saldo insuficiente!");
        
            Conta c1 = new Conta();
            c1.numero = 2;
            c1.titular = "João";
            c1.saldo = 200.0;
            c1.Saca(100.0);

            Console.WriteLine(c.saldo);
            Console.WriteLine(c1.saldo);
        }
    }
}
