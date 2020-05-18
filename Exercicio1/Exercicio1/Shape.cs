using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        // o método tem apenas a assinatura
        // já é implicitamente virtual
        public abstract double Area();
    }
}
