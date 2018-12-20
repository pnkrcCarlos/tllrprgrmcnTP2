using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        private static CalculadoraGeometrica calcuGeo = new CalculadoraGeometrica();
        static void Main(string[] args)
        {
            char input;
            do
            {
                Console.Clear();
                Console.WriteLine("(TP2/EJ1)");
                Console.WriteLine("[ 1 ] Circulos");
                Console.WriteLine("[ 2 ] Triangulos");
                Console.WriteLine("[ESC] Salir");
                input = Console.ReadKey().KeyChar;
                switch ((ConsoleKey)input)
                {
                    case ConsoleKey.D1:
                        EntradaCirculo();
                        break;
                    case ConsoleKey.D2:
                        EntradaTriangulo();
                        break;
                }
            } while ((ConsoleKey)input != ConsoleKey.Escape);
        }

        static void EntradaCirculo()
        {
            double x, y, r;
            Console.Clear();
            Console.WriteLine("(Circulos)");
            Console.Write("O_x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("O_y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("r = ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimetro = {0}", calcuGeo.PerimetroCirculo(x, y, r));
            Console.WriteLine("Area = {0}", calcuGeo.AreaCirculo(x, y, r));
            Console.ReadLine();
        }

        static void EntradaTriangulo()
        {
            double ax, ay, bx, by, cx, cy;
            Console.Clear();
            Console.WriteLine("(Triangulos)");

            // A
            Console.Write("A_x = ");
            ax = Convert.ToDouble(Console.ReadLine());
            Console.Write("A_y = ");
            ay = Convert.ToDouble(Console.ReadLine());

            // B
            Console.Write("B_x = ");
            bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("B_y = ");
            by = Convert.ToDouble(Console.ReadLine());

            // C
            Console.Write("C_x = ");
            cx = Convert.ToDouble(Console.ReadLine());
            Console.Write("C_y = ");
            cy = Convert.ToDouble(Console.ReadLine());

            // Triangulo
            Console.WriteLine("Perimetro = {0}", calcuGeo.PerimetroTriangulo(ax, ay, bx, by, cx, cy));
            Console.WriteLine("Area = {0}", calcuGeo.AreaTriangulo(ax, ay, bx, by, cx, cy));
            Console.ReadLine();
        }
    }
}
