namespace ejercicio_2_programacion._2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Shape[] shapes = new Shape[]
            {
                new Rectangle(10, 5),
                new Triangle(10, 5),
                new Circle(10)
            };

            double[] areas = new double[shapes.Length];

            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
                Console.WriteLine($"Área del {shapes[i].GetShapeName()}: {areas[i]:F2}"); 
            }

            Console.WriteLine("Presiona cualquier tecla para cerrar la consola...");
            Console.ReadKey();
        }




    }
    }

