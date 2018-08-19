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

        public Circulo() : this(new Punto(), 0.0) { }

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        public double Perimetro
        {
            get { return 2 * Math.PI * this.Radio; }
        }

        public double Area
        {
            get { return Math.Pow(this.Radio, 2) * Math.PI; }
        }
    }
}
