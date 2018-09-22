using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class AhorcadoJuego // Controlador
    {
        private DateTime iInicio, iFin;
        private static Ahorcado cPartida;

        public void IniciarJuego(DateTime pInicio)
        {
            cPartida = new Ahorcado();
            this.iInicio = pInicio;
        }

        public void FinalizarJuego(DateTime pFin)
        {
            this.iFin = pFin;
        }

        public bool Jugando()
        {
            return (cPartida.Intentos > 0 && !cPartida.PalabraDescubierta());
        }

        public String Progreso()
        {
            char[] progreso = cPartida.Palabra.ToCharArray();
            for (int i = 0; i < cPartida.Palabra.Length; i++)
            {
                if (!cPartida.Letras[i])
                {
                    progreso[i] = '_';
                }
            }
            return new String(progreso);
        }
        
        public bool Intentar(char pIntento)
        {
            return cPartida.Intentar(pIntento);
        }

        public void RegistrarPuntaje(String pJugador)
        {
            bool victoria = cPartida.Intentos > 0;
            Resultado resultado = new Resultado(pJugador, this.iFin.TimeOfDay.TotalMilliseconds - this.iInicio.TimeOfDay.TotalMilliseconds, victoria);
        }

        public Resultado[] Victorias
        {
            get { return Resultado.Victorias; }
        }

        public int Intentos
        {
            get { return cPartida.Intentos; }
        }

        public String Palabra
        {
            get { return cPartida.Palabra; }
        }
    }
}
