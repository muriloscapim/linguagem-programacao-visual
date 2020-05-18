using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAula
{
    class Ave : Animal
    {
        public Ave(string tipoAnimal) :
            base(tipoAnimal)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Ave voando");
        }
    }
}
