using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_programacion._2
{
    internal class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }

        public override string GetShapeName()
        {
            return "Triángulo";
        }
    }
}
