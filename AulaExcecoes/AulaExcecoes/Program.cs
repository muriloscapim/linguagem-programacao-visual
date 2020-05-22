using System;

namespace AulaExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            /* Sempre melhor informar o tipo mais específico de exceção.
             * E não o tipo genérico Exception.
             * Temos condição de dar tratamento específico para cada tipo
             * de exceção.
             */
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divisão por zero não é permitida! " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro de formato!" + e.Message);
            }
            finally
            {

            }
        }
    }
}
