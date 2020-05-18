using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle(10.0,5.0,"Blue");
            Console.WriteLine(shape.Area());

            Shape shape2 = new Circle(4.0, "Red");
            Console.WriteLine(shape2.Area());
        }
    }
}
