using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_programacion._2
{
    internal class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        }

        public override string GetShapeName()
        {
            return "Rectángulo";
        }
    }
}
