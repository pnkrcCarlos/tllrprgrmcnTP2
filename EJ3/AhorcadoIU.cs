using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class AhorcadoIU
    {
        private static AhorcadoJuego cJuego = new AhorcadoJuego();
        public static void Jugar()
        {
            char input;
            String jugador;
            do
            {
                Console.Clear();
                List<char> errores = new List<char>();
                Console.WriteLine("(AHORCADO)");
                cJuego.IniciarJuego(DateTime.Now);
                Console.WriteLine("Descubra la palabra");
                while (cJuego.Jugando())
                {
                    Console.Clear();
                    Console.WriteLine("{0}", cJuego.Progreso());
                    Console.WriteLine("Errores: {0}\t\tIntentos restantes: {1}", new String(errores.ToArray()), cJuego.Intentos);
                    Console.Write("> ");
                    input = Console.ReadKey(true).KeyChar;
                    if ((ConsoleKey)input == ConsoleKey.Escape)
                    {
                        break; // Se queria salir antes
                    }
                    Console.WriteLine();
                    if ((ConsoleKey)input!=ConsoleKey.Enter && !errores.Contains(input) && !cJuego.Intentar(input))
                    {
                        errores.Add(input);
                    }
                }
                if (cJuego.Jugando())
                {
                    break; // Se queria salir antes. No quería usar estos 'break' pero no se me ocurrio otra forma
                }
                Console.WriteLine("{0}", cJuego.Progreso());
                cJuego.FinalizarJuego(DateTime.Now);
                if (cJuego.Intentos > 0)
                {
                    Console.WriteLine("Ganaste!");
                    Console.Write("Nombre: ");
                    jugador = Console.ReadLine();
                    cJuego.RegistrarPuntaje(jugador);
                }
                else
                {
                    Console.WriteLine("Perdiste...");
                    Console.WriteLine("La palabra era: \"{0}\"", cJuego.Palabra);
                }
                Console.WriteLine("TOP 5:");
                Console.WriteLine("#\tNombre\t\tTiempo");
                int i = 0;
                while (i < cJuego.MejoresPuntajes.Length && i < 5)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2:F2}", i + 1, cJuego.MejoresPuntajes[i].Jugador, cJuego.MejoresPuntajes[i].Tiempo / 1000);
                    i++;
                }
                Console.WriteLine("Otro? [S/n]");
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape && input.ToString().ToUpper() != ConsoleKey.N.ToString().ToUpper());
        }
    }
}
