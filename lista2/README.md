# Lista 2

1. Desenvolva uma calculadora em C#, entrar com a operação (+, -, * e /) do tipo char, 
o primeiro e o segundo valor, exiba o resultado da operação escolhida pelo usuário.

```
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            double num1,num2,valor;

            Console.WriteLine("Bem-Vindo a Calculadora!\nPara realizar uma Soma digite '1', para Subtrair digite '2', para Multiplicar digite '3', para Dividir digite '4'.");
            opcao = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case '1':
                    valor = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + num1 + " + " + num2 + " = " + valor.ToString("F"));
                    break;
                case '2':
                    valor = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + num1 + " - " + num2 + " = " + valor.ToString("F"));
                    break;
                case '3':
                    valor = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + num1 + " * " + num2 + " = " + valor.ToString("F"));
                    break;
                case '4':
                    valor = num1 / num2;
                    Console.WriteLine("O resultado da divisão é: " + num1 + " / " + num2 + " = " + valor.ToString("F"));
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
           

        }
    }
}
```

2. Exiba os números de 0 a 10, pulando de 2 em 2.
```
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; 

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                i+=2;
            }

        }
    }
}
```
3. Exiba os números de 10 a 0, pulando de 2 em 2.
```
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; 

            for (i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                i-=2;
            }

        }
    }
}
```
4. Exiba os números de 10 a 100 que divididos por 11 o resto da divisão é igual a 5.
```
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=10; 

            while (i <= 100) {
                if(i % 11 == 5){
                    Console.WriteLine(i);
                }
                i++;
            }

        }
    }
}
```    
5. Faça um programa em C# que imprima a soma dos números de 1 até 1000.
``` 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, soma=0; 

            while (i <= 1000) {
                soma += i;
                i++;
            }
            Console.WriteLine(soma);
        }
    }
}
``` 
6. Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
``` 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                    Console.WriteLine(i);
            }

        }
    }
}
``` 
7. Escreva um programa em C# que some todos os números de 1 a 100, pulando os múltiplos de 3.
``` 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, soma=0; 

            while (i <= 100) {
                i++;
                if (i % 3 == 0)
                    continue;
                soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}
``` 
8. Escreva um programa em C# que imprime todos os números que são divisíveis por 3 ou por 4 entre 0 e 30.
``` 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                    Console.WriteLine(i);

            }
        }
    }
}

``` 
9. Faça um programa em C# que imprima os fatoriais de 1 a 10.
    > O fatorial de um número é a multiplicação desse número por todos seus antecessores até o número 1.
``` 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j, fatorial;

            for (i = 1; i <= 10; i++)
            {
                fatorial = 1;
                for(j = i; j>=1; j--)
                {
                    fatorial *= j;
                }
                Console.WriteLine("\n" + "Fatorial de "+ i + " é: " + fatorial);
            }
        }
    }
}

``` 
10. Ler um número inteiro n e exibir todos os seus divisores.
``` 
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Todos seus divisores são: ");
            for (i = num; i >= 1; i--)
            {
                if(num % i == 0)
                Console.WriteLine(i);
            }
        }
    }
}
``` 
