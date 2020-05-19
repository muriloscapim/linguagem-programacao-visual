using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria um Array de Alunos com 10 posições
            Aluno[] alunos = new Aluno[10];

            for(int i = 0; i <= 2; i++)
            {
                Aluno aluno = new Aluno();
                Console.WriteLine("Digite o nome: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite o telefone: ");
                aluno.Telefone = Console.ReadLine();

                alunos[i] = aluno; // Atribui um valor ao Array
            }

            for(int i = 0; i <= 2; i++)
            {
                Aluno aluno = alunos[i]; // Pega um valor do Array
                Console.WriteLine("O telefone do aluno {0} é {1}",
                    aluno.Nome, aluno.Telefone);
            }

            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine("O telefone do aluno {0} é {1}",
                    aluno.Nome, aluno.Telefone);
            }
        }
    }
}
