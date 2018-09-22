using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Complejo
    {
        private readonly double iReal;
        private readonly double iImaginario;

        /// <summary>
        /// Instancia un numero complejo.
        /// </summary>
        /// <param name="pReal">Parte real.</param>
        /// <param name="pImaginario">Parte imaginaria.</param>
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }
        
        /// <summary>
        /// Devuelve la parte real del numero complejo.
        /// </summary>
        public double Real
        {
            get { return this.iReal; }
        }

        /// <summary>
        /// Devuelve la parte imaginaria del numero complejo.
        /// </summary>
        public double Imaginario
        {
            get { return this.iImaginario; }
        }

        /// <summary>
        /// Devuelve el argumento del numero complejo expresado en radianes.
        /// </summary>
        public double ArgumentoEnRadianes
        {
            get { return Math.Atan2(this.Real, this.Imaginario); }
        }

        /// <summary>
        /// Devuelve el argumento del numero complejo expresado en grados.
        /// </summary>
        public double ArgumentoEnGrados
        {
            get { return this.ArgumentoEnRadianes * (180 / Math.PI); }
        }

        /// <summary>
        /// Devuelve una nueva instancia de Complejo representando al conjugado del numero complejo.
        /// </summary>
        public Complejo Conjugado
        {
            get { return new Complejo(this.Real, -this.Imaginario); }
        }

        /// <summary>
        /// Devuelve la magnitud del numero complejo.
        /// </summary>
        public double Magnitud
        {
            get { return Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginario, 2)); }
        }

        /// <summary>
        /// Deuelve true si el numero complejo es extrictamente real. De lo contrario, devuelve false.
        /// </summary>
        public bool EsReal()
        {
            return this.Imaginario == 0;
        }

        /// <summary>
        /// Devuelve true si el numero complejo es extrictamente imaginario. De lo contrario, devuelve false.
        /// </summary>
        public bool EsImaginario()
        {
            return this.Real == 0;
        }

        /// <summary>
        /// Devuelve true si el numero complejo es igual a otro. De lo contrario, devuelve false.
        /// </summary>
        /// <param name="pOtroComplejo">Complejo con el que se compara.</param>
        public bool EsIgual(Complejo pOtroComplejo)
        {
            return (this.Real == pOtroComplejo.Real && this.Imaginario == pOtroComplejo.Imaginario);
        }

        /// <summary>
        /// Devuelve true si las partes real e imaginaria del numero complejo son iguales a las dadas como parametros. De lo contrario, devuelve false.
        /// </summary>
        /// <param name="pReal">Numero real con el que se compara la parte real del numero complejo.</param>
        /// <param name="pImaginario">Numero imaginario con el que se compara la parte imaginaria del numero complejo.</param>
        public bool EsIgual(double pReal, double pImaginario)
        {
            return (this.Real == pReal && this.Imaginario == pImaginario);
        }

        /// <summary>
        /// Devuelve una nueva instancia de Complejo representando al complejo que se obtiene de sumar a este el complejo dado como parametro.
        /// </summary>
        /// <param name="pOtroComplejo">Numero complejo con el que se va a sumar.</param>
        /// <returns>Devuelve un nuevo Complejo.</returns>
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            return new Complejo(this.Real + pOtroComplejo.Real, this.Imaginario + pOtroComplejo.Imaginario);
        }

        /// <summary>
        /// Devuelve una nueva instancia de Complejo representando al complejo que se obtiene de restar a este el complejo dado como parametro.
        /// </summary>
        /// <param name="pOtroComplejo">Numero complejo que se va a restar.</param>
        /// <returns>Devuelve un nuevo Complejo.</returns>
        public Complejo Restar(Complejo pOtroComplejo)
        {
            return new Complejo(this.Real - pOtroComplejo.Real, this.Imaginario - pOtroComplejo.Imaginario);
        }

        /// <summary>
        /// Devuelve una nueva instancia de Complejo representando al complejo que se obtiene de multiplicar a este por el complejo dado como parametro.
        /// </summary>
        /// <param name="pOtroComplejo">Numero complejo con el que se va a multiplicar.</param>
        /// <returns>Devuelve un nuevo Complejo.</returns>
        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            return new Complejo(this.Real * pOtroComplejo.Real - this.Imaginario * pOtroComplejo.Imaginario,
                this.Real * pOtroComplejo.Imaginario + this.Imaginario * pOtroComplejo.Real);
        }

        /// <summary>
        /// Devuelve una nueva instancia de Complejo representando al complejo que se obtiene de dividir a este por el complejo dado como parametro.
        /// </summary>
        /// <param name="pOtroComplejo">Numero complejo con el que se va a dividir.</param>
        /// <returns>Devuelve un nuevo Complejo.</returns>
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            double a = this.Real;
            double b = this.Imaginario;
            double c = pOtroComplejo.Real;
            double d = pOtroComplejo.Imaginario;
            return new Complejo((this.Real * pOtroComplejo.Real + this.Imaginario * pOtroComplejo.Imaginario) / (Math.Pow(pOtroComplejo.Real, 2) + Math.Pow(pOtroComplejo.Imaginario, 2)),
                (this.Imaginario * pOtroComplejo.Real - this.Real * pOtroComplejo.Imaginario) / (Math.Pow(pOtroComplejo.Real, 2) + Math.Pow(pOtroComplejo.Imaginario, 2)));
        }
    }
}
