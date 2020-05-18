using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercicio1
{
    class Circle : Shape
    {
        // propriedades auto implementadas do atributo
        public double Radius { get; set; }

        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
