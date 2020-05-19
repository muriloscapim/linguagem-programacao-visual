using System;
using System.Collections;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria um ArrayList
            ArrayList alunos = new ArrayList();

            for (int i = 0; i <= 2; i++)
            {
                Aluno aluno = new Aluno();
                Console.WriteLine("Digite o nome: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite o telefone: ");
                aluno.Telefone = Console.ReadLine();

                // Adiciona um item ao ArrayList
                alunos.Add(aluno);
            }

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("O telefone do aluno {0} é {1}",
                    aluno.Nome, aluno.Telefone);
            }
        }
    }
}
