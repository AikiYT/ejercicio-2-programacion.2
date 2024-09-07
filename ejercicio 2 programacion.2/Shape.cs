using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_programacion._2
{
    abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        protected Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateSurface();
        public abstract string GetShapeName();
    }
}
