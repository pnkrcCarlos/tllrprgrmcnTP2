using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Triangulo
    {
        // Le cambie los nombres a los puntos
        private Punto iA;
        private Punto iB;
        private Punto iC;

        public Triangulo() : this(new Punto(), new Punto(), new Punto()) { }

        public Triangulo(Punto pA, Punto pB, Punto pC)
        {
            this.iA = pA;
            this.iB = pB;
            this.iC = pC;
        }

        public Punto A
        {
            get { return this.iA; }
            //set { this.iA = value; }
        }

        public Punto B
        {
            get { return this.iB; }
            //set { this.iB = value; }
        }

        public Punto C
        {
            get { return this.iC; }
            //set { this.iC = value; }
        }

        private double LadoA
        {
            get { return this.B.CalcularDistanciaDesde(this.C); }
        }

        private double LadoB
        {
            get { return this.A.CalcularDistanciaDesde(this.C); }
        }

        private double LadoC
        {
            get { return this.A.CalcularDistanciaDesde(this.B); }
        }

        public double Perimetro
        {
            get { return this.LadoA + this.LadoB + this.LadoC; }
        }

        public double Area
        {
            get
            {
                double s = this.Perimetro / 2;
                return Math.Sqrt(s * (s - this.LadoA) * (s - this.LadoB) * (s - this.LadoC));
            }
        }
    }
}
