using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("(TP2/EJ1)");
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
            char input;
            do
            {
                Console.Clear();
                Console.WriteLine("(Circulos)");
                Console.WriteLine("[ 1 ] circulos");
                Console.WriteLine();
                Console.WriteLine("[ 2 ] Triangulos");
                Console.WriteLine("[ESC] Salir");
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape);
        }

        static void EntradaTriangulo()
        {
            char input;
            do
            {
                Console.Clear();
                Console.WriteLine("(Triangulos)");
                Console.WriteLine("[ 1 ] Circulos");
                Console.WriteLine("[ 2 ] Triangulos");
                Console.WriteLine("[ESC] Salir");
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape);
        }
    }
}
