using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAula
{
    class Peixe : Animal
    {
        public Peixe(string tipoAnimal) :
            base(tipoAnimal)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Peixe nadando");
        }
    }
}
