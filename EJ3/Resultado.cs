using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Resultado
    {
        private static List<Resultado> cResultados = new List<Resultado>();
        private String iJugador;
        private double iTiempo;
        private bool iVictoria;

        /// <summary>
        /// Crea una instancia de Resultado que es agregada a la lista de resultados en una posicion acorde.
        /// </summary>
        /// <param name="pJugador">Nombre del jugador.</param>
        /// <param name="pTiempo">Tiempo en segundos. Puede tener decimales.</param>
        /// <param name="pVictoria">Resultado.</param>
        public Resultado(String pJugador, double pTiempo, bool pVictoria)
        {
            this.iJugador = pJugador;
            this.iTiempo = pTiempo;
            this.iVictoria = pVictoria;
            cResultados.Add(this);
            cResultados.Sort((x, y) => x.Tiempo.CompareTo(y.Tiempo));
        }

        public String Jugador
        {
            get { return this.iJugador; }
        }

        public double Tiempo
        {
            get { return this.iTiempo; }
        }

        public bool Victoria
        {
            get { return this.iVictoria; }
        }

        /// <summary>
        /// Devuelve un arreglo de Resultado.
        /// </summary>
        public static Resultado[] Puntajes
        {
            get { return cResultados.ToArray(); }
        }

        /// <summary>
        /// Devuelve un arreglo de Resultado con los victoriosos. 
        /// </summary>
        public static Resultado[] Victorias
        {
            get { return cResultados.Where(x => x.Victoria == true).ToArray(); }
        }
    }
}
