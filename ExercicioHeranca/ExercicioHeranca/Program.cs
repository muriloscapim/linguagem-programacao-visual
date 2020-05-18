using System;

namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoa = 
                new PessoaFisica("Ana","123.456.789-00","12.456.789-0");
            pessoa.Endereco = "Rua de teste, 123";
            pessoa.Telefone = "1699999-9999";
            pessoa.DataNascimento = new DateTime(1990, 6, 10);
            pessoa.CalcImpostoDeRenda(2000.00);

            Console.WriteLine($"{pessoa.Nome} {pessoa.Endereco}");

            PessoaJuridica empresa =
                new PessoaJuridica("Empresa","123.456.789-09","12.345.678-0");
            empresa.Endereco = "Endereco da empresa";
            empresa.Telefone = "169999-9999";
            empresa.InscEstadual = "12.345.677-0";
            empresa.CalcImpostoDeRenda(50000.00);
        }
    }
}
