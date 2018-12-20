using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Circulo
    {
        private Punto iCentro;
        private double iRadio;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Circulo con valores de centro y radio indicados como parámetros.
        /// </summary>
        /// <param name="pCentro">Punto céntrico del círculo.</param>
        /// <param name="pRadio">Radio del círculo.</param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Circulo con valores de las componentes del punto centro y el radio indicados como parámetros.
        /// </summary>
        /// <param name="pX">Componente en X del punto céntrico del círculo.</param>
        /// <param name="pY">Componente en Y del punto céntrico del círculo<./param>
        /// <param name="pRadio">Radio del círculo.</param>
        public Circulo(double pX, double pY, double pRadio) : this(new Punto(pX, pY), pRadio) {}
      
        /// <summary>
        /// Devuelve el Punto céntrico del círculo.
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; }
        }

        /// <summary>
        /// Devuelve el radio del círculo.
        /// </summary>
        public double Radio
        {
            get { return this.iRadio; }
        }

        /// <summary>
        /// Devuelve el perímetro del círculo.
        /// </summary>
        public double Perimetro
        {
            get { return 2 * Math.PI * this.Radio; }
        }

        /// <summary>
        /// Devuelve el área del círculo.
        /// </summary>
        public double Area
        {
            get { return Math.Pow(this.Radio, 2) * Math.PI; }
        }
    }
}
