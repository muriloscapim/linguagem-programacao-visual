using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAula
{
     abstract class Animal
     {
        public string Tipo { get; set; }

        public Animal(string tipoAnimal)
        {
            this.Tipo = tipoAnimal;
        }

        public abstract void Mover();
     }
}
