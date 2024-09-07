using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_programacion._2
{
    internal class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius)
        {
        }

        public override double CalculateSurface()
        {
            double radius = Width / 2;
            return Math.PI * radius * radius;
        }

        public override string GetShapeName()
        {
            return "Círculo";
        }
    }
}
