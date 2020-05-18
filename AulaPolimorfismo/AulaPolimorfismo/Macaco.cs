using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAula
{
    class Macaco : Animal
    {
        public Macaco(string tipoAnimal) :
            base(tipoAnimal)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Macaco andando");
        }
    }
}
