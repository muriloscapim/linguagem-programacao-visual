using System;

namespace ExemploAula
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polimorfismo
            Animal animal = new Ave("Pardal");
            MoverAnimal(animal);

            Animal peixe = new Peixe("Espada");
            MoverAnimal(peixe);
        }
        
        public static void MoverAnimal(Animal animal)
        {
            Console.WriteLine(animal.Tipo);
            animal.Mover();
        }
    }
}
