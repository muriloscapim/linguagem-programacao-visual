using System;
using System.Collections;
using System.Collections.Generic;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria a lista
            List<Aluno> alunos = new List<Aluno>();
            // Classe List implementa a interface genérica IList<T>
            //IList<Aluno> alunos = new List<Aluno>();

            string sair = "";
            do 
            {
                Aluno aluno = new Aluno();
                Console.WriteLine("Digite o nome: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite o telefone: ");
                aluno.Telefone = Console.ReadLine();

                // Adiciona um item na lista
                alunos.Add(aluno);

                Console.WriteLine("Deseja sair?");
                sair = Console.ReadLine();
            } while(sair.Equals("n"));

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"O telefone do aluno {aluno.Nome} é {aluno.Telefone}");
            }
        }
    }
}