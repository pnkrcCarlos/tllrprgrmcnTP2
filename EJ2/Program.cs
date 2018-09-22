using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        private static char input;
        private static Banco controladorBanco = new Banco();
        private static TipoDocumento tipoDocumento;
        private static String nroDocumento;
        private static int transaccion;
        private static String monto;
        private static int cuenta;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("(TP2/EJ2)");

                SeleccionTipoDocumento();
                if ((ConsoleKey)input == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    tipoDocumento = (TipoDocumento)Char.GetNumericValue(input);
                }

                EntradaNroDocumento();
                if (nroDocumento.Length == 0)
                {
                    break;
                }

                controladorBanco.IniciarSesion(tipoDocumento, nroDocumento);
                do
                {
                    SeleccionTransaccion();
                    if ((ConsoleKey)input == ConsoleKey.Escape)
                    {
                        break;
                    }
                    else
                    {
                        transaccion = (int)Char.GetNumericValue(input);
                    }

                    SeleccionCuenta();
                    if ((ConsoleKey)input == ConsoleKey.Escape)
                    {
                        break;
                    }
                    else
                    {
                        cuenta = (int)Char.GetNumericValue(input);
                    }

                    if (transaccion != 3)
                    {
                        EntradaMonto();
                        if (monto.Length == 0)
                        {
                            break;
                        }
                    }

                    Console.Clear();
                    switch (transaccion)
                    {
                        case 1:
                            controladorBanco.Acreditar(Convert.ToDouble(monto), cuenta);
                            Console.WriteLine($"Se acreditaron ${monto}.");
                            break;
                        case 2:
                            if (controladorBanco.Debitar(Convert.ToDouble(monto), cuenta))
                            {
                                Console.WriteLine($"Se debitaron ${monto}.");
                            }
                            else
                            {
                                Console.WriteLine("No se pudo debitar el monto especificado.");
                            }
                            break;
                        case 3:
                            Console.WriteLine($"La cuenta tiene ${controladorBanco.Consultar(cuenta):F2}");
                            break;
                        default:
                            break;
                    }
                    Console.ReadLine();
                } while ((ConsoleKey)input != ConsoleKey.Escape);
            } while ((ConsoleKey)input != ConsoleKey.Escape);
        }

        static void SeleccionTipoDocumento()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Tipo de documento:");
                Console.WriteLine("[ 1 ] DNI");
                Console.WriteLine("[ 2 ] CUIT");
                Console.WriteLine("[ 3 ] CUIL");
                Console.WriteLine("[ 4 ] LE");
                Console.WriteLine("[ 5 ] LC");
                Console.WriteLine("[Esc] Salir");
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape && (ConsoleKey)input != ConsoleKey.D1 && (ConsoleKey)input != ConsoleKey.D2 && (ConsoleKey)input != ConsoleKey.D3 && (ConsoleKey)input != ConsoleKey.D4 && (ConsoleKey)input != ConsoleKey.D5);
        }

        static void EntradaNroDocumento()
        {
            Console.Clear();
            Console.Write("Numero de documento: ");
            nroDocumento = Console.ReadLine();
        }

        static void SeleccionTransaccion()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Transaccion:");
                Console.WriteLine("[ 1 ] Acreditar saldo");
                Console.WriteLine("[ 2 ] Debitar saldo");
                Console.WriteLine("[ 3 ] Consultar saldo");
                Console.WriteLine("[Esc] Salir");
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape && (ConsoleKey)input != ConsoleKey.D1 && (ConsoleKey)input != ConsoleKey.D2 && (ConsoleKey)input != ConsoleKey.D3);
        }

        static void SeleccionCuenta()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Caja:");
                Console.WriteLine("[ 1 ] Cuenta corriente");
                Console.WriteLine("[ 2 ] Caja de ahorros");
                Console.WriteLine("[Esc] Salir");
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape && (ConsoleKey)input != ConsoleKey.D1 && (ConsoleKey)input != ConsoleKey.D2);
        }

        static void EntradaMonto()
        {
            Console.Clear();
            Console.Write("Monto: ");
            monto = Console.ReadLine();
        }
    }
}
